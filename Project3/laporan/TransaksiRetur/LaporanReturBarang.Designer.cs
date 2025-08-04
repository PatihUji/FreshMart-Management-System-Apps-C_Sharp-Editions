namespace Project3.Laporan.TransaksiRetur
{
    partial class LaporanReturBarang
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
            this.splaporanreturpembeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theFreshChoice = new Project3.Database.TheFreshChoice();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_laporan_retur_pembeliTableAdapter = new Project3.Database.TheFreshChoiceTableAdapters.sp_laporan_retur_pembeliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splaporanreturpembeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theFreshChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // splaporanreturpembeliBindingSource
            // 
            this.splaporanreturpembeliBindingSource.DataMember = "sp_laporan_retur_pembeli";
            this.splaporanreturpembeliBindingSource.DataSource = this.theFreshChoice;
            // 
            // theFreshChoice
            // 
            this.theFreshChoice.DataSetName = "TheFreshChoice";
            this.theFreshChoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.guna2ImageButton1.TabIndex = 6;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsReturBarang";
            reportDataSource1.Value = this.splaporanreturpembeliBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project3.laporan.TransaksiRetur.ReportReturBarang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(125, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 942);
            this.reportViewer1.TabIndex = 5;
            // 
            // sp_laporan_retur_pembeliTableAdapter
            // 
            this.sp_laporan_retur_pembeliTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanReturBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 1080);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaporanReturBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanReturBarang";
            this.Load += new System.EventHandler(this.LaporanReturBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splaporanreturpembeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theFreshChoice)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource splaporanreturpembeliBindingSource;
        private Database.TheFreshChoice theFreshChoice;
        private Database.TheFreshChoiceTableAdapters.sp_laporan_retur_pembeliTableAdapter sp_laporan_retur_pembeliTableAdapter;

        #endregion
        //private Database.TheFreshChoiceTableAdapters.sp_getList_retur_pembeliTableAdapter sp_getList_retur_pembeliTableAdapter;
    }
}