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
    public partial class FrmKhoa : Form
    {
        private int loadCS = 0;
        private Boolean checkThem = false;
        private Boolean checkSua = false;
        public static Boolean checkSave = true;

        public FrmKhoa()
        {
            InitializeComponent();
        }


        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            edtMACS.Enabled = false;
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
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }

            this.ta_KHOA.Connection.ConnectionString = Program.connstr;
            this.ta_KHOA.Fill(this.tN_CSDLPTDataSet.KHOA);

            if (Program.mGroup == "COSO")
            {
                cbbCOSO.Enabled = false;
                btnThem.Visibility = btnGhi.Visibility = btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "TRUONG")
            {
                cbbCOSO.Enabled = true;
                btnThem.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnSua.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            edtMAKHOA.Enabled = edtTENKHOA.Enabled = false;

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
                        this.ta_KHOA.Connection.ConnectionString = Program.connstrKhac;
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
                var table = (DataTable)Program.bds_dspm.DataSource;
                string Field_CS = table.Rows[cbbCOSO.SelectedIndex].Field<string>(0);

                bds_KHOA.AddNew();
                edtMACS.Text = Field_CS;
                checkThem = true;
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSua.Enabled = false;
                edtMAKHOA.Focus();
                btnGhi.Enabled = true;
                KHOA_GridView.Enabled = false;
                edtMAKHOA.Enabled = edtTENKHOA.Enabled = true;
                checkSave = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khoa " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (edtMAKHOA.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã khoa không được rỗng", "", MessageBoxButtons.OK);
                    edtMAKHOA.Focus();
                    return;
                }
                if (edtTENKHOA.Text.Equals(""))
                {
                    MessageBox.Show("Tên khoa không được rỗng", "", MessageBoxButtons.OK);
                    edtTENKHOA.Focus();
                    return;
                }

                String sql = "EXEC SP_KTKHOA_TONTAI '" + edtMAKHOA.Text.Trim() + "', N'" + edtTENKHOA.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtTENKHOA.Focus();
                    return;
                }

                ghiKhoa();

            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi khoa " + ex, "", MessageBoxButtons.OK);
                return;
            }

        }

        private int ghiKhoa()
        {
            try
            {
                this.Validate();
                bds_KHOA.EndEdit();
                this.ta_KHOA.Update(this.tN_CSDLPTDataSet.KHOA);

                this.ta_KHOA.Connection.ConnectionString = Program.connstr;
                this.ta_KHOA.Fill(this.tN_CSDLPTDataSet.KHOA);

                checkThem = false;
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSua.Enabled = true;
                edtMAKHOA.Focus();
                btnGhi.Enabled = true;
                KHOA_GridView.Enabled = true;
                edtMAKHOA.Enabled = edtTENKHOA.Enabled = false;

                checkSave = true;
                checkSua = false;
                checkThem = false;
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                return 0;
            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi khoa " + ex, "", MessageBoxButtons.OK);
                return -1;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_KHOA.Count == 0)
            {
                MessageBox.Show("Không có Khoa để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                checkSua = true;
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSua.Enabled = false;
                edtMAKHOA.Focus();
                btnGhi.Enabled = true;
                KHOA_GridView.Enabled = false;
                edtMAKHOA.Enabled = true;
                edtTENKHOA.Enabled = true;
                checkSave = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_KHOA.Count == 0)
            {
                MessageBox.Show("Không có Khoa để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + ((DataRowView)this.bds_KHOA.Current).Row["TENKH"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //phải chạy lệnh del from where mới chính xác
                        bds_KHOA.RemoveCurrent();
                        //đẩy dữ liệu về adapter
                        this.ta_KHOA.Update(this.tN_CSDLPTDataSet.KHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa khoa" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới khoa, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                if (MessageBox.Show("Bạn đang sửa khoa, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            this.ta_KHOA.Connection.ConnectionString = Program.connstrKhac;
            this.ta_KHOA.Fill(this.tN_CSDLPTDataSet.KHOA);
        }


    }
}
