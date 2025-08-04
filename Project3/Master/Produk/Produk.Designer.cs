namespace Project3.Master.Produk
{
    partial class Produk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.dgvProduk = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSortFilter = new Guna.UI2.WinForms.Guna2Button();
            this.panelShort = new Guna.UI2.WinForms.Guna2Panel();
            this.cbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBersihkan = new Guna.UI2.WinForms.Guna2Button();
            this.formProduk = new Project3.Master.Produk.FormProduk();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.panelShort.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.lblPageInfo.Location = new System.Drawing.Point(513, 711);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(28, 32);
            this.lblPageInfo.TabIndex = 11;
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
            this.btnNext.Location = new System.Drawing.Point(554, 706);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 45);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
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
            this.btnPrev.Location = new System.Drawing.Point(458, 706);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 45);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // dgvProduk
            // 
            this.dgvProduk.AllowUserToAddRows = false;
            this.dgvProduk.AllowUserToDeleteRows = false;
            this.dgvProduk.AllowUserToResizeColumns = false;
            this.dgvProduk.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvProduk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduk.ColumnHeadersHeight = 41;
            this.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduk.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvProduk.Location = new System.Drawing.Point(22, 230);
            this.dgvProduk.Name = "dgvProduk";
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvProduk.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduk.RowTemplate.Height = 40;
            this.dgvProduk.Size = new System.Drawing.Size(1015, 443);
            this.dgvProduk.TabIndex = 8;
            this.dgvProduk.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduk.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProduk.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProduk.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProduk.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProduk.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.dgvProduk.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvProduk.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProduk.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProduk.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduk.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProduk.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProduk.ThemeStyle.HeaderStyle.Height = 41;
            this.dgvProduk.ThemeStyle.ReadOnly = true;
            this.dgvProduk.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduk.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduk.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduk.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduk.ThemeStyle.RowsStyle.Height = 40;
            this.dgvProduk.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduk.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduk_CellContentClick);
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
            this.txtCari.Location = new System.Drawing.Point(22, 105);
            this.txtCari.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtCari.Name = "txtCari";
            this.txtCari.PlaceholderText = "";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(781, 61);
            this.txtCari.TabIndex = 7;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged_1);
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.Controls.Add(this.formProduk);
            this.pnlForm.Location = new System.Drawing.Point(1060, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(473, 891);
            this.pnlForm.TabIndex = 12;
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
            this.btnSortFilter.Location = new System.Drawing.Point(818, 105);
            this.btnSortFilter.Name = "btnSortFilter";
            this.btnSortFilter.Size = new System.Drawing.Size(219, 61);
            this.btnSortFilter.TabIndex = 19;
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
            this.panelShort.Controls.Add(this.label2);
            this.panelShort.Controls.Add(this.cbFilter);
            this.panelShort.Controls.Add(this.label1);
            this.panelShort.Controls.Add(this.cbSort);
            this.panelShort.Location = new System.Drawing.Point(757, 172);
            this.panelShort.Name = "panelShort";
            this.panelShort.Size = new System.Drawing.Size(297, 393);
            this.panelShort.TabIndex = 20;
            this.panelShort.Visible = false;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Urut berdasarkan";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(27, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Saring berdasarkan";
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
            "Nama",
            "Jenis Produk",
            "Harga",
            "Satuan",
            "Stok",
            "Deskripsi"});
            this.cbFilter.Location = new System.Drawing.Point(34, 174);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(234, 36);
            this.cbFilter.TabIndex = 22;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
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
            this.btnBersihkan.Size = new System.Drawing.Size(234, 38);
            this.btnBersihkan.TabIndex = 26;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // formProduk
            // 
            this.formProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.formProduk.Location = new System.Drawing.Point(1, 0);
            this.formProduk.Name = "formProduk";
            this.formProduk.Size = new System.Drawing.Size(455, 1393);
            this.formProduk.TabIndex = 0;
            // 
            // Produk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1533, 891);
            this.Controls.Add(this.panelShort);
            this.Controls.Add(this.btnSortFilter);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dgvProduk);
            this.Controls.Add(this.txtCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produk";
            this.Text = "Produk";
            this.Load += new System.EventHandler(this.Produk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.panelShort.ResumeLayout(false);
            this.panelShort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProduk;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private FormProduk formProduk;
        private Guna.UI2.WinForms.Guna2Button btnSortFilter;
        private Guna.UI2.WinForms.Guna2Panel panelShort;
        private Guna.UI2.WinForms.Guna2ComboBox cbSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2Button btnBersihkan;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
    }
}