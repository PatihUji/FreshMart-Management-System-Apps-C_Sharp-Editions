namespace Project3.Master.Produk
{
    partial class FormProduk
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnupload = new Guna.UI2.WinForms.Guna2Button();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.cbJenisProduk = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbharga = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSatuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStok = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDeskripsi = new Guna.UI2.WinForms.Guna2TextBox();
            this.imageViewProduk = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewProduk)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNama.BorderRadius = 15;
            this.tbNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNama.DefaultText = "";
            this.tbNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.tbNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNama.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.tbNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNama.Location = new System.Drawing.Point(32, 297);
            this.tbNama.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbNama.MaxLength = 50;
            this.tbNama.Name = "tbNama";
            this.tbNama.PlaceholderText = "Nama";
            this.tbNama.SelectedText = "";
            this.tbNama.Size = new System.Drawing.Size(385, 54);
            this.tbNama.TabIndex = 3;
            this.tbNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            this.tbNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNama_KeyPress_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(27, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btnSimpan.Location = new System.Drawing.Point(237, 1309);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(182, 45);
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnupload
            // 
            this.btnupload.BorderRadius = 15;
            this.btnupload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnupload.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnupload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.btnupload.Location = new System.Drawing.Point(235, 108);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(182, 45);
            this.btnupload.TabIndex = 18;
            this.btnupload.Text = "Unggah";
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
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
            this.btnBatal.Location = new System.Drawing.Point(36, 1309);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(182, 45);
            this.btnBatal.TabIndex = 19;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // cbJenisProduk
            // 
            this.cbJenisProduk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbJenisProduk.BackColor = System.Drawing.Color.Transparent;
            this.cbJenisProduk.BorderRadius = 15;
            this.cbJenisProduk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbJenisProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisProduk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.cbJenisProduk.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJenisProduk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJenisProduk.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.cbJenisProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.cbJenisProduk.ItemHeight = 54;
            this.cbJenisProduk.Location = new System.Drawing.Point(34, 454);
            this.cbJenisProduk.Name = "cbJenisProduk";
            this.cbJenisProduk.Size = new System.Drawing.Size(385, 60);
            this.cbJenisProduk.TabIndex = 21;
            this.cbJenisProduk.SelectedIndexChanged += new System.EventHandler(this.cbJenisProduk_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(29, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "Jenis Produk";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbharga
            // 
            this.tbharga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbharga.BorderRadius = 15;
            this.tbharga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbharga.DefaultText = "";
            this.tbharga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbharga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbharga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbharga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbharga.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.tbharga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbharga.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbharga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.tbharga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbharga.Location = new System.Drawing.Point(34, 620);
            this.tbharga.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbharga.MaxLength = 50;
            this.tbharga.Name = "tbharga";
            this.tbharga.PlaceholderText = "";
            this.tbharga.SelectedText = "";
            this.tbharga.Size = new System.Drawing.Size(385, 54);
            this.tbharga.TabIndex = 23;
            this.tbharga.TextChanged += new System.EventHandler(this.tbharga_TextChanged);
            this.tbharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbharga_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(29, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Harga";
            // 
            // tbSatuan
            // 
            this.tbSatuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSatuan.BorderRadius = 15;
            this.tbSatuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSatuan.DefaultText = "";
            this.tbSatuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSatuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSatuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSatuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSatuan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.tbSatuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSatuan.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSatuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.tbSatuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSatuan.Location = new System.Drawing.Point(32, 783);
            this.tbSatuan.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbSatuan.MaxLength = 50;
            this.tbSatuan.Name = "tbSatuan";
            this.tbSatuan.PlaceholderText = "";
            this.tbSatuan.SelectedText = "";
            this.tbSatuan.Size = new System.Drawing.Size(385, 54);
            this.tbSatuan.TabIndex = 25;
            this.tbSatuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSatuan_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label4.Location = new System.Drawing.Point(27, 724);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "Satuan";
            // 
            // tbStok
            // 
            this.tbStok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStok.BorderRadius = 15;
            this.tbStok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStok.DefaultText = "";
            this.tbStok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbStok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbStok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.tbStok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStok.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.tbStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.tbStok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStok.Location = new System.Drawing.Point(34, 948);
            this.tbStok.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbStok.MaxLength = 50;
            this.tbStok.Name = "tbStok";
            this.tbStok.PlaceholderText = "";
            this.tbStok.SelectedText = "";
            this.tbStok.Size = new System.Drawing.Size(385, 54);
            this.tbStok.TabIndex = 27;
            this.tbStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStok_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(29, 889);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "Stok";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label6.Location = new System.Drawing.Point(29, 1053);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 37);
            this.label6.TabIndex = 28;
            this.label6.Text = "Deskripsi";
            // 
            // tbDeskripsi
            // 
            this.tbDeskripsi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeskripsi.BorderRadius = 15;
            this.tbDeskripsi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDeskripsi.DefaultText = "";
            this.tbDeskripsi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDeskripsi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDeskripsi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDeskripsi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDeskripsi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.tbDeskripsi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDeskripsi.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.tbDeskripsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.tbDeskripsi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDeskripsi.Location = new System.Drawing.Point(32, 1099);
            this.tbDeskripsi.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbDeskripsi.MaxLength = 50;
            this.tbDeskripsi.Multiline = true;
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.PlaceholderText = "";
            this.tbDeskripsi.SelectedText = "";
            this.tbDeskripsi.Size = new System.Drawing.Size(385, 158);
            this.tbDeskripsi.TabIndex = 29;
            this.tbDeskripsi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeskripsi_KeyPress);
            // 
            // imageViewProduk
            // 
            this.imageViewProduk.ImageRotate = 0F;
            this.imageViewProduk.Location = new System.Drawing.Point(34, 42);
            this.imageViewProduk.Name = "imageViewProduk";
            this.imageViewProduk.Size = new System.Drawing.Size(174, 158);
            this.imageViewProduk.TabIndex = 4;
            this.imageViewProduk.TabStop = false;
            // 
            // FormProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.tbDeskripsi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSatuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbharga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbJenisProduk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.imageViewProduk);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label1);
            this.Name = "FormProduk";
            this.Size = new System.Drawing.Size(455, 1393);
            this.Load += new System.EventHandler(this.FormProduk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageViewProduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbNama;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox imageViewProduk;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnupload;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2ComboBox cbJenisProduk;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbharga;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbSatuan;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbDeskripsi;
    }
}
