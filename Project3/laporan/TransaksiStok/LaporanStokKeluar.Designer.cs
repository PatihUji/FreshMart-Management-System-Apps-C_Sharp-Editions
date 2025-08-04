namespace Project3.Laporan.TransaksiStok
{
    partial class LaporanStokKeluar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.theFreshChoice = new Project3.Database.TheFreshChoice();
            this.splaporanstokkeluarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_laporan_stok_keluarTableAdapter = new Project3.Database.TheFreshChoiceTableAdapters.sp_laporan_stok_keluarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.theFreshChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splaporanstokkeluarBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.guna2ImageButton1.TabIndex = 8;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "dsStokKeluar";
            reportDataSource3.Value = this.splaporanstokkeluarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project3.laporan.TransaksiStok.ReportStokKeluar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(125, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 942);
            this.reportViewer1.TabIndex = 7;
            // 
            // theFreshChoice
            // 
            this.theFreshChoice.DataSetName = "TheFreshChoice";
            this.theFreshChoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splaporanstokkeluarBindingSource
            // 
            this.splaporanstokkeluarBindingSource.DataMember = "sp_laporan_stok_keluar";
            this.splaporanstokkeluarBindingSource.DataSource = this.theFreshChoice;
            // 
            // sp_laporan_stok_keluarTableAdapter
            // 
            this.sp_laporan_stok_keluarTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanStokKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1013, 1080);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaporanStokKeluar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanStokKeluar";
            this.Load += new System.EventHandler(this.LaporanStokKeluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theFreshChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splaporanstokkeluarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource splaporanstokkeluarBindingSource;
        private Database.TheFreshChoice theFreshChoice;
        private Database.TheFreshChoiceTableAdapters.sp_laporan_stok_keluarTableAdapter sp_laporan_stok_keluarTableAdapter;

        #endregion
        //private Database.TheFreshChoiceTableAdapters.sp_getList_stok_keluarTableAdapter sp_getList_stok_keluarTableAdapter;
    }
}