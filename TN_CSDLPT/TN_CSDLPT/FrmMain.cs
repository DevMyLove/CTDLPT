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
    public partial class FrmMain : Form
    {   
        private Form form;
        private FrmKhoa frmKhoa = null;
        private FrmLop frmLop = null;
        private FrmMonHoc frmMonHoc = null;
        private FrmGVDK frmGVDK = null;
        private FrmDeThi frmDeThi = null;
        private FrmThi frmThi = null;
        private FrmBangDiem frmBangDiem = null;
        private FrmNewAcc frmNewAcc = null;
        private FrmGiaoVien frmGV = null;
        private FrmQLSV frmQLSV = null;

        private Boolean checkOpenKhoa = false;
        private Boolean checkOpenLop = false;
        private Boolean checkOpenMonHoc = false;
        private Boolean checkOpenDeThi = false; 
        private Boolean checkOpenGVDK = false;
        private Boolean checkOpenThiThu = false;
        private Boolean checkOpenTaoTK = false;
        private Boolean checkOpenGV = false;
        private Boolean checkOpenQLSV = false;
        private Boolean checkDangXuat = false;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1330, 700);

            //Giangvien thì chỉ được quyền cập nhật đề thi, và chỉ được quyền hiệu chỉnh câu hỏi thi do mình soạn
            //, được thi thử nhưng không ghi điểm
            if (Program.mGroup.Equals("GIAOVIEN"))
            {
                rbKhoa.Visible = rbLop.Visible = rbMon.Visible = false;
                rbGVDK.Visible = false;
                rbBaoCao.Visible = false;
                rbTaoTK.Visible = false;
                rbThiThu.Visible = true;
            }
            else if (Program.mGroup.Equals("COSO"))
            {
                rbKhoa.Visible = rbLop.Visible = rbMon.Visible = true;
                rbBaoCao.Visible = true;
                rbGVDK.Visible = true;
                rbTaoTK.Visible = true;
                rbThiThu.Visible = true;
            }
            else
            {
                rbKhoa.Visible = rbLop.Visible = rbMon.Visible = true;
                rbBaoCao.Visible = true;
                rbGVDK.Visible = true;
                rbTaoTK.Visible = true;
                rbThiThu.Visible = false;
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(FrmKhoa));
            if (form == null)
            {

                IsMdiContainer = true;
                frmKhoa = new FrmKhoa();
                frmKhoa.MdiParent = this;

                frmKhoa.Show();
                checkOpenKhoa = true;
            }
            else form.Activate();
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(FrmLop));
            if (form == null)
            {

                IsMdiContainer = true;
                frmLop = new FrmLop();
                frmLop.MdiParent = this;

                frmLop.Show();
                checkOpenLop = true;
            }
            else form.Activate();
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(FrmMonHoc));
            if (form == null)
            {

                IsMdiContainer = true;
                frmMonHoc = new FrmMonHoc();
                frmMonHoc.MdiParent = this;

                frmMonHoc.Show();
                checkOpenMonHoc = true;
            }
            else form.Activate();
        }

        private void btnGiangVienDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(FrmGVDK));
            if (form == null)
            {

                IsMdiContainer = true;
                frmGVDK = new FrmGVDK();
                frmGVDK.MdiParent = this;

                frmGVDK.Show();
                checkOpenGVDK = true;
            }
            else form.Activate();
        }

        private void btnDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(FrmDeThi));
            if (form == null)
            {
                IsMdiContainer = true;
                frmDeThi = new FrmDeThi();
                frmDeThi.MdiParent = this;
                frmDeThi.Show();
                checkOpenDeThi = true;
            }
            else form.Activate();
            
        }

        private void btnThiThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(FrmThi));
            if (form == null)
            {
                IsMdiContainer = true;
                frmThi = new FrmThi();
                frmThi.MdiParent = this;

                frmThi.Show();
                checkOpenThiThu = true;
            }
            else form.Activate();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkDangXuat = true;
            Program.mlogin = "";
            Program.password = "";
            this.Hide();
            Program.frmLogin = new FrmLogin();
            Program.frmLogin.Activate();
            Program.frmLogin.ShowDialog();
            this.Close();
        }

        private void btnThoatMain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắc muốn thoát", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                return;
            }
        }

        private void btnBangDiemBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(FrmBangDiem));
            if (form == null)
            {

                IsMdiContainer = true;
                frmBangDiem = new FrmBangDiem();
                frmBangDiem.MdiParent = this;

                frmBangDiem.Show();
            }
            else form.Activate();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(FrmNewAcc));
            if (form == null)
            {

                IsMdiContainer = true;
                frmNewAcc = new FrmNewAcc();
                frmNewAcc.MdiParent = this;

                frmNewAcc.Show();
                checkOpenTaoTK = true;
            }
            else form.Activate();
        }

        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(FrmGiaoVien));
            if (form == null)
            {

                IsMdiContainer = true;
                frmGV = new FrmGiaoVien();
                frmGV.MdiParent = this;

                frmGV.Show();
                checkOpenGV = true;
            }
            else form.Activate();
        }

        private void btnQLSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form = this.CheckExists(typeof(FrmQLSV));
            if (form == null)
            {

                IsMdiContainer = true;
                frmQLSV = new FrmQLSV();
                frmQLSV.MdiParent = this;

                frmQLSV.Show();
                checkOpenQLSV = true;
            }
            else form.Activate();
        }
    }
}
