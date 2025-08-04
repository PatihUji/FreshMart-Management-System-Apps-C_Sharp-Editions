namespace Project3.Dashboard
{
    partial class DashboardKasir
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
            this.tbjumlahpenjualan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tglmulai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tglakhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tbjumlahpengiriman = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbjumlahpenjualan
            // 
            this.tbjumlahpenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbjumlahpenjualan.BorderRadius = 15;
            this.tbjumlahpenjualan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbjumlahpenjualan.DefaultText = "";
            this.tbjumlahpenjualan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbjumlahpenjualan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbjumlahpenjualan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbjumlahpenjualan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbjumlahpenjualan.Enabled = false;
            this.tbjumlahpenjualan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.tbjumlahpenjualan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbjumlahpenjualan.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbjumlahpenjualan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.tbjumlahpenjualan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbjumlahpenjualan.Location = new System.Drawing.Point(153, 312);
            this.tbjumlahpenjualan.Margin = new System.Windows.Forms.Padding(19, 21, 19, 21);
            this.tbjumlahpenjualan.MaxLength = 50;
            this.tbjumlahpenjualan.Name = "tbjumlahpenjualan";
            this.tbjumlahpenjualan.PlaceholderText = "";
            this.tbjumlahpenjualan.SelectedText = "";
            this.tbjumlahpenjualan.Size = new System.Drawing.Size(516, 126);
            this.tbjumlahpenjualan.TabIndex = 41;
            this.tbjumlahpenjualan.TextChanged += new System.EventHandler(this.tbnama_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(146, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 50);
            this.label2.TabIndex = 40;
            this.label2.Text = "Jumlah Penjualan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tglmulai
            // 
            this.tglmulai.BorderRadius = 15;
            this.tglmulai.Checked = true;
            this.tglmulai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tglmulai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglmulai.Location = new System.Drawing.Point(155, 132);
            this.tglmulai.MaxDate = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.tglmulai.MinDate = new System.DateTime(2020, 7, 21, 0, 0, 0, 0);
            this.tglmulai.Name = "tglmulai";
            this.tglmulai.Size = new System.Drawing.Size(200, 54);
            this.tglmulai.TabIndex = 43;
            this.tglmulai.Value = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.tglmulai.ValueChanged += new System.EventHandler(this.tbtgl_ValueChanged);
            // 
            // tglakhir
            // 
            this.tglakhir.BorderRadius = 15;
            this.tglakhir.Checked = true;
            this.tglakhir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglakhir.Location = new System.Drawing.Point(370, 132);
            this.tglakhir.MaxDate = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.tglakhir.MinDate = new System.DateTime(2020, 7, 21, 0, 0, 0, 0);
            this.tglakhir.Name = "tglakhir";
            this.tglakhir.Size = new System.Drawing.Size(200, 54);
            this.tglakhir.TabIndex = 44;
            this.tglakhir.Value = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.tglakhir.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // tbjumlahpengiriman
            // 
            this.tbjumlahpengiriman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbjumlahpengiriman.BorderRadius = 15;
            this.tbjumlahpengiriman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbjumlahpengiriman.DefaultText = "";
            this.tbjumlahpengiriman.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbjumlahpengiriman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbjumlahpengiriman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbjumlahpengiriman.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbjumlahpengiriman.Enabled = false;
            this.tbjumlahpengiriman.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.tbjumlahpengiriman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbjumlahpengiriman.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbjumlahpengiriman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.tbjumlahpengiriman.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbjumlahpengiriman.Location = new System.Drawing.Point(155, 524);
            this.tbjumlahpengiriman.Margin = new System.Windows.Forms.Padding(19, 21, 19, 21);
            this.tbjumlahpengiriman.MaxLength = 50;
            this.tbjumlahpengiriman.Name = "tbjumlahpengiriman";
            this.tbjumlahpengiriman.PlaceholderText = "";
            this.tbjumlahpengiriman.SelectedText = "";
            this.tbjumlahpengiriman.Size = new System.Drawing.Size(514, 126);
            this.tbjumlahpengiriman.TabIndex = 46;
            this.tbjumlahpengiriman.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(148, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 50);
            this.label1.TabIndex = 45;
            this.label1.Text = "Jumlah Pengiriman";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(771, 168);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(675, 545);
            this.chart1.TabIndex = 47;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
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
            this.btnFilter.Location = new System.Drawing.Point(585, 96);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(168, 45);
            this.btnFilter.TabIndex = 48;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.btnClear.Location = new System.Drawing.Point(585, 168);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(168, 45);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Bersihkan";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label3.Location = new System.Drawing.Point(178, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 30);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tanggal Mulai";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label4.Location = new System.Drawing.Point(391, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 30);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tanggal Selesai";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project3.Properties.Resources.big_cart_green_icon;
            this.pictureBox1.Location = new System.Drawing.Point(498, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project3.Properties.Resources.big_delivery_green_icon;
            this.pictureBox2.Location = new System.Drawing.Point(498, 545);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // DashboardKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1592, 861);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tbjumlahpengiriman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tglakhir);
            this.Controls.Add(this.tglmulai);
            this.Controls.Add(this.tbjumlahpenjualan);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardKasir";
            this.Text = "DashboardKasir";
            this.Load += new System.EventHandler(this.DashboardKasir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbjumlahpenjualan;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker tglmulai;
        private Guna.UI2.WinForms.Guna2DateTimePicker tglakhir;
        private Guna.UI2.WinForms.Guna2TextBox tbjumlahpengiriman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}