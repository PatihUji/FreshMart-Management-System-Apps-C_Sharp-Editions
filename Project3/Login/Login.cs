using Project3.Database;
using Project3.SideBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string jabatan;

            // Validasi kosong
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            DBConnect connection = new DBConnect();
            
            if (connection.LoginKaryawan(username, password, out jabatan) == 0)
            {
                if (jabatan.Equals("Admin"))
                {
                    this.Hide(); // Sembunyikan form login

                    sideBarAdmin sidebar = new sideBarAdmin(connection.GetUserLoginName(username), username);
                    sidebar.FormClosed += (s, args) => this.Close(); // Tutup aplikasi saat sidebar ditutup
                    sidebar.Show();
                }
                else if (jabatan.Equals("Kasir"))
                {
                    this.Hide(); // Sembunyikan form login

                    SideBarKasir sidebar = new SideBarKasir(connection.GetUserLoginName(username), username);
                    sidebar.FormClosed += (s, args) => this.Close(); // Tutup aplikasi saat sidebar ditutup
                    sidebar.Show();
                }
                else if (jabatan.Equals("Quality Control"))
                {
                    this.Hide(); // Sembunyikan form login

                    SideBarQualityControl sidebar = new SideBarQualityControl(connection.GetUserLoginName(username), username);
                    sidebar.FormClosed += (s, args) => this.Close(); // Tutup aplikasi saat sidebar ditutup
                    sidebar.Show();
                }
                else if (jabatan.Equals("Customer Service"))
                {
                    this.Hide(); // Sembunyikan form login

                    SideBarCustomerService sidebar = new SideBarCustomerService(connection.GetUserLoginName(username), username);
                    sidebar.FormClosed += (s, args) => this.Close(); // Tutup aplikasi saat sidebar ditutup
                    sidebar.Show();
                }
                else if (jabatan.Equals("Owner"))
                {
                    this.Hide(); // Sembunyikan form login

                    SideBarOwner sidebar = new SideBarOwner(connection.GetUserLoginName(username), username);
                    sidebar.FormClosed += (s, args) => this.Close(); // Tutup aplikasi saat sidebar ditutup
                    sidebar.Show();
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool passwordVisible = false;

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                txtPassword.PasswordChar = '●';
                btnEye.Image = Properties.Resources.eye_closed;
                passwordVisible = false;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                btnEye.Image = Properties.Resources.eye_open;
                passwordVisible = true;
            }
        }
    }
}
