namespace Project3.Laporan.TransaksiPenjualan
{
    partial class LaporanPenjualan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.splaporanpenjualanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theFreshChoice = new Project3.Database.TheFreshChoice();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.sp_laporan_penjualanTableAdapter = new Project3.Database.TheFreshChoiceTableAdapters.sp_laporan_penjualanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splaporanpenjualanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theFreshChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // splaporanpenjualanBindingSource
            // 
            this.splaporanpenjualanBindingSource.DataMember = "sp_laporan_penjualan";
            this.splaporanpenjualanBindingSource.DataSource = this.theFreshChoice;
            // 
            // theFreshChoice
            // 
            this.theFreshChoice.DataSetName = "TheFreshChoice";
            this.theFreshChoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Image = global::Project3.Properties.Resources.exit_icon;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.Location = new System.Drawing.Point(1141, -65);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Size = new System.Drawing.Size(48, 44);
            this.btnExit.TabIndex = 3;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsPenjualan";
            reportDataSource1.Value = this.splaporanpenjualanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project3.laporan.TransaksiPenjualan.ReportPenjualan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(125, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 942);
            this.reportViewer1.TabIndex = 2;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::Project3.Properties.Resources.exit_icon;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(953, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(48, 44);
            this.guna2ImageButton1.TabIndex = 4;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // sp_laporan_penjualanTableAdapter
            // 
            this.sp_laporan_penjualanTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 1080);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaporanPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanPenjualan";
            this.Load += new System.EventHandler(this.LaporanPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splaporanpenjualanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theFreshChoice)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.BindingSource splaporanpenjualanBindingSource;
        private Database.TheFreshChoice theFreshChoice;
        private Database.TheFreshChoiceTableAdapters.sp_laporan_penjualanTableAdapter sp_laporan_penjualanTableAdapter;

        #endregion
        //private Database.TheFreshChoiceTableAdapters.sp_getList_penjualanTableAdapter sp_getList_penjualanTableAdapter;
    }
}