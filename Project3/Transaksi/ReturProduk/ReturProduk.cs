using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using Project3.Database;

namespace Project3.Transaksi.Retur_Barang
{
    public partial class ReturProduk : Form
    {


        private string userAccess;

        private string username;

        private DBConnect connection = new DBConnect();

        private int currentPage = 1;

        private int pageSize = 8;

        private DataTable allData;

        private int selectedPenjualanId = 0;

        private bool kolomGambarSudahDitambahkanUtama = false;

        public ReturProduk(String userAccess, String username)
        {
            InitializeComponent();
            this.userAccess = userAccess;
            this.username = username;
        }

        private void dgvReturBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReturBarang.Rows[e.RowIndex];

                if (dgvReturBarang.Columns[e.ColumnIndex].Name == "imgTambah")
                {
                    selectedPenjualanId = Convert.ToInt32(row.Cells["pnj_id"].Value);
                    lblIDPnj.Text = selectedPenjualanId.ToString();

                    btnTambahDtl.Enabled = true;
                }

            }
        }

        private void pnlReturProduk_Paint(object sender, PaintEventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
            pnlDetailRetur.Visible = false;
            LoadDataPenjualan(null);
            InitKolomDgvDetailRetur();
        }

        private void LoadDataPenjualan(string search)
        {
            allData = connection.getListPenjualanByKategori(search, null, "Retur Produk");
            currentPage = 1;
            LoadPage();
        }

        private void FormatGrid()
        {
            // Kolom yang tidak ingin ditampilkan
            string[] hiddenColumns = {
                "s_id", "mpb_id", "kry_id", "pnj_status",
                "pnj_created_by", "pnj_created_date", "pnj_modif_by", "pnj_modif_date"
                  };

            foreach (string col in hiddenColumns)
            {
                if (dgvReturBarang.Columns.Contains(col))
                    dgvReturBarang.Columns[col].Visible = false;
            }

            if (dgvReturBarang.Columns.Contains("pnj_id"))
                dgvReturBarang.Columns["pnj_id"].HeaderText = "ID Penjualan";

            if (dgvReturBarang.Columns.Contains("s_nama"))
                dgvReturBarang.Columns["s_nama"].HeaderText = "Jenis Pembelian";

            if (dgvReturBarang.Columns.Contains("mpb_nama"))
                dgvReturBarang.Columns["mpb_nama"].HeaderText = "Metode Pembayaran";

            if (dgvReturBarang.Columns.Contains("kry_nama"))
                dgvReturBarang.Columns["kry_nama"].HeaderText = "Nama Kasir";

            if (dgvReturBarang.Columns.Contains("pnj_total_harga"))
                dgvReturBarang.Columns["pnj_total_harga"].HeaderText = "Total Harga";

            if (dgvReturBarang.Columns.Contains("imgTambah"))
            {
                dgvReturBarang.Columns["imgTambah"].Width = 50;
                // Jangan ubah HeaderText di sini agar tetap “Aksi”
                dgvReturBarang.Columns["imgTambah"].DisplayIndex = dgvReturBarang.Columns.Count - 1;
            }

            dgvReturBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            allData = connection.getListPenjualanByKategori(txtCari.Text, null, "Retur Produk");
            currentPage = 1;
            LoadPage();
        }

        public void LoadPage()
        {
            if (allData == null || allData.Rows.Count == 0)
            {
                dgvReturBarang.DataSource = null; 
                lblPageInfo.Text = "0";
                return;
            }

            var rows = allData.AsEnumerable()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize);

            DataTable dt = rows.Any() ? rows.CopyToDataTable() : allData.Clone();
            dgvReturBarang.DataSource = dt; 

            addButtonReturBarang();

            FormatGrid();                  
            lblPageInfo.Text = $"{currentPage}";
        }

        //tmbh prdk
        bool isTambahDtl = false;
        private void btnTambahDtl_Click(object sender, EventArgs e)
        {
            if (selectedPenjualanId == 0)
            {
                MessageBox.Show("Silakan pilih ID Penjualan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Stop further execution
            }
            else
            {
                LoadProdukToComboBox(); // Load produk hanya jika ID Penjualan sudah dipilih
            }

            if (isTambahDtl)
            {
                isTambahDtl = false;
                pnlDetailRetur.Visible = isTambahDtl;
            }
            else
            {
                isTambahDtl = true;
                cmbProduk.SelectedIndex = -1;
                Jmlh.Value = 0;
                pnlDetailRetur.Visible = isTambahDtl;
            }
        }



        private void btnBatal_Click(object sender, EventArgs e)
        {
            isTambahDtl = false;
            pnlDetailRetur.Visible = isTambahDtl;
            cmbProduk.SelectedIndex = -1;
            Jmlh.Value = 0;
            dgvDetailRetur.Rows.Clear();
            lblIDPnj.Text = null;
            btnTambahDtl.Enabled = false;
        }

        private void addButtonReturBarang()
        {
            // Hapus dulu jika sudah ada, untuk hindari dobel
            if (dgvReturBarang.Columns.Contains("imgTambah"))
                dgvReturBarang.Columns.Remove("imgTambah");

            DataGridViewImageColumn imgTambah = new DataGridViewImageColumn
            {
                Name = "imgTambah",
                HeaderText = "Aksi",
                Image = Properties.Resources.plus_icon, // pastikan ikon ini ada
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 40
            };
            dgvReturBarang.Columns.Add(imgTambah);
        }

        //detai///
        private void InitKolomDgvDetailRetur()
        {
            
            if (dgvDetailRetur.Columns.Count == 0)
            {
                // Kolom tersembunyi untuk ID produk
                DataGridViewTextBoxColumn colPId = new DataGridViewTextBoxColumn
                {
                    Name = "p_id",
                    HeaderText = "ID Produk",
                    Visible = false
                };
                dgvDetailRetur.Columns.Add(colPId);

                dgvDetailRetur.Columns.Add("produk", "Produk");
                dgvDetailRetur.Columns.Add("jumlah", "Jumlah");
                dgvDetailRetur.Columns.Add("alasan", "Alasan");

                if (!dgvDetailRetur.Columns.Contains("imgDelete"))
                {
                    DataGridViewImageColumn imgDelete = new DataGridViewImageColumn
                    {
                        Name = "imgDelete",
                        HeaderText = "Aksi",
                        Image = Properties.Resources.delete_icon,
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Width = 40
                    };
                    dgvDetailRetur.Columns.Add(imgDelete);
                }
            }
        }

        private void dgvDetailRetur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDetailRetur.Columns[e.ColumnIndex].Name == "imgDelete")
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus baris ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove the row from the DataGridView
                    dgvDetailRetur.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void cmbProduk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduk.SelectedIndex != -1)
            {
                if (int.TryParse(cmbProduk.SelectedValue.ToString(), out int produkId))
                {
                    Jmlh.Value = connection.GetKuantitasProdukTerjualById(produkId);
                }
            }
        }

        private void btnTmbhDeatil_Click(object sender, EventArgs e)
        {
            InitKolomDgvDetailRetur();

            if (!(cmbProduk.SelectedItem is KeyValuePair<int, string> selectedProduk))
            {
                MessageBox.Show("Silakan pilih produk.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string produk = selectedProduk.Value;
            string jumlah = Jmlh.Text.Trim();
            string alasan = txtAlasan.Text.Trim();

            if (string.IsNullOrWhiteSpace(alasan) || !Regex.IsMatch(alasan, @"^[a-zA-Z0-9\s]{1,50}$"))
            {
                MessageBox.Show("Alasan wajib diisi dan maksimal 50 karakter.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(jumlah, out int jml) || jml <= 0)
            {
                MessageBox.Show("Jumlah tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //dgvDetailRetur.Rows.Add(produk, jml, alasan);
            dgvDetailRetur.Rows.Add(selectedProduk.Key, produk, jml, alasan);


            FormatGridDetailRetur();

            // Reset
            cmbProduk.SelectedIndex = -1;
            Jmlh.Value = 0;
            txtAlasan.Clear();
        }

        private void LoadProdukToComboBox()
        {
            string connectionString = "Server=localhost;Initial Catalog=TheFreshChoice;Integrated Security=True;TrustServerCertificate=true;";

            string query = @"
                        SELECT p.p_id, p.p_nama 
                        FROM produk p
                        JOIN detail_transaksi_penjualan dp ON p.p_id = dp.p_id
                        WHERE dp.pnj_id = @pnj_id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pnj_id", selectedPenjualanId);

                    conn.Open();
                    List<KeyValuePair<int, string>> listProduk = new List<KeyValuePair<int, string>>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["p_id"]);
                            string nama = reader["p_nama"].ToString();

                            listProduk.Add(new KeyValuePair<int, string>(id, nama));
                        }
                    }

                    cmbProduk.DataSource = listProduk;
                    cmbProduk.DisplayMember = "Value"; // tampil nama saja
                    cmbProduk.ValueMember = "Key";     // ambil ID dari SelectedValue

                    if (cmbProduk.Items.Count > 0)
                        cmbProduk.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data produk: " + ex.Message);
            }
        }
        private void FormatGridDetailRetur()
        {
            // Cek apakah DataGridView sudah punya kolom
            if (dgvDetailRetur.Columns.Count == 0)
                return;

            // Update the column headers
            if (dgvDetailRetur.Columns.Contains("produk"))
                dgvDetailRetur.Columns["produk"].HeaderText = "Produk";
            if (dgvDetailRetur.Columns.Contains("jumlah"))
                dgvDetailRetur.Columns["jumlah"].HeaderText = "Jumlah";
            if (dgvDetailRetur.Columns.Contains("alasan"))
                dgvDetailRetur.Columns["alasan"].HeaderText = "Alasan";

            // Adjust the column widths
            if (dgvDetailRetur.Columns.Contains("produk"))
                dgvDetailRetur.Columns["produk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dgvDetailRetur.Columns.Contains("jumlah"))
                dgvDetailRetur.Columns["jumlah"].Width = 70;
            if (dgvDetailRetur.Columns.Contains("alasan"))
                dgvDetailRetur.Columns["alasan"].Width = 200;

            // Disable adding rows manually
            dgvDetailRetur.AllowUserToAddRows = false;

            // Set AutoSizeMode for the columns
            dgvDetailRetur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void clearForm()
        {
            // Reset form fields after saving
            lblIDPnj.Text = "";
            dgvDetailRetur.Rows.Clear();
            cmbProduk.SelectedIndex = -1;
            Jmlh.Value = 0; // Reset NumericUpDown to its default value (e.g., 0)
            txtAlasan.Clear();  // Clear the TextBox
        }
        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            LoadRiwayatRetur(); // ✅ Harus di sini dulu
            pnlRiwayat.Visible = true;
            pnlRiwayat.BringToFront();
            pnlReturProduk.Visible = false;
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (selectedPenjualanId == 0 || dgvDetailRetur.Rows.Count == 0)
            {
                MessageBox.Show("Data tidak boleh kosong!",
                                "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Detail_Retur> detailList = new List<Detail_Retur>();

            foreach (DataGridViewRow row in dgvDetailRetur.Rows)
            {
                if (row.IsNewRow) continue;

                var valPId = row.Cells["p_id"].Value;
                var valQty = row.Cells["jumlah"].Value;
                var valAlasan = row.Cells["alasan"].Value;

                if (valPId == null || string.IsNullOrWhiteSpace(valPId.ToString()) ||
                    valQty == null || string.IsNullOrWhiteSpace(valQty.ToString()) ||
                    valAlasan == null || string.IsNullOrWhiteSpace(valAlasan.ToString()))
                {
                    MessageBox.Show("Semua kolom pada tabel retur harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int p_id = Convert.ToInt32(valPId);
                int jumlah = Convert.ToInt32(valQty);
                string alasan = valAlasan.ToString();

                detailList.Add(new Detail_Retur(p_id, "", jumlah, alasan));
            }

            int totalRetur = detailList.Sum(d => d.Drp_kuantitas);
            int idKasir = connection.GetIdKaryawanByUsername(username);
            string createdBy = userAccess;

            bool success = connection.InsertReturBarang(idKasir, selectedPenjualanId, totalRetur, createdBy, detailList);

            if (success)
            {
                MessageBox.Show("Retur berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDetailRetur.Rows.Clear();
            }

            isTambahDtl = false;
            pnlDetailRetur.Visible = isTambahDtl;
            cmbProduk.SelectedIndex = -1;
            Jmlh.Value = 0;
            dgvDetailRetur.Rows.Clear();
            lblIDPnj.Text = null;
            btnTambahDtl.Enabled = false;
        }



        //PANEL RIWAYAT RETUR
        private int currentRiwayatPage = 1;
        private int riwayatPageSize = 8;
        private DataTable allRiwayatData;

        private void LoadRiwayatRetur(string search = null)
        {
            string query = @"SELECT 
                rp.rtr_id AS [ID Retur],
                k.kry_nama AS [Nama Kasir],
                FORMAT(rp.rtr_tanggal_retur, 'dd-MM-yyyy') AS [Tanggal Retur],
                COUNT(drp.p_id) AS [Jumlah]
             FROM retur_pembeli rp
             JOIN karyawan k ON rp.kry_id = k.kry_id
             JOIN detail_transaksi_retur_pembeli drp ON rp.rtr_id = drp.rtr_id
             WHERE (@search IS NULL OR k.kry_nama LIKE '%' + @search + '%' OR CAST(rp.rtr_id AS VARCHAR) LIKE '%' + @search + '%')
             GROUP BY rp.rtr_id, k.kry_nama, rp.rtr_tanggal_retur
             ORDER BY rp.rtr_id DESC";

            using (SqlConnection conn = new SqlConnection("Server=localhost;Initial Catalog=TheFreshChoice;Integrated Security=True;TrustServerCertificate=true;"))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@search", (object)search ?? DBNull.Value);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                allRiwayatData = dt;
                currentRiwayatPage = 1;
                LoadRiwayatPage();
            }
        }


        private void LoadRiwayatPage()
        {
            if (allRiwayatData == null || allRiwayatData.Rows.Count == 0)
            {
                dgvRiwayatRetur.DataSource = null;
                lblPageInfo.Text = "0 / 0";
                return;
            }

            var rows = allRiwayatData.AsEnumerable()
                .Skip((currentRiwayatPage - 1) * riwayatPageSize)
                .Take(riwayatPageSize);

            DataTable dt = rows.Any() ? rows.CopyToDataTable() : allRiwayatData.Clone();
            dgvRiwayatRetur.DataSource = dt;

            AddDetailButtonToRiwayat();
            FormatRiwayatGrid();

            int totalPage = (int)Math.Ceiling((double)allRiwayatData.Rows.Count / riwayatPageSize);
            lblPageInfoRiwayat.Text = $"{currentRiwayatPage}";
        }


        private void AddDetailButtonToRiwayat()
        {
            if (dgvRiwayatRetur.Columns.Contains("Aksi"))
                dgvRiwayatRetur.Columns.Remove("Aksi");

            DataGridViewImageColumn detailCol = new DataGridViewImageColumn();
            detailCol.Name = "Aksi";
            detailCol.HeaderText = "Aksi";
            detailCol.Image = Properties.Resources.ikon_gambar; // Pastikan ada icon ini
            detailCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            detailCol.Width = 40;

            dgvRiwayatRetur.Columns.Add(detailCol);
        }

        private void FormatRiwayatGrid()
        {
            dgvRiwayatRetur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRiwayatRetur.Columns["ID Retur"].ReadOnly = true;
            dgvRiwayatRetur.Columns["Nama Kasir"].ReadOnly = true;
            dgvRiwayatRetur.Columns["Tanggal Retur"].ReadOnly = true;
            dgvRiwayatRetur.Columns["Jumlah"].ReadOnly = true;
        }


        private void txtCariRiwayat_TextChanged(object sender, EventArgs e)
        {
            string search = txtCariRiwayat.Text.Trim();
            LoadRiwayatRetur(string.IsNullOrEmpty(search) ? null : search);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            pnlReturProduk.Visible = true;
            pnlReturProduk.BringToFront(); // Tambahkan ini

            pnlRiwayat.Visible = false;
        }

        private void dgvRiwayatRetur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRiwayatRetur.Columns[e.ColumnIndex].Name == "Aksi")
            {
                // Di sini Anda bisa buka form detail retur jika dibutuhkan
                DataGridViewRow row = dgvRiwayatRetur.Rows[e.RowIndex];

                
                    setDataDetail(
                        Convert.ToInt32(row.Cells["ID Retur"].Value),
                        row.Cells["Nama Kasir"].Value.ToString(),
                        Convert.ToDateTime(row.Cells["Tanggal Retur"].Value),
                        Convert.ToInt32(row.Cells["Jumlah"].Value)
                    );
                
            }

        }

        private void dgvDetailRetur_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSblmny_Click(object sender, EventArgs e)
        {

            if (currentRiwayatPage > 1)
            {
                currentRiwayatPage--;
                LoadRiwayatPage();
            }
        }

        private void btnSesudah_Click(object sender, EventArgs e)
        {
            int totalPage = (int)Math.Ceiling((double)allRiwayatData.Rows.Count / riwayatPageSize);
            if (currentRiwayatPage < totalPage)
            {
                currentRiwayatPage++;
                LoadRiwayatPage();
            }
        }

        private void pnlRiwayat_Paint(object sender, PaintEventArgs e)
        {
            LoadDataPenjualan(null);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // === Detail Retur ===
        private void loadDataDetail(int id)
        {
            dgvDetail.DataSource = connection.GetListDetailReturBarang(id);

            // Ganti header kolom yang ditampilkan
            if (dgvDetail.Columns.Contains("p_nama"))
                dgvDetail.Columns["p_nama"].HeaderText = "Produk";

            if (dgvDetail.Columns.Contains("drp_kuantitas"))
                dgvDetail.Columns["drp_kuantitas"].HeaderText = "Jumlah";
                dgvDetail.Columns["drp_kuantitas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (dgvDetail.Columns.Contains("drp_alasan"))
                dgvDetail.Columns["drp_alasan"].HeaderText = "Alasan";
        }

        private void setDataDetail(int rtr_id, String namaKaryawan, DateTime tglRetur, int jumlahRetur)
        {
            lblNamaKaryawan.Text = namaKaryawan;
            lblTglRetur.Text = tglRetur.ToString("dd-MM-yyyy");
            lblJumlahRetur.Text = jumlahRetur.ToString();
            loadDataDetail(rtr_id);

            pnlOverlayDetail.Visible = true;
            pnlOverlayDetail.BringToFront();
            pnlOverlayDetail.BackColor = Color.FromArgb(128, 0, 0, 0); // hitam transparan
            pnlOverlayDetail.FillColor = Color.FromArgb(128, 0, 0, 0); // pastikan juga fill transparan
        }

        private void pnlOverlayDetail_Click(object sender, EventArgs e)
        {
            pnlOverlayDetail.SendToBack();
            pnlOverlayDetail.Visible = false;
        }

        private void Jmlh_ValueChanged(object sender, EventArgs e)
        {
            if (cmbProduk.SelectedIndex == -1)
            {
                Jmlh.Value = 0;
            }
            else if (Jmlh.Value < 1)
            {
                MessageBox.Show("Jumlah tidak boleh kurang dari 1", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Jmlh.Value = 1;
            }
            else if (Jmlh.Value > connection.GetKuantitasProdukTerjualById(Convert.ToInt32(cmbProduk.SelectedValue)))
            {
                MessageBox.Show("Jumlah tidak boleh melebihi kuantitas produk yang terjual.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Jmlh.Value = connection.GetKuantitasProdukTerjualById(Convert.ToInt32(cmbProduk.SelectedValue));
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
