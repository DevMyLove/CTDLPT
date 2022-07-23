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
    public partial class FrmMonHoc : Form
    {
        private Boolean checkThem = false;
        private Boolean checkSua = false;
        public static Boolean checkSave = true;

        public FrmMonHoc()
        {
            InitializeComponent();
        }

        

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            tN_CSDLPTDataSet.EnforceConstraints = false;
            Program.connstrKhac = Program.connstr;

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.ta_MH.Connection.ConnectionString = Program.connstr;
            this.ta_MH.Fill(this.tN_CSDLPTDataSet.MONHOC);

            edtMAMH.ReadOnly = true;
            edtTENMH.ReadOnly = true;
            btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

        }

        private void btnThemGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                bds_MH.AddNew();
                edtMAMH.ReadOnly = false;
                edtTENMH.ReadOnly = false;
                edtMAMH.Text = "";
                edtTENMH.Text = "";
                btnThem.Enabled = btnSua.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = false;
                checkThem = true;
                checkSave = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm môn học " + ex.Message, "", MessageBoxButtons.OK);
            }

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (checkThem == true)
            {
                if (edtMAMH.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã môn học không được để trống ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else if (edtTENMH.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên môn học không được để trống ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                String sql = "EXEC SP_KT_MONHOC_TON_TAI '" + edtMAMH.Text.Trim() + "', N'" + edtTENMH.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtMAMH.Focus();
                    return;
                }
                else
                {
                    ghiMH();
                    
                }
            }
            else if (checkSua == true)
            {
                if (edtTENMH.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên môn học không được để trống ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                String sql = "EXEC SP_KT_TEN_MONHOC_TON_TAI '" + edtMAMH.Text.Trim() + "', N'" + edtTENMH.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtTENMH.Focus();
                    return;
                }
                else
                {
                    ghiMH();
                    
                }
            }
            
        }
        private void ghiMH()
        {
            edtTENMH.ReadOnly = true;
            edtMAMH.ReadOnly = true;
            btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                bds_MH.EndEdit();
                bds_MH.ResetCurrentItem();
                this.ta_MH.Update(this.tN_CSDLPTDataSet.MONHOC);

                this.ta_MH.Connection.ConnectionString = Program.connstr;
                this.ta_MH.Fill(this.tN_CSDLPTDataSet.MONHOC);

                checkSave = true;
                checkThem = false;
                checkSua = false;
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi môn học" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (bds_MH.Count == 0)
                {
                    MessageBox.Show("Không có môn học để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                    edtMAMH.ReadOnly = false;
                    edtTENMH.ReadOnly = false;
                    btnThem.Enabled = btnSua.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = false;
                    checkSua = true;
                    checkSave = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Sửa môn học " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_MH.Count == 0)
            {
                MessageBox.Show("Không có môn học để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                string sql = "EXEC SP_XOA_MH '" + edtMAMH.Text + "'";
                int kq = Program.ExecSqlNonQuery(sql);
                if(kq == 1)
                {
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa môn học: " + ((DataRowView)this.bds_MH.Current).Row["TENMH"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            bds_MH.RemoveCurrent();
                            this.ta_MH.Update(this.tN_CSDLPTDataSet.MONHOC);

                            this.ta_MH.Connection.ConnectionString = Program.connstr;
                            this.ta_MH.Fill(this.tN_CSDLPTDataSet.MONHOC);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                        }
                    }
                }
                
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới môn học, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                if (MessageBox.Show("Bạn đang sửa môn học, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            this.ta_MH.Connection.ConnectionString = Program.connstrKhac;
            this.ta_MH.Fill(this.tN_CSDLPTDataSet.MONHOC);
        }
    }
}
