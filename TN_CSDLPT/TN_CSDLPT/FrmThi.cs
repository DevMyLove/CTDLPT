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
    public partial class FrmThi : Form
    {

        public static Boolean checkThi = false;
        private Boolean isSinhVien = false;
        private int thoigianThi = 0;
        private int soCauThi = 0;
        public static CauHoiItem[] listCauHoi;
        public static ListViewItem baiThi;
        private float diem = -1;
        private DateTime ngayThi;

        String MaLop = "";
        String TenLop = "";

        public FrmThi()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_Lop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }

        private void load_LopSV()
        {
            edtHoTen.Text = Program.mHoten;
            if (!Program.mSV.Equals(""))
            {
                String queyStr = "SELECT LOP.MALOP, TENLOP FROM dbo.LOP JOIN dbo.SINHVIEN " +
                    "ON SINHVIEN.MALOP = LOP.MALOP WHERE MASV = '" + Program.mSV + "'";
                Program.myReader = Program.ExecSqlDataReader(queyStr);
                if (Program.myReader == null)
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                    return;
                }
                else
                {
                    Program.myReader.Read();
                    MaLop = Program.myReader.GetString(0).Trim();
                    TenLop = Program.myReader.GetString(1).Trim();
                    Console.WriteLine(MaLop);
                    cbbTenLop.SelectedValue = MaLop;
                    Program.myReader.Close();
                    Program.conn.Close();
                }
            }
        }

        private void FrmThi_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            tN_CSDLPTDataSet.EnforceConstraints = false;

            if (Program.mGroup.Equals("SINHVIEN"))
            {
                isSinhVien = true;              
            }
            else
            {
                isSinhVien = false;
            }

            this.ta_Lop.Connection.ConnectionString = Program.connstr;
            this.ta_Lop.Fill(this.tN_CSDLPTDataSet.LOP);

            if (bds_Lop.Count <= 0)
            {
                MessageBox.Show("Danh sách lớp đăng kí rỗng ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {  
                edtHoTen.Text = Program.mHoten; 
                this.ta_DSMHDK.Connection.ConnectionString = Program.connstr;
                if (isSinhVien == true)
                {
                    load_LopSV();
                    cbbTenLop.Enabled = false;
                    this.ta_DSMHDK.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, MaLop.Trim());
                }
                else
                {
                    cbbTenLop.Enabled = true;
                    this.ta_DSMHDK.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, cbbTenLop.SelectedValue.ToString().Trim());
                }

                if (bds_DSMHDK.Count > 0)
                {
                    cbbMHDK.SelectedIndex = 0;
                    edtMaMH.Text = cbbMHDK.SelectedValue.ToString().Trim();

                    this.ta_DSLANTHI_MHLOP.Connection.ConnectionString = Program.connstr;
                    this.ta_DSLANTHI_MHLOP.Fill(this.tN_CSDLPTDataSet.SP_DSLANTHI_MHLOP, cbbMHDK.SelectedValue.ToString().Trim(), cbbTenLop.SelectedValue.ToString().Trim());
                    if (bds_DSLANTHI_MHLOP.Count <= 0)
                    {
                        MessageBox.Show("Môn học " + cbbMHDK.SelectedValue.ToString() + " không có lần thi", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        cbbLanThi.SelectedIndex = 0;
                        loadThongTinThi();
                    }
                }
                else
                {
                    MessageBox.Show("Không có môn học đăng ký", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


            }
        }

        private Boolean loadThongTinThi()
        {
            btnNopBai.Visible = false;
            String sql = "";
            if (Program.mGroup.Equals("SINHVIEN"))
            {
                if (MaLop.Trim().Equals(""))
                {
                    MessageBox.Show("Mã lớp sinh viên rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (cbbMHDK.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Môn học sinh viên rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (cbbLanThi.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Lần thi sinh viên rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                sql = "exec sp_thongtinlanthi N'"
                    + MaLop + "', N'"
                    + cbbMHDK.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedValue.ToString().Trim();
            }
            else
            {
                if (cbbTenLop.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Mã lớp thi thử rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (cbbMHDK.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Môn học thi thử rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (cbbLanThi.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Lần thi thi thử rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                sql = "exec sp_thongtinlanthi N'"
                    + cbbTenLop.SelectedValue.ToString().Trim() + "', N'"
                    + cbbMHDK.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedValue.ToString();
            }


            try
            {
                Program.myReader = Program.ExecSqlDataReader(sql);
                if (Program.myReader == null)
                {
                    edtTrinhDo.Text = "";
                    edtSoCauThi.Text = "0";
                    edtThoiGian.Text = "";
                    gb_Control.Visible = false;
                    Program.conn.Close();
                    return false;
                }
                else
                {
                    Program.myReader.Read();

                    edtTrinhDo.Text = Program.myReader.GetString(0);
                    soCauThi = Program.myReader.GetInt16(1);
                    edtSoCauThi.Text = soCauThi.ToString();
                    thoigianThi = Program.myReader.GetInt16(2);
                    lbTime.Text = thoigianThi + ":00";
                    edtThoiGian.Text = thoigianThi.ToString();
                    NgayThi_DateEdit.DateTime = ngayThi = Program.myReader.GetDateTime(3);
                    Program.myReader.Close();
                    Program.conn.Close();
                    gb_Control.Visible = true;
                    btnBatDau.Visible = true;
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối lấy thông tin thi " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return false;
            }
        }

       
        private void cbbMHDK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbMHDK.SelectedValue != null)
            {
                edtMaMH.Text = cbbMHDK.SelectedValue.ToString();
            }
        }

        
        private void cbbTenLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this.ta_DSMHDK.Connection.ConnectionString = Program.connstr;
                this.ta_DSMHDK.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, cbbTenLop.SelectedValue.ToString().Trim());
                if (bds_DSMHDK.Count > 0)
                {
                    cbbMHDK.SelectedIndex = 0;
                    edtMaMH.Text = cbbMHDK.SelectedValue.ToString().Trim();

                    this.ta_DSLANTHI_MHLOP.Connection.ConnectionString = Program.connstr;
                    this.ta_DSLANTHI_MHLOP.Fill(this.tN_CSDLPTDataSet.SP_DSLANTHI_MHLOP, cbbMHDK.SelectedValue.ToString().Trim(), cbbTenLop.SelectedValue.ToString().Trim());
                    if (bds_DSLANTHI_MHLOP.Count <= 0)
                    {
                        btnBatDau.Enabled = false;
                        MessageBox.Show("Môn học " + cbbMHDK.SelectedValue.ToString() + " không có lần thi", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        btnBatDau.Enabled = true;
                        cbbLanThi.SelectedIndex = 0;
                        loadThongTinThi();
                    }
                }
                else
                {
                    btnBatDau.Enabled = false;    
                    edtMaMH.Text = "";
                    cbbLanThi.Text = "";
                    MessageBox.Show("Không có môn học đăng ký", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);

            }
        }

        private void cbbLanThi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadThongTinThi();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (!loadThongTinThi()) return;

            if (Program.mGroup.Equals("SINHVIEN"))
            {
                String sql_sp_ktlanthi = "exec SP_KTLANTHI'"
                    + Program.mSV + "', '"
                    + cbbMHDK.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedValue.ToString().Trim();

                int kq = Program.ExecSqlNonQuery(sql_sp_ktlanthi);
                Program.conn.Close();
                if (kq == 1)
                {
                    return;
                }

                DateTime today = DateTime.Today;
                //if (today.CompareTo(ngayThi.Date) != 0)
                //{
                //    MessageBox.Show("Hôm nay không thi, kiểm tra lại lịch", "Thông báo", MessageBoxButtons.OK);
                //    return;
                //}
            }

            load_CauHoi();
        }

        private void load_CauHoi()
        {
            String sql = "";
            if (isSinhVien == true)
            {
                sql = "exec SP_BAITHI '"
                    + MaLop+ "','"
                    + Program.mSV + "','"
                    + cbbMHDK.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedValue.ToString().Trim();
            }
            else
            {
                sql = "exec SP_ThiThu '"
                     + cbbTenLop.SelectedValue.ToString() + "','"
                    + cbbMHDK.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedValue.ToString().Trim();
            }
            DataTable dt = Program.ExecSqlDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không thể lấy được đề thi, thiếu đề", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            // bắt đầu thi khi đã có dữ liệu
            btnBatDau.Visible = false;
            btnNopBai.Visible = true;
            timer1.Start();
            bds_BODE.DataSource = dt;
            cbbTenLop.Enabled = cbbMHDK.Enabled = cbbLanThi.Enabled = false;
            listCauHoi = new CauHoiItem[soCauThi];
            checkThi = true;
            if (isSinhVien == true)
            {
                for (int i = 0; i < listCauHoi.Length; i++)
                {
                    listCauHoi[i] = new CauHoiItem();
                    listCauHoi[i].Width = scroll_BaiThi.Width;

                    listCauHoi[i].CauSo = i + 1;
                    listCauHoi[i].CauHoi = (int)((DataRowView)bds_BODE[i])["CAUHOI"];
                    listCauHoi[i].MaMH = ((DataRowView)bds_BODE[i])["MAMH"].ToString();
                    listCauHoi[i].TrinhDo = ((DataRowView)bds_BODE[i])["TRINHDO"].ToString();
                    listCauHoi[i].NdCauHoi = ((DataRowView)bds_BODE[i])["NOIDUNG"].ToString();
                    listCauHoi[i].Da_A = ((DataRowView)bds_BODE[i])["A"].ToString();
                    listCauHoi[i].Da_B = ((DataRowView)bds_BODE[i])["B"].ToString();
                    listCauHoi[i].Da_C = ((DataRowView)bds_BODE[i])["C"].ToString();
                    listCauHoi[i].Da_D = ((DataRowView)bds_BODE[i])["D"].ToString();
                    listCauHoi[i].DapAn = ((DataRowView)bds_BODE[i])["DAP_AN"].ToString();
                    listCauHoi[i].MaGV = ((DataRowView)bds_BODE[i])["MAGV"].ToString();
                    listCauHoi[i].DaChon = "";

                    String[] arr = new string[2];
                    arr[0] = (i + 1).ToString();
                    arr[1] = listCauHoi[i].DaChon;

                    baiThi = new ListViewItem(arr);
                    this.summarylistview.Items.Add(baiThi);


                    if (scroll_BaiThi.Controls.Count < 0)
                    {
                        scroll_BaiThi.Controls.Clear();
                    }
                    else
                        scroll_BaiThi.Controls.Add(listCauHoi[i]);
                }
            }
            else
            {
                for (int i = 0; i < listCauHoi.Length; i++)
                {
                    listCauHoi[i] = new CauHoiItem();
                    listCauHoi[i].Width = scroll_BaiThi.Width;

                    listCauHoi[i].CauSo = i + 1;
                    listCauHoi[i].CauHoi = (int)((DataRowView)bds_BODE[i])["CAUHOI"];
                    listCauHoi[i].MaMH = ((DataRowView)bds_BODE[i])["MAMH"].ToString();
                    listCauHoi[i].TrinhDo = ((DataRowView)bds_BODE[i])["TRINHDO"].ToString();
                    listCauHoi[i].NdCauHoi = ((DataRowView)bds_BODE[i])["NOIDUNG"].ToString();
                    listCauHoi[i].Da_A = ((DataRowView)bds_BODE[i])["A"].ToString();
                    listCauHoi[i].Da_B = ((DataRowView)bds_BODE[i])["B"].ToString();
                    listCauHoi[i].Da_C = ((DataRowView)bds_BODE[i])["C"].ToString();
                    listCauHoi[i].Da_D = ((DataRowView)bds_BODE[i])["D"].ToString();
                    listCauHoi[i].DapAn = ((DataRowView)bds_BODE[i])["DAP_AN"].ToString();
                    listCauHoi[i].MaGV = ((DataRowView)bds_BODE[i])["MAGV"].ToString();
                    listCauHoi[i].DaChon = "";

                    String[] arr = new string[2];
                    arr[0] = (i + 1).ToString();
                    arr[1] = listCauHoi[i].DaChon;

                    baiThi = new ListViewItem(arr);
                    this.summarylistview.Items.Add(baiThi);


                    if (scroll_BaiThi.Controls.Count < 0)
                    {
                        scroll_BaiThi.Controls.Clear();
                    }
                    else
                        scroll_BaiThi.Controls.Add(listCauHoi[i]);
                }
            }
        }

        public void capNhapDaChon(int cauSo, String daChon)
        {
            String[] arr = new string[2];
            arr[0] = (cauSo).ToString();
            arr[1] = daChon;
            ListViewItem baiThi = new ListViewItem(arr);
            summarylistview.Items[cauSo - 1] = baiThi;
        }

        private void insertCT_BAITHI()
        {
            string sqlUpdate = "";
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                //if (listCauHoi[i].DaChon != "") {
                    sqlUpdate += " UPDATE dbo.CT_BAITHI SET DACHON = '"+ listCauHoi[i].DaChon.ToString().Trim()
                        + "' WHERE MASV = '" + Program.mSV.ToString().Trim()
                        + "' AND MAMH = '" + cbbMHDK.SelectedValue.ToString().Trim()
                        + "' AND LAN = '" + cbbLanThi.SelectedValue.ToString().Trim()
                        + "' AND CAUHOI = " + listCauHoi[i].CauHoi.ToString().Trim();
                //}

                Console.WriteLine(" CAU HOI:  " + listCauHoi[i].CauHoi + "\tDACHON:" + listCauHoi[i].DaChon);
            }

            Console.WriteLine("Lenh SQL: " + sqlUpdate);

            try
            {
                int kq = Program.ExecSqlNonQuery(sqlUpdate);
                Program.conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đáp án thi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void insertBANGDIEM()
        {
            String sql = "UPDATE dbo.BANGDIEM SET DIEM = " + diem 
                + "WHERE MASV = '" + Program.mSV
                + "' AND MAMH = '" + cbbMHDK.SelectedValue.ToString().Trim()
                + "' AND LAN = " + cbbLanThi.SelectedValue.ToString().Trim();
            try
            {
                int kq = Program.ExecSqlNonQuery(sql);
                Program.conn.Close();
                insertCT_BAITHI();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi điểm thi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void tinhDiem()
        {
            int caudung = 0;
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                if (listCauHoi[i].DaChon.Trim().CompareTo(listCauHoi[i].DapAn.Trim()) == 0)
                    caudung++;
            }

            if (caudung == 0) diem = 0;

            else diem = (float)Math.Round((double)(10 * caudung) / soCauThi, 2);
            MessageBox.Show("Số câu đúng: " + caudung + "/" + soCauThi + "\nĐiểm: " + diem, "Kết Quả", MessageBoxButtons.OK);
            btnNopBai.Visible = false;
            btnBatDau.Visible = true;
        }

        private int s = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == 0)
            {
                if (thoigianThi != 0)
                {
                    thoigianThi--;
                    s = 59;
                }
            }
            lbTime.Text = thoigianThi.ToString() + " : " + s.ToString();
            if (thoigianThi == 0 && s == 0)
            {
                timer1.Stop();
                cbbTenLop.Enabled = cbbMHDK.Enabled = cbbLanThi.Enabled = true;
                checkThi = false;
                MessageBox.Show("Đã hết thời gian thi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tinhDiem();
                if (Program.mGroup.Equals("SINHVIEN"))
                {
                    insertBANGDIEM();
                }
                btnNopBai.Enabled = false;
            }
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            DialogResult Nop = MessageBox.Show("Bạn chắc chắn muốn nộp bài", "", MessageBoxButtons.YesNo);
            if (Nop == DialogResult.Yes)
            {
                timer1.Stop();
                checkThi = false;
                tinhDiem();

                if (Program.mGroup.Equals("SINHVIEN"))
                    insertBANGDIEM();

                btnNopBai.Visible = false;
                btnBatDau.Visible = btnBatDau.Enabled = true;
                summarylistview.Items.Clear();
                scroll_BaiThi.Controls.Clear();
                cbbTenLop.Enabled = cbbLanThi.Enabled = cbbMHDK.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkThi == true) // đang thi
            {
                btnNopBai_Click(sender, e);
                if (checkThi == false)
                    this.Close();
                else
                    return;
            }
            else
            {
                this.Close();
            }
        }
    }
}
