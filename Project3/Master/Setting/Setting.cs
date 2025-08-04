using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Project3.Database;
using Project3.Master.Karyawan;
using Project3.Master.Produk;

namespace Project3.Master.Setting
{
    public partial class Setting : Form
    {
        private string userAccess;
        private DBConnect connection = new DBConnect();

        private int currentPage = 1;
        private int pageSize = 8;
        private DataTable allData;
        private bool kolomGambarSudahDitambahkan = false;
        int s_id = 0;
        int status = 1; // Default: hanya tampilkan yang aktif


        public Setting(string userAccess)
        {
            InitializeComponent();
            this.userAccess = userAccess;
        }
        
        private void Setting_Load(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = -1;
            LoadAllData();
            LoadPage();

        }

        public void LoadAllData()
        {
            status = 1;
            allData = connection.GetListSetting(null, 1, "s_id", "ASC");
        }

        public void LoadPage()
        {
            if (allData == null || allData.Rows.Count == 0)
            {
                dgvSetting.DataSource = null;
                lblPageInfo.Text = "0";
                return;
            }

            var rows = allData.AsEnumerable()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize);

            DataTable dt = rows.Any() ? rows.CopyToDataTable() : allData.Clone();
            dgvSetting.DataSource = dt;
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
                dgvSetting.Columns.Add(imgUpdate);

                DataGridViewImageColumn imgDelete = new DataGridViewImageColumn
                {
                    Name = "imgDelete",
                    HeaderText = "",
                    Image = Properties.Resources.delete_icon,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvSetting.Columns.Add(imgDelete);
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
                dgvSetting.Columns.Add(imgRestore);
                kolomGambarSudahDitambahkan = true;
            }
        }

        private void FormatGrid()
        {
            string[] hiddenColumns = { "No", "s_id", "s_status", "s_created_date",
                "s_created_by", "s_modif_date", "s_modif_by" };

            foreach (string col in hiddenColumns)
            {
                if (dgvSetting.Columns.Contains(col))
                    dgvSetting.Columns[col].Visible = false;
            }

            if (dgvSetting.Columns.Contains("s_nama"))
                dgvSetting.Columns["s_nama"].HeaderText = "Nama";

            if (dgvSetting.Columns.Contains("s_kategori"))
                dgvSetting.Columns["s_kategori"].HeaderText = "Kategori";

            if (dgvSetting.Columns.Contains("imgUpdate"))
            {
                dgvSetting.Columns["imgUpdate"].Width = 50;
                dgvSetting.Columns["imgUpdate"].DisplayIndex = dgvSetting.Columns.Count - 2;
            }

            if (dgvSetting.Columns.Contains("imgDelete"))
            {
                dgvSetting.Columns["imgDelete"].Width = 50;
                dgvSetting.Columns["imgDelete"].DisplayIndex = dgvSetting.Columns.Count - 1;
            }

            if (dgvSetting.Columns.Contains("imgRestore"))
            {
                dgvSetting.Columns["imgRestore"].Width = 50;
                dgvSetting.Columns["imgRestore"].DisplayIndex = dgvSetting.Columns.Count - 1;
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

            string filterColumn = "s_nama";
            switch (cbFilter.SelectedItem?.ToString())
            {
                case "Nama": filterColumn = "s_nama"; break;
                case "Kategori": filterColumn = "s_kategori"; break;
                
            }

            string sortOrder = "ASC";
            string sortText = cbSort.SelectedItem?.ToString();
            if (sortText != null)
            {
                if (sortText.Contains("Turun")) sortOrder = "DESC";
                else if (sortText.Contains("Naik")) sortOrder = "ASC";
            }

            currentPage = 1;
            allData = connection.GetListSetting(search, status, filterColumn, sortOrder);

            // reset dulu kolom tombol
            kolomGambarSudahDitambahkan = false;
            dgvSetting.Columns.Clear();


            LoadPage();
        }


        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            allData = connection.GetListSetting(txtCari.Text, 1, "s_id", "ASC");
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

        private void dgvSetting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= dgvSetting.Rows.Count || e.ColumnIndex >= dgvSetting.Columns.Count) return;

            string columnName = dgvSetting.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvSetting.Rows[e.RowIndex];

            if (columnName == "imgUpdate")
            {
                s_id = Convert.ToInt32(row.Cells["s_id"].Value);
                txtNama.Text = row.Cells["s_nama"].Value.ToString();
                cbKategori.Text = row.Cells["s_kategori"].Value.ToString();
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
                        s_id = Convert.ToInt32(row.Cells["s_id"].Value);
                        connection.setStatusSetting(s_id, userAccess);
                        LoadAllData();
                        LoadPage();
                    }
               }

                if (columnName == "imgRestore")
                {
                    int p_id = Convert.ToInt32(row.Cells["s_id"].Value);
                    DialogResult result = MessageBox.Show("Aktifkan kembali data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        connection.setStatusSetting(p_id, userAccess); // panggil SP restore/ubah status
                        ReloadFilteredData(); // sudah otomatis panggil GetList + refresh tombol restore/edit
                        LoadPage(); // tampilkan halaman pertama/terakhir yang sesuai
                    }
                }
            }
        
        private void btnBatal_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            s_id = 0;
            txtNama.Text = "";
            cbKategori.SelectedIndex = -1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi wajib isi
            if (String.IsNullOrWhiteSpace(txtNama.Text) || cbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Nama dan Kategori tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nama = txtNama.Text.Trim();
                string kategori = cbKategori.Text.Trim();

                if (s_id != 0 && connection.isSettingExist(s_id))
                {
                    // Update
                    connection.UpdateSetting(s_id, nama, kategori, userAccess);
                    LoadAllData();
                    LoadPage();
                    Clear();
                }
                else
                {
                    // Insert
                    connection.InsertSetting(nama, kategori, userAccess);
                    LoadAllData();
                    LoadPage();
                    Clear();
                }
            }
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

        private void btnSortFilter_Click(object sender, EventArgs e)
        {
            panelShort.Visible = !panelShort.Visible;
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
    }

}
