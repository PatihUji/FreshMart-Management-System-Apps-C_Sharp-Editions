namespace Project3.Master.Metode_Pembayaran
{
    partial class MetodePembayaran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMetodePmb = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSortFilter = new Guna.UI2.WinForms.Guna2Button();
            this.panelShort = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBersihkan = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodePmb)).BeginInit();
            this.panelShort.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.btnBatal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Location = new System.Drawing.Point(1079, -60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 1393);
            this.panel1.TabIndex = 22;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BorderRadius = 15;
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnSimpan.Location = new System.Drawing.Point(239, 377);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(182, 45);
            this.btnSimpan.TabIndex = 19;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BorderRadius = 15;
            this.btnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatal.FillColor = System.Drawing.Color.Red;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnBatal.Location = new System.Drawing.Point(39, 377);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(182, 45);
            this.btnBatal.TabIndex = 18;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(47, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.BorderRadius = 15;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(36, 219);
            this.txtNama.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtNama.MaxLength = 50;
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderText = "Nama";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(385, 54);
            this.txtNama.TabIndex = 14;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.lblPageInfo.Location = new System.Drawing.Point(509, 608);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(28, 32);
            this.lblPageInfo.TabIndex = 21;
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
            this.btnNext.Location = new System.Drawing.Point(550, 603);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 45);
            this.btnNext.TabIndex = 20;
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
            this.btnPrev.Location = new System.Drawing.Point(454, 603);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 45);
            this.btnPrev.TabIndex = 19;
            this.btnPrev.Text = "<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // dgvMetodePmb
            // 
            this.dgvMetodePmb.AllowUserToAddRows = false;
            this.dgvMetodePmb.AllowUserToDeleteRows = false;
            this.dgvMetodePmb.AllowUserToResizeColumns = false;
            this.dgvMetodePmb.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvMetodePmb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvMetodePmb.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodePmb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvMetodePmb.ColumnHeadersHeight = 41;
            this.dgvMetodePmb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMetodePmb.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvMetodePmb.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvMetodePmb.Location = new System.Drawing.Point(29, 132);
            this.dgvMetodePmb.Name = "dgvMetodePmb";
            this.dgvMetodePmb.ReadOnly = true;
            this.dgvMetodePmb.RowHeadersVisible = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvMetodePmb.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvMetodePmb.RowTemplate.Height = 40;
            this.dgvMetodePmb.Size = new System.Drawing.Size(1015, 443);
            this.dgvMetodePmb.TabIndex = 23;
            this.dgvMetodePmb.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMetodePmb.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMetodePmb.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMetodePmb.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMetodePmb.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMetodePmb.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.dgvMetodePmb.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvMetodePmb.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMetodePmb.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMetodePmb.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMetodePmb.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMetodePmb.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMetodePmb.ThemeStyle.HeaderStyle.Height = 41;
            this.dgvMetodePmb.ThemeStyle.ReadOnly = true;
            this.dgvMetodePmb.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMetodePmb.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMetodePmb.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMetodePmb.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMetodePmb.ThemeStyle.RowsStyle.Height = 40;
            this.dgvMetodePmb.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMetodePmb.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMetodePmb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetodePembayaran_CellClick);
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.txtCari.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.txtCari.BorderRadius = 15;
            this.txtCari.BorderThickness = 3;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.IconLeft = global::Project3.Properties.Resources.search_icon;
            this.txtCari.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtCari.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtCari.Location = new System.Drawing.Point(31, 23);
            this.txtCari.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtCari.Name = "txtCari";
            this.txtCari.PlaceholderText = "";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(781, 61);
            this.txtCari.TabIndex = 18;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // btnSortFilter
            // 
            this.btnSortFilter.BorderRadius = 15;
            this.btnSortFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnSortFilter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnSortFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnSortFilter.Location = new System.Drawing.Point(834, 23);
            this.btnSortFilter.Name = "btnSortFilter";
            this.btnSortFilter.Size = new System.Drawing.Size(219, 61);
            this.btnSortFilter.TabIndex = 26;
            this.btnSortFilter.Text = "Urut && Saring";
            this.btnSortFilter.Click += new System.EventHandler(this.btnSortFilter_Click);
            // 
            // panelShort
            // 
            this.panelShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.panelShort.BorderRadius = 15;
            this.panelShort.Controls.Add(this.btnBersihkan);
            this.panelShort.Controls.Add(this.label3);
            this.panelShort.Controls.Add(this.cbStatus);
            this.panelShort.Controls.Add(this.label4);
            this.panelShort.Controls.Add(this.cbFilter);
            this.panelShort.Controls.Add(this.label5);
            this.panelShort.Controls.Add(this.cbSort);
            this.panelShort.Location = new System.Drawing.Point(776, 96);
            this.panelShort.Name = "panelShort";
            this.panelShort.Size = new System.Drawing.Size(297, 393);
            this.panelShort.TabIndex = 27;
            this.panelShort.Visible = false;
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.BorderRadius = 15;
            this.btnBersihkan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBersihkan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBersihkan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBersihkan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBersihkan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnBersihkan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnBersihkan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnBersihkan.Location = new System.Drawing.Point(34, 336);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(234, 40);
            this.btnBersihkan.TabIndex = 26;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(27, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 37);
            this.label3.TabIndex = 25;
            this.label3.Text = "Berdasarkan status";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderRadius = 15;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.cbStatus.Location = new System.Drawing.Point(34, 274);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(234, 36);
            this.cbStatus.TabIndex = 24;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label4.Location = new System.Drawing.Point(27, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "Saring berdasarkan";
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderRadius = 15;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "Nama"});
            this.cbFilter.Location = new System.Drawing.Point(34, 174);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(234, 36);
            this.cbFilter.TabIndex = 22;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(27, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "Urut berdasarkan";
            // 
            // cbSort
            // 
            this.cbSort.BackColor = System.Drawing.Color.Transparent;
            this.cbSort.BorderRadius = 15;
            this.cbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSort.ItemHeight = 30;
            this.cbSort.Items.AddRange(new object[] {
            "Turun ⬇",
            "Naik   ⬆"});
            this.cbSort.Location = new System.Drawing.Point(34, 65);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(234, 36);
            this.cbSort.TabIndex = 0;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // MetodePembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1533, 891);
            this.Controls.Add(this.panelShort);
            this.Controls.Add(this.btnSortFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dgvMetodePmb);
            this.Controls.Add(this.txtCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetodePembayaran";
            this.Text = "MetodePembayaran";
            this.Load += new System.EventHandler(this.MetodePembayaran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodePmb)).EndInit();
            this.panelShort.ResumeLayout(false);
            this.panelShort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private System.Windows.Forms.Label lblPageInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMetodePmb;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2Button btnSortFilter;
        private Guna.UI2.WinForms.Guna2Panel panelShort;
        private Guna.UI2.WinForms.Guna2Button btnBersihkan;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbSort;
    }
}