
namespace TN_CSDLPT
{
    partial class FrmGiaoVien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label tENCSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiaoVien));
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
            this.bds_KHOA = new System.Windows.Forms.BindingSource(this.components);
            this.tN_CSDLPTDataSet = new TN_CSDLPT.TN_CSDLPTDataSet();
            this.bds_COSO = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbbHOCVI = new System.Windows.Forms.ComboBox();
            this.bds_GIAOVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.edtTENGV = new DevExpress.XtraEditors.TextEdit();
            this.edtHOGV = new DevExpress.XtraEditors.TextEdit();
            this.edtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbbTENKHOA = new System.Windows.Forms.ComboBox();
            this.cbbCOSO = new System.Windows.Forms.ComboBox();
            this.ta_GIAOVIEN = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.ta_COSO = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.COSOTableAdapter();
            this.ta_KHOA = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.GIAOVIEN_GridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            tENCSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_KHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_COSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GIAOVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTENGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHOGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GIAOVIEN_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(101, 58);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(39, 13);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MAGV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(310, 58);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(484, 58);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Location = new System.Drawing.Point(741, 58);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(43, 13);
            hOCVILabel.TabIndex = 6;
            hOCVILabel.Text = "HOCVI:";
            // 
            // tENCSLabel
            // 
            tENCSLabel.AutoSize = true;
            tENCSLabel.Location = new System.Drawing.Point(227, 37);
            tENCSLabel.Name = "tENCSLabel";
            tENCSLabel.Size = new System.Drawing.Size(43, 13);
            tENCSLabel.TabIndex = 0;
            tENCSLabel.Text = "TENCS:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1237, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 403);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlBottom.Size = new System.Drawing.Size(1237, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 363);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1237, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 363);
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
            // bds_KHOA
            // 
            this.bds_KHOA.DataMember = "KHOA";
            this.bds_KHOA.DataSource = this.tN_CSDLPTDataSet;
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_COSO
            // 
            this.bds_COSO.DataMember = "COSO";
            this.bds_COSO.DataSource = this.tN_CSDLPTDataSet;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(hOCVILabel);
            this.groupControl2.Controls.Add(this.cbbHOCVI);
            this.groupControl2.Controls.Add(tENLabel);
            this.groupControl2.Controls.Add(this.edtTENGV);
            this.groupControl2.Controls.Add(hOLabel);
            this.groupControl2.Controls.Add(this.edtHOGV);
            this.groupControl2.Controls.Add(mAGVLabel);
            this.groupControl2.Controls.Add(this.edtMAGV);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 240);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1237, 163);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "groupControl2";
            // 
            // cbbHOCVI
            // 
            this.cbbHOCVI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_GIAOVIEN, "HOCVI", true));
            this.cbbHOCVI.FormattingEnabled = true;
            this.cbbHOCVI.Location = new System.Drawing.Point(790, 55);
            this.cbbHOCVI.Name = "cbbHOCVI";
            this.cbbHOCVI.Size = new System.Drawing.Size(161, 21);
            this.cbbHOCVI.TabIndex = 7;
            // 
            // bds_GIAOVIEN
            // 
            this.bds_GIAOVIEN.DataMember = "GIAOVIEN";
            this.bds_GIAOVIEN.DataSource = this.tN_CSDLPTDataSet;
            // 
            // edtTENGV
            // 
            this.edtTENGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GIAOVIEN, "TEN", true));
            this.edtTENGV.Location = new System.Drawing.Point(520, 55);
            this.edtTENGV.MenuManager = this.barManager1;
            this.edtTENGV.Name = "edtTENGV";
            this.edtTENGV.Size = new System.Drawing.Size(157, 20);
            this.edtTENGV.TabIndex = 5;
            // 
            // edtHOGV
            // 
            this.edtHOGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GIAOVIEN, "HO", true));
            this.edtHOGV.Location = new System.Drawing.Point(342, 55);
            this.edtHOGV.MenuManager = this.barManager1;
            this.edtHOGV.Name = "edtHOGV";
            this.edtHOGV.Size = new System.Drawing.Size(100, 20);
            this.edtHOGV.TabIndex = 3;
            // 
            // edtMAGV
            // 
            this.edtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_GIAOVIEN, "MAGV", true));
            this.edtMAGV.Location = new System.Drawing.Point(146, 55);
            this.edtMAGV.MenuManager = this.barManager1;
            this.edtMAGV.Name = "edtMAGV";
            this.edtMAGV.Size = new System.Drawing.Size(100, 20);
            this.edtMAGV.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(550, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "TEN KHOA";
            // 
            // cbbTENKHOA
            // 
            this.cbbTENKHOA.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_GIAOVIEN, "MAKH", true));
            this.cbbTENKHOA.DataSource = this.bds_KHOA;
            this.cbbTENKHOA.DisplayMember = "TENKH";
            this.cbbTENKHOA.FormattingEnabled = true;
            this.cbbTENKHOA.Location = new System.Drawing.Point(632, 34);
            this.cbbTENKHOA.Name = "cbbTENKHOA";
            this.cbbTENKHOA.Size = new System.Drawing.Size(194, 21);
            this.cbbTENKHOA.TabIndex = 2;
            this.cbbTENKHOA.ValueMember = "MAKH";
            this.cbbTENKHOA.SelectedIndexChanged += new System.EventHandler(this.cbbTENKHOA_SelectedIndexChanged);
            // 
            // cbbCOSO
            // 
            this.cbbCOSO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_COSO, "TENCS", true));
            this.cbbCOSO.FormattingEnabled = true;
            this.cbbCOSO.Location = new System.Drawing.Point(276, 34);
            this.cbbCOSO.Name = "cbbCOSO";
            this.cbbCOSO.Size = new System.Drawing.Size(183, 21);
            this.cbbCOSO.TabIndex = 1;
            this.cbbCOSO.SelectedIndexChanged += new System.EventHandler(this.cbbCOSO_SelectedIndexChanged);
            // 
            // ta_GIAOVIEN
            // 
            this.ta_GIAOVIEN.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = this.ta_COSO;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.ta_GIAOVIEN;
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
            // ta_KHOA
            // 
            this.ta_KHOA.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbbCOSO);
            this.groupControl1.Controls.Add(tENCSLabel);
            this.groupControl1.Controls.Add(this.cbbTENKHOA);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 40);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1237, 100);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.GIAOVIEN_GridView);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 140);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(1237, 100);
            this.groupControl3.TabIndex = 12;
            this.groupControl3.Text = "groupControl3";
            // 
            // GIAOVIEN_GridView
            // 
            this.GIAOVIEN_GridView.AutoGenerateColumns = false;
            this.GIAOVIEN_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GIAOVIEN_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GIAOVIEN_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.GIAOVIEN_GridView.DataSource = this.bds_GIAOVIEN;
            this.GIAOVIEN_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GIAOVIEN_GridView.Enabled = false;
            this.GIAOVIEN_GridView.Location = new System.Drawing.Point(2, 2);
            this.GIAOVIEN_GridView.Name = "GIAOVIEN_GridView";
            this.GIAOVIEN_GridView.Size = new System.Drawing.Size(1233, 96);
            this.GIAOVIEN_GridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAGV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAGV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn2.HeaderText = "HO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HOCVI";
            this.dataGridViewTextBoxColumn4.HeaderText = "HOCVI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn5.HeaderText = "MAKH";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FrmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 403);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmGiaoVien";
            this.Text = "FrmGiaoVien";
            this.Load += new System.EventHandler(this.FrmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_KHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_COSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GIAOVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTENGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHOGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GIAOVIEN_GridView)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnPhuchoiGVDK;
        private DevExpress.XtraBars.BarButtonItem btnInDSGVDK;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource bds_GIAOVIEN;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter ta_GIAOVIEN;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPTDataSetTableAdapters.COSOTableAdapter ta_COSO;
        private System.Windows.Forms.BindingSource bds_COSO;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter ta_KHOA;
        private System.Windows.Forms.BindingSource bds_KHOA;
        private System.Windows.Forms.ComboBox cbbHOCVI;
        private DevExpress.XtraEditors.TextEdit edtTENGV;
        private DevExpress.XtraEditors.TextEdit edtHOGV;
        private DevExpress.XtraEditors.TextEdit edtMAGV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbbTENKHOA;
        private System.Windows.Forms.ComboBox cbbCOSO;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView GIAOVIEN_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}