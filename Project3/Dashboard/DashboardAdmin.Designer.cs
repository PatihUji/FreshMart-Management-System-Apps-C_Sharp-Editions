namespace Project3.Dashboard
{
    partial class DashboardAdmin
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
            this.panelShort = new Guna.UI2.WinForms.Guna2Panel();
            this.tbjumlahproduk = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbjmlhkry = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconTitle = new System.Windows.Forms.PictureBox();
            this.panelShort.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShort
            // 
            this.panelShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.panelShort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.panelShort.BorderRadius = 15;
            this.panelShort.Controls.Add(this.iconTitle);
            this.panelShort.Controls.Add(this.tbjumlahproduk);
            this.panelShort.Controls.Add(this.label2);
            this.panelShort.Location = new System.Drawing.Point(801, 206);
            this.panelShort.Name = "panelShort";
            this.panelShort.Size = new System.Drawing.Size(607, 421);
            this.panelShort.TabIndex = 21;
            // 
            // tbjumlahproduk
            // 
            this.tbjumlahproduk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbjumlahproduk.BorderRadius = 15;
            this.tbjumlahproduk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbjumlahproduk.DefaultText = "";
            this.tbjumlahproduk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbjumlahproduk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbjumlahproduk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbjumlahproduk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbjumlahproduk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.tbjumlahproduk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbjumlahproduk.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbjumlahproduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.tbjumlahproduk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbjumlahproduk.Location = new System.Drawing.Point(38, 172);
            this.tbjumlahproduk.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbjumlahproduk.MaxLength = 50;
            this.tbjumlahproduk.Name = "tbjumlahproduk";
            this.tbjumlahproduk.PlaceholderText = "";
            this.tbjumlahproduk.ReadOnly = true;
            this.tbjumlahproduk.SelectedText = "";
            this.tbjumlahproduk.Size = new System.Drawing.Size(534, 101);
            this.tbjumlahproduk.TabIndex = 26;
            this.tbjumlahproduk.TextChanged += new System.EventHandler(this.tbSatuan_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(65, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 86);
            this.label2.TabIndex = 23;
            this.label2.Text = "Jumlah Produk";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.tbjmlhkry);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(119, 206);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(607, 421);
            this.guna2Panel1.TabIndex = 28;
            // 
            // tbjmlhkry
            // 
            this.tbjmlhkry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbjmlhkry.BorderRadius = 15;
            this.tbjmlhkry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbjmlhkry.DefaultText = "";
            this.tbjmlhkry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbjmlhkry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbjmlhkry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbjmlhkry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbjmlhkry.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.tbjmlhkry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbjmlhkry.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbjmlhkry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(21)))));
            this.tbjmlhkry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbjmlhkry.Location = new System.Drawing.Point(38, 172);
            this.tbjmlhkry.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbjmlhkry.MaxLength = 50;
            this.tbjmlhkry.Name = "tbjmlhkry";
            this.tbjmlhkry.PlaceholderText = "";
            this.tbjmlhkry.ReadOnly = true;
            this.tbjmlhkry.SelectedText = "";
            this.tbjmlhkry.Size = new System.Drawing.Size(534, 101);
            this.tbjmlhkry.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 86);
            this.label1.TabIndex = 23;
            this.label1.Text = "Jumlah Karyawan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.pictureBox1.Image = global::Project3.Properties.Resources.big_person1_green_icon;
            this.pictureBox1.Location = new System.Drawing.Point(491, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.iconTitle.Image = global::Project3.Properties.Resources.small_produk_green_icon;
            this.iconTitle.Location = new System.Drawing.Point(491, 189);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(65, 67);
            this.iconTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconTitle.TabIndex = 27;
            this.iconTitle.TabStop = false;
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1517, 852);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelShort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardAdmin";
            this.Text = "DashboardAdmin";
            this.panelShort.ResumeLayout(false);
            this.panelShort.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelShort;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbjumlahproduk;
        private System.Windows.Forms.PictureBox iconTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbjmlhkry;
        private System.Windows.Forms.Label label1;
    }
}