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
    public partial class FrmSinhVien : Form
    {
        private Form form;
        private FrmThi frmThi = null;
        private FrmXemKQThi frmXemKQThi = null;

        private Boolean checkDangXuat = false;
        public static Boolean checkThi = false;
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             form = this.CheckExists(typeof(FrmThi));
            if (form == null)
            {
                IsMdiContainer = true;
                frmThi = new FrmThi();
                frmThi.MdiParent = this;

                frmThi.Show();
                checkThi = true;
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

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát ", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btnXemKQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FrmXemKQThi));
            if (form == null)
            {

                IsMdiContainer = true;
                frmXemKQThi = new FrmXemKQThi();
                frmXemKQThi.MdiParent = this;

                frmXemKQThi.Show();
            }
            else form.Activate();
        }
    }
}
