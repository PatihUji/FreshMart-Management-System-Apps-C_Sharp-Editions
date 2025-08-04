using Project3.Database;
using Project3.Master.Karyawan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3.Master.Produk
{
    public partial class Produk : Form
    {
        private string userAccess;
        private DBConnect connection = new DBConnect();

        private int currentPage = 1;
        private int pageSize = 8;
        private DataTable allData;
        private bool kolomGambarSudahDitambahkan = false;

        public Produk(String userAccess)
        {
            InitializeComponent();
            this.userAccess = userAccess;
        }

        public void LoadAllData()
        {
            status = 1;
            allData = connection.GetListProduk(null, 1, "p_nama", "ASC");
        }

        public void LoadPage()
        {
            if (allData == null || allData.Rows.Count == 0)
            {
                dgvProduk.DataSource = null;
                lblPageInfo.Text = "0";
                return;
            }

            var rows = allData.AsEnumerable()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize);

            DataTable dt = rows.Any() ? rows.CopyToDataTable() : allData.Clone();
            dgvProduk.DataSource = dt;

            addButton();
            FormatGrid();

            lblPageInfo.Text = $"{currentPage}";
        }

        private void FormatGrid()
        {
            string[] hiddenCols = {
                "No", "p_id", "jp_id", "p_gambar", "p_status",
                "p_created_by", "p_created_date", "p_modif_by", "p_modif_date"
            };

            foreach (string col in hiddenCols)
            {
                if (dgvProduk.Columns.Contains(col))
                    dgvProduk.Columns[col].Visible = false;
            }

            if (dgvProduk.Columns.Contains("p_nama"))
                dgvProduk.Columns["p_nama"].HeaderText = "Nama";

            if (dgvProduk.Columns.Contains("jp_nama"))
                dgvProduk.Columns["jp_nama"].HeaderText = "Jenis Produk";

            

            if (dgvProduk.Columns.Contains("p_harga"))
            {
                dgvProduk.Columns["p_harga"].HeaderText = "Harga";
                dgvProduk.Columns["p_harga"].DefaultCellStyle.Format = "C";
                dgvProduk.Columns["p_harga"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
            }
            if (dgvProduk.Columns.Contains("p_satuan"))
                dgvProduk.Columns["p_satuan"].HeaderText = "Satuan";
            if (dgvProduk.Columns.Contains("p_stok"))
                dgvProduk.Columns["p_stok"].HeaderText = "Stok";
            if (dgvProduk.Columns.Contains("p_deskripsi"))
            {
                dgvProduk.Columns["p_deskripsi"].HeaderText = "Deskripsi";
                dgvProduk.Columns["p_deskripsi"].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            }

            if (dgvProduk.Columns.Contains("imgUpdate"))
            {
                dgvProduk.Columns["imgUpdate"].Width = 50;
                dgvProduk.Columns["imgUpdate"].DisplayIndex = dgvProduk.Columns.Count - 2;
            }

            if (dgvProduk.Columns.Contains("imgDelete"))
            {
                dgvProduk.Columns["imgDelete"].Width = 50;
                dgvProduk.Columns["imgDelete"].DisplayIndex = dgvProduk.Columns.Count - 1;
            }

            if (dgvProduk.Columns.Contains("imgShow"))
            {
                dgvProduk.Columns["imgShow"].Width = 50;
                dgvProduk.Columns["imgShow"].DisplayIndex = dgvProduk.Columns.Count - 4;
            }
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
                DataGridViewImageColumn imgShow = new DataGridViewImageColumn
                {
                    Name = "imgShow",
                    HeaderText = "",
                    Image = Properties.Resources.ikon_gambar,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvProduk.Columns.Add(imgShow);

                DataGridViewImageColumn imgUpdate = new DataGridViewImageColumn
                {
                    Name = "imgUpdate",
                    HeaderText = "",
                    Image = Properties.Resources.edit_icon,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvProduk.Columns.Add(imgUpdate);

                DataGridViewImageColumn imgDelete = new DataGridViewImageColumn
                {
                    Name = "imgDelete",
                    HeaderText = "",
                    Image = Properties.Resources.delete_icon,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvProduk.Columns.Add(imgDelete);
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
                dgvProduk.Columns.Add(imgRestore);
                kolomGambarSudahDitambahkan = true;
            }

        }

        //private void addRestoreButton()
        //{
        //    if (kolomGambarSudahDitambahkan) return;

        //    DataGridViewImageColumn imgRestore = new DataGridViewImageColumn
        //    {
        //        Name = "imgRestore",
        //        HeaderText = "",
        //        Image = Properties.Resources.restore_icon, // pastikan icon ini ada di Resources
        //        ImageLayout = DataGridViewImageCellLayout.Zoom,
        //        Width = 50
        //    };
        //    dgvProduk.Columns.Add(imgRestore);

        //    //imgRestore.DisplayIndex = dgvProduk.Columns.Count - 1;

        //    kolomGambarSudahDitambahkan = true;
        //}

        private void Produk_Load(object sender, EventArgs e)
        {
            formProduk.SetUserAccess(userAccess);
            formProduk.setParentForm(this);
            //addRestoreButton();
            //LoadAllData();
            //LoadPage();
            cbStatus.SelectedIndex = -1; // Default: Aktif
            //ReloadFilteredData();       // Baru reload data
            LoadAllData();
            LoadPage();
            AturKolomIkon();
        }

        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= dgvProduk.Rows.Count || e.ColumnIndex >= dgvProduk.Columns.Count) return;

            string columnName = dgvProduk.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvProduk.Rows[e.RowIndex];

            if (columnName == "imgShow")
            {
                string fileName = row.Cells["p_gambar"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(fileName))
                {
                    string pathGambar = Path.Combine(Application.StartupPath, @"..\..\Pict\Produk", fileName);
                    if (File.Exists(pathGambar))
                    {
                        Form formPreview = new Form();
                        PictureBox pic = new PictureBox
                        {
                            Image = Image.FromFile(pathGambar),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Dock = DockStyle.Fill
                        };
                        formPreview.Text = "Preview Gambar";
                        formPreview.Size = new Size(500, 500);
                        formPreview.Controls.Add(pic);
                        formPreview.StartPosition = FormStartPosition.CenterParent;
                        formPreview.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Gambar tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (columnName == "imgUpdate")
            {
                //if (!DateTime.TryParse(row.Cells["kry_tgl_lahir"].Value?.ToString(), out DateTime tglLahir))
                //    tglLahir = DateTime.Now;

                formProduk.setForm(
                    Convert.ToInt32(row.Cells["p_id"].Value),
                    Convert.ToInt32(row.Cells["jp_id"].Value),
                    row.Cells["p_nama"].Value.ToString(),
                    row.Cells["p_deskripsi"].Value.ToString(),
                    Convert.ToDouble(row.Cells["p_harga"].Value),
                    row.Cells["p_satuan"].Value.ToString(),
                    Convert.ToInt32(row.Cells["p_stok"].Value),
                    row.Cells["p_gambar"].Value?.ToString() ?? ""
                );
            }
            
            if (columnName == "imgDelete")
            {
                int p_id = Convert.ToInt32(row.Cells["p_id"].Value);
                connection.SetStatusProduk(p_id, userAccess);
                LoadAllData();
                LoadPage();
            }

            if (columnName == "imgRestore")
            {
                int p_id = Convert.ToInt32(row.Cells["p_id"].Value);
                DialogResult result = MessageBox.Show("Aktifkan kembali data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    connection.SetStatusProduk(p_id, userAccess); // panggil SP untuk restore
                    ReloadFilteredData();
                    LoadPage();
                }
            }

        }


        private void txtCari_TextChanged_1(object sender, EventArgs e)
        {
            currentPage = 1;
            allData = connection.GetListProduk(txtCari.Text, 1, "p_nama", "ASC");
            LoadPage();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            int totalPage = (int)Math.Ceiling((double)allData.Rows.Count / pageSize);
            if (currentPage < totalPage)
            {
                currentPage++;
                LoadPage();
            }
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
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

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            status = 1;
            cbSort.SelectedIndex = -1;
            cbFilter.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1; // Kembali ke default: Aktif
            ReloadFilteredData();
            LoadAllData();
            //LoadPage();
        }

        int status = 1; // Default: hanya tampilkan yang aktif

        private void ReloadFilteredData()
        {
            string search = txtCari.Text;
            //int? status = 1; // Default: hanya tampilkan yang aktif

            string statusText = cbStatus.SelectedItem?.ToString();
            if (statusText == "Tidak Aktif")
                status = 0;
            else if (statusText == "Aktif")
                status = 1; 

            string filterColumn = "p_nama";
            switch (cbFilter.SelectedItem?.ToString())
            {
                case "Nama": filterColumn = "p_nama"; break;
                case "Jenis Produk": filterColumn = "jp_nama"; break;
                case "Harga": filterColumn = "p_harga"; break;
                case "Satuan": filterColumn = "p_satuan"; break;
                case "Stok": filterColumn = "p_stok"; break;
                case "Deskripsi": filterColumn = "p_deskripsi"; break;
            }

            string sortOrder = "ASC";
            string sortText = cbSort.SelectedItem?.ToString();
            if (sortText != null)
            {
                if (sortText.Contains("Turun")) sortOrder = "DESC";
                else if (sortText.Contains("Naik")) sortOrder = "ASC";
            }

            currentPage = 1;
            allData = connection.GetListProduk(search, status, filterColumn, sortOrder);

            // reset dulu kolom tombol
            kolomGambarSudahDitambahkan = false;
            dgvProduk.Columns.Clear();

           
            LoadPage();
            AturKolomIkon();
        }

        private void AturKolomIkon()
        {
            if (dgvProduk.Columns.Contains("imgShow"))
            {
                dgvProduk.Columns["imgShow"].Width = 50;
                dgvProduk.Columns["imgShow"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvProduk.Columns.Contains("imgUpdate"))
            {
                dgvProduk.Columns["imgUpdate"].Width = 50;
                dgvProduk.Columns["imgUpdate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvProduk.Columns.Contains("imgDelete"))
            {
                dgvProduk.Columns["imgDelete"].Width = 50;
                dgvProduk.Columns["imgDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvProduk.Columns.Contains("imgRestore"))
            {
                dgvProduk.Columns["imgRestore"].Width = 50;
                dgvProduk.Columns["imgRestore"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvProduk.RowTemplate.Height = 50; // Optional: buat tinggi lebih kecil
            dgvProduk.RowTemplate.DefaultCellStyle.Padding = new Padding(0); // Hilangkan padding
        }


        private void btnSortFilter_Click(object sender, EventArgs e)
        {
            panelShort.Visible = !panelShort.Visible;
        }
    }
}
