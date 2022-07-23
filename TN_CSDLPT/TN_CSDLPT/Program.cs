using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TN_CSDLPT
{
    internal static class Program
    {
        public static FrmLogin frmLogin;
        public static FrmMain frmChinh;
        public static FrmSinhVien frmSV;


        public static SqlConnection conn = new SqlConnection();
        public static String connstr_publisher = @"Data Source=DESKTOP-84EDD9G\SQL2019_CEN;Initial Catalog=TN_CSDLPT;Integrated Security=True";
        public static String connstr;

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static String mSV = "";

        public static String mloginHTKN = "HTKN";
        public static String passwordHTKN = "123";
        public static String connstrKhac = "";
        public static String servernameKhac = "";
        public static SqlConnection connKhac = new SqlConnection();

        public static String database = "TN_CSDLPT";
        public static String remotelogin = "sa";
        public static String remotepassword = "123";

        public static String mloginDN = "";
        public static String passwordDN = "";

        public static String mGroup = "";
        public static String mHoten = "";
        public static int mCoSo = 0;
        public static String mTenCoSo = "";

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
                                                                  
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
               
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" + Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n "
                    + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static int KetNoiCosoKhac()
        {
            if (Program.connKhac != null && Program.connKhac.State == ConnectionState.Open)
                Program.connKhac.Close();
            try
            {
                Program.connstrKhac = "Data Source=" + Program.servernameKhac + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mloginHTKN + ";password=" + Program.passwordHTKN;
                Program.connKhac.ConnectionString = Program.connstrKhac;
                Program.connKhac.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n "
                    + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static int ExecSqlNonQuery(String strlenh)
        {

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            try
            {
                Sqlcmd.ExecuteNonQuery();
                return 0;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        public static SqlDataReader ExecSqlDataReaderHTKN(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.connKhac);
            sqlcmd.CommandType = CommandType.Text;
            //tối đa cho đợi 10p, tgian tính bằng s
            sqlcmd.CommandTimeout = 600;
            // Kiểm tra trạng thái đóng hay mở
            if (Program.connKhac.State == ConnectionState.Closed) Program.connKhac.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.connKhac.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            // Trả về datable
            DataTable dt = new DataTable();
            //Nếu đang đóng thì mở
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            // Muốn gọi csdl phải thông qua SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            // Chạy lệnh cmd
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable ExecSqlDataTable1(String cmd)
        {
            // Trả về datable
            DataTable dt = new DataTable();
            //Nếu đang đóng thì mở
            if (Program.connKhac.State == ConnectionState.Closed) Program.connKhac.Open();
            // Muốn gọi csdl phải thông qua SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd, connKhac);
            // Chạy lệnh cmd
            da.Fill(dt);
            connKhac.Close();
            return dt;
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            //tối đa cho đợi 10p, tgian tính bằng s
            sqlcmd.CommandTimeout = 600;
            // Kiểm tra trạng thái đóng hay mở
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open(); 
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static SqlDataReader ExecSqlDataReader1(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.connKhac);
            sqlcmd.CommandType = CommandType.Text;
            //tối đa cho đợi 10p, tgian tính bằng s
            sqlcmd.CommandTimeout = 600;
            // Kiểm tra trạng thái đóng hay mở
            if (Program.connKhac.State == ConnectionState.Closed) Program.connKhac.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.connKhac.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FrmLogin();
            Application.Run(frmLogin);
        }

    }
}
