using DevExpress.XtraReports.UI;
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
    public partial class FrmBangDiem : Form
    {
        public static Boolean isCoSoKhac = false;
        private int loadCoso = 0;

        public FrmBangDiem()
        {
            InitializeComponent();
        }

        private void cOSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_COSO.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }

        private void FrmBangDiem_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            Program.connstrKhac = Program.connstr;
            tN_CSDLPTDataSet.EnforceConstraints = false;

            // Lấy kết danh sách phân mảnh đổ vào combobox
            cbbCOSO.DataSource = Program.bds_dspm.DataSource;
            cbbCOSO.DisplayMember = "TENCS";
            cbbCOSO.ValueMember = "TENSERVER";
            cbbCOSO.SelectedIndex = Program.mCoSo;

            if (Program.mGroup == "TRUONG")
            {
                cbbCOSO.Enabled = true;
            }
            else if (Program.mGroup == "COSO")
            {
                cbbCOSO.Enabled = false;
            }
            loadCoso++;

            this.ta_LOP.Connection.ConnectionString = Program.connstrKhac;
            this.ta_LOP.Fill(this.tN_CSDLPTDataSet.LOP);
            if (bds_LOP.Count > 0)
            {
                cbbTENLOP.SelectedIndex = 0;
                this.ta_SP_DSMHDK.Connection.ConnectionString = Program.connstrKhac;
                this.ta_SP_DSMHDK.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, cbbTENLOP.SelectedValue.ToString());

                if (bds_SP_DSMHDK.Count > 0)
                {
                    cbbMH.SelectedIndex = 0;

                    this.ta_SP_DSLANTHI.Connection.ConnectionString = Program.connstrKhac;
                    this.ta_SP_DSLANTHI.Fill(this.tN_CSDLPTDataSet.SP_DSLANTHI_MHLOP, cbbMH.SelectedValue.ToString(), cbbTENLOP.SelectedValue.ToString());
                    if (bds_SP_DSLANTHI.Count > 0)
                    {
                        cbbLAN.SelectedIndex = 0;
                        this.ta_SP_XemKQSV.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_SP_XemKQSV.Fill(this.tN_CSDLPTDataSet.SP_XemKQSV, cbbTENLOP.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLAN.SelectedValue.ToString()));
                    }
                }
            }
            else
            {
                this.ta_SP_DSMHDK.Connection.ConnectionString = Program.connstrKhac;
                this.ta_SP_DSMHDK.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, null);
                this.ta_SP_XemKQSV.Connection.ConnectionString = Program.connstrKhac;
                this.ta_SP_XemKQSV.Fill(this.tN_CSDLPTDataSet.SP_XemKQSV, null, null, null);
            }

        }

        private void cbbCOSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCOSO.SelectedValue != null && loadCoso != 0)
            {
                Program.servernameKhac = cbbCOSO.SelectedValue.ToString();
                if (Program.KetNoiCosoKhac() == 0) return;
                else
                {
                    this.ta_LOP.Connection.ConnectionString = Program.connstrKhac;
                    this.ta_LOP.Fill(this.tN_CSDLPTDataSet.LOP);
                    if (bds_LOP.Count > 0)
                    {
                        cbbTENLOP.SelectedIndex = 0;
                        this.ta_SP_DSMHDK.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_SP_DSMHDK.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, cbbTENLOP.SelectedValue.ToString());
                        if (bds_SP_DSMHDK.Count > 0)
                        {
                            cbbMH.SelectedIndex = 0;

                            this.ta_SP_DSLANTHI.Connection.ConnectionString = Program.connstrKhac;
                            this.ta_SP_DSLANTHI.Fill(this.tN_CSDLPTDataSet.SP_DSLANTHI_MHLOP, cbbMH.SelectedValue.ToString(), cbbTENLOP.SelectedValue.ToString());
                            if (bds_SP_DSLANTHI.Count > 0)
                            {
                                cbbLAN.SelectedIndex = 0;
                                this.ta_SP_XemKQSV.Connection.ConnectionString = Program.connstrKhac;
                                this.ta_SP_XemKQSV.Fill(this.tN_CSDLPTDataSet.SP_XemKQSV, cbbTENLOP.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLAN.SelectedValue.ToString()));
                            }
                        }
                        else
                        {
                            this.ta_SP_DSMHDK.Connection.ConnectionString = Program.connstrKhac;
                            this.ta_SP_DSMHDK.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, null);
                            this.ta_SP_XemKQSV.Connection.ConnectionString = Program.connstrKhac;
                            this.ta_SP_XemKQSV.Fill(this.tN_CSDLPTDataSet.SP_XemKQSV, null, null, null);
                        }
                    }
                }
            }
        }

        private void cbbTENLOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbTENLOP.SelectedValue != null)
                {
                    Console.WriteLine(cbbTENLOP.SelectedValue.ToString());
                    this.ta_SP_DSMHDK.Connection.ConnectionString = Program.connstrKhac;
                    this.ta_SP_DSMHDK.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, cbbTENLOP.SelectedValue.ToString());
                    if (bds_SP_DSMHDK.Count > 0)
                    {
                        cbbMH.SelectedIndex = 0;

                        this.ta_SP_DSLANTHI.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_SP_DSLANTHI.Fill(this.tN_CSDLPTDataSet.SP_DSLANTHI_MHLOP, cbbMH.SelectedValue.ToString(), cbbTENLOP.SelectedValue.ToString());
                        if (bds_SP_DSLANTHI.Count > 0)
                        {
                            cbbLAN.SelectedIndex = 0;
                            this.ta_SP_XemKQSV.Connection.ConnectionString = Program.connstrKhac;
                            this.ta_SP_XemKQSV.Fill(this.tN_CSDLPTDataSet.SP_XemKQSV, cbbTENLOP.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLAN.SelectedValue.ToString()));
                        }
                    }
                }
            }
            catch (Exception) { };
        }

        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {   
            try
            {
                if (cbbTENLOP.SelectedValue != null)
                {
                    if (cbbMH.SelectedValue != null)
                    {
                        this.ta_SP_DSLANTHI.Connection.ConnectionString = Program.connstrKhac;
                        this.ta_SP_DSLANTHI.Fill(this.tN_CSDLPTDataSet.SP_DSLANTHI_MHLOP, cbbMH.SelectedValue.ToString(), cbbTENLOP.SelectedValue.ToString());
                        if (bds_SP_DSLANTHI.Count > 0)
                        {
                            cbbLAN.SelectedIndex = 0;
                            this.ta_SP_XemKQSV.Connection.ConnectionString = Program.connstrKhac;
                            this.ta_SP_XemKQSV.Fill(this.tN_CSDLPTDataSet.SP_XemKQSV, cbbTENLOP.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLAN.SelectedValue.ToString()));
                        }
                    }
                }
            }
            catch (Exception) { };
        }

        private void cbbLAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbTENLOP.SelectedValue != null)
                {
                    if (cbbMH.SelectedValue != null)
                    {
                        if (cbbLAN.SelectedValue != null)
                        {
                            this.ta_SP_XemKQSV.Connection.ConnectionString = Program.connstrKhac;
                            this.ta_SP_XemKQSV.Fill(this.tN_CSDLPTDataSet.SP_XemKQSV, cbbTENLOP.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLAN.SelectedValue.ToString()));
                        }
                    }
                }
            }
            catch (Exception) { };
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnInDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_LOP.Count <= 0 || bds_SP_DSMHDK.Count <= 0 || bds_SP_DSLANTHI.Count <= 0)
            {
                MessageBox.Show("Không có thông tin bảng điểm ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            
        }
    }
}
