using Project3.Dashboard;
using Project3.DASHBOARD_ADMIN;
using Project3.Database;
using Project3.Master.Karyawan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class sideBarAdmin : Form
    {
        private String userAccess;
        private String username;
        public sideBarAdmin(String userAccess, String username)
        {
            InitializeComponent();
            this.userAccess = userAccess;
            this.username = username;
            lblUserAccess.Text = this.userAccess;
            ShowFormInPanel(new DashboardAdmin(userAccess));
        }

        public String getUserAccess()
        {
            return userAccess;
        }

        public void setLblTitle(String title)
        {
            lblTitle.Text = title;
        }

        public void setIconTitle(Image image)
        {
            iconTitle.Image = image;
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

        private void sideBarAdmin_Load(object sender, EventArgs e)
        {
            sideBar.setForm(this);
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
    }
}
