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
    public partial class CauHoiItem : UserControl
    {
        public CauHoiItem()
        {
            InitializeComponent();
        }

        private int cauSo;
        private int cauHoi;
        private string maMH;
        private string trinhDo;
        private string ndCauHoi;
        private string da_A;
        private string da_B;
        private string da_C;
        private string da_D;
        private string dapAn = "";
        private string maGV;
        private string daChon = "";

        public int CauSo { 
            get => cauSo;
            set { cauSo = value; lbCauSo.Text = "Câu " + cauSo + ": "; }
        }
        public int CauHoi { get => cauHoi; set => cauHoi = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string NdCauHoi { 
            get => ndCauHoi;
            set { ndCauHoi = value; lbNoiDungCH.Text = ndCauHoi; }
        }
        public string Da_A { 
            get => da_A;
            set { da_A = value; rbA.Text = da_A; } 
        }
        public string Da_B { 
            get => da_B; 
            set { da_B = value; rbB.Text = da_B; }
        }
        public string Da_C { 
            get => da_C;
            set { da_C = value; rbC.Text = da_C; }
        }
        public string Da_D { 
            get => da_D;
            set { da_D = value; rbD.Text = da_D; }
        }
        public string DapAn { get => dapAn; set => dapAn = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string DaChon { get => daChon; set => daChon = value; }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            DaChon = "A";
            var principalForm = Application.OpenForms.OfType<FrmThi>().Single();
            principalForm.capNhapDaChon(CauSo, "A");
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            DaChon = "B";
            var principalForm = Application.OpenForms.OfType<FrmThi>().Single();
            principalForm.capNhapDaChon(CauSo, "B");
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            DaChon = "C";
            var principalForm = Application.OpenForms.OfType<FrmThi>().Single();
            principalForm.capNhapDaChon(CauSo, "C");
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            DaChon = "D";
            var principalForm = Application.OpenForms.OfType<FrmThi>().Single();
            principalForm.capNhapDaChon(CauSo, "D");
        }
    }
}
