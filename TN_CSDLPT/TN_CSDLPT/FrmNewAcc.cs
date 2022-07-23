using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class FrmNewAcc : Form
    {
        public static Boolean checkSave = true;
        private Boolean checkThem = false;
        private int loadCoso = 0;
        public FrmNewAcc()
        {
            InitializeComponent();
        }

        private void FrmNewAcc_Load(object sender, EventArgs e)
        {
           
            this.ControlBox = false;
            Program.connstrKhac = Program.connstr;
            tN_CSDLPTDataSet.EnforceConstraints = false;

            try
            {
                cbbCoSo.DataSource = Program.bds_dspm.DataSource;
                cbbCoSo.DisplayMember = "TENCS";
                cbbCoSo.ValueMember = "TENSERVER";
                cbbCoSo.SelectedIndex = Program.mCoSo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load cơ sở " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }

            loadCoso++;


            this.ta_SP_MAGV_CHUA_TAO_TK.Connection.ConnectionString = Program.connstr;
            this.ta_SP_MAGV_CHUA_TAO_TK.Fill(this.tN_CSDLPTDataSet.SP_MAGV_CHUA_TAO_TK);

            if (Program.mGroup == "COSO")
            {
                cbbCoSo.Enabled = false;
                cbbLoaiTK.Items.Add("COSO");
                cbbLoaiTK.Items.Add("GIAOVIEN");
            }
            else if (Program.mGroup == "TRUONG")
            {
                cbbCoSo.Enabled = true;
                cbbLoaiTK.Items.Add("TRUONG");
            }

            cbbLoaiTK.SelectedIndex = 0;
            
        }

      
        private void cOSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_COSO.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }

        private void cbbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbbCoSo.SelectedValue != null && Program.mGroup.Equals("Truong") && loadCoso > 0)
                {
                    if (cbbCoSo.SelectedIndex != Program.mCoSo)
                    {
                        Program.servernameKhac = cbbCoSo.SelectedValue.ToString();
                        if (Program.KetNoiCosoKhac() == 0) return;
                        else
                        {
                            this.ta_SP_MAGV_CHUA_TAO_TK.Connection.ConnectionString = Program.connstrKhac;
                            this.ta_SP_MAGV_CHUA_TAO_TK.Fill(this.tN_CSDLPTDataSet.SP_MAGV_CHUA_TAO_TK);
                        }
                    }
                    else
                    {
                        this.ta_SP_MAGV_CHUA_TAO_TK.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_SP_MAGV_CHUA_TAO_TK.Fill(this.tN_CSDLPTDataSet.SP_MAGV_CHUA_TAO_TK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn cơ sở " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            };
        }

        private void cbbMaGV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            edtMAGV.Text = cbbMaGV.SelectedValue.ToString();
        }

        private void cbbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaGV.SelectedValue != null)
            {
                edtMAGV.Text = cbbMaGV.SelectedValue.ToString();
            }
            else
            {
                edtMAGV.Text = "";
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (edtTenDN.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "", MessageBoxButtons.OK);
                edtTenDN.Focus();
                return;
            }
            if (edtPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "", MessageBoxButtons.OK);
                edtPass.Focus();
                return;
            }
            SqlCommand sqlcmd;
            //neu dăng nhập với quyền co so
            if (Program.mGroup.Equals("COSO"))
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                sqlcmd = Program.conn.CreateCommand();
            }
            else
            {
                if (cbbCoSo.SelectedIndex != Program.mCoSo)
                {
                    Program.servernameKhac = cbbCoSo.SelectedValue.ToString();

                    if (Program.KetNoiCosoKhac() == 0) return;
                    else
                    {
                        this.ta_SP_MAGV_CHUA_TAO_TK.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_SP_MAGV_CHUA_TAO_TK.Fill(this.tN_CSDLPTDataSet.SP_MAGV_CHUA_TAO_TK);
                        sqlcmd = Program.connKhac.CreateCommand();
                    }
                }
                else
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    sqlcmd = Program.conn.CreateCommand();
                }
            }


            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "SP_TAOLOGIN";
            sqlcmd.Parameters.Add(new SqlParameter("@LGNAME", edtTenDN.Text.Trim()));
            sqlcmd.Parameters.Add(new SqlParameter("@PASS", edtPass.Text.Trim()));
            sqlcmd.Parameters.Add(new SqlParameter("@USERNAME", cbbMaGV.SelectedValue.ToString().Trim()));
            sqlcmd.Parameters.Add(new SqlParameter("@ROLE", cbbLoaiTK.SelectedItem.ToString().Trim()));
            SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            sqlcmd.Parameters.Add(sqlParameter);


            int result = -1;
            try
            {
                sqlcmd.ExecuteNonQuery();
                result = (int)sqlcmd.Parameters["@return"].Value;
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show("Lỗi tạo tài khoản " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (result != -1)
            {
                if (result == 1)
                {
                    Program.conn.Close();
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    edtTenDN.Focus();
                    return;
                }
                if (result == 2)
                {
                    Program.conn.Close();
                    MessageBox.Show("Mã giảng viên đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    cbbMaGV.Focus();
                    return;
                }
                //tao tk thành công
                if (result == 0)
                {
                    Program.conn.Close();
                    MessageBox.Show("Tạo tài khoản thành công", "Thành công", MessageBoxButtons.OK);
                    edtPass.Text = "";
                    edtTenDN.Text = "";
                    this.ta_SP_MAGV_CHUA_TAO_TK.Connection.ConnectionString = Program.connstrKhac;
                    this.ta_SP_MAGV_CHUA_TAO_TK.Fill(this.tN_CSDLPTDataSet.SP_MAGV_CHUA_TAO_TK);
                    return;
                }
                else
                {
                    Program.conn.Close();
                    MessageBox.Show("Tạo tài khoản thất bại", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại", "Lỗi", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo tài khoản, bạn có muốn lưu thông tin này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnDangKy_Click(sender, e);
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
    }
}
