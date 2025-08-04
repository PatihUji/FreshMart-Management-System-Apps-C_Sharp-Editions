namespace Project3
{
    partial class CardStokKeluar
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
            this.panelCardProduk = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblJumlahStok = new System.Windows.Forms.Label();
            this.lblNamaProduk = new System.Windows.Forms.Label();
            this.panelCardProduk.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCardProduk
            // 
            this.panelCardProduk.Controls.Add(this.panel2);
            this.panelCardProduk.Controls.Add(this.lblNamaProduk);
            this.panelCardProduk.ForeColor = System.Drawing.Color.Coral;
            this.panelCardProduk.Location = new System.Drawing.Point(17, 19);
            this.panelCardProduk.Name = "panelCardProduk";
            this.panelCardProduk.Size = new System.Drawing.Size(231, 142);
            this.panelCardProduk.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(21, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 104);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblJumlahStok);
            this.panel3.Location = new System.Drawing.Point(7, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 90);
            this.panel3.TabIndex = 0;
            // 
            // lblJumlahStok
            // 
            this.lblJumlahStok.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlahStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.lblJumlahStok.Location = new System.Drawing.Point(0, 31);
            this.lblJumlahStok.Name = "lblJumlahStok";
            this.lblJumlahStok.Size = new System.Drawing.Size(169, 22);
            this.lblJumlahStok.TabIndex = 2;
            this.lblJumlahStok.Text = "Jumlah Stok";
            this.lblJumlahStok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNamaProduk
            // 
            this.lblNamaProduk.AutoEllipsis = true;
            this.lblNamaProduk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.lblNamaProduk.Location = new System.Drawing.Point(17, 5);
            this.lblNamaProduk.Name = "lblNamaProduk";
            this.lblNamaProduk.Size = new System.Drawing.Size(190, 22);
            this.lblNamaProduk.TabIndex = 0;
            this.lblNamaProduk.Text = "Nama Produk";
            this.lblNamaProduk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardStokKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCardProduk);
            this.Name = "CardStokKeluar";
            this.Size = new System.Drawing.Size(257, 176);
            this.panelCardProduk.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCardProduk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblJumlahStok;
        private System.Windows.Forms.Label lblNamaProduk;
    }
}
