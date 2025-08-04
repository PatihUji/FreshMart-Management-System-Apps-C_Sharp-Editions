namespace Project3.Master.Karyawan
{
    partial class Karyawan
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
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.formKaryawan = new Project3.Master.Karyawan.FormKaryawan();
            this.dgvKaryawan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnSortFilter = new Guna.UI2.WinForms.Guna2Button();
            this.panelShort = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBersihkan = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).BeginInit();
            this.panelShort.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm.Controls.Add(this.formKaryawan);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.Location = new System.Drawing.Point(1060, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(473, 891);
            this.pnlForm.TabIndex = 0;
            // 
            // formKaryawan
            // 
            this.formKaryawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.formKaryawan.Location = new System.Drawing.Point(0, 0);
            this.formKaryawan.Name = "formKaryawan";
            this.formKaryawan.Size = new System.Drawing.Size(455, 1356);
            this.formKaryawan.TabIndex = 0;
            // 
            // dgvKaryawan
            // 
            this.dgvKaryawan.AllowUserToAddRows = false;
            this.dgvKaryawan.AllowUserToDeleteRows = false;
            this.dgvKaryawan.AllowUserToResizeColumns = false;
            this.dgvKaryawan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvKaryawan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKaryawan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKaryawan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKaryawan.ColumnHeadersHeight = 41;
            this.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKaryawan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKaryawan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvKaryawan.Location = new System.Drawing.Point(22, 230);
            this.dgvKaryawan.Name = "dgvKaryawan";
            this.dgvKaryawan.ReadOnly = true;
            this.dgvKaryawan.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvKaryawan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKaryawan.RowTemplate.Height = 40;
            this.dgvKaryawan.Size = new System.Drawing.Size(1015, 443);
            this.dgvKaryawan.TabIndex = 3;
            this.dgvKaryawan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKaryawan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKaryawan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKaryawan.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.dgvKaryawan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.dgvKaryawan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKaryawan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKaryawan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKaryawan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKaryawan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKaryawan.ThemeStyle.HeaderStyle.Height = 41;
            this.dgvKaryawan.ThemeStyle.ReadOnly = true;
            this.dgvKaryawan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKaryawan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKaryawan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKaryawan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKaryawan.ThemeStyle.RowsStyle.Height = 40;
            this.dgvKaryawan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKaryawan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKaryawan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKaryawan_CellClick);
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
            this.txtCari.TabIndex = 2;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
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
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
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
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.lblPageInfo.Location = new System.Drawing.Point(513, 711);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(28, 32);
            this.lblPageInfo.TabIndex = 6;
            this.lblPageInfo.Text = "0";
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSortFilter.TabIndex = 27;
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
            this.panelShort.Location = new System.Drawing.Point(757, 178);
            this.panelShort.Name = "panelShort";
            this.panelShort.Size = new System.Drawing.Size(297, 393);
            this.panelShort.TabIndex = 28;
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
            // Karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1533, 891);
            this.Controls.Add(this.panelShort);
            this.Controls.Add(this.btnSortFilter);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dgvKaryawan);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Karyawan";
            this.Text = "Karyawan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Karyawan_Load);
            this.pnlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).EndInit();
            this.panelShort.ResumeLayout(false);
            this.panelShort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private FormKaryawan formKaryawan;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKaryawan;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Label lblPageInfo;
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