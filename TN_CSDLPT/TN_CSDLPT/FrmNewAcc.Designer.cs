
namespace TN_CSDLPT
{
    partial class FrmNewAcc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewAcc));
            this.edtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.edtTenDN = new System.Windows.Forms.TextBox();
            this.cbbLoaiTK = new System.Windows.Forms.ComboBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbLoginName = new System.Windows.Forms.Label();
            this.lbLoaiTaiKhoan = new System.Windows.Forms.Label();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.cbbMaGV = new System.Windows.Forms.ComboBox();
            this.bds_SP_MAGV_CHUA_TAO_TK = new System.Windows.Forms.BindingSource(this.components);
            this.tN_CSDLPTDataSet = new TN_CSDLPT.TN_CSDLPTDataSet();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.bds_COSO = new System.Windows.Forms.BindingSource(this.components);
            this.ta_COSO = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.COSOTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.ta_SP_MAGV_CHUA_TAO_TK = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.SP_MAGV_CHUA_TAO_TKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SP_MAGV_CHUA_TAO_TK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_COSO)).BeginInit();
            this.SuspendLayout();
            // 
            // edtPass
            // 
            this.edtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPass.Location = new System.Drawing.Point(391, 297);
            this.edtPass.Margin = new System.Windows.Forms.Padding(1);
            this.edtPass.Name = "edtPass";
            this.edtPass.PasswordChar = '*';
            this.edtPass.Size = new System.Drawing.Size(277, 27);
            this.edtPass.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cơ sở";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(533, 412);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 44);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.Location = new System.Drawing.Point(216, 412);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(1);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(132, 44);
            this.btnDangKy.TabIndex = 38;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // edtTenDN
            // 
            this.edtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTenDN.Location = new System.Drawing.Point(391, 165);
            this.edtTenDN.Margin = new System.Windows.Forms.Padding(1);
            this.edtTenDN.Name = "edtTenDN";
            this.edtTenDN.Size = new System.Drawing.Size(277, 27);
            this.edtTenDN.TabIndex = 37;
            // 
            // cbbLoaiTK
            // 
            this.cbbLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiTK.FormattingEnabled = true;
            this.cbbLoaiTK.Location = new System.Drawing.Point(391, 100);
            this.cbbLoaiTK.Margin = new System.Windows.Forms.Padding(1);
            this.cbbLoaiTK.Name = "cbbLoaiTK";
            this.cbbLoaiTK.Size = new System.Drawing.Size(277, 28);
            this.cbbLoaiTK.TabIndex = 36;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(252, 300);
            this.lbPass.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(75, 20);
            this.lbPass.TabIndex = 35;
            this.lbPass.Text = "Mật khẩu";
            // 
            // lbLoginName
            // 
            this.lbLoginName.AutoSize = true;
            this.lbLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginName.Location = new System.Drawing.Point(252, 168);
            this.lbLoginName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbLoginName.Name = "lbLoginName";
            this.lbLoginName.Size = new System.Drawing.Size(116, 20);
            this.lbLoginName.TabIndex = 34;
            this.lbLoginName.Text = "Tên đăng nhập";
            // 
            // lbLoaiTaiKhoan
            // 
            this.lbLoaiTaiKhoan.AutoSize = true;
            this.lbLoaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiTaiKhoan.Location = new System.Drawing.Point(252, 103);
            this.lbLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbLoaiTaiKhoan.Name = "lbLoaiTaiKhoan";
            this.lbLoaiTaiKhoan.Size = new System.Drawing.Size(108, 20);
            this.lbLoaiTaiKhoan.TabIndex = 33;
            this.lbLoaiTaiKhoan.Text = "Loại tài khoản";
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(391, 47);
            this.cbbCoSo.Margin = new System.Windows.Forms.Padding(1);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(277, 28);
            this.cbbCoSo.TabIndex = 48;
            this.cbbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged_1);
            // 
            // cbbMaGV
            // 
            this.cbbMaGV.DataSource = this.bds_SP_MAGV_CHUA_TAO_TK;
            this.cbbMaGV.DisplayMember = "TEN";
            this.cbbMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaGV.FormattingEnabled = true;
            this.cbbMaGV.Location = new System.Drawing.Point(391, 233);
            this.cbbMaGV.Margin = new System.Windows.Forms.Padding(1);
            this.cbbMaGV.Name = "cbbMaGV";
            this.cbbMaGV.Size = new System.Drawing.Size(277, 28);
            this.cbbMaGV.TabIndex = 50;
            this.cbbMaGV.ValueMember = "MAGV";
            this.cbbMaGV.SelectedIndexChanged += new System.EventHandler(this.cbbMaGV_SelectedIndexChanged);
            this.cbbMaGV.SelectionChangeCommitted += new System.EventHandler(this.cbbMaGV_SelectionChangeCommitted);
            // 
            // bds_SP_MAGV_CHUA_TAO_TK
            // 
            this.bds_SP_MAGV_CHUA_TAO_TK.DataMember = "SP_MAGV_CHUA_TAO_TK";
            this.bds_SP_MAGV_CHUA_TAO_TK.DataSource = this.tN_CSDLPTDataSet;
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(252, 236);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(75, 20);
            this.lbUserName.TabIndex = 49;
            this.lbUserName.Text = "Giáo viên";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(216, 94);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(216, 166);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(216, 296);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(216, 233);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // edtMAGV
            // 
            this.edtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_SP_MAGV_CHUA_TAO_TK, "MAGV", true));
            this.edtMAGV.Location = new System.Drawing.Point(715, 241);
            this.edtMAGV.Name = "edtMAGV";
            this.edtMAGV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.edtMAGV.Properties.Appearance.Options.UseFont = true;
            this.edtMAGV.Properties.ReadOnly = true;
            this.edtMAGV.Size = new System.Drawing.Size(100, 24);
            this.edtMAGV.TabIndex = 51;
            // 
            // bds_COSO
            // 
            this.bds_COSO.DataMember = "COSO";
            this.bds_COSO.DataSource = this.tN_CSDLPTDataSet;
            // 
            // ta_COSO
            // 
            this.ta_COSO.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = this.ta_COSO;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ta_SP_MAGV_CHUA_TAO_TK
            // 
            this.ta_SP_MAGV_CHUA_TAO_TK.ClearBeforeFill = true;
            // 
            // FrmNewAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 501);
            this.Controls.Add(this.edtMAGV);
            this.Controls.Add(this.cbbMaGV);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.cbbCoSo);
            this.Controls.Add(this.edtPass);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.edtTenDN);
            this.Controls.Add(this.cbbLoaiTK);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbLoginName);
            this.Controls.Add(this.lbLoaiTaiKhoan);
            this.Name = "FrmNewAcc";
            this.Text = "FrmNewAcc";
            this.Load += new System.EventHandler(this.FrmNewAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bds_SP_MAGV_CHUA_TAO_TK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_COSO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtPass;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox edtTenDN;
        private System.Windows.Forms.ComboBox cbbLoaiTK;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbLoginName;
        private System.Windows.Forms.Label lbLoaiTaiKhoan;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource bds_COSO;
        private TN_CSDLPTDataSetTableAdapters.COSOTableAdapter ta_COSO;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.ComboBox cbbMaGV;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.BindingSource bds_SP_MAGV_CHUA_TAO_TK;
        private TN_CSDLPTDataSetTableAdapters.SP_MAGV_CHUA_TAO_TKTableAdapter ta_SP_MAGV_CHUA_TAO_TK;
        private DevExpress.XtraEditors.TextEdit edtMAGV;
    }
}