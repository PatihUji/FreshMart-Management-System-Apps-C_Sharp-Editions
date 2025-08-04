using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Project3.Dashboard;
using Project3.Master.JenisProduk;
using Project3.Master.Karyawan;
using Project3.Master.Metode_Pembayaran;
using Project3.Master.Produk;
using Project3.Master.Promo;
using Project3.Master.Setting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project3.DASHBOARD_ADMIN
{
    public partial class navBarAdmin : UserControl
    {
        public navBarAdmin()
        {
            InitializeComponent();
            isFormActive = "Dashboard";
        }

        sideBarAdmin form;

        public void setForm(sideBarAdmin form)
        {
            this.form = form;
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
                    SetButtonInactive(btnKaryawan, Properties.Resources.small_person1_icon_white);
                    SetButtonInactive(btnSetting, Properties.Resources.small_setting_white_icon);
                    SetButtonInactive(btnProduk, Properties.Resources.small_produk_white_icon);
                    SetButtonInactive(btnJenisProduk, Properties.Resources.small_jproduk_white_icon);
                    SetButtonInactive(btnMetodePembayaran, Properties.Resources.small_credit_white_icon);
                    SetButtonInactive(btnPromo, Properties.Resources.small_dollar_white_icon);
                    form.setLblTitle(isFormActive);
                    form.setIconTitle(Properties.Resources.big_home_green_icon);
                    break;

                case "Karyawan":
                    SetButtonActive(btnKaryawan, Properties.Resources.small_person1_green_icon);
                    SetButtonInactive(btnDashboard, Properties.Resources.small_home_white_icon);
                    SetButtonInactive(btnSetting, Properties.Resources.small_setting_white_icon);
                    SetButtonInactive(btnProduk, Properties.Resources.small_produk_white_icon);
                    SetButtonInactive(btnJenisProduk, Properties.Resources.small_jproduk_white_icon);
                    SetButtonInactive(btnMetodePembayaran, Properties.Resources.small_credit_white_icon);
                    SetButtonInactive(btnPromo, Properties.Resources.small_dollar_white_icon);
                    form.setLblTitle(isFormActive);
                    form.setIconTitle(Properties.Resources.big_person1_green_icon);
                    break;

                case "Setting":
                    SetButtonActive(btnSetting, Properties.Resources.small_setting_green_icon);
                    SetButtonInactive(btnDashboard, Properties.Resources.small_home_white_icon);
                    SetButtonInactive(btnKaryawan, Properties.Resources.small_person1_icon_white);
                    SetButtonInactive(btnProduk, Properties.Resources.small_produk_white_icon);
                    SetButtonInactive(btnJenisProduk, Properties.Resources.small_jproduk_white_icon);
                    SetButtonInactive(btnMetodePembayaran, Properties.Resources.small_credit_white_icon);
                    SetButtonInactive(btnPromo, Properties.Resources.small_dollar_white_icon);
                    form.setLblTitle(isFormActive);
                    form.setIconTitle(Properties.Resources.big_setting_green_icon);
                    break;

                case "Produk":
                    SetButtonActive(btnProduk, Properties.Resources.small_produk_green_icon);
                    SetButtonInactive(btnDashboard, Properties.Resources.small_home_white_icon);
                    SetButtonInactive(btnKaryawan, Properties.Resources.small_person1_icon_white);
                    SetButtonInactive(btnSetting, Properties.Resources.small_setting_white_icon);
                    SetButtonInactive(btnJenisProduk, Properties.Resources.small_jproduk_white_icon);
                    SetButtonInactive(btnMetodePembayaran, Properties.Resources.small_credit_white_icon);
                    SetButtonInactive(btnPromo, Properties.Resources.small_dollar_white_icon);
                    form.setLblTitle(isFormActive);
                    form.setIconTitle(Properties.Resources.big_produk_green_icon);
                    break;

                case "Jenis Produk":
                    SetButtonActive(btnJenisProduk, Properties.Resources.small_jproduk_green_icon);
                    SetButtonInactive(btnDashboard, Properties.Resources.small_home_white_icon);
                    SetButtonInactive(btnKaryawan, Properties.Resources.small_person1_icon_white);
                    SetButtonInactive(btnSetting, Properties.Resources.small_setting_white_icon);
                    SetButtonInactive(btnProduk, Properties.Resources.small_produk_white_icon);
                    SetButtonInactive(btnMetodePembayaran, Properties.Resources.small_credit_white_icon);
                    SetButtonInactive(btnPromo, Properties.Resources.small_dollar_white_icon);
                    form.setLblTitle(isFormActive);
                    form.setIconTitle(Properties.Resources.big_jproduk_green_icon);
                    break;

                case "Metode Pembayaran":
                    SetButtonActive(btnMetodePembayaran, Properties.Resources.small_credit_green_icon);
                    SetButtonInactive(btnDashboard, Properties.Resources.small_home_white_icon);
                    SetButtonInactive(btnKaryawan, Properties.Resources.small_person1_icon_white);
                    SetButtonInactive(btnSetting, Properties.Resources.small_setting_white_icon);
                    SetButtonInactive(btnProduk, Properties.Resources.small_produk_white_icon);
                    SetButtonInactive(btnJenisProduk, Properties.Resources.small_jproduk_white_icon);
                    SetButtonInactive(btnPromo, Properties.Resources.small_dollar_white_icon);
                    form.setLblTitle(isFormActive);
                    form.setIconTitle(Properties.Resources.big_credit_green_icon);
                    break;

                case "Promo":
                    SetButtonActive(btnPromo, Properties.Resources.small_dollar_green_icon);
                    SetButtonInactive(btnDashboard, Properties.Resources.small_home_white_icon);
                    SetButtonInactive(btnKaryawan, Properties.Resources.small_person1_icon_white);
                    SetButtonInactive(btnSetting, Properties.Resources.small_setting_white_icon);
                    SetButtonInactive(btnProduk, Properties.Resources.small_produk_white_icon);
                    SetButtonInactive(btnJenisProduk, Properties.Resources.small_jproduk_white_icon);
                    SetButtonInactive(btnMetodePembayaran, Properties.Resources.small_credit_white_icon);
                    form.setLblTitle(isFormActive);
                    form.setIconTitle(Properties.Resources.big_dollar_green_icon);
                    break;
            }

        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            form.ShowFormInPanel(new Karyawan(form.getUserAccess()));
            isFormActive = "Karyawan";
            switchButtonColor();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            form.Hide();

            FormLogin login = new FormLogin();
            login.FormClosed += (s, args) => form.Close(); // Tutup aplikasi saat dashboard ditutup
            login.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            form.ShowFormInPanel(new Setting(form.getUserAccess()));
            isFormActive = "Setting";
            switchButtonColor();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            form.ShowFormInPanel(new Produk(form.getUserAccess()));
            isFormActive = "Produk";
            switchButtonColor();
        }

        private void btnJenisProduk_Click(object sender, EventArgs e)
        {
            form.ShowFormInPanel(new JenisProduk(form.getUserAccess()));
            isFormActive = "Jenis Produk";
            switchButtonColor();
        }

        private void btnMetodePembayaran_Click(object sender, EventArgs e)
        {
            form.ShowFormInPanel(new MetodePembayaran(form.getUserAccess()));
            isFormActive = "Metode Pembayaran";
            switchButtonColor();
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            form.ShowFormInPanel(new Promo(form.getUserAccess()));
            isFormActive = "Promo";
            switchButtonColor();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            form.ShowFormInPanel(new DashboardAdmin(form.getUserAccess()));
            isFormActive = "Dashboard";
            switchButtonColor();
        }
    }
}
