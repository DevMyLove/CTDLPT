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
    public partial class FrmLop : Form
    {
        private int loadCS = 0;
        private Boolean checkThem = false;
        private Boolean checkSua = false;
        public static Boolean checkSave = true;

        public FrmLop()
        {
            InitializeComponent();
        }

        private void cOSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_COSO.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }

        private void FrmLop_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            Program.connstrKhac = Program.connstr;
            tN_CSDLPTDataSet.EnforceConstraints = false;

            try
            {
                // Lấy kết danh sách phân mảnh đổ vào combobox
                cbbCOSO.DataSource = Program.bds_dspm.DataSource;
                cbbCOSO.DisplayMember = "TENCS";
                cbbCOSO.ValueMember = "TENSERVER";
                cbbCOSO.SelectedIndex = Program.mCoSo;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu cơ sở. \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }


            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.ta_LOP.Connection.ConnectionString = Program.connstr;
            this.ta_LOP.Fill(this.tN_CSDLPTDataSet.LOP);

            this.ta_KHOA.Connection.ConnectionString = Program.connstr;
            this.ta_KHOA.Fill(this.tN_CSDLPTDataSet.KHOA);

            if (Program.mGroup == "COSO")
            {
                cbbCOSO.Enabled = false;
                btnThem.Visibility = btnGhi.Visibility = btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                groupControl2.Enabled = false;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "TRUONG")
            {
                cbbCOSO.Enabled = true;
                btnThem.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnSua.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                groupControl2.Visible = false;
            }


            loadCS++;

        }

        private void cbbCOSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbCOSO.SelectedValue != null && loadCS != 0)
                {
                    Program.servernameKhac = cbbCOSO.SelectedValue.ToString();
                    if (Program.KetNoiCosoKhac() == 0) return;
                    else
                    {
                        this.ta_LOP.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_LOP.Fill(this.tN_CSDLPTDataSet.LOP);

                        this.ta_KHOA.Connection.ConnectionString = Program.connstr;
                        this.ta_KHOA.Fill(this.tN_CSDLPTDataSet.KHOA);

                    }
                }
            }
            catch (Exception) { };
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                bds_LOP.AddNew();
                btnGhi.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = false;
                groupControl2.Enabled = true;
                this.ta_KHOA.Connection.ConnectionString = Program.connstr;
                this.ta_KHOA.Fill(this.tN_CSDLPTDataSet.KHOA);

                cbbTENKHOA.SelectedIndex = 0;
                edtMAKHOA.Text = cbbTENKHOA.SelectedValue.ToString();
                edtMAKHOA.Enabled = false;

                checkThem = true;
                checkSave = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm lớp" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void cbbTENKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTENKHOA.SelectedValue != null)
            {
                edtMAKHOA.Text = cbbTENKHOA.SelectedValue.ToString();
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (edtMALOP.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã lớp không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }
                if (edtTENLOP.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên lớp không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                String sql = "EXEC SP_KTLOP_TONTAI '" + edtMALOP.Text.Trim() + "', N'" + edtTENLOP.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtTENLOP.Focus();
                    return;
                }

                ghiLop();
            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi lớp " + ex, "", MessageBoxButtons.OK);
                return;
            }

        }

        private void ghiLop()
        {
            try
            {
                bds_LOP.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bds_LOP.ResetCurrentItem();
                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.ta_LOP.Update(this.tN_CSDLPTDataSet.LOP);
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnTaiLai.Enabled = true;
                groupControl2.Enabled = false;

                checkSave = true;
                checkSua = false;
                checkThem = false;
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;


            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi lớp" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_LOP.Count == 0)
            {
                MessageBox.Show("Không có lớp để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = false;
                groupControl2.Enabled = true;
                this.ta_KHOA.Connection.ConnectionString = Program.connstr;
                this.ta_KHOA.Fill(this.tN_CSDLPTDataSet.KHOA);
                cbbTENKHOA.SelectedValue = ((DataRowView)this.bds_LOP.Current).Row["MAKH"].ToString();
                cbbTENKHOA.Enabled = edtMAKHOA.Enabled = false;
                edtMAKHOA.Text = cbbTENKHOA.SelectedValue.ToString();
                checkSua = true;
                checkSave = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_LOP.Count == 0)
            {
                MessageBox.Show("Không có lớp để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học : " + ((DataRowView)this.bds_LOP.Current).Row["TENLOP"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //phải chạy lệnh del from where mới chính xác
                        bds_LOP.RemoveCurrent();
                        //đẩy dữ liệu về adapter
                        this.ta_LOP.Update(this.tN_CSDLPTDataSet.LOP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa lớp học " + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới lớp, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
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
                if (MessageBox.Show("Bạn đang sửa lớp, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
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
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ta_LOP.Connection.ConnectionString = Program.connstrKhac;
            this.ta_LOP.Fill(this.tN_CSDLPTDataSet.LOP);

            this.ta_KHOA.Connection.ConnectionString = Program.connstrKhac;
            this.ta_KHOA.Fill(this.tN_CSDLPTDataSet.KHOA);
        }
    }
}
