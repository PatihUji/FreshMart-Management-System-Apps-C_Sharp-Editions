namespace Project3.Dashboard
{
    partial class DashboardQC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.tglakhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tglmulai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tbjumlahstok = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartStok = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label4.Location = new System.Drawing.Point(343, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 30);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tanggal Selesai";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label3.Location = new System.Drawing.Point(130, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 30);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tanggal Mulai";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 15;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnClear.Location = new System.Drawing.Point(537, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(168, 45);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Bersihkan";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BorderRadius = 15;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnFilter.Location = new System.Drawing.Point(537, 274);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(168, 45);
            this.btnFilter.TabIndex = 54;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // tglakhir
            // 
            this.tglakhir.BorderRadius = 15;
            this.tglakhir.Checked = true;
            this.tglakhir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglakhir.Location = new System.Drawing.Point(322, 310);
            this.tglakhir.MaxDate = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.tglakhir.MinDate = new System.DateTime(2020, 7, 21, 0, 0, 0, 0);
            this.tglakhir.Name = "tglakhir";
            this.tglakhir.Size = new System.Drawing.Size(200, 54);
            this.tglakhir.TabIndex = 53;
            this.tglakhir.Value = new System.DateTime(2025, 7, 21, 0, 0, 0, 0);
            this.tglakhir.ValueChanged += new System.EventHandler(this.tglakhir_ValueChanged);
            // 
            // tglmulai
            // 
            this.tglmulai.BorderRadius = 15;
            this.tglmulai.Checked = true;
            this.tglmulai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tglmulai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglmulai.Location = new System.Drawing.Point(107, 310);
            this.tglmulai.MaxDate = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.tglmulai.MinDate = new System.DateTime(2020, 7, 21, 0, 0, 0, 0);
            this.tglmulai.Name = "tglmulai";
            this.tglmulai.Size = new System.Drawing.Size(200, 54);
            this.tglmulai.TabIndex = 52;
            this.tglmulai.Value = new System.DateTime(2025, 7, 21, 0, 0, 0, 0);
            this.tglmulai.ValueChanged += new System.EventHandler(this.tglmulai_ValueChanged);
            // 
            // tbjumlahstok
            // 
            this.tbjumlahstok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbjumlahstok.BorderRadius = 15;
            this.tbjumlahstok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbjumlahstok.DefaultText = "";
            this.tbjumlahstok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbjumlahstok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbjumlahstok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbjumlahstok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbjumlahstok.Enabled = false;
            this.tbjumlahstok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.tbjumlahstok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbjumlahstok.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbjumlahstok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.tbjumlahstok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbjumlahstok.Location = new System.Drawing.Point(174, 505);
            this.tbjumlahstok.Margin = new System.Windows.Forms.Padding(19, 21, 19, 21);
            this.tbjumlahstok.MaxLength = 50;
            this.tbjumlahstok.Name = "tbjumlahstok";
            this.tbjumlahstok.PlaceholderText = "";
            this.tbjumlahstok.SelectedText = "";
            this.tbjumlahstok.Size = new System.Drawing.Size(516, 126);
            this.tbjumlahstok.TabIndex = 60;
            this.tbjumlahstok.TextChanged += new System.EventHandler(this.tbjumlahstok_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(178, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 50);
            this.label2.TabIndex = 59;
            this.label2.Text = "Jumlah Stok Keluar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chartStok
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStok.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStok.Legends.Add(legend1);
            this.chartStok.Location = new System.Drawing.Point(810, 154);
            this.chartStok.Name = "chartStok";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStok.Series.Add(series1);
            this.chartStok.Size = new System.Drawing.Size(675, 545);
            this.chartStok.TabIndex = 62;
            this.chartStok.Text = "chart1";
            this.chartStok.Click += new System.EventHandler(this.chartbatang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.pictureBox1.Image = global::Project3.Properties.Resources.delete_icon;
            this.pictureBox1.Location = new System.Drawing.Point(517, 525);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DashboardQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1592, 861);
            this.Controls.Add(this.chartStok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbjumlahstok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.tglakhir);
            this.Controls.Add(this.tglmulai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardQC";
            this.Text = "DashboardQC";
            this.Load += new System.EventHandler(this.DashboardQC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker tglakhir;
        private Guna.UI2.WinForms.Guna2DateTimePicker tglmulai;
        private Guna.UI2.WinForms.Guna2TextBox tbjumlahstok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStok;
    }
}