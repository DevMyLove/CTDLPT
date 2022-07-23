using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {            
            InitializeComponent();
        }

        private void radSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            lbMSV.Visible = true;
            txtMSV.Visible = true;
            pictureBoxMSV.Visible = true;

        }

        private void radGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            lbMSV.Visible = false;
            txtMSV.Visible = false;
            pictureBoxMSV.Visible = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txUsername.Text.Trim() == "" || txPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và password không được trống", "", MessageBoxButtons.OK);
                return;
            }
            if (txtMSV.Text.Trim() == "" && radSinhVien.Checked)
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txUsername.Text;
            Program.password = txPassword.Text;
            Program.mSV = txtMSV.Text;


            // Đăng nhập thất bại
            if (Program.KetNoi() == 0) return;

            
            Program.mCoSo = cbbCoso.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;


            if (radSinhVien.Checked)
            {
                String sql = "EXEC SP_KTSV_DANGNHAP '" + txtMSV.Text + "'";
                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    return;
                }
            }

            string strLenh;
            if (radGiaoVien.Checked)
            {
                strLenh = "EXEC SP_TTGV_DANGNHAP'" + Program.mlogin + "'";
            }
            else
            {
                strLenh = "EXEC SP_TTSV_DANGNHAP '" + Program.mlogin + "' , " + "'" + Program.mSV + "'";
            }

            //Thực hiện sp
            Program.myReader = Program.ExecSqlDataReader(strLenh);

            if (Program.myReader == null) return;
            Program.myReader.Read();

            // Check giáo viên nhưng lại lấy tài khoản sinh viên đăng nhập
            if (radGiaoVien.Checked)
            {
                if (Program.myReader.GetString(2).Trim().Equals("SINHVIEN"))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu.. \nVui lòng kiểm tra lại username, password.", "", MessageBoxButtons.OK);
                    return;
                }
            }
            // Check sinh viên nhưng lại lấy GIAOVIEN đăng nhập
            else
            {
                if (!Program.myReader.GetString(2).Trim().Equals("SINHVIEN"))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu. \nVui lòng kiểm tra lại username, password", "", MessageBoxButtons.OK);
                    return;
                }
            }

            Program.username = Program.myReader.GetString(0);     // Lay user name
            
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            if (radSinhVien.Checked)
            {
                this.Hide();
                Program.frmSV = new FrmSinhVien();
                Program.frmSV.Activate();
                Program.frmSV.MASO.Text = "Mã số: " + Program.mSV;
                Program.frmSV.HOTEN.Text = "Họ tên: " + Program.mHoten;
                Program.frmSV.NHOM.Text = "Nhóm: " + Program.mGroup;
                Program.frmSV.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Program.frmChinh = new FrmMain();                  

                Program.frmChinh.MASO.Text = "Mã số: " + Program.username;
                Program.frmChinh.HOTEN.Text = "Họ tên: " + Program.mHoten;
                Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;
                Program.frmChinh.ShowDialog();
                this.Close();
            }

            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            radGiaoVien.Checked = true;
            lbMSV.Visible = false;
            txtMSV.Visible = false;
            pictureBoxMSV.Visible = false;
            try
            {
                //Kết nối về site chủ không cần password và tài khoản
                // dùng để lấy danh sách cơ sở từ site chủ               
                Program.conn.ConnectionString = Program.connstr_publisher;
                Program.conn.Open();

                // Gọi view COSO và trả về datable 
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_COSO");
                Program.bds_dspm.DataSource = dt;

                // Lấy kết quả đổ vào combobox
                cbbCoso.DataSource = dt;
                cbbCoso.DisplayMember = "TENCS";
                cbbCoso.ValueMember = "TENSERVER";
                cbbCoso.SelectedIndex = 1;
                cbbCoso.SelectedIndex = 0;
                txUsername.Focus();
            }
            catch (Exception a)
            {
                MessageBox.Show("Không thể kết nối tới database! " + a.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {           
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }          
        }

        private void cbbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbCoso.SelectedValue != null)
                {
                    Program.servername = cbbCoso.SelectedValue.ToString();                 
                }
            }
            catch (Exception) { };
        }
    }
}
