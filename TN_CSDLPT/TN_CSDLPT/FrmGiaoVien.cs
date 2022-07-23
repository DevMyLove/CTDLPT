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
    public partial class FrmGiaoVien : Form
    {

        private int loadCS = 0;
        private Boolean checkThem = false;
        private Boolean checkSua = false;
        public static Boolean checkSave = true;
        public FrmGiaoVien()
        {
            InitializeComponent();

        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_GIAOVIEN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
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
            catch (Exception)
            {
                MessageBox.Show("Lỗi load dữ liệu cơ sở ", "Lỗi", MessageBoxButtons.OK);
            }


            this.ta_KHOA.Connection.ConnectionString = Program.connstr;
            this.ta_KHOA.Fill(this.tN_CSDLPTDataSet.KHOA);

            this.ta_GIAOVIEN.Connection.ConnectionString = Program.connstr;
            this.ta_GIAOVIEN.Fill(this.tN_CSDLPTDataSet.GIAOVIEN);

            if (cbbTENKHOA.SelectedValue != null)
            {
                bds_GIAOVIEN.Filter = "MAKH = '" + cbbTENKHOA.SelectedValue.ToString() + "'";
                GIAOVIEN_GridView.Refresh();
                cbbTENKHOA.SelectedIndex = 0;
            }

            if (Program.mGroup == "COSO")
            {
                cbbCOSO.Enabled = false;
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnThem.Visibility = btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "TRUONG")
            {
                cbbCOSO.Enabled = true;
                btnThem.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnSua.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            groupControl2.Enabled = false;

            cbbHOCVI.Items.Add("Thạc sĩ");
            cbbHOCVI.Items.Add("Tiến sĩ");
            cbbHOCVI.Items.Add("Giáo sư");
            cbbHOCVI.SelectedIndex = 0;

            loadCS++;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSua.Enabled = false;
                int i = cbbTENKHOA.SelectedIndex;
                cbbTENKHOA.Enabled = false;

                bds_GIAOVIEN.AddNew();
                checkThem = true;
                edtMAGV.Focus();
                GIAOVIEN_GridView.Enabled = false;
                checkSave = false;

                cbbTENKHOA.SelectedIndex = i;
                groupControl2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khoa " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vt = cbbTENKHOA.SelectedIndex;
            cbbTENKHOA.SelectedIndex = vt;
            if (checkThem == true)
            {
                if (edtMAGV.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã GV không được rỗng", "", MessageBoxButtons.OK);
                    edtMAGV.Focus();
                    return;
                }
                if (edtHOGV.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Họ GV không được rỗng", "", MessageBoxButtons.OK);
                    edtHOGV.Focus();
                    return;
                }
                if (edtTENGV.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên GV không được rỗng", "", MessageBoxButtons.OK);
                    edtTENGV.Focus();
                    return;
                }

                String sql = "EXEC SP_KTGV_TONTAI '" + edtMAGV.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtMAGV.Focus();
                    return;
                }
                else
                {
                    ghiGV();
                    checkThem = false;
                }
            }
            else if (checkSua == true)
            {

                if (edtHOGV.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Họ GV không được rỗng", "", MessageBoxButtons.OK);
                    edtHOGV.Focus();
                    return;
                }
                if (edtTENGV.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên GV không được rỗng", "", MessageBoxButtons.OK);
                    edtTENGV.Focus();
                    return;
                }

                String sql = "EXEC SP_KTGV_TONTAI '" + edtMAGV.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtMAGV.Focus();
                    return;
                }
                else
                {
                    ghiGV();
                    checkThem = false;
                }
            }
            else
            {
                ghiGV();
            }
        }

        private int ghiGV()
        {
            try
            {
                bds_GIAOVIEN.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bds_GIAOVIEN.ResetCurrentItem();
                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                //lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.ta_GIAOVIEN.Update(this.tN_CSDLPTDataSet.GIAOVIEN);

                this.ta_GIAOVIEN.Connection.ConnectionString = Program.connstr;
                this.ta_GIAOVIEN.Fill(this.tN_CSDLPTDataSet.GIAOVIEN);

                checkThem = false;
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSua.Enabled = true;

                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnGhi.Enabled = true;
                GIAOVIEN_GridView.Enabled = true;
                cbbTENKHOA.Enabled = true;
                checkSave = true;
                groupControl2.Visible = false;


                return 0;
            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi GV" + ex.Message, "", MessageBoxButtons.OK);
                return -1;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới giáo viên, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                if (MessageBox.Show("Bạn đang sửa giáo viên, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            this.ta_GIAOVIEN.Connection.ConnectionString = Program.connstr;
            this.ta_GIAOVIEN.Fill(this.tN_CSDLPTDataSet.GIAOVIEN);
            cbbTENKHOA.SelectedIndex = 0;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_GIAOVIEN.Count == 0)
            {
                MessageBox.Show("Không có GV để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " +
                    ((DataRowView)this.bds_GIAOVIEN.Current).Row["HO"].ToString() + ((DataRowView)this.bds_GIAOVIEN.Current).Row["TEN"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //phải chạy lệnh del from where mới chính xác
                        bds_GIAOVIEN.RemoveCurrent();
                        //đẩy dữ liệu về adapter
                        this.ta_GIAOVIEN.Update(this.tN_CSDLPTDataSet.GIAOVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa GV" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_GIAOVIEN.Count == 0)
            {
                MessageBox.Show("Không có GV để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                checkSua = true;
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSua.Enabled = false;
                edtMAGV.Focus();
                GIAOVIEN_GridView.Enabled = false;
                groupControl2.Enabled = true;
                checkSave = false;
            }
        }

        private void cbbTENKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vt = cbbTENKHOA.SelectedIndex;
            if (cbbTENKHOA.SelectedValue != null)
            {
                bds_GIAOVIEN.Filter = "MAKH = '" + cbbTENKHOA.SelectedValue.ToString() + "'";
                GIAOVIEN_GridView.Refresh();
                cbbTENKHOA.SelectedIndex = vt;
            }

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
                        this.ta_KHOA.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_KHOA.Fill(this.tN_CSDLPTDataSet.KHOA);
                        cbbTENKHOA.SelectedIndex = Program.mCoSo;
                        if (cbbTENKHOA.SelectedValue != null)
                        {
                            bds_GIAOVIEN.Filter = "MAKH = '" + cbbTENKHOA.SelectedValue.ToString() + "'";
                            GIAOVIEN_GridView.Refresh();
                            cbbTENKHOA.SelectedIndex = 0;
                        }

                    }
                }
            }
            catch (Exception) { };
        }
    }
}
