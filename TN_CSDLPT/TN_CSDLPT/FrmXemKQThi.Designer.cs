
namespace TN_CSDLPT
{
    partial class FrmXemKQThi
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label lANLabel;
            this.btnInDSBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatBDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnReFresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbLAN = new System.Windows.Forms.ComboBox();
            this.bds_SP_LAN_SV_THI = new System.Windows.Forms.BindingSource(this.components);
            this.tN_CSDLPTDataSet = new TN_CSDLPT.TN_CSDLPTDataSet();
            this.cbbMH = new System.Windows.Forms.ComboBox();
            this.bds_SP_MH_SV_THI = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bds_DETAIL_BAITHI = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.ta_SP_MH_SV_THI = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.SP_MH_SV_THITableAdapter();
            this.ta_SP_LAN_SV_THI = new TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.SP_LAN_SV_THITableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SP_LAN_SV_THI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SP_MH_SV_THI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DETAIL_BAITHI)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(37, 20);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(43, 13);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Tên MH";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(313, 20);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(30, 13);
            lANLabel.TabIndex = 2;
            lANLabel.Text = "LAN:";
            // 
            // btnInDSBD
            // 
            this.btnInDSBD.Caption = "In bài thi";
            this.btnInDSBD.Id = 0;
            this.btnInDSBD.Name = "btnInDSBD";
            // 
            // btnThoatBDiem
            // 
            this.btnThoatBDiem.Caption = "Thoát";
            this.btnThoatBDiem.Id = 1;
            this.btnThoatBDiem.Name = "btnThoatBDiem";
            // 
            // btnReFresh
            // 
            this.btnReFresh.Caption = "Tải lại";
            this.btnReFresh.Id = 2;
            this.btnReFresh.Name = "btnReFresh";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1047, 0);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 461);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbLAN);
            this.groupControl1.Controls.Add(this.cbbMH);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(lANLabel);
            this.groupControl1.Controls.Add(mAMHLabel);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1047, 73);
            this.groupControl1.TabIndex = 8;
            // 
            // cbbLAN
            // 
            this.cbbLAN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_SP_LAN_SV_THI, "LAN", true));
            this.cbbLAN.DataSource = this.bds_SP_LAN_SV_THI;
            this.cbbLAN.DisplayMember = "LAN";
            this.cbbLAN.FormattingEnabled = true;
            this.cbbLAN.Location = new System.Drawing.Point(358, 17);
            this.cbbLAN.Name = "cbbLAN";
            this.cbbLAN.Size = new System.Drawing.Size(121, 21);
            this.cbbLAN.TabIndex = 6;
            this.cbbLAN.ValueMember = "LAN";
            this.cbbLAN.SelectionChangeCommitted += new System.EventHandler(this.cbbLAN_SelectionChangeCommitted);
            // 
            // bds_SP_LAN_SV_THI
            // 
            this.bds_SP_LAN_SV_THI.DataMember = "SP_LAN_SV_THI";
            this.bds_SP_LAN_SV_THI.DataSource = this.tN_CSDLPTDataSet;
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbMH
            // 
            this.cbbMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_SP_MH_SV_THI, "TENMH", true));
            this.cbbMH.DataSource = this.bds_SP_MH_SV_THI;
            this.cbbMH.DisplayMember = "TENMH";
            this.cbbMH.FormattingEnabled = true;
            this.cbbMH.Location = new System.Drawing.Point(86, 15);
            this.cbbMH.Name = "cbbMH";
            this.cbbMH.Size = new System.Drawing.Size(162, 21);
            this.cbbMH.TabIndex = 5;
            this.cbbMH.ValueMember = "MAMH";
            this.cbbMH.SelectionChangeCommitted += new System.EventHandler(this.cbbMH_SelectionChangeCommitted);
            // 
            // bds_SP_MH_SV_THI
            // 
            this.bds_SP_MH_SV_THI.DataMember = "SP_MH_SV_THI";
            this.bds_SP_MH_SV_THI.DataSource = this.tN_CSDLPTDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 73);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1047, 388);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "groupControl2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ta_SP_MH_SV_THI
            // 
            this.ta_SP_MH_SV_THI.ClearBeforeFill = true;
            // 
            // ta_SP_LAN_SV_THI
            // 
            this.ta_SP_LAN_SV_THI.ClearBeforeFill = true;
            // 
            // FrmXemKQThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 461);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlRight);
            this.Name = "FrmXemKQThi";
            this.Text = "XemKQThi";
            this.Load += new System.EventHandler(this.FrmXemKQThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SP_LAN_SV_THI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SP_MH_SV_THI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DETAIL_BAITHI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem btnThoatBDiem;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnInDSBD;
        private DevExpress.XtraBars.BarButtonItem btnReFresh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bds_SP_MH_SV_THI;
        private TN_CSDLPTDataSetTableAdapters.SP_MH_SV_THITableAdapter ta_SP_MH_SV_THI;
        private System.Windows.Forms.ComboBox cbbMH;
        private System.Windows.Forms.BindingSource bds_SP_LAN_SV_THI;
        private TN_CSDLPTDataSetTableAdapters.SP_LAN_SV_THITableAdapter ta_SP_LAN_SV_THI;
        private System.Windows.Forms.ComboBox cbbLAN;
        private System.Windows.Forms.BindingSource bds_DETAIL_BAITHI;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}