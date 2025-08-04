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

namespace Project3.Master.Metode_Pembayaran
{
    public partial class MetodePembayaran : Form
    {
        private string userAccess;
        private DBConnect connection = new DBConnect();

        private int currentPage = 1;
        private int pageSize = 8;
        private DataTable allData;
        private bool kolomGambarSudahDitambahkan = false;
        int mpb_id = 0;
        int status = 1; // Default: hanya tampilkan yang aktif

        public MetodePembayaran(string userAccess)
        {
            InitializeComponent();
            this.userAccess = userAccess;
        }

        private void MetodePembayaran_Load(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = -1;
            LoadAllData();
            LoadPage();
        }
        public void LoadAllData()
        {
            status = 1;
            allData = connection.GetListMetodePembayaran(null, 1, "mpb_id", "ASC");
        }

        public void LoadPage()
        {
            if (allData == null || allData.Rows.Count == 0)
            {
                dgvMetodePmb.DataSource = null;
                lblPageInfo.Text = "0";
                return;
            }

            var rows = allData.AsEnumerable()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize);

            DataTable dt = rows.Any() ? rows.CopyToDataTable() : allData.Clone();
            dgvMetodePmb.DataSource = dt;

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
                dgvMetodePmb.Columns.Add(imgUpdate);

                DataGridViewImageColumn imgDelete = new DataGridViewImageColumn
                {
                    Name = "imgDelete",
                    HeaderText = "",
                    Image = Properties.Resources.delete_icon,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvMetodePmb.Columns.Add(imgDelete);
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
                dgvMetodePmb.Columns.Add(imgRestore);
                kolomGambarSudahDitambahkan = true;
            }
        }

        private void FormatGrid()
        {
            // Sembunyikan kolom-kolom
            string[] hiddenColumns =
            {
            "No", "mpb_id", "mpb_created_by", "mpb_created_date",
            "mpb_status", "mpb_modif_date", "mpb_modif_by"
            };

            foreach (string col in hiddenColumns)
            {
                if (dgvMetodePmb.Columns.Contains(col))
                    dgvMetodePmb.Columns[col].Visible = false;
            }

            // Ganti header kolom nama
            if (dgvMetodePmb.Columns.Contains("mpb_nama"))
                dgvMetodePmb.Columns["mpb_nama"].HeaderText = "Nama";

            // Tombol Edit
            if (dgvMetodePmb.Columns.Contains("imgUpdate"))
            {
                dgvMetodePmb.Columns["imgUpdate"].Width = 50;
                dgvMetodePmb.Columns["imgUpdate"].DisplayIndex = dgvMetodePmb.Columns.Count - 2;
            }

            // Tombol Delete
            if (dgvMetodePmb.Columns.Contains("imgDelete"))
            {
                dgvMetodePmb.Columns["imgDelete"].Width = 50;
                dgvMetodePmb.Columns["imgDelete"].DisplayIndex = dgvMetodePmb.Columns.Count - 1;
            }

            // Tombol Restore
            if (dgvMetodePmb.Columns.Contains("imgRestore"))
            {
                dgvMetodePmb.Columns["imgRestore"].Width = 50;
                dgvMetodePmb.Columns["imgRestore"].DisplayIndex = dgvMetodePmb.Columns.Count - 1;
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

            string filterColumn = "mpb_nama";
            switch (cbFilter.SelectedItem?.ToString())
            {
                case "Nama": filterColumn = "mpb_nama"; break;

            }

            string sortOrder = "ASC";
            string sortText = cbSort.SelectedItem?.ToString();
            if (sortText != null)
            {
                if (sortText.Contains("Turun")) sortOrder = "DESC";
                else if (sortText.Contains("Naik")) sortOrder = "ASC";
            }

            currentPage = 1;
            allData = connection.GetListMetodePembayaran(search, status, filterColumn, sortOrder);

            // reset dulu kolom tombol
            kolomGambarSudahDitambahkan = false;
            dgvMetodePmb.Columns.Clear();

            LoadPage();
        }


        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            allData = connection.GetListMetodePembayaran(txtCari.Text, 1, "mpb_id", "ASC");
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

        private void dgvMetodePembayaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= dgvMetodePmb.Rows.Count || e.ColumnIndex >= dgvMetodePmb.Columns.Count) return;

            string columnName = dgvMetodePmb.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvMetodePmb.Rows[e.RowIndex];

            if (columnName == "imgUpdate")
            {
                mpb_id = Convert.ToInt32(row.Cells["mpb_id"].Value);
                txtNama.Text = row.Cells["mpb_nama"].Value.ToString();
            }

            if (columnName == "imgDelete")
            {
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    mpb_id = Convert.ToInt32(row.Cells["mpb_id"].Value);
                    connection.SetStatusMetodePembayaran(mpb_id, userAccess);
                    LoadAllData();
                    LoadPage();
                }
            }

            if (columnName == "imgRestore")
            {
                int id = Convert.ToInt32(row.Cells["mpb_id"].Value);
                DialogResult result = MessageBox.Show("Aktifkan kembali data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    connection.SetStatusMetodePembayaran(id, userAccess); // panggil SP restore
                    ReloadFilteredData(); // otomatis refresh data & tombol restore/edit
                    LoadPage(); // tampilkan halaman sesuai
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            mpb_id = 0;
            txtNama.Text = "";
        }

        public MetodePembayaran parentForm;

        public void setParentForm(MetodePembayaran form)
        {
            parentForm = form;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Data tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                String nama = txtNama.Text;

                if (mpb_id != 0 && connection.isMetodePembayaranExist(mpb_id))
                {
                    connection.UpdateMetodePembayaran(mpb_id, nama, userAccess);

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
                    connection.InsertMetodePembayaran(nama, userAccess);

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
        }


        private void Clear()
        {
            txtNama.Text = "";
            mpb_id = 0;
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

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            cbSort.SelectedIndex = -1;
            cbFilter.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1; // Kembali ke default: Aktif
            status = 1;

            ReloadFilteredData();
            LoadAllData();
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
    }
}

