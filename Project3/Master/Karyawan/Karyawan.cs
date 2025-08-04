using Project3.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project3.Master.Karyawan
{
    public partial class Karyawan : Form
    {
        private string userAccess;
        private DBConnect connection = new DBConnect();

        private int currentPage = 1;
        private int pageSize = 8;
        private DataTable allData;
        private bool kolomGambarSudahDitambahkan = false;
        int kry_id = 0;
        int status = 1; // Default: hanya tampilkan yang aktif

        public Karyawan(string userAccess)
        {
            InitializeComponent();
            this.userAccess = userAccess;
        }

        private void Karyawan_Load(object sender, EventArgs e)
        {
            formKaryawan.setUserAccess(userAccess);
            formKaryawan.setParentForm(this);

            cbStatus.SelectedIndex = -1;
            LoadAllData();
            LoadPage();

            cbFilter.Items.AddRange(new string[] { "Jabatan", "Jenis Kelamin", "Alamat" });
        }

        public void LoadAllData()
        {
            status = 1;
            allData = connection.GetListKaryawan(null, 1, "kry_nama", "ASC");
        }

        public void LoadPage()
        {
            if (allData == null || allData.Rows.Count == 0)
            {
                dgvKaryawan.DataSource = null;
                lblPageInfo.Text = "0";
                return;
            }

            var rows = allData.AsEnumerable()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize);

            DataTable dt = rows.Any() ? rows.CopyToDataTable() : allData.Clone();
            dgvKaryawan.DataSource = dt;

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
                dgvKaryawan.Columns.Add(imgUpdate);

                DataGridViewImageColumn imgDelete = new DataGridViewImageColumn
                {
                    Name = "imgDelete",
                    HeaderText = "",
                    Image = Properties.Resources.delete_icon,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvKaryawan.Columns.Add(imgDelete);
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
                dgvKaryawan.Columns.Add(imgRestore);
                kolomGambarSudahDitambahkan = true;
            }
        }

        private void FormatGrid()
        {
            // Sembunyikan kolom-kolom yang tidak perlu ditampilkan
            string[] hiddenColumns = {
            "No", "kry_id", "s_id", "kry_username", "kry_password",
            "kry_status", "kry_created_date", "kry_created_by",
            "kry_modif_date", "kry_modif_by"
    };

            foreach (string col in hiddenColumns)
            {
                if (dgvKaryawan.Columns.Contains(col))
                    dgvKaryawan.Columns[col].Visible = false;
            }

            // Ganti header kolom yang ditampilkan
            if (dgvKaryawan.Columns.Contains("kry_nama"))
                dgvKaryawan.Columns["kry_nama"].HeaderText = "Nama";

            if (dgvKaryawan.Columns.Contains("s_nama"))
                dgvKaryawan.Columns["s_nama"].HeaderText = "Jabatan";

            if (dgvKaryawan.Columns.Contains("kry_tgl_lahir"))
                dgvKaryawan.Columns["kry_tgl_lahir"].HeaderText = "Tanggal Lahir";

            if (dgvKaryawan.Columns.Contains("kry_alamat"))
                dgvKaryawan.Columns["kry_alamat"].HeaderText = "Alamat";

            if (dgvKaryawan.Columns.Contains("kry_gender"))
                dgvKaryawan.Columns["kry_gender"].HeaderText = "Jenis Kelamin";

            // Tombol Edit
            if (dgvKaryawan.Columns.Contains("imgUpdate"))
            {
                dgvKaryawan.Columns["imgUpdate"].Width = 50;
                dgvKaryawan.Columns["imgUpdate"].DisplayIndex = dgvKaryawan.Columns.Count - 2;
            }

            // Tombol Delete
            if (dgvKaryawan.Columns.Contains("imgDelete"))
            {
                dgvKaryawan.Columns["imgDelete"].Width = 50;
                dgvKaryawan.Columns["imgDelete"].DisplayIndex = dgvKaryawan.Columns.Count - 1;
            }

            // Tombol Restore (jika ada)
            if (dgvKaryawan.Columns.Contains("imgRestore"))
            {
                dgvKaryawan.Columns["imgRestore"].Width = 50;
                dgvKaryawan.Columns["imgRestore"].DisplayIndex = dgvKaryawan.Columns.Count - 1;
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

            string filterColumn = "kry_nama";
            switch (cbFilter.SelectedItem?.ToString())
            {
                case "Nama":
                    filterColumn = "kry_nama";
                    break;
                case "Jabatan":
                    filterColumn = "s_nama";
                    break;
                case "Jenis Kelamin":
                    filterColumn = "kry_gender";
                    break;
                case "Alamat":
                    filterColumn = "kry_alamat";
                    break;
            }


            string sortOrder = "ASC";
            string sortText = cbSort.SelectedItem?.ToString();
            if (sortText != null)
            {
                if (sortText.Contains("Turun")) sortOrder = "DESC";
                else if (sortText.Contains("Naik")) sortOrder = "ASC";
            }

            currentPage = 1;
            allData = connection.GetListKaryawan(search, status, filterColumn, sortOrder);

            // reset dulu kolom tombol
            kolomGambarSudahDitambahkan = false;
            dgvKaryawan.Columns.Clear();

            LoadPage();
        }

        private void dgvKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= dgvKaryawan.Rows.Count || e.ColumnIndex >= dgvKaryawan.Columns.Count) return;

            string columnName = dgvKaryawan.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvKaryawan.Rows[e.RowIndex];

            if (columnName == "imgUpdate")
            {
                if (!DateTime.TryParse(row.Cells["kry_tgl_lahir"].Value?.ToString(), out DateTime tglLahir))
                    tglLahir = DateTime.Now;

                formKaryawan.setForm(
                    Convert.ToInt32(row.Cells["kry_id"].Value),
                    row.Cells["kry_nama"].Value.ToString(),
                    row.Cells["kry_username"].Value.ToString(),
                    row.Cells["kry_alamat"].Value.ToString(),
                    Convert.ToInt32(row.Cells["s_id"].Value),
                    row.Cells["kry_gender"].Value.ToString(),
                    tglLahir
                );
            }

            if (columnName == "imgDelete")
            {
                int kry_id = Convert.ToInt32(row.Cells["kry_id"].Value);
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    connection.SetStatusKaryawan(kry_id, userAccess);
                    LoadAllData();
                    LoadPage();
                }
            }

            if (columnName == "imgRestore")
            {
                int kry_id = Convert.ToInt32(row.Cells["kry_id"].Value);
                DialogResult result = MessageBox.Show(
                    "Aktifkan kembali data ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    connection.SetStatusKaryawan(kry_id, userAccess); // metode restore karyawan
                    ReloadFilteredData();
                    LoadPage();
                }
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            allData = connection.GetListKaryawan(txtCari.Text, 1, "kry_nama", "ASC");
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
