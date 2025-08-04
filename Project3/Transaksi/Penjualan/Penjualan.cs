using Project3.Database;
using Project3.Master.Karyawan;
using Project3.Master.Produk;
using Project3.Master.Promo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project3.Transaksi.Penjualan
{
    public partial class Penjualan: Form
    {
        String userAccess, username;
        public Penjualan(String userAccess, String username)
        {
            InitializeComponent();
            this.userAccess = userAccess;
            this.username = username;
            formPenjualan.setLblNamaKasir(userAccess);
            formPenjualan.setIdKry(username);
        }

        private void formPenjualan_Load(object sender, EventArgs e)
        {
            loadDataProduk(search);
            formPenjualan.setParentForm(this);

            ckbPromo.Items.Clear();
            foreach (PromoADT promo in connection.getListNamaPromo())
            {
                ckbPromo.Items.Add(promo);
            }
        }

        DBConnect connection = new DBConnect();
        public String search = null;
        public void loadDataProduk(String search)
        {
            DataTable data = connection.GetListProduk(search, 1, "p_nama", "ASC");

            fpProduk.Controls.Clear(); // bersihkan dulu kalau perlu

            foreach (DataRow row in data.Rows)
            {
                var displayCaseProduk = new ListShowProduk(
                Convert.ToInt32(row["p_id"]),
                row["p_gambar"].ToString(),
                row["p_nama"].ToString(),
                Convert.ToDouble(row["p_harga"]),
                row["p_satuan"].ToString(),
                row["jp_nama"].ToString(),
                Convert.ToInt32(row["p_stok"])
                );

                displayCaseProduk.setParentForm1(this);

                fpProduk.Controls.Add(displayCaseProduk);
            }
        }

        private void ckbPromo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                HitungTotalHargaSetelahDiskon();
            });
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            search = txtCari.Text;
            loadDataProduk(search);
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            LoadAllData(null);
            LoadPage();
            pnlRiwayat.Visible = true;
            pnlRiwayat.BringToFront();
            pnlInsertPenjualan.Visible = false;
        }

        private void HitungTotalHargaSetelahDiskon()
        {
            double totalHargaAwal = formPenjualan.getTotalHargaSebelumDiskon(); // ambil dari form/keranjang
            double totalDiskon = 0;

            foreach (var item in ckbPromo.CheckedItems)
            {
                PromoADT promo = (PromoADT)item;
                totalDiskon += totalHargaAwal * (promo.pr_persentase / 100);
            }

            double totalAkhir = totalHargaAwal - totalDiskon;
            formPenjualan.setTotalHarga(totalAkhir);
        }

        //=== Riwayat Penjualan ===
        private int currentPage = 1;
        private int pageSize = 8;
        private DataTable allData;
        private bool kolomGambarSudahDitambahkan = false;

        public void LoadAllData(String search)
        {
            allData = connection.GetListPenjualan(search, 1);
        }

        public void LoadPage()
        {
            if (allData == null || allData.Rows.Count == 0)
            {
                dgvRiwayatPenjualan.DataSource = null;
                lblPageInfo.Text = "0";
                return;
            }

            var rows = allData.AsEnumerable()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize);

            DataTable dt = rows.Any() ? rows.CopyToDataTable() : allData.Clone();
            dgvRiwayatPenjualan.DataSource = dt;

            addButton();

            FormatGrid();
            lblPageInfo.Text = $"{currentPage}";
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
            dgvRiwayatPenjualan.Columns.Add(imgDetail);
            kolomGambarSudahDitambahkan = true;
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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            pnlRiwayat.Visible = false;
            pnlRiwayat.SendToBack();
            pnlInsertPenjualan.Visible = true;
        }

        private void txtCariRiwayat_TextChanged(object sender, EventArgs e)
        {
            LoadAllData(txtCariRiwayat.Text);
            LoadPage();
        }

        private void FormatGrid()
        {
            string[] hiddenColumns = {
            "s_id", "mpb_id", "kry_id", "pnj_status"
            };

            foreach (string col in hiddenColumns)
            {
                if (dgvRiwayatPenjualan.Columns.Contains(col))
                    dgvRiwayatPenjualan.Columns[col].Visible = false;
            }

            // Ganti header kolom yang ditampilkan
            if (dgvRiwayatPenjualan.Columns.Contains("pnj_id"))
                dgvRiwayatPenjualan.Columns["pnj_id"].HeaderText = "ID Penjualan";

            if (dgvRiwayatPenjualan.Columns.Contains("pnj_created_date"))
                dgvRiwayatPenjualan.Columns["pnj_created_date"].HeaderText = "Tanggal Pembelian";
                dgvRiwayatPenjualan.Columns["pnj_created_date"].DefaultCellStyle.Format = "dd-MM-yyyy";

            if (dgvRiwayatPenjualan.Columns.Contains("s_nama"))
                dgvRiwayatPenjualan.Columns["s_nama"].HeaderText = "Jenis Pembelian";

            if (dgvRiwayatPenjualan.Columns.Contains("mpb_nama"))
                dgvRiwayatPenjualan.Columns["mpb_nama"].HeaderText = "Metode Pembayaran";

            if (dgvRiwayatPenjualan.Columns.Contains("kry_nama"))
                dgvRiwayatPenjualan.Columns["kry_nama"].HeaderText = "Nama Kasir";

            if (dgvRiwayatPenjualan.Columns.Contains("pnj_total_harga"))
                dgvRiwayatPenjualan.Columns["pnj_total_harga"].HeaderText = "Total Harga";
                dgvRiwayatPenjualan.Columns["pnj_total_harga"].DefaultCellStyle.Format = "c2"; // "c2" = currency desimal
                dgvRiwayatPenjualan.Columns["pnj_total_harga"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");

                // Optional: rata kanan
                dgvRiwayatPenjualan.Columns["pnj_total_harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Tombol Edit
            if (dgvRiwayatPenjualan.Columns.Contains("imgDetail"))
            {
                dgvRiwayatPenjualan.Columns["imgDetail"].Width = 50;
                dgvRiwayatPenjualan.Columns["imgDetail"].DisplayIndex = dgvRiwayatPenjualan.Columns.Count - 2;
            }
        }

        private void dgvRiwayatPenjualan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= dgvRiwayatPenjualan.Rows.Count || e.ColumnIndex >= dgvRiwayatPenjualan.Columns.Count) return;

            string columnName = dgvRiwayatPenjualan.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvRiwayatPenjualan.Rows[e.RowIndex];

            if (columnName == "imgDetail")
            {
                setDataDetail(
                    Convert.ToInt32(row.Cells["pnj_id"].Value),
                    row.Cells["kry_nama"].Value.ToString(),
                    row.Cells["s_nama"].Value.ToString(),
                    Convert.ToDouble(row.Cells["pnj_total_harga"].Value)
                );
            }
        }

        // === Detail Penjualan ===
        private void loadDataDetail(int pnj_id)
        {
            dgvDetailPenjualan.DataSource = connection.GetListDetailPenjualan(pnj_id);

            // Ganti header kolom yang ditampilkan
            if (dgvDetailPenjualan.Columns.Contains("p_nama"))
                dgvDetailPenjualan.Columns["p_nama"].HeaderText = "Produk";

            if (dgvDetailPenjualan.Columns.Contains("dp_kuantitas"))
                dgvDetailPenjualan.Columns["dp_kuantitas"].HeaderText = "Jumlah";
                dgvDetailPenjualan.Columns["dp_kuantitas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (dgvDetailPenjualan.Columns.Contains("p_harga"))
                dgvDetailPenjualan.Columns["p_harga"].HeaderText = "Harga Satuan";
                dgvDetailPenjualan.Columns["p_harga"].DefaultCellStyle.Format = "c2"; // "c2" = currency desimal
                dgvDetailPenjualan.Columns["p_harga"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");

                // Optional: rata kanan
                dgvDetailPenjualan.Columns["p_harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void setDataDetail(int pnj_id, String namaKasir, String jenisPembelian, Double totalHarga)
        {
            lblNama.Text = namaKasir;
            lblJenisPembelian.Text = jenisPembelian;
            lblTotalPembelian.Text = FormatRupiah(totalHarga);
            loadDataDetail(pnj_id);

            double totalDiskon = 0.0;

            if (dgvDetailPenjualan.DataSource != null)
            {
                foreach (DataGridViewRow row in dgvDetailPenjualan.Rows)
                {
                    if (!row.IsNewRow) // Hindari baris kosong di bawah DataGridView
                    {
                        double harga = 0;
                        if (row.Cells["p_harga"].Value != null)
                        {
                            double.TryParse(row.Cells["p_harga"].Value.ToString(), out harga);
                            totalDiskon += harga;
                        }
                    }
                }

                totalDiskon -= totalHarga;
            }

            if (totalDiskon > 0)
            {
                lblDiskon.Text = FormatRupiah(totalDiskon); // Pastikan FormatRupiah mengembalikan string seperti Rp 10.000
            }
            else
            {
                lblDiskon.Text = "-";
            }

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

        public static string FormatRupiah(Double amount)
        {
            return string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp{0:N2}", amount);
        }
    }
}
