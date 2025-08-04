namespace Project3.Laporan.TransaksiPengiriman
{
    partial class LaporanPengiriman
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.splaporanpengirimanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theFreshChoice = new Project3.Database.TheFreshChoice();
            this.sp_laporan_pengirimanTableAdapter = new Project3.Database.TheFreshChoiceTableAdapters.sp_laporan_pengirimanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splaporanpengirimanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theFreshChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsPengiriman";
            reportDataSource1.Value = this.splaporanpengirimanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project3.laporan.TransaksiPengiriman.ReportPengiriman.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(125, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 942);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Image = global::Project3.Properties.Resources.exit_icon;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.Location = new System.Drawing.Point(939, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Size = new System.Drawing.Size(48, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splaporanpengirimanBindingSource
            // 
            this.splaporanpengirimanBindingSource.DataMember = "sp_laporan_pengiriman";
            this.splaporanpengirimanBindingSource.DataSource = this.theFreshChoice;
            // 
            // theFreshChoice
            // 
            this.theFreshChoice.DataSetName = "TheFreshChoice";
            this.theFreshChoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_laporan_pengirimanTableAdapter
            // 
            this.sp_laporan_pengirimanTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanPengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 1080);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaporanPengiriman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanPengiriman";
            this.Load += new System.EventHandler(this.LaporanPengiriman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splaporanpengirimanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theFreshChoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private System.Windows.Forms.BindingSource splaporanpengirimanBindingSource;
        private Database.TheFreshChoice theFreshChoice;
        private Database.TheFreshChoiceTableAdapters.sp_laporan_pengirimanTableAdapter sp_laporan_pengirimanTableAdapter;
    }
}