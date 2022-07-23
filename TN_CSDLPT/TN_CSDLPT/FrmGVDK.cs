using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class FrmGVDK : Form
    {
        private int LoadCS = 0;
        public static Boolean checkSave = true;
        private Boolean checkThem = false;
        private Boolean checkSua = false;

        public FrmGVDK()
        {
            InitializeComponent();
        }


        private void FrmGVDK_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            tN_CSDLPTDataSet.EnforceConstraints = false; 
            Program.connstrKhac = Program.connstr;

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.ta_Lop.Connection.ConnectionString = Program.connstr;
            this.ta_Lop.Fill(this.tN_CSDLPTDataSet.LOP);

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.ta_MH.Connection.ConnectionString = Program.connstr;
            this.ta_MH.Fill(this.tN_CSDLPTDataSet.MONHOC);

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.ta_GV.Connection.ConnectionString = Program.connstr;
            this.ta_GV.Fill(this.tN_CSDLPTDataSet.GIAOVIEN);

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.ta_GVDK.Connection.ConnectionString = Program.connstr;
            this.ta_GVDK.Fill(this.tN_CSDLPTDataSet.GIAOVIEN_DANGKY);


            try
            {
                // Lấy kết danh sách phân mảnh đổ vào combobox
                cbbCoSo.DataSource = Program.bds_dspm.DataSource;
                cbbCoSo.DisplayMember = "TENCS";
                cbbCoSo.ValueMember = "TENSERVER";
                cbbCoSo.SelectedIndex = Program.mCoSo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);

            }


            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("Cao học", "A");
            items.Add("Đại học", "B");
            items.Add("Cao đẳng", "C");
            cbbTrinhDo.DataSource = new BindingSource(items, null);
            cbbTrinhDo.DisplayMember = "KEY";
            cbbTrinhDo.ValueMember = "VALUE";
            cbbTrinhDo.SelectedIndex = 0;


            if (Program.mGroup == "COSO")
            {
                cbbCoSo.Enabled = false;
                btnGhiGVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnThemGVDK.Visibility = btnSuaGVDK.Visibility = btnXoaGVDK.Visibility = btnPhuchoiGVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                Detail_GroupControl.Enabled = false;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "TRUONG")
            {
                cbbCoSo.Enabled = true;
                btnThemGVDK.Visibility = btnSuaGVDK.Visibility = btnGhiGVDK.Visibility = btnXoaGVDK.Visibility = btnPhuchoiGVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                Detail_GroupControl.Hide();
            }


            LoadCS++;
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbCoSo.SelectedValue != null & LoadCS != 0)
                {
                    Program.servernameKhac = cbbCoSo.SelectedValue.ToString();
                    if (Program.KetNoiCosoKhac() == 0) return;
                    else
                    {

                        this.ta_GVDK.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_GVDK.Fill(this.tN_CSDLPTDataSet.GIAOVIEN_DANGKY);

                        // TODO: This line of code loads data into the 'tNDataSet.DSLOP' table. You can move, or remove it, as needed.
                        this.ta_Lop.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_Lop.Fill(this.tN_CSDLPTDataSet.LOP);

                        // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.
                        this.ta_MH.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_MH.Fill(this.tN_CSDLPTDataSet.MONHOC);

                        // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
                        this.ta_GV.Connection.ConnectionString = Program.connstr;
                        this.ta_GV.Fill(this.tN_CSDLPTDataSet.GIAOVIEN);

                    }
                }
            }
            catch (Exception) { };
        }

        private void cbbGV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                edtMaGV.Text = cbbGV.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);

            }
        }

        private void cbbMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                edtMaMon.Text = cbbMH.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);

            }
        }

        private void cbbLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                edtMaLop.Text = cbbLop.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void cbbTrinhDo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                edtTrinhdo.Text = cbbTrinhDo.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);

            }
        }

        private void btnThemGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                btnGhiGVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled = btnTaiLaiGVDK.Enabled = false;
                Detail_GroupControl.Enabled = true;


                bds_GVDK.AddNew();

                checkThem = true;
                checkSave = false;

                cbbGV.SelectedIndex = 0;
                cbbTrinhDo.SelectedIndex = 0;
                cbbMH.SelectedIndex = 0;
                cbbLop.SelectedIndex = 0;
                cbbLan.SelectedIndex = 0;
                cbbLan.SelectedIndex = 0;

                edtMaGV.Text = cbbGV.SelectedValue.ToString();
                edtTrinhdo.Text = cbbTrinhDo.SelectedValue.ToString();
                edtMaMon.Text = cbbMH.SelectedValue.ToString();
                edtMaLop.Text = cbbLop.SelectedValue.ToString();

                nudSoCau.Value = 16;
                nudThoiGian.Value = 16;

                nudSoCau.Value = 15;
                nudThoiGian.Value = 15;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giảng viên đăng ký " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnSuaGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_GVDK.Count == 0)
            {
                MessageBox.Show("Không có giảng viên đăng ký để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                btnGhiGVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                checkSua = true;
                btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled = btnTaiLaiGVDK.Enabled = false;
                Detail_GroupControl.Enabled = true;
                checkSave = false;

            }
        }

        private void btnGhiGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bds_GVDK.EndEdit();
                bds_GVDK.ResetCurrentItem();
                this.ta_GVDK.Update(this.tN_CSDLPTDataSet.GIAOVIEN_DANGKY);

                btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled = btnTaiLaiGVDK.Enabled = true;
                Detail_GroupControl.Enabled = false;
                checkThem = checkSua = false;
                checkSave = true;
                btnGhiGVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giảng viên " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoaGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (bds_GVDK.Count == 0)
                {
                    MessageBox.Show("Không có giảng viên đăng ký để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);

                }
                else
                {
                    String sql = "EXEC SP_KT_XOA_GVDK N'" + edtMaMon.Text.Trim()
                       + "', N'" + edtMaLop.Text.Trim()
                       + "',  " + cbbLan.SelectedItem.ToString();

                    if (Program.connKhac.State == ConnectionState.Open) Program.connKhac.Close();
                    int kq = Program.ExecSqlNonQuery(sql);
                    if (kq == 1)
                    {
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên "
                        + ((DataRowView)this.bds_GVDK.Current).Row["MAGV"].ToString() + " môn "
                        + ((DataRowView)this.bds_GVDK.Current).Row["MAMH"].ToString() + " lớp "
                        + ((DataRowView)this.bds_GVDK.Current).Row["MALOP"].ToString() + " lần "
                        + ((DataRowView)this.bds_GVDK.Current).Row["LAN"].ToString()
                        + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                //phải chạy lệnh del from where mới chính xác
                                bds_GVDK.RemoveCurrent();
                                //đẩy dữ liệu về adapter
                                this.ta_GVDK.Update(this.tN_CSDLPTDataSet.GIAOVIEN_DANGKY);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi lớp " + ex, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoatGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới giảng viên đăng ký, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiGVDK_ItemClick(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            else if (checkSua == true)
            {
                if (MessageBox.Show("Bạn đang sửa giảng viên đăng ký, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiGVDK_ItemClick(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            else
            {
                checkSave = true;
                this.Close();
            }
            cbbTrinhDo.Enabled = false;
        }

        private void btnTaiLaiGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
                this.ta_Lop.Connection.ConnectionString = Program.connstrKhac;
                this.ta_Lop.Fill(this.tN_CSDLPTDataSet.LOP);

                // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
                this.ta_MH.Connection.ConnectionString = Program.connstrKhac;
                this.ta_MH.Fill(this.tN_CSDLPTDataSet.MONHOC);

                // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
                this.ta_GV.Connection.ConnectionString = Program.connstrKhac;
                this.ta_GV.Fill(this.tN_CSDLPTDataSet.GIAOVIEN);

                // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.ta_GVDK.Connection.ConnectionString = Program.connstrKhac;
                this.ta_GVDK.Fill(this.tN_CSDLPTDataSet.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải lại danh sách giảng viên đăng ký: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
