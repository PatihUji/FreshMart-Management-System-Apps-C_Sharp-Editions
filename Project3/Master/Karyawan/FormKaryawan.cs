using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project3.Database;

namespace Project3.Master.Karyawan
{
    public partial class FormKaryawan: UserControl
    {
        String userAccess;
        public FormKaryawan()
        {
            InitializeComponent();
        }

        public void setUserAccess(String userAccess)
        {
            this.userAccess = userAccess;
        }

        DBConnect connection = new DBConnect();
        int kry_id = 0;

        private void FormKaryawan_Load(object sender, EventArgs e)
        {
            dtpTanggalLahir.Format = DateTimePickerFormat.Custom;
            dtpTanggalLahir.CustomFormat = "'Minimal usia 19 tahun'";
            ComboBoxJabatan();
        }

        private void dtpTanggalLahir_ValueChanged(object sender, EventArgs e)
        {
            dtpTanggalLahir.Format = DateTimePickerFormat.Custom;
            dtpTanggalLahir.CustomFormat = "dd/MM/yyyy";

            if (dtpTanggalLahir.Value > DateTime.Today.AddYears(-19))
            {
                MessageBox.Show(this,"Usia tidak mencukupi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpTanggalLahir.CustomFormat = "'Minimal usia 19 tahun'";
            }
        }

        public Karyawan parentForm;

        public void setParentForm(Karyawan form) {
            parentForm = form;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari form
            string nama = txtNama.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            DateTime tglLahir = dtpTanggalLahir.Value;
            int idJabatan = cbJabatan.SelectedIndex != -1 ? Convert.ToInt32(cbJabatan.SelectedValue) : -1;
            string gender = cbJenisKelamin.Text;

            // Validasi umum
            bool isTanggalValid = !dtpTanggalLahir.CustomFormat.Equals(" ");
            bool isFormValid = !string.IsNullOrWhiteSpace(nama) &&
                               idJabatan != -1 &&
                               !string.IsNullOrWhiteSpace(gender) &&
                               isTanggalValid &&
                               !string.IsNullOrWhiteSpace(alamat);

            // Tambahan validasi untuk admin (input username/password)
            if (isJabatanAccess)
            {
                isFormValid &= !string.IsNullOrWhiteSpace(username);

                // Saat insert, password wajib diisi
                if (kry_id == 0 && string.IsNullOrWhiteSpace(password))
                {
                    isFormValid = false;
                }
            }

            if (!isFormValid)
            {
                MessageBox.Show("Data tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Proses simpan/update
            if (kry_id != 0 && connection.isKaryawanExist(kry_id))
            {
                // Update
                if (isJabatanAccess)
                {
                    connection.UpdateKaryawan(kry_id, idJabatan, nama, tglLahir, alamat, gender, username, userAccess);
                }
                else
                {
                    connection.UpdateKaryawan(kry_id, idJabatan, nama, tglLahir, alamat, gender, null, userAccess);
                }
            }
            else
            {
                // Insert
                if (isJabatanAccess)
                {
                    connection.InsertKaryawan(idJabatan, nama, tglLahir, alamat, gender, username, password, userAccess);
                }
                else
                {
                    connection.InsertKaryawan(idJabatan, nama, tglLahir, alamat, gender, null, null, userAccess);
                }
            }

            // Refresh tampilan
            parentForm.LoadAllData();
            parentForm.LoadPage();
            Clear();
        }

        private void ComboBoxJabatan()
        {
            cbJabatan.DataSource = connection.getListSettingByKategori("Jabatan");
            cbJabatan.DisplayMember = "s_nama";
            cbJabatan.ValueMember = "s_id";
            cbJabatan.SelectedIndex = -1;
        }

        private void Clear()
        {
            kry_id = 0;
            txtNama.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtAlamat.Text = "";
            ComboBoxJabatan();
            cbJenisKelamin.SelectedIndex = -1;
            dtpTanggalLahir.CustomFormat = "'Minimal usia 19 tahun'";
            isJabatanAccess = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void setForm(int kry_id, String txtNama, String txtUsername, String txtAlamat, int cbJabatan, String cbJenisKelamin, DateTime dtpTanggalLahir)
        {
            this.kry_id = kry_id;
            this.txtNama.Text = txtNama;
            this.txtUsername.Text = txtUsername;
            this.txtAlamat.Text = txtAlamat;
            this.cbJabatan.SelectedValue = cbJabatan;
            this.cbJenisKelamin.Text = cbJenisKelamin;
            this.dtpTanggalLahir.Value = dtpTanggalLahir;
            this.dtpTanggalLahir.CustomFormat = "dd/MM/yyyy";
        }

        private bool isJabatanAccess = false;
        private void cbJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cbJabatan.SelectedItem as DataRowView;
            string jabatan = selected?["s_nama"]?.ToString();

            if (jabatan == "Admin" || jabatan == "Kasir" || jabatan == "Owner" || jabatan == "Quality Control" || jabatan == "Customer Service")
            {
                if (connection.isKaryawanExist(kry_id))
                {
                    isJabatanAccess = true;
                    lblReqUsername.Visible = true;
                    lblReqPassword.Visible = false;
                    txtUsername.Enabled = true;
                    txtPassword.Enabled = false;
                }
                else
                {
                    isJabatanAccess = true;
                    lblReqUsername.Visible = true;
                    lblReqPassword.Visible = true;
                    txtUsername.Enabled = true;
                    txtPassword.Enabled = true;
                }
            }
            else
            {
                isJabatanAccess = false;
                lblReqUsername.Visible = false;
                lblReqPassword.Visible = false;
                txtUsername.Text = null;
                txtPassword.Text = null;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }

        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtNama.Text.Length >= 20 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtUsername.Text.Length >= 20 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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

        private void txtAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAlamat.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
