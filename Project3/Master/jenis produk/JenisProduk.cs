using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;
using Project3.Database;
using Project3.Master.Karyawan;

namespace Project3.Master.JenisProduk
{
    public partial class JenisProduk : Form
    {
        private string userAccess;
        private DBConnect connection = new DBConnect();

        private int currentPage = 1;
        private int pageSize = 8;
        private DataTable allData;
        private bool kolomGambarSudahDitambahkan = false;
        int jp_id = 0;
        int status = 1; // Default: hanya tampilkan yang aktif


        public JenisProduk(string userAccess)
        {
            InitializeComponent();
            this.userAccess = userAccess;
        }

        private void JenisProduk_Load(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = -1;
            LoadAllData();
            LoadPage();
        }

        public void LoadAllData()
        {
            status = 1;
            allData = connection.GetListJenisProduk(null, 1, "jp_id", "ASC");
        }

        public void LoadPage()
        {
            if (allData == null || allData.Rows.Count == 0)
            {
                dgvJenisProduk.DataSource = null;
                lblPageInfo.Text = "0";
                return;
            }

            var rows = allData.AsEnumerable()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize);

            DataTable dt = rows.Any() ? rows.CopyToDataTable() : allData.Clone();
            dgvJenisProduk.DataSource = dt;

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
                dgvJenisProduk.Columns.Add(imgUpdate);

                DataGridViewImageColumn imgDelete = new DataGridViewImageColumn
                {
                    Name = "imgDelete",
                    HeaderText = "",
                    Image = Properties.Resources.delete_icon,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvJenisProduk.Columns.Add(imgDelete);
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
                dgvJenisProduk.Columns.Add(imgRestore);
                kolomGambarSudahDitambahkan = true;
            }
        }

        private void FormatGrid()
        {
            // Sembunyikan kolom-kolom
            string[] hiddenColumns =
            { "No","jp_id","jp_created_by","jp_created_date",
                "jp_status","jp_modif_date","jp_modif_by"};

            foreach (string col in hiddenColumns)
            {
                if (dgvJenisProduk.Columns.Contains(col))
                    dgvJenisProduk.Columns[col].Visible = false;
            }

            // Ganti header kolom nama
            if (dgvJenisProduk.Columns.Contains("jp_nama"))
                dgvJenisProduk.Columns["jp_nama"].HeaderText = "Nama";

            // Tombol Edit
            if (dgvJenisProduk.Columns.Contains("imgUpdate"))
            {
                dgvJenisProduk.Columns["imgUpdate"].Width = 50;
                dgvJenisProduk.Columns["imgUpdate"].DisplayIndex = dgvJenisProduk.Columns.Count - 2;
            }

            // Tombol Delete
            if (dgvJenisProduk.Columns.Contains("imgDelete"))
            {
                dgvJenisProduk.Columns["imgDelete"].Width = 50;
                dgvJenisProduk.Columns["imgDelete"].DisplayIndex = dgvJenisProduk.Columns.Count - 1;
            }
            // Restore
            if (dgvJenisProduk.Columns.Contains("imgRestore"))
            {
                dgvJenisProduk.Columns["imgRestore"].Width = 50;
                dgvJenisProduk.Columns["imgRestore"].DisplayIndex = dgvJenisProduk.Columns.Count - 1;
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

            string filterColumn = "jp_nama";
            switch (cbFilter.SelectedItem?.ToString())
            {
                case "Nama": filterColumn = "jp_nama"; break;

            }

            string sortOrder = "ASC";
            string sortText = cbSort.SelectedItem?.ToString();
            if (sortText != null)
            {
                if (sortText.Contains("Turun")) sortOrder = "DESC";
                else if (sortText.Contains("Naik")) sortOrder = "ASC";
            }

            currentPage = 1;
            allData = connection.GetListJenisProduk(search, status, filterColumn, sortOrder);

            // reset dulu kolom tombol
            kolomGambarSudahDitambahkan = false;
            dgvJenisProduk.Columns.Clear();

            LoadPage();
        }


        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            allData = connection.GetListJenisProduk(txtCari.Text, 1, "jp_id", "ASC");
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

        private void dgvJenisProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= dgvJenisProduk.Rows.Count || e.ColumnIndex >= dgvJenisProduk.Columns.Count) return;

            string columnName = dgvJenisProduk.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvJenisProduk.Rows[e.RowIndex];

            if (columnName == "imgUpdate")
            {
                jp_id = Convert.ToInt32(row.Cells["jp_id"].Value);
                txtNama.Text = row.Cells["jp_nama"].Value.ToString();
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
                    jp_id = Convert.ToInt32(row.Cells["jp_id"].Value);
                    connection.SetStatusJenisProduk(jp_id, userAccess);
                    LoadAllData();
                    LoadPage();
                }
            }

            if (columnName == "imgRestore")
            {
                int p_id = Convert.ToInt32(row.Cells["jp_id"].Value);
                DialogResult result = MessageBox.Show("Aktifkan kembali data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    connection.SetStatusJenisProduk(p_id, userAccess); // panggil SP restore/ubah status
                    ReloadFilteredData(); // sudah otomatis panggil GetList + refresh tombol restore/edit
                    LoadPage(); // tampilkan halaman pertama/terakhir yang sesuai
                }
            }
        }


        private void btnBatal_Click(object sender, EventArgs e)
        {
            jp_id = 0;
            txtNama.Text = "";
        }

        public JenisProduk parentForm;

        public void setParentForm(JenisProduk form)
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

                if (jp_id != 0 && connection.isJenisProdukExist(jp_id))
                {
                    connection.UpdateJenisProduk(jp_id, nama, userAccess);

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
                    connection.InsertJenisProduk(nama, userAccess);

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
            jp_id = 0; 
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

        private void btnSortFilter_Click_1(object sender, EventArgs e)
        {
            panelShort.Visible = !panelShort.Visible;

        }
    }
}
