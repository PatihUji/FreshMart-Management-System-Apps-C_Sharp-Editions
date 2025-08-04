using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project3.Database;

namespace Project3.Master.Promo
{
    public partial class Promo : Form
    {
        private string userAccess;
        private DBConnect connection = new DBConnect();

        private int currentPage = 1;
        private int pageSize = 8;
        private DataTable allData;
        private bool kolomGambarSudahDitambahkan = false;
        private int pr_id = 0;
        int status = 1; // Default: hanya tampilkan yang aktif

        public Promo(string userAccess)
        {
            InitializeComponent();
            this.userAccess = userAccess;
            dgvPromo.CellFormatting += dgvPromo_CellFormatting;
        }

        private void Promo_Load(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = -1;
            LoadAllData();
            LoadPage();
            TanggalMulai.Format = DateTimePickerFormat.Custom;
            TanggalMulai.CustomFormat = " ";
            TanggalSelesai.Format = DateTimePickerFormat.Custom;
            TanggalSelesai.CustomFormat = " ";

            // Batas maksimal karakter untuk nama promo
            txtNama.MaxLength = 50;
        }
        public void LoadAllData()
        {
            status = 1;
            allData = connection.GetListPromo(null, 1, "pr_id", "ASC");
        }
        public void LoadPage()
        {
            if (allData == null || allData.Rows.Count == 0)
            {
                dgvPromo.DataSource = null;
                lblPageInfo.Text = "0";
                return;
            }

            var rows = allData.AsEnumerable()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize);

            DataTable dt = rows.Any() ? rows.CopyToDataTable() : allData.Clone();
            dgvPromo.DataSource = dt;

            addButton();

            FormatGrid();
            lblPageInfo.Text = $"{currentPage}";
        }

        private void addButton()
        {
            if (kolomGambarSudahDitambahkan) return;

            string statusText = cbStatus.SelectedItem?.ToString();
            if (statusText == "Tidak Aktif")
                status = 0;
            else if (statusText == "Aktif")
                status = 1;

            if (status == 1)
            {
                DataGridViewImageColumn imgUpdate = new DataGridViewImageColumn
                {
                    Name = "imgUpdate",
                    HeaderText = "",
                    Image = Properties.Resources.edit_icon,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvPromo.Columns.Add(imgUpdate);

                DataGridViewImageColumn imgDelete = new DataGridViewImageColumn
                {
                    Name = "imgDelete",
                    HeaderText = "",
                    Image = Properties.Resources.delete_icon,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvPromo.Columns.Add(imgDelete);
                kolomGambarSudahDitambahkan = true;
            }
            else
            {
                DataGridViewImageColumn imgRestore = new DataGridViewImageColumn
                {
                    Name = "imgRestore",
                    HeaderText = "",
                    Image = Properties.Resources.restore_icon, // pastikan icon ini ada di Resources
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvPromo.Columns.Add(imgRestore);
                kolomGambarSudahDitambahkan = true;
            }
        }

        private void FormatGrid()
        {
            // Sembunyikan kolom yang tidak perlu ditampilkan
            string[] hiddenColumns =
            {
             "No", "pr_id", "pr_status",
             "pr_created_date", "pr_created_by",
             "pr_modif_date", "pr_modif_by"
    };

            foreach (string col in hiddenColumns)
            {
                if (dgvPromo.Columns.Contains(col))
                    dgvPromo.Columns[col].Visible = false;
            }

            // Ubah nama header kolom
            if (dgvPromo.Columns.Contains("pr_nama"))
                dgvPromo.Columns["pr_nama"].HeaderText = "Nama";

            if (dgvPromo.Columns.Contains("pr_persentase"))
                dgvPromo.Columns["pr_persentase"].HeaderText = "Persentase";

            if (dgvPromo.Columns.Contains("pr_tanggal_mulai"))
                dgvPromo.Columns["pr_tanggal_mulai"].HeaderText = "Tanggal Mulai";

            if (dgvPromo.Columns.Contains("pr_tanggal_berakhir"))
                dgvPromo.Columns["pr_tanggal_berakhir"].HeaderText = "Tanggal Berakhir";

            // Atur tombol Edit
            if (dgvPromo.Columns.Contains("imgUpdate"))
            {
                dgvPromo.Columns["imgUpdate"].Width = 50;
                dgvPromo.Columns["imgUpdate"].DisplayIndex = dgvPromo.Columns.Count - 2;
            }

            // Atur tombol Hapus
            if (dgvPromo.Columns.Contains("imgDelete"))
            {
                dgvPromo.Columns["imgDelete"].Width = 50;
                dgvPromo.Columns["imgDelete"].DisplayIndex = dgvPromo.Columns.Count - 1;
            }

            // Atur tombol Restore jika ada
            if (dgvPromo.Columns.Contains("imgRestore"))
            {
                dgvPromo.Columns["imgRestore"].Width = 50;
                dgvPromo.Columns["imgRestore"].DisplayIndex = dgvPromo.Columns.Count - 1;
            }
        }

        private void ReloadFilteredData()
        {
            string search = txtCari.Text;
            //int? status = 1; // Default: hanya tampilkan yang aktif

            string statusText = cbStatus.SelectedItem?.ToString();
            if (statusText == "Tidak Aktif")
                status = 0;
            else if (statusText == "Aktif")
                status = 1;

            string filterColumn = "pr_nama";
            switch (cbFilter.SelectedItem?.ToString())
            {
                case "Nama": filterColumn = "pr_nama"; break;

            }

            string sortOrder = "ASC";
            string sortText = cbSort.SelectedItem?.ToString();
            if (sortText != null)
            {
                if (sortText.Contains("Turun")) sortOrder = "DESC";
                else if (sortText.Contains("Naik")) sortOrder = "ASC";
            }

            currentPage = 1;
            allData = connection.GetListPromo(search, status, filterColumn, sortOrder);

            // reset dulu kolom tombol
            kolomGambarSudahDitambahkan = false;
            dgvPromo.Columns.Clear();

            LoadPage();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            allData = connection.GetListPromo(txtCari.Text, 1, "pr_nama", "ASC");
            LoadPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPage = (int)Math.Ceiling((double)allData.Rows.Count / pageSize);
            if (currentPage < totalPage)
            {
                currentPage++;
                LoadPage();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
            }
        }

        private void dgvPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= dgvPromo.Rows.Count || e.ColumnIndex >= dgvPromo.Columns.Count) return;

            string columnName = dgvPromo.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvPromo.Rows[e.RowIndex];

            if (columnName == "imgUpdate")
            {
                pr_id = Convert.ToInt32(row.Cells["pr_id"].Value);
                txtNama.Text = row.Cells["pr_nama"].Value.ToString();
                txtPersentase.Text = row.Cells["pr_persentase"].Value.ToString().Replace(" %", "");

                if (!DateTime.TryParse(row.Cells["pr_tanggal_mulai"].Value?.ToString(), out DateTime tglMulai))
                    tglMulai = DateTime.Now;
                if (!DateTime.TryParse(row.Cells["pr_tanggal_berakhir"].Value?.ToString(), out DateTime tglSelesai))
                    tglSelesai = DateTime.Now;

                TanggalMulai.Value = tglMulai;
                TanggalMulai.CustomFormat = "dd/MM/yyyy";

                TanggalSelesai.Value = tglSelesai;
                TanggalSelesai.CustomFormat = "dd/MM/yyyy";
            }

            if (columnName == "imgDelete")
            {
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus data promo ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    pr_id = Convert.ToInt32(row.Cells["pr_id"].Value);
                    connection.SetStatusPromo(pr_id, userAccess); // method soft delete
                    LoadAllData();
                    LoadPage();
                }
            }

            if (columnName == "imgRestore")
            {
                int idPromo = Convert.ToInt32(row.Cells["pr_id"].Value);
                DialogResult result = MessageBox.Show("Aktifkan kembali data promo ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    connection.SetStatusPromo(idPromo, userAccess); // aktifkan kembali promo
                    ReloadFilteredData();
                    LoadPage();
                }
            }
        }



        private void btnBatal_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public Promo parentForm;

        public void setParentForm(Promo form)
        {
            parentForm = form;
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi field kosong
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtPersentase.Text) ||
                TanggalMulai.Value == DateTime.MinValue ||
                TanggalSelesai.Value == DateTime.MinValue)
            {
                MessageBox.Show("Semua field harus diisi, termasuk Tanggal Mulai dan Tanggal Selesai.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string nama = txtNama.Text.Trim();
            //mengubah (parse) persenText (string) menjadi angka decimal, lalu disimpan ke variabel persen.
            string persenText = txtPersentase.Text.Trim();
            decimal persen;

            // Validasi panjang nama
            if (nama.Length > 50)
            {
                MessageBox.Show("Nama promo tidak boleh lebih dari 50 karakter.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validasi persentase angka
            if (!decimal.TryParse(persenText, out persen))
            {
                MessageBox.Show("Persentase harus berupa angka.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validasi range persentase
            if (persen <= 0)
            {
                MessageBox.Show("Persentase tidak boleh kurang dari atau sama dengan 0.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (persen > 100)
            {
                MessageBox.Show("Persentase tidak boleh lebih dari 100%.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Proses simpan (tidak diubah)
            if (pr_id != 0 && connection.isPromoExist(pr_id))
            {
                connection.UpdatePromo(pr_id, nama, persen, TanggalMulai.Value, TanggalSelesai.Value, userAccess);

                if (parentForm != null)
                {
                    parentForm.LoadAllData();
                    parentForm.LoadPage();
                }
                else
                {
                    LoadAllData();
                    LoadPage();
                }

                Clear();
            }
            else
            {
                connection.InsertPromo(nama, persen, TanggalMulai.Value, TanggalSelesai.Value, userAccess);

                if (parentForm != null)
                {
                    parentForm.LoadAllData();
                    parentForm.LoadPage();
                }
                else
                {
                    LoadAllData();
                    LoadPage();
                }

                Clear();
            }
        }

        private void Clear()
        {
            pr_id = 0;
            txtNama.Text = "";
            txtPersentase.Text = "";
            TanggalMulai.CustomFormat = " ";
            TanggalSelesai.CustomFormat = " ";
        }

        public void setForm(String txtNama)
        {
            this.txtNama.Text = txtNama;
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya izinkan huruf (A-Z, a-z) dan spasi
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Blokir input
            }
        }

        private void dgvPromo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPromo.Columns[e.ColumnIndex].Name == "pr_persentase" && e.Value != null && e.Value != DBNull.Value)
            {
                decimal persen;
                if (decimal.TryParse(e.Value.ToString(), out persen))
                {
                    e.Value = persen.ToString("0") + " %";
                    e.FormattingApplied = true;
                }
            }
        }

        private void TanggalMulai_ValueChanged(object sender, EventArgs e)
        {
            TanggalMulai.CustomFormat = "dd/MM/yyyy";

            DateTime tanggalMulai = TanggalMulai.Value.Date;
            DateTime tanggalBerakhir = TanggalSelesai.Value.Date;
            DateTime today = DateTime.Today;

            // Cegah tanggal mulai di masa lalu
            if (tanggalMulai < today)
            {
                MessageBox.Show(this, "Tanggal mulai promo tidak boleh sebelum hari ini!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TanggalMulai.Value = today;
                return;
            }

            // Hanya validasi jika user sudah isi TanggalSelesai (bukan default today)
            if (TanggalSelesai.Focused && tanggalMulai > tanggalBerakhir)
            {
                MessageBox.Show(this, "Tanggal mulai promo tidak boleh setelah tanggal berakhir!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TanggalMulai.Value = tanggalBerakhir;
            }
        }

        private void TanggalSelesai_ValueChanged(object sender, EventArgs e)
        {
            TanggalSelesai.CustomFormat = "dd/MM/yyyy";

            DateTime tanggalMulai = TanggalMulai.Value.Date;
            DateTime tanggalBerakhir = TanggalSelesai.Value.Date;
            DateTime today = DateTime.Today;

            // Cegah tanggal berakhir di masa lalu
            if (tanggalBerakhir < today)
            {
                MessageBox.Show(this, "Tanggal berakhir promo tidak boleh sebelum hari ini!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TanggalSelesai.Value = today;
                return;
            }

            // Validasi hanya jika tanggal mulai sudah diisi
            if (TanggalMulai.Focused && tanggalBerakhir < tanggalMulai)
            {
                MessageBox.Show(this, "Tanggal berakhir promo tidak boleh sebelum tanggal mulai!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TanggalSelesai.Value = tanggalMulai;
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadFilteredData();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadFilteredData();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadFilteredData();
        }

        private void btnSortFilter_Click(object sender, EventArgs e)
        {
            panelShort.Visible = !panelShort.Visible;
        }

        private void btnBersihkan_Click_1(object sender, EventArgs e)
        {
            // Reset semua ComboBox filter & status
            cbSort.SelectedIndex = -1;
            cbFilter.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;

            // Reset status ke default (misalnya 1 = aktif)
            status = 1;

            // Reset tanggal mulai dan tanggal selesai ke hari ini
            TanggalMulai.Value = DateTime.Today;
            TanggalMulai.CustomFormat = "dd/MM/yyyy";

            TanggalSelesai.Value = DateTime.Today;
            TanggalSelesai.CustomFormat = "dd/MM/yyyy";

            // Muat ulang data
            ReloadFilteredData();
            LoadAllData();
        }

        private void txtNama_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Hanya izinkan huruf (A-Z, a-z) dan spasi
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Blokir input
            }
        }

        private void txtPersentase_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Izinkan hanya angka dan tombol kontrol seperti Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Blokir input selain angka
            }

            // Batasi maksimal 3 digit
            if (char.IsDigit(e.KeyChar) && txtPersentase.Text.Length >= 3 && txtPersentase.SelectionLength == 0)
            {
                e.Handled = true;
            }

        }
    }
}
