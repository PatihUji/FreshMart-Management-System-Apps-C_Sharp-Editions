namespace Project3.Transaksi.Penjualan
{
    partial class ListShowProduk
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
            this.displayCaseProduk = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStokTersisa = new System.Windows.Forms.Label();
            this.lblJenisProduk = new System.Windows.Forms.Label();
            this.lblHargaDanSatuan = new System.Windows.Forms.Label();
            this.lblNamaProduk = new System.Windows.Forms.Label();
            this.imvProduk = new Guna.UI2.WinForms.Guna2PictureBox();
            this.displayCaseProduk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imvProduk)).BeginInit();
            this.SuspendLayout();
            // 
            // displayCaseProduk
            // 
            this.displayCaseProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.displayCaseProduk.BorderRadius = 15;
            this.displayCaseProduk.Controls.Add(this.lblStokTersisa);
            this.displayCaseProduk.Controls.Add(this.lblJenisProduk);
            this.displayCaseProduk.Controls.Add(this.lblHargaDanSatuan);
            this.displayCaseProduk.Controls.Add(this.lblNamaProduk);
            this.displayCaseProduk.Controls.Add(this.imvProduk);
            this.displayCaseProduk.CustomizableEdges.BottomLeft = false;
            this.displayCaseProduk.CustomizableEdges.BottomRight = false;
            this.displayCaseProduk.Location = new System.Drawing.Point(14, 3);
            this.displayCaseProduk.MaximumSize = new System.Drawing.Size(238, 353);
            this.displayCaseProduk.MinimumSize = new System.Drawing.Size(238, 353);
            this.displayCaseProduk.Name = "displayCaseProduk";
            this.displayCaseProduk.Size = new System.Drawing.Size(238, 353);
            this.displayCaseProduk.TabIndex = 0;
            this.displayCaseProduk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.displayCaseProduk_MouseClick);
            // 
            // lblStokTersisa
            // 
            this.lblStokTersisa.AutoSize = true;
            this.lblStokTersisa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokTersisa.ForeColor = System.Drawing.Color.Red;
            this.lblStokTersisa.Location = new System.Drawing.Point(3, 318);
            this.lblStokTersisa.Name = "lblStokTersisa";
            this.lblStokTersisa.Size = new System.Drawing.Size(92, 17);
            this.lblStokTersisa.TabIndex = 4;
            this.lblStokTersisa.Text = "0 Stok Tersisa";
            // 
            // lblJenisProduk
            // 
            this.lblJenisProduk.AutoSize = true;
            this.lblJenisProduk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisProduk.ForeColor = System.Drawing.Color.White;
            this.lblJenisProduk.Location = new System.Drawing.Point(4, 291);
            this.lblJenisProduk.Name = "lblJenisProduk";
            this.lblJenisProduk.Size = new System.Drawing.Size(72, 13);
            this.lblJenisProduk.TabIndex = 3;
            this.lblJenisProduk.Text = "Jenis Produk";
            // 
            // lblHargaDanSatuan
            // 
            this.lblHargaDanSatuan.AutoSize = true;
            this.lblHargaDanSatuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaDanSatuan.ForeColor = System.Drawing.Color.White;
            this.lblHargaDanSatuan.Location = new System.Drawing.Point(3, 256);
            this.lblHargaDanSatuan.Name = "lblHargaDanSatuan";
            this.lblHargaDanSatuan.Size = new System.Drawing.Size(129, 21);
            this.lblHargaDanSatuan.TabIndex = 2;
            this.lblHargaDanSatuan.Text = "Rp0,00 / Satuan";
            // 
            // lblNamaProduk
            // 
            this.lblNamaProduk.AutoSize = true;
            this.lblNamaProduk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaProduk.ForeColor = System.Drawing.Color.White;
            this.lblNamaProduk.Location = new System.Drawing.Point(3, 225);
            this.lblNamaProduk.Name = "lblNamaProduk";
            this.lblNamaProduk.Size = new System.Drawing.Size(106, 21);
            this.lblNamaProduk.TabIndex = 1;
            this.lblNamaProduk.Text = "Nama Produk";
            // 
            // imvProduk
            // 
            this.imvProduk.ImageRotate = 0F;
            this.imvProduk.Location = new System.Drawing.Point(0, 0);
            this.imvProduk.Name = "imvProduk";
            this.imvProduk.Size = new System.Drawing.Size(238, 213);
            this.imvProduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imvProduk.TabIndex = 0;
            this.imvProduk.TabStop = false;
            this.imvProduk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imvProduk_MouseClick);
            // 
            // ListShowProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.displayCaseProduk);
            this.Name = "ListShowProduk";
            this.Size = new System.Drawing.Size(266, 359);
            this.displayCaseProduk.ResumeLayout(false);
            this.displayCaseProduk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imvProduk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel displayCaseProduk;
        private System.Windows.Forms.Label lblStokTersisa;
        private System.Windows.Forms.Label lblJenisProduk;
        private System.Windows.Forms.Label lblHargaDanSatuan;
        private System.Windows.Forms.Label lblNamaProduk;
        private Guna.UI2.WinForms.Guna2PictureBox imvProduk;
    }
}
