
namespace TN_CSDLPT
{
    partial class FrmKhoa
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
            System.Windows.Forms.Label tENCSLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoa));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnPhuchoiGVDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSGVDK = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbCOSO = new System.Windows.Forms.ComboBox();
            this.bds_COSO = new System.Windows.Forms.BindingSource(this.components);
            this.tN_CSDLPTDataSet = new TN_CSDLPT.TN_CSDLPTDataSet();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.edtMACS = new DevExpress.XtraEditors.TextEdit();
            this.bds_KHOA = new System.Windows.Forms.BindingSource(this.components);
            this.edtTENKHOA = new DevExpress.XtraEditors.TextEdit();
            this.edtMAKHOA = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.KHOA_GridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta_KHOA = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.ta_COSO = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.COSOTableAdapter();
            tENCSLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_COSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMACS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_KHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTENKHOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMAKHOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KHOA_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCSLabel
            // 
            tENCSLabel.AutoSize = true;
            tENCSLabel.Location = new System.Drawing.Point(361, 40);
            tENCSLabel.Name = "tENCSLabel";
            tENCSLabel.Size = new System.Drawing.Size(43, 13);
            tENCSLabel.TabIndex = 0;
            tENCSLabel.Text = "TENCS:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(40, 29);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(39, 13);
            mAKHLabel.TabIndex = 5;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(373, 29);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(43, 13);
            tENKHLabel.TabIndex = 6;
            tENKHLabel.Text = "TENKH:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(720, 29);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(39, 13);
            mACSLabel.TabIndex = 7;
            mACSLabel.Text = "MACS:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnSua,
            this.btnPhuchoiGVDK,
            this.btnTaiLai,
            this.btnInDSGVDK,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(270, 162);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 3;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 1;
            this.btnGhi.ImageOptions.Image = global::TN_CSDLPT.Properties.Resources.apply_32x32;
            this.btnGhi.ImageOptions.LargeImage = global::TN_CSDLPT.Properties.Resources.apply_32x32;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Caption = "Tải lại";
            this.btnTaiLai.Id = 5;
            this.btnTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.Image")));
            this.btnTaiLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.LargeImage")));
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLai_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlTop.Size = new System.Drawing.Size(1198, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 519);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlBottom.Size = new System.Drawing.Size(1198, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 479);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1198, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 479);
            // 
            // btnPhuchoiGVDK
            // 
            this.btnPhuchoiGVDK.Caption = "Phục hồi";
            this.btnPhuchoiGVDK.Id = 4;
            this.btnPhuchoiGVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhuchoiGVDK.ImageOptions.Image")));
            this.btnPhuchoiGVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhuchoiGVDK.ImageOptions.LargeImage")));
            this.btnPhuchoiGVDK.Name = "btnPhuchoiGVDK";
            // 
            // btnInDSGVDK
            // 
            this.btnInDSGVDK.Caption = "In danh sách";
            this.btnInDSGVDK.Id = 6;
            this.btnInDSGVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSGVDK.ImageOptions.Image")));
            this.btnInDSGVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDSGVDK.ImageOptions.LargeImage")));
            this.btnInDSGVDK.Name = "btnInDSGVDK";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(tENCSLabel);
            this.groupControl1.Controls.Add(this.cbbCOSO);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 40);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1198, 100);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // cbbCOSO
            // 
            this.cbbCOSO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_COSO, "TENCS", true));
            this.cbbCOSO.FormattingEnabled = true;
            this.cbbCOSO.Location = new System.Drawing.Point(410, 37);
            this.cbbCOSO.Name = "cbbCOSO";
            this.cbbCOSO.Size = new System.Drawing.Size(245, 21);
            this.cbbCOSO.TabIndex = 1;
            this.cbbCOSO.SelectedIndexChanged += new System.EventHandler(this.cbbCOSO_SelectedIndexChanged);
            // 
            // bds_COSO
            // 
            this.bds_COSO.DataMember = "COSO";
            this.bds_COSO.DataSource = this.tN_CSDLPTDataSet;
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(mACSLabel);
            this.groupControl2.Controls.Add(this.edtMACS);
            this.groupControl2.Controls.Add(tENKHLabel);
            this.groupControl2.Controls.Add(this.edtTENKHOA);
            this.groupControl2.Controls.Add(mAKHLabel);
            this.groupControl2.Controls.Add(this.edtMAKHOA);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 419);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1198, 100);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "groupControl2";
            // 
            // edtMACS
            // 
            this.edtMACS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_KHOA, "MACS", true));
            this.edtMACS.Location = new System.Drawing.Point(765, 26);
            this.edtMACS.MenuManager = this.barManager1;
            this.edtMACS.Name = "edtMACS";
            this.edtMACS.Size = new System.Drawing.Size(100, 20);
            this.edtMACS.TabIndex = 8;
            // 
            // bds_KHOA
            // 
            this.bds_KHOA.DataMember = "KHOA";
            this.bds_KHOA.DataSource = this.tN_CSDLPTDataSet;
            // 
            // edtTENKHOA
            // 
            this.edtTENKHOA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_KHOA, "TENKH", true));
            this.edtTENKHOA.Location = new System.Drawing.Point(422, 26);
            this.edtTENKHOA.MenuManager = this.barManager1;
            this.edtTENKHOA.Name = "edtTENKHOA";
            this.edtTENKHOA.Size = new System.Drawing.Size(189, 20);
            this.edtTENKHOA.TabIndex = 7;
            // 
            // edtMAKHOA
            // 
            this.edtMAKHOA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_KHOA, "MAKH", true));
            this.edtMAKHOA.Location = new System.Drawing.Point(85, 26);
            this.edtMAKHOA.MenuManager = this.barManager1;
            this.edtMAKHOA.Name = "edtMAKHOA";
            this.edtMAKHOA.Size = new System.Drawing.Size(168, 20);
            this.edtMAKHOA.TabIndex = 6;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.KHOA_GridView);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 140);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(1198, 279);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "groupControl3";
            // 
            // KHOA_GridView
            // 
            this.KHOA_GridView.AutoGenerateColumns = false;
            this.KHOA_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KHOA_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KHOA_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.KHOA_GridView.DataSource = this.bds_KHOA;
            this.KHOA_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KHOA_GridView.Location = new System.Drawing.Point(2, 2);
            this.KHOA_GridView.Name = "KHOA_GridView";
            this.KHOA_GridView.Size = new System.Drawing.Size(1194, 275);
            this.KHOA_GridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAKH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENKH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MACS";
            this.dataGridViewTextBoxColumn3.HeaderText = "MACS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // ta_KHOA
            // 
            this.ta_KHOA.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOATableAdapter = this.ta_KHOA;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ta_COSO
            // 
            this.ta_COSO.ClearBeforeFill = true;
            // 
            // FrmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 519);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmKhoa";
            this.Text = "FrmKhoa";
            this.Load += new System.EventHandler(this.FrmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_COSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMACS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_KHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTENKHOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMAKHOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KHOA_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoiGVDK;
        private DevExpress.XtraBars.BarButtonItem btnInDSGVDK;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter ta_KHOA;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPTDataSetTableAdapters.COSOTableAdapter ta_COSO;
        private System.Windows.Forms.BindingSource bds_COSO;
        private System.Windows.Forms.ComboBox cbbCOSO;
        private System.Windows.Forms.DataGridView KHOA_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource bds_KHOA;
        private DevExpress.XtraEditors.TextEdit edtMAKHOA;
        private DevExpress.XtraEditors.TextEdit edtTENKHOA;
        private DevExpress.XtraEditors.TextEdit edtMACS;
    }
}