namespace Project3.Transaksi.Pengiriman
{
    partial class Pengiriman
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvPengiriman = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formPengiriman = new Project3.Transaksi.Pengiriman.FormPengiriman();
            this.pnlPengiriman = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlOverlayDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDetailTransaksi = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.line = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNamaPenerima = new System.Windows.Forms.Label();
            this.lblNamaKaryawan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTglDikirim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengiriman)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlPengiriman.SuspendLayout();
            this.pnlOverlayDetail.SuspendLayout();
            this.pnlDetailTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // cbstatus
            // 
            this.cbstatus.BackColor = System.Drawing.Color.Transparent;
            this.cbstatus.BorderRadius = 15;
            this.cbstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbstatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbstatus.ItemHeight = 30;
            this.cbstatus.Items.AddRange(new object[] {
            "Belum Dikirim",
            "Sedang Dikirim",
            "Selesai Dikirim"});
            this.cbstatus.Location = new System.Drawing.Point(877, 108);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(234, 36);
            this.cbstatus.TabIndex = 1;
            this.cbstatus.SelectedIndexChanged += new System.EventHandler(this.cbstatus_SelectedIndexChanged);
            // 
            // dgvPengiriman
            // 
            this.dgvPengiriman.AllowUserToAddRows = false;
            this.dgvPengiriman.AllowUserToDeleteRows = false;
            this.dgvPengiriman.AllowUserToResizeColumns = false;
            this.dgvPengiriman.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvPengiriman.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPengiriman.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPengiriman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPengiriman.ColumnHeadersHeight = 41;
            this.dgvPengiriman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPengiriman.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPengiriman.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvPengiriman.Location = new System.Drawing.Point(22, 198);
            this.dgvPengiriman.Name = "dgvPengiriman";
            this.dgvPengiriman.ReadOnly = true;
            this.dgvPengiriman.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvPengiriman.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPengiriman.RowTemplate.Height = 40;
            this.dgvPengiriman.Size = new System.Drawing.Size(1089, 443);
            this.dgvPengiriman.TabIndex = 9;
            this.dgvPengiriman.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPengiriman.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPengiriman.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPengiriman.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPengiriman.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPengiriman.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.dgvPengiriman.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvPengiriman.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPengiriman.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPengiriman.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPengiriman.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPengiriman.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPengiriman.ThemeStyle.HeaderStyle.Height = 41;
            this.dgvPengiriman.ThemeStyle.ReadOnly = true;
            this.dgvPengiriman.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPengiriman.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPengiriman.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPengiriman.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPengiriman.ThemeStyle.RowsStyle.Height = 40;
            this.dgvPengiriman.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPengiriman.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPengiriman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPengiriman_CellContentClick);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.lblPageInfo.Location = new System.Drawing.Point(553, 697);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(28, 32);
            this.lblPageInfo.TabIndex = 14;
            this.lblPageInfo.Text = "0";
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnNext.BorderThickness = 2;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnNext.Location = new System.Drawing.Point(594, 692);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 45);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnPrev.BorderThickness = 2;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnPrev.Location = new System.Drawing.Point(498, 692);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 45);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.formPengiriman);
            this.panel1.Location = new System.Drawing.Point(1144, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 956);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // formPengiriman
            // 
            this.formPengiriman.AutoScroll = true;
            this.formPengiriman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.formPengiriman.Location = new System.Drawing.Point(1, 0);
            this.formPengiriman.Name = "formPengiriman";
            this.formPengiriman.Size = new System.Drawing.Size(449, 1393);
            this.formPengiriman.TabIndex = 0;
            // 
            // pnlPengiriman
            // 
            this.pnlPengiriman.Controls.Add(this.panel1);
            this.pnlPengiriman.Controls.Add(this.lblPageInfo);
            this.pnlPengiriman.Controls.Add(this.btnNext);
            this.pnlPengiriman.Controls.Add(this.btnPrev);
            this.pnlPengiriman.Controls.Add(this.dgvPengiriman);
            this.pnlPengiriman.Controls.Add(this.cbstatus);
            this.pnlPengiriman.Location = new System.Drawing.Point(0, 0);
            this.pnlPengiriman.Name = "pnlPengiriman";
            this.pnlPengiriman.Size = new System.Drawing.Size(1592, 861);
            this.pnlPengiriman.TabIndex = 16;
            // 
            // pnlOverlayDetail
            // 
            this.pnlOverlayDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnlOverlayDetail.Controls.Add(this.pnlDetailTransaksi);
            this.pnlOverlayDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlOverlayDetail.Name = "pnlOverlayDetail";
            this.pnlOverlayDetail.Size = new System.Drawing.Size(1592, 861);
            this.pnlOverlayDetail.TabIndex = 17;
            this.pnlOverlayDetail.UseTransparentBackground = true;
            this.pnlOverlayDetail.Visible = false;
            this.pnlOverlayDetail.Click += new System.EventHandler(this.pnlOverlayDetail_Click);
            // 
            // pnlDetailTransaksi
            // 
            this.pnlDetailTransaksi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.pnlDetailTransaksi.Controls.Add(this.lblTglDikirim);
            this.pnlDetailTransaksi.Controls.Add(this.label7);
            this.pnlDetailTransaksi.Controls.Add(this.label8);
            this.pnlDetailTransaksi.Controls.Add(this.label5);
            this.pnlDetailTransaksi.Controls.Add(this.label6);
            this.pnlDetailTransaksi.Controls.Add(this.lblAlamat);
            this.pnlDetailTransaksi.Controls.Add(this.dgvDetail);
            this.pnlDetailTransaksi.Controls.Add(this.guna2Panel1);
            this.pnlDetailTransaksi.Controls.Add(this.line);
            this.pnlDetailTransaksi.Controls.Add(this.lblNamaPenerima);
            this.pnlDetailTransaksi.Controls.Add(this.lblNamaKaryawan);
            this.pnlDetailTransaksi.Controls.Add(this.label11);
            this.pnlDetailTransaksi.Controls.Add(this.label10);
            this.pnlDetailTransaksi.Controls.Add(this.label9);
            this.pnlDetailTransaksi.Controls.Add(this.label4);
            this.pnlDetailTransaksi.Controls.Add(this.label3);
            this.pnlDetailTransaksi.Controls.Add(this.label2);
            this.pnlDetailTransaksi.Controls.Add(this.label1);
            this.pnlDetailTransaksi.FillColor = System.Drawing.Color.White;
            this.pnlDetailTransaksi.ForeColor = System.Drawing.Color.Transparent;
            this.pnlDetailTransaksi.Location = new System.Drawing.Point(380, 14);
            this.pnlDetailTransaksi.Name = "pnlDetailTransaksi";
            this.pnlDetailTransaksi.Size = new System.Drawing.Size(833, 832);
            this.pnlDetailTransaksi.TabIndex = 0;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeColumns = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvDetail.ColumnHeadersHeight = 41;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvDetail.Location = new System.Drawing.Point(59, 528);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvDetail.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvDetail.RowTemplate.Height = 40;
            this.dgvDetail.Size = new System.Drawing.Size(718, 286);
            this.dgvDetail.TabIndex = 23;
            this.dgvDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetail.ThemeStyle.HeaderStyle.Height = 41;
            this.dgvDetail.ThemeStyle.ReadOnly = true;
            this.dgvDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetail.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.guna2Panel1.Location = new System.Drawing.Point(62, 673);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(718, 2);
            this.guna2Panel1.TabIndex = 22;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.line.Location = new System.Drawing.Point(57, 116);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(718, 2);
            this.line.TabIndex = 21;
            // 
            // lblNamaPenerima
            // 
            this.lblNamaPenerima.AutoSize = true;
            this.lblNamaPenerima.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPenerima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.lblNamaPenerima.Location = new System.Drawing.Point(346, 219);
            this.lblNamaPenerima.Name = "lblNamaPenerima";
            this.lblNamaPenerima.Size = new System.Drawing.Size(195, 32);
            this.lblNamaPenerima.TabIndex = 16;
            this.lblNamaPenerima.Text = "Nama Penerima";
            // 
            // lblNamaKaryawan
            // 
            this.lblNamaKaryawan.AutoSize = true;
            this.lblNamaKaryawan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaKaryawan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.lblNamaKaryawan.Location = new System.Drawing.Point(346, 146);
            this.lblNamaKaryawan.Name = "lblNamaKaryawan";
            this.lblNamaKaryawan.Size = new System.Drawing.Size(201, 32);
            this.lblNamaKaryawan.TabIndex = 15;
            this.lblNamaKaryawan.Text = "Nama Karyawan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label11.Location = new System.Drawing.Point(297, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label10.Location = new System.Drawing.Point(297, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label9.Location = new System.Drawing.Point(297, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label4.Location = new System.Drawing.Point(56, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat Tujuan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label3.Location = new System.Drawing.Point(56, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Penerima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(56, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kurir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(277, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Transaksi";
            // 
            // lblAlamat
            // 
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.lblAlamat.Location = new System.Drawing.Point(352, 290);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(428, 78);
            this.lblAlamat.TabIndex = 24;
            this.lblAlamat.Text = "Alamat Tujuan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label5.Location = new System.Drawing.Point(297, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label6.Location = new System.Drawing.Point(56, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tanggal Dikirim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label7.Location = new System.Drawing.Point(297, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 32);
            this.label7.TabIndex = 28;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label8.Location = new System.Drawing.Point(56, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 32);
            this.label8.TabIndex = 27;
            this.label8.Text = "Detail Pengiriman";
            // 
            // lblTglDikirim
            // 
            this.lblTglDikirim.AutoSize = true;
            this.lblTglDikirim.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTglDikirim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.lblTglDikirim.Location = new System.Drawing.Point(352, 399);
            this.lblTglDikirim.Name = "lblTglDikirim";
            this.lblTglDikirim.Size = new System.Drawing.Size(162, 32);
            this.lblTglDikirim.TabIndex = 29;
            this.lblTglDikirim.Text = "dd-MM-yyyy";
            // 
            // Pengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1592, 861);
            this.Controls.Add(this.pnlPengiriman);
            this.Controls.Add(this.pnlOverlayDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pengiriman";
            this.Text = "Pengiriman";
            this.Load += new System.EventHandler(this.Pengiriman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengiriman)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlPengiriman.ResumeLayout(false);
            this.pnlPengiriman.PerformLayout();
            this.pnlOverlayDetail.ResumeLayout(false);
            this.pnlDetailTransaksi.ResumeLayout(false);
            this.pnlDetailTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbstatus;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPengiriman;
        private System.Windows.Forms.Label lblPageInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private System.Windows.Forms.Panel panel1;
        private FormPengiriman formPengiriman;
        private Guna.UI2.WinForms.Guna2Panel pnlPengiriman;
        private Guna.UI2.WinForms.Guna2Panel pnlOverlayDetail;
        private Guna.UI2.WinForms.Guna2Panel pnlDetailTransaksi;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetail;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel line;
        private System.Windows.Forms.Label lblNamaPenerima;
        private System.Windows.Forms.Label lblNamaKaryawan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTglDikirim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAlamat;
    }
}