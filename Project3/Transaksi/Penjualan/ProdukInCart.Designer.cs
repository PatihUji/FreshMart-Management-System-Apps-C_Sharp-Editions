namespace Project3.Transaksi.Penjualan
{
    partial class ProdukInCart
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.nupKuantitas = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblHargaByKuantitas = new System.Windows.Forms.Label();
            this.lblJenisProduk = new System.Windows.Forms.Label();
            this.lblNamaProduk = new System.Windows.Forms.Label();
            this.imvProduk = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKuantitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imvProduk)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.btnHapus);
            this.guna2Panel3.Controls.Add(this.nupKuantitas);
            this.guna2Panel3.Controls.Add(this.lblHargaByKuantitas);
            this.guna2Panel3.Controls.Add(this.lblJenisProduk);
            this.guna2Panel3.Controls.Add(this.lblNamaProduk);
            this.guna2Panel3.Controls.Add(this.imvProduk);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(453, 105);
            this.guna2Panel3.TabIndex = 1;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.FillColor = System.Drawing.Color.Transparent;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Image = global::Project3.Properties.Resources.delete_icon;
            this.btnHapus.Location = new System.Drawing.Point(346, 61);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(38, 32);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.UseTransparentBackground = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // nupKuantitas
            // 
            this.nupKuantitas.BackColor = System.Drawing.Color.Transparent;
            this.nupKuantitas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupKuantitas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nupKuantitas.Location = new System.Drawing.Point(390, 64);
            this.nupKuantitas.Name = "nupKuantitas";
            this.nupKuantitas.Size = new System.Drawing.Size(50, 24);
            this.nupKuantitas.TabIndex = 4;
            this.nupKuantitas.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.nupKuantitas.ValueChanged += new System.EventHandler(this.nupKuantitas_ValueChanged);
            // 
            // lblHargaByKuantitas
            // 
            this.lblHargaByKuantitas.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaByKuantitas.Location = new System.Drawing.Point(314, 28);
            this.lblHargaByKuantitas.Name = "lblHargaByKuantitas";
            this.lblHargaByKuantitas.Size = new System.Drawing.Size(126, 25);
            this.lblHargaByKuantitas.TabIndex = 3;
            this.lblHargaByKuantitas.Text = "Rp0,00";
            this.lblHargaByKuantitas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblJenisProduk
            // 
            this.lblJenisProduk.AutoSize = true;
            this.lblJenisProduk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisProduk.Location = new System.Drawing.Point(113, 64);
            this.lblJenisProduk.Name = "lblJenisProduk";
            this.lblJenisProduk.Size = new System.Drawing.Size(81, 17);
            this.lblJenisProduk.TabIndex = 2;
            this.lblJenisProduk.Text = "Jenis Produk";
            // 
            // lblNamaProduk
            // 
            this.lblNamaProduk.AutoSize = true;
            this.lblNamaProduk.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaProduk.Location = new System.Drawing.Point(111, 28);
            this.lblNamaProduk.Name = "lblNamaProduk";
            this.lblNamaProduk.Size = new System.Drawing.Size(120, 23);
            this.lblNamaProduk.TabIndex = 1;
            this.lblNamaProduk.Text = "Nama Produk";
            // 
            // imvProduk
            // 
            this.imvProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imvProduk.ImageRotate = 0F;
            this.imvProduk.Location = new System.Drawing.Point(3, 3);
            this.imvProduk.Name = "imvProduk";
            this.imvProduk.Size = new System.Drawing.Size(102, 99);
            this.imvProduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imvProduk.TabIndex = 0;
            this.imvProduk.TabStop = false;
            // 
            // ProdukInCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel3);
            this.Name = "ProdukInCart";
            this.Size = new System.Drawing.Size(453, 105);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKuantitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imvProduk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupKuantitas;
        private System.Windows.Forms.Label lblHargaByKuantitas;
        private System.Windows.Forms.Label lblJenisProduk;
        private System.Windows.Forms.Label lblNamaProduk;
        private Guna.UI2.WinForms.Guna2PictureBox imvProduk;
    }
}
