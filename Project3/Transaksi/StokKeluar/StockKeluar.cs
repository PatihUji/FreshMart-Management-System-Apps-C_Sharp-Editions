using Project3.Database;
using Project3.Master.Produk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project3
{
    public partial class FormStockKeluar : Form
    {
        private DBConnect connection = new DBConnect();
        private int pageSize = 8;
        private DataTable allData;
        private bool kolomGambarSudahDitambahkan = false;
        private int kuantitas = 1;

        //Pagging
        private DataTable stokKeluarData = new DataTable();
        private int currentPage = 0;
        private int rowsPerPage = 10;

        private string userAccess;
        public FormStockKeluar(string userAccess) //Menerima parameter userAccess
        {
            InitializeComponent();

            InitDataGridTambahProduk();
            // Menambahkan kolom ke DataGridView 'dgvTambahProduk'

            this.dvgTambahProduk.CellContentClick += new DataGridViewCellEventHandler(this.dgvTambahProduk_CellContentClick);
            // Menambahkan event handler ketika tombol di dalam kolom aksi DataGridView diklik (misalnya: tombol hapus)

            LoadCardProduk();
            // Mengambil data produk dari database dan menampilkannya dalam bentuk kartu di FlowLayoutPanel

            LoadProdukToComboBox();
            // Mengisi ComboBox dengan daftar produk aktif dari database (untuk dipilih saat menambah item)

            this.userAccess = userAccess;
            // Menyimpan hak akses user (jika akan digunakan untuk kontrol otorisasi di kemudian hari)

            txtCari.TextChanged += txtCari_TextChanged;
            // Event cari produk

            guna2NumericUpDown1.Minimum = 1; //Mengatur nilai minimum
            guna2NumericUpDown1.Value = 1;  // Nilai awal: 1

            txtCariRiwayat.TextChanged += txtCariRiwayat_TextChanged;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormStockKeluar_Load(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToString("yyyy/MM/dd");
            InitDataGridTambahProduk();
            InitDataGridViewStokKeluar(); // di FormStockKeluar_Load

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool isApTambahProduk = false;
        private void btnTambah_Click(object sender, EventArgs e)
        {
            isApTambahProduk = !isApTambahProduk; // toggle nilai

            panelTambahProduk.Visible = isApTambahProduk;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        int stokTersedia = 0; // Diisi saat produk dipilih
        private void txtKuantitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // hanya angka boleh
            }
        }

        private void cbProduk_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2NumericUpDown1.Enabled = cbProduk.SelectedIndex >= 0;
            guna2NumericUpDown1.Value = 1;
        }

        private void LoadCardProduk()
        {
            string search = txtCari.Text.Trim(); // Ambil input pencarian
            int? status = 1; // Status aktif

            // Ambil semua data produk dari database
            DataTable dtProduk = connection.GetListProduk(null, null, null);

            flowPanelProduk.Controls.Clear(); // Kosongkan panel dulu

            // Filter berdasarkan nama produk yang mengandung teks pencarian
            var filteredRows = dtProduk.AsEnumerable()
                .Where(row => row.Field<string>("p_nama").IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0);

            // Tampilkan hanya produk yang sesuai pencarian
            foreach (DataRow row in filteredRows)
            {
                string namaProduk = row["p_nama"].ToString();
                int stok = Convert.ToInt32(row["p_stok"]);

                CardStokKeluar card = new CardStokKeluar();
                card.SetData(namaProduk, stok);

                flowPanelProduk.Controls.Add(card);
            }

            // Jika hasil pencarian kosong, beri info
            if (!filteredRows.Any())
            {
                Label lblKosong = new Label();
                lblKosong.Text = "Produk tidak ditemukan.";
                lblKosong.AutoSize = true;
                lblKosong.ForeColor = Color.Gray;
                lblKosong.Font = new Font("Segoe UI", 10, FontStyle.Italic);
                flowPanelProduk.Controls.Add(lblKosong);
            }
        }

        private void LoadProdukToComboBox()
        {
            DataTable dt = connection.GetListNamaProduk();

            cbProduk.DataSource = dt;
            cbProduk.DisplayMember = "p_nama";
            cbProduk.ValueMember = "p_id";
            cbProduk.SelectedIndex = -1; // biar tidak terpilih otomatis
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            LoadCardProduk();
        }

        private void InitDataGridTambahProduk()
        {
            dvgTambahProduk.Columns.Clear();
            dvgTambahProduk.Columns.Add("NamaProduk", "Nama Produk");
            dvgTambahProduk.Columns.Add("Jumlah", "Jumlah");

            // Kolom Aksi
            DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
            colHapus.Name = "Aksi";
            colHapus.HeaderText = "Aksi";
            colHapus.Text = "Hapus";
            colHapus.UseColumnTextForButtonValue = true;

            dvgTambahProduk.Columns.Add(colHapus);

            dvgTambahProduk.AllowUserToAddRows = false;
        }


        private void btnTambahItem_Click(object sender, EventArgs e)
        {
            if (cbProduk.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih produk terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaProduk = cbProduk.Text;
            int produkId = Convert.ToInt32(cbProduk.SelectedValue);
            int kuantitas = (int)guna2NumericUpDown1.Value;

            if (kuantitas < 1)
            {
                MessageBox.Show("Jumlah tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cek apakah produk sudah ditambahkan
            foreach (DataGridViewRow row in dvgTambahProduk.Rows)
            {
                if (row.Cells["NamaProduk"].Value.ToString() == namaProduk)
                {
                    MessageBox.Show("Produk sudah ditambahkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            dvgTambahProduk.Rows.Add(namaProduk, kuantitas);

            // Reset form
            cbProduk.SelectedIndex = -1;
            guna2NumericUpDown1.Value = 1;
            guna2NumericUpDown1.Enabled = false;
        }

        private void dgvTambahProduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgTambahProduk.Columns["Aksi"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Hapus item ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dvgTambahProduk.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi keterangan kosong dan produk kosong
            if (string.IsNullOrWhiteSpace(tbKeterangan.Text) && dvgTambahProduk.Rows.Count == 0)
            {
                MessageBox.Show("Data tidak boleh kosong semua!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi produk belum ditambahkan
            if (dvgTambahProduk.Rows.Count == 0)
            {
                MessageBox.Show("Silakan tambahkan minimal 1 produk terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi keterangan kosong
            string keterangan = tbKeterangan.Text.Trim();
            if (string.IsNullOrEmpty(keterangan))
            {
                MessageBox.Show("Keterangan tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi panjang keterangan
            if (keterangan.Length > 50)
            {
                MessageBox.Show("Keterangan tidak boleh lebih dari 50 karakter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // variabel untuk nyimpan 
            int totalStokKeluar = 0;
            // Buat objek DataTable untuk menampung detail transaksi stok keluar
            DataTable detailTable = new DataTable();
            // Tambahkan kolom "p_id" untuk menyimpan ID produk
            detailTable.Columns.Add("p_id", typeof(int));
            // untuk menyimpan jumlah (kuantitas) stok keluar per produk
            detailTable.Columns.Add("dsk_kuantitas", typeof(int));
            // Ambil DataTable sumber dari ComboBox
            DataTable dtProduk = (DataTable)cbProduk.DataSource;

            foreach (DataGridViewRow row in dvgTambahProduk.Rows)
            {
                if (row.IsNewRow) continue;

                string namaProduk = row.Cells["NamaProduk"].Value.ToString();
                int jumlah = Convert.ToInt32(row.Cells["Jumlah"].Value);

                // Cari ID produk dari nama
                DataRow[] found = dtProduk.Select($"p_nama = '{namaProduk.Replace("'", "''")}'");
                if (found.Length == 0)
                {
                    MessageBox.Show($"Produk '{namaProduk}' tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int produkId = Convert.ToInt32(found[0]["p_id"]);
                detailTable.Rows.Add(produkId, jumlah);
                totalStokKeluar += jumlah;
            }

            // Ambil ID karyawan dari username
            int karyawanId = connection.GetIdKaryawanByUsername(userAccess);

            // Simpan ke database
            bool berhasil = connection.InsertStokKeluar(karyawanId, totalStokKeluar, keterangan, userAccess, detailTable);

            if (berhasil)
            {
                MessageBox.Show("Stok keluar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ClearForm(); // Jika ada method ini
            }
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Pastikan item di ComboBox produk tidak null dan bertipe DataRowView
            if (cbProduk.SelectedValue != null && cbProduk.SelectedItem is DataRowView rowView)
            {
                // Ambil ID produk dari item yang dipilih
                int produkId = Convert.ToInt32(rowView["p_id"]);

                // Ambil stok saat ini dari database untuk produk
                int stok = connection.GetStokProdukById(produkId);

                // Jika jumlah yang dimasukkan melebihi stok tersedia, tampilkan peringatan dan sesuaikan nilai
                if (guna2NumericUpDown1.Value > stok)
                {
                    MessageBox.Show("Jumlah item melebihi stok tersedia!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    guna2NumericUpDown1.Value = stok; // Set ulang ke nilai maksimal yang tersedia
                }
                // Jika nilai kurang dari 1, ubah ke minimal 1 (tidak boleh 0 atau minus)
                else if (guna2NumericUpDown1.Value < 1)
                {
                    guna2NumericUpDown1.Value = 1;
                }

                // Simpan nilai akhir ke variabel `kuantitas`
                kuantitas = (int)guna2NumericUpDown1.Value;
            }
        }

        // Saat tombol Riwayat diklik
        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            panelViewStokKeluar.BringToFront();
            panelViewStokKeluar.Visible = true;
            panelStokKeluar.Visible = false;

            LoadDataStokKeluar(null); // Ambil semua data tanpa filter
        }

        // Saat tombol kembali diklik
        private void btnKembali_Click(object sender, EventArgs e)
        {
            panelViewStokKeluar.Visible = false;
            panelStokKeluar.Visible = true;
        }

        private void LoadDataStokKeluar(string search)
        {
            // Ambil semua data
            stokKeluarData = connection.GetListStokKeluar(null, null); // Ambil semua data

            if (!string.IsNullOrEmpty(search))
            {
                var filtered = stokKeluarData.AsEnumerable().Where(row =>
                   row["sk_id"].ToString().IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   Convert.ToDateTime(row["sk_tanggal_keluar"]).ToString("dd-MM-yyyy").IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0
                );

                if (filtered.Any())
                {
                    stokKeluarData = filtered.CopyToDataTable();
                }
                else
                {
                    dgvStokKeluar.Rows.Clear();
                    PageInfolbl.Text = "0";
                    return;
                }
            }

            currentPage = 0;
            TampilkanHalaman();
        }

        // Tampilkan data stok keluar per halaman
        private void TampilkanHalaman()
        {
            dgvStokKeluar.Rows.Clear();

            int start = currentPage * rowsPerPage;
            int end = Math.Min(start + rowsPerPage, stokKeluarData.Rows.Count);

            for (int i = start; i < end; i++)
            {
                DataRow row = stokKeluarData.Rows[i];

                dgvStokKeluar.Rows.Add(
                    row["sk_id"],
                    row["kry_nama"],
                    Convert.ToDateTime(row["sk_tanggal_keluar"]).ToString("dd-MM-yyyy"),
                    row["sk_jumlah_keluar"],
                    row["sk_keterangan"]
                );
            }

            addButton();
            PageInfolbl.Text = (currentPage + 1).ToString(); // Tampilkan angka halaman (1-based)
        }

        private void addButton()
        {
            if (kolomGambarSudahDitambahkan) return;

            DataGridViewImageColumn imgDetail = new DataGridViewImageColumn
            {
                Name = "imgDetail",
                HeaderText = "",
                Image = Properties.Resources.ikon_gambar,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 50
            };
            dgvStokKeluar.Columns.Add(imgDetail);
            kolomGambarSudahDitambahkan = true;
        }

        private void dgvStokKeluar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= dgvStokKeluar.Rows.Count || e.ColumnIndex >= dgvStokKeluar.Columns.Count) return;

            string columnName = dgvStokKeluar.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvStokKeluar.Rows[e.RowIndex];

            if (columnName == "imgDetail")
            {
                setDataDetail(
                    Convert.ToInt32(row.Cells["sk_id"].Value),
                    Convert.ToDateTime(row.Cells["sk_tanggal_keluar"].Value),
                    row.Cells["sk_keterangan"].Value.ToString()
                );
            }
        }

        // Navigasi ke halaman selanjutnya
        private void Nextbtn_Click(object sender, EventArgs e)
        {
            int maxPage = (int)Math.Ceiling(stokKeluarData.Rows.Count / (double)rowsPerPage);
            if (currentPage < maxPage - 1)
            {
                currentPage++;
                TampilkanHalaman();
            }
        }

        // Navigasi ke halaman sebelumnya
        private void Prevbtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                TampilkanHalaman();
            }
        }

        private void InitDataGridViewStokKeluar()
        {
            dgvStokKeluar.Columns.Clear();
            dgvStokKeluar.Columns.Add("sk_id", "ID");
            dgvStokKeluar.Columns.Add("kry_nama", "Nama Karyawan");
            dgvStokKeluar.Columns.Add("sk_tanggal_keluar", "Tanggal Keluar");
            dgvStokKeluar.Columns.Add("sk_jumlah_keluar", "Jumlah");
            dgvStokKeluar.Columns.Add("sk_keterangan", "Keterangan");

            dgvStokKeluar.AllowUserToAddRows = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            tbKeterangan.Text = ""; // Kosongkan TextBox keterangan
            panelTambahProduk.Visible = false; // Sembunyikan panel tambah produk
            dvgTambahProduk.Rows.Clear(); // Kosongkan tabel produk
        }

        private void txtCariRiwayat_TextChanged(object sender, EventArgs e)
        {
            string search = txtCariRiwayat.Text.Trim();
            LoadDataStokKeluar(search);
        }

        // === Detail Stok Keluar ===
        private void loadDataDetail(int id)
        {
            dgvDetail.DataSource = connection.GetDetailStokKeluarById(id);

            // Ganti header kolom yang ditampilkan
            if (dgvDetail.Columns.Contains("p_nama"))
                dgvDetail.Columns["p_nama"].HeaderText = "Produk";

            if (dgvDetail.Columns.Contains("dsk_kuantitas"))
                dgvDetail.Columns["dsk_kuantitas"].HeaderText = "Jumlah";
            dgvDetail.Columns["dsk_kuantitas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void setDataDetail(int sk_id, DateTime tglKeluar, String keterangan)
        {
            lblIdTransaksi.Text = sk_id.ToString();
            lblTglStokKeluar.Text = tglKeluar.ToString("dd-MM-yyyy");
            lblKeterangan.Text = keterangan;
            loadDataDetail(sk_id);

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

        
    }
}

