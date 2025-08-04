using Guna.UI2.WinForms;
using Project3.Dashboard;
using Project3.Database;
using Project3.Master.Karyawan;
using Project3.Transaksi.Pengiriman;
using Project3.Transaksi.Penjualan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3.SideBar
{
    public partial class SideBarKasir: Form
    {
        private String userAccess;
        private String username;
        public SideBarKasir(String userAccess, String username)
        {
            InitializeComponent();
            this.userAccess = userAccess;
            this.username = username;
            lblUserAccess.Text = this.userAccess;

            ShowFormInPanel(new DashboardKasir(getUserAccess()));
            isFormActive = "Dashboard";
            switchButtonColor();
        }

        public String getUserAccess()
        {
            return userAccess;
        }

        public void ShowFormInPanel(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            form.Show();
        }

        DBConnect connection = new DBConnect();
        private void lblUserAccess_Click(object sender, EventArgs e)
        {
            KaryawanADT getData = connection.GetProfileByUsername(username);
            lblNama.Text = getData.Nama;
            lblTglLahir.Text = getData.TanggalLahir.ToString("dd-MM-yyyy");
            lblJenisKelamin.Text = getData.Gender;
            lblJabatanDD.Text = getData.SNama;
            lblAlamat.Text = getData.Alamat;
            lblUsername.Text = getData.Username;

            pnlOverlay.BringToFront();
            pnlOverlay.BackColor = Color.FromArgb(128, 0, 0, 0); // hitam transparan
            pnlOverlay.FillColor = Color.FromArgb(128, 0, 0, 0); // pastikan juga fill transparan
        }

        private void lblUserAccess_MouseEnter(object sender, EventArgs e)
        {
            lblUserAccess.ForeColor = Color.Blue;
        }

        private void lblUserAccess_MouseLeave(object sender, EventArgs e)
        {
            lblUserAccess.ForeColor = ColorTranslator.FromHtml("#016015");
        }

        private void pnlOverlay_Click(object sender, EventArgs e)
        {
            pnlOverlay.SendToBack();
            txtPassword.Clear();
        }


        private void btnGantiPassword_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                connection.UpdatePasswordKaryawanByUsername(username, txtPassword.Text);
                txtPassword.Text = null;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtPassword.Text.Length >= 20 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        String isFormActive = null;

        private void SetButtonActive(Guna2Button btn, Image icon)
        {
            btn.FillColor = Color.FromArgb(255, 253, 246);
            btn.ForeColor = Color.FromArgb(160, 200, 120);
            btn.Image = icon;
        }

        private void SetButtonInactive(Guna2Button btn, Image icon)
        {
            btn.FillColor = Color.FromArgb(160, 200, 120);
            btn.ForeColor = Color.FromArgb(255, 253, 246);
            btn.Image = icon;
        }
        private void switchButtonColor()
        {
            switch (isFormActive)
            {
                case "Dashboard":
                    SetButtonActive(btnDashboard, Properties.Resources.small_home_green_icon);
                    SetButtonInactive(btnPenjualan, Properties.Resources.small_cart_white_icon);
                    SetButtonInactive(btnPengiriman, Properties.Resources.small_delivery_white_icon);
                    lblTitle.Text = isFormActive;
                    iconTitle.Image = Properties.Resources.big_home_green_icon;
                    break;

                case "Penjualan":
                    SetButtonActive(btnPenjualan, Properties.Resources.small_cart_green_icon);
                    SetButtonInactive(btnDashboard, Properties.Resources.small_home_white_icon);
                    SetButtonInactive(btnPengiriman, Properties.Resources.small_delivery_white_icon);
                    lblTitle.Text = isFormActive;
                    iconTitle.Image = Properties.Resources.big_cart_green_icon;
                    break;

                case "Pengiriman":
                    SetButtonActive(btnPengiriman, Properties.Resources.small_delivery_green_icon);
                    SetButtonInactive(btnDashboard, Properties.Resources.small_home_white_icon);
                    SetButtonInactive(btnPenjualan, Properties.Resources.small_cart_white_icon);
                    lblTitle.Text = isFormActive;
                    iconTitle.Image = Properties.Resources.big_delivery_green_icon;
                    break;
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new DashboardKasir(getUserAccess()));
            isFormActive = "Dashboard";
            switchButtonColor();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Penjualan(userAccess, username));
            isFormActive = "Penjualan";
            switchButtonColor();
        }

        private void btnPengiriman_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Pengiriman(userAccess));
            isFormActive = "Pengiriman";
            switchButtonColor();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormLogin login = new FormLogin();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }
    }
}
