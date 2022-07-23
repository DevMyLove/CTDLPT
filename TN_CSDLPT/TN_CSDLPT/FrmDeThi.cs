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
    public partial class FrmDeThi : Form
    {
        private Boolean checkThem = false;
        private Boolean checkSua = false;
        public static Boolean checkSave = true;

        public FrmDeThi()
        {
            InitializeComponent();
        }
       
        private void FrmDeThi_Load(object sender, EventArgs e)
        {
           
            this.ControlBox = false;           
            tN_CSDLPTDataSet.EnforceConstraints = false;
            Program.connstrKhac = Program.connstr;

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.ta_GV.Connection.ConnectionString = Program.connstr;
            this.ta_GV.Fill(this.tN_CSDLPTDataSet.GIAOVIEN);

            this.ta_DSMH.Connection.ConnectionString = Program.connstr;
            this.ta_BoDe.Connection.ConnectionString = Program.connstr;

            if (Program.mGroup.Equals("GIAOVIEN"))
            {
                this.ta_DSMH.FillByMAGV(this.tN_CSDLPTDataSet.MONHOC, Program.username);
                if (bds_DSMH.Count <= 0)
                {
                    MessageBox.Show("Giáo viên chưa có môn học đăng ký ", "Thông báo", MessageBoxButtons.OK);                  
                    bds_BoDe = null;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled =  true;
                    this.ta_BoDe.FillByGV_MH(this.tN_CSDLPTDataSet.BODE, Program.username, cbbDSMH.SelectedValue.ToString().Trim());
                    cbbDSMH.SelectedIndex = 0;
                }

            }
            else
            {
                this.ta_DSMH.Fill(this.tN_CSDLPTDataSet.MONHOC);
                if (bds_DSMH.Count <= 0)
                {
                    MessageBox.Show("Danh sách môn học rỗng ", "Thông báo", MessageBoxButtons.OK);
                    bds_BoDe = null;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;                 
                    this.ta_BoDe.FillBy(this.tN_CSDLPTDataSet.BODE, cbbDSMH.SelectedValue.ToString().Trim());
                    cbbDSMH.SelectedIndex = 0;
                }
            }

            this.ta_MH.Connection.ConnectionString = Program.connstr;
            this.ta_MH.Fill(this.tN_CSDLPTDataSet.MONHOC);

            Detail_GroupControl.Enabled = false;

            cbbTrinhDo.Items.Add("A");
            cbbTrinhDo.Items.Add("B");
            cbbTrinhDo.Items.Add("C");           

            cbbDapAn.Items.Add("A");
            cbbDapAn.Items.Add("B");
            cbbDapAn.Items.Add("C");
            cbbDapAn.Items.Add("D");        

            if (Program.mGroup == "COSO")
            {
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnThem.Visibility = btnSua.Visibility = btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "TRUONG")
            {
                btnThem.Visibility = btnSua.Visibility = btnGhi.Visibility = btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            edtMAGV.Enabled = false;
            edtMAMH.Enabled = false;

        }

        
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnThem.Enabled = btnSua.Enabled =btnTaiLai.Enabled = btnXoa.Enabled = false;

                bds_BoDe.AddNew();
                edtMAMH.Text = cbbDSMH.SelectedValue.ToString();

                Program.conn.Open();
                SqlCommand cmd = new SqlCommand("SP_CH_MAX", Program.conn);               
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CH_MAX", SqlDbType.SmallInt).Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                int kq = int.Parse(cmd.Parameters["@CH_MAX"].Value.ToString());
                nudCauHoi.Value = kq + 1;

                checkThem = true;
                BoDe_GridView.Enabled = false;
                checkSave = false;
               
                Detail_GroupControl.Enabled = true;
                cbbDSMH.Enabled = false;
                nudCauHoi.Enabled = false;
                           
                cbbTrinhDo.SelectedIndex = 1;
                cbbTrinhDo.SelectedIndex = 0;
                cbbDapAn.SelectedIndex = 1;
                cbbDapAn.SelectedIndex = 0;

                if (Program.mGroup.Equals("GIAOVIEN"))
                {
                    cbbGV.Enabled = false;
                    cbbGV.SelectedValue = Program.username;
                }
                else
                {
                    cbbGV.Enabled = true;
                    cbbGV.SelectedIndex = 0;
                }

                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm đề thi " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_BoDe.Count == 0)
            {
                MessageBox.Show("Không có Khoa để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnThem.Enabled = btnSua.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = false;

                if (Program.mGroup.Equals("GIAOVIEN"))
                {
                    cbbGV.Enabled = false;
                    cbbGV.SelectedValue = Program.username;
                }
                else
                {
                    cbbGV.Enabled = true;
                    cbbGV.SelectedValue = ((DataRowView)this.bds_BoDe.Current).Row["MAGV"].ToString();
                }
                int x= cbbTrinhDo.SelectedIndex;
                cbbTrinhDo.SelectedIndex = x;

                checkSua = true;
                nudCauHoi.Enabled = false;
                BoDe_GridView.Enabled = false;

                Detail_GroupControl.Enabled = true;
                cbbTrinhDo.SelectedValue = ((DataRowView)this.bds_BoDe.Current).Row["TRINHDO"].ToString();
                cbbDSMH.Enabled = false;
                checkSave = false;
            }
        }
        private void ghiDB()
        {
            try
            {
                bds_BoDe.EndEdit();
                bds_BoDe.ResetCurrentItem();
                this.ta_BoDe.Update(this.tN_CSDLPTDataSet.BODE);
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                BoDe_GridView.Enabled = true;
                checkSave = true;
                Detail_GroupControl.Enabled = false;
                cbbDSMH.Enabled = true;

                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnTaiLai.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi bộ đề thi " + ex.Message, "", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);

            }

        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (nudCauHoi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã khoa không được rỗng", "", MessageBoxButtons.OK);
                    nudCauHoi.Focus();
                    return;
                }
                else if (edtNoiDung.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Nội dung câu hỏi thi không được rỗng", "", MessageBoxButtons.OK);
                    edtNoiDung.Focus();
                    return;
                }
                else if (edtA.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án A không được bỏ trống", "", MessageBoxButtons.OK);
                    edtA.Focus();
                    return;
                }
                else if (edtB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án B không được bỏ trống", "", MessageBoxButtons.OK);
                    edtB.Focus();
                    return;
                }
                else if (edtC.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án C không được bỏ trống", "", MessageBoxButtons.OK);
                    edtC.Focus();
                    return;
                }
                else if (edtD.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án D không được bỏ trống", "", MessageBoxButtons.OK);
                    edtD.Focus();
                    return;
                }
                else
                {
                    ghiDB();
                    checkThem = false;
                }
                
            }
            else if (checkSua == true)
            {
                ghiDB();
                checkSua = false;
            }
            else
            {
                ghiDB();
            }
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_BoDe.Count == 0)
            {
                MessageBox.Show("Không có câu hỏi để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa câu hỏi thi "
                + ((DataRowView)this.bds_BoDe.Current).Row["CAUHOI"].ToString()
                + "\n" + ((DataRowView)this.bds_BoDe.Current).Row["NOIDUNG"].ToString()
                + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bds_BoDe.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.ta_BoDe.Update(this.tN_CSDLPTDataSet.BODE);
                    btnTaiLai_ItemClick(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi thi " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }
        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ta_GV.Connection.ConnectionString = Program.connstrKhac;
                this.ta_GV.Fill(this.tN_CSDLPTDataSet.GIAOVIEN);
                this.ta_DSMH.Connection.ConnectionString = Program.connstrKhac;
                this.ta_BoDe.Connection.ConnectionString = Program.connstrKhac;

                if (Program.mGroup.Equals("GIAOVIEN"))
                {
                    this.ta_DSMH.FillByMAGV(this.tN_CSDLPTDataSet.MONHOC, Program.username);
                    if (bds_DSMH.Count <= 0)
                    {
                        bds_BoDe = null;
                    }
                    else
                    {
                        this.ta_BoDe.FillByGV_MH(this.tN_CSDLPTDataSet.BODE, Program.username, cbbDSMH.SelectedValue.ToString().Trim());
                    }

                }
                else
                {
                    this.ta_DSMH.Fill(this.tN_CSDLPTDataSet.MONHOC);
                    if (bds_DSMH.Count <= 0)
                    {
                        bds_BoDe = null;
                    }
                    else
                    {
                        this.ta_BoDe.FillBy(this.tN_CSDLPTDataSet.BODE, cbbDSMH.SelectedValue.ToString().Trim());
                    }
                }
                cbbDSMH.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Reload " + ex.Message);
            }
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới câu hỏi thi, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //btnGhiBD_ItemClick(sender, e);
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
                if (MessageBox.Show("Bạn đang sửa câu hỏi thi, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //btnGhi_ItemClick(sender, e);
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

        private void cbbDSMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbDSMH.SelectedValue != null)
            {
                int i = cbbDSMH.SelectedIndex;
                if (Program.mGroup.Equals("GIAOVIEN"))
                {
                    this.ta_BoDe.FillByGV_MH(this.tN_CSDLPTDataSet.BODE, Program.username, cbbDSMH.SelectedValue.ToString().Trim());
                }
                else
                {
                    this.ta_BoDe.FillBy(this.tN_CSDLPTDataSet.BODE, cbbDSMH.SelectedValue.ToString().Trim());
                }
                cbbDSMH.SelectedIndex = i;
                edtMAMH.Text = cbbDSMH.SelectedValue.ToString(); ;
            }
        }

        private void cbbGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGV.SelectedValue != null)
            {
                edtMAGV.Text = cbbGV.SelectedValue.ToString();
            }
        }

       
    }
}
