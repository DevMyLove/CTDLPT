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
    public partial class FrmXemKQThi : Form
    {
        public FrmXemKQThi()
        {
            InitializeComponent();
        }


        private void FrmXemKQThi_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            tN_CSDLPTDataSet.EnforceConstraints = false;

            try
            {
                this.ta_SP_MH_SV_THI.Connection.ConnectionString = Program.connstr;
                this.ta_SP_MH_SV_THI.Fill(this.tN_CSDLPTDataSet.SP_MH_SV_THI, Program.mSV);
                if (bds_SP_MH_SV_THI.Count > 0)
                {   
                    cbbMH.SelectedIndex = 0;
                    
                    this.ta_SP_LAN_SV_THI.Connection.ConnectionString = Program.connstr;
                    this.ta_SP_LAN_SV_THI.Fill(this.tN_CSDLPTDataSet.SP_LAN_SV_THI, Program.mSV, cbbMH.SelectedValue.ToString());
                    if (bds_SP_LAN_SV_THI.Count > 0)
                    {
                        cbbLAN.SelectedIndex = 0;

                        string sql = "exec SP_DETAIL_BAITHI N'"
                       + Program.mSV + "', N'"
                       + cbbMH.SelectedValue.ToString() + "', "
                       + cbbLAN.SelectedValue.ToString().Trim();

                        DataTable dt = Program.ExecSqlDataTable(sql);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không thể lấy được bài thi", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                       dataGridView1.DataSource = dt;
                    }
                }
                else
                {                  
                    Program.conn.Close();
                    MessageBox.Show("Sinh viên không có môn học đăng ký", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("abc " + ex.Message);
            };
        }
        private void cbbMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbMH.SelectedValue != null)
            {
                try
                {
                    this.ta_SP_LAN_SV_THI.Connection.ConnectionString = Program.connstr;
                    this.ta_SP_LAN_SV_THI.Fill(this.tN_CSDLPTDataSet.SP_LAN_SV_THI, Program.mSV, cbbMH.SelectedValue.ToString());
                    cbbLAN.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("loi lay dsmh sv: " + ex);
                }
            }
        }

        private void cbbLAN_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbbMH.SelectedValue != null && cbbLAN.SelectedValue != null)
                {
                    this.ta_SP_LAN_SV_THI.Connection.ConnectionString = Program.connstr;
                    this.ta_SP_LAN_SV_THI.Fill(this.tN_CSDLPTDataSet.SP_LAN_SV_THI, Program.mSV, cbbMH.SelectedValue.ToString());
                    if (bds_SP_LAN_SV_THI.Count > 0)
                    {
                        cbbLAN.SelectedIndex = 0;

                        string sql = "exec SP_DETAIL_BAITHI N'"
                       + Program.mSV + "', N'"
                       + cbbMH.SelectedValue.ToString() + "', "
                       + cbbLAN.SelectedValue.ToString().Trim();

                        DataTable dt = Program.ExecSqlDataTable(sql);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không thể lấy được baif thi", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
