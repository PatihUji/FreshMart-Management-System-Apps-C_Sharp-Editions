using Guna.UI2.WinForms;
using Project3.Dashboard;
using Project3.Database;
using Project3.Laporan.TransaksiPengiriman;
using Project3.Laporan.TransaksiPenjualan;
using Project3.Laporan.TransaksiRetur;
using Project3.Laporan.TransaksiStok;
using Project3.Master.Karyawan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project3.SideBar
{
    public partial class SideBarOwner : Form
    {
        private String userAccess;
        private String username;
        public SideBarOwner(String userAccess, String username)
        {
            InitializeComponent();
            this.userAccess = userAccess;
            this.username = username;
            lblUserAccess.Text = this.userAccess;
            DashboardOwner_Load();
        }

        public String getUserAccess()
        {
            return userAccess;
        }

        public void ShowFormInPanel(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            form.Show();
        }

        DBConnect connection = new DBConnect();
        private void lblUserAccess_Click(object sender, EventArgs e)
        {
            KaryawanADT getData = connection.GetProfileByUsername(username);
            lblNama.Text = getData.Nama;
            lblTglLahir.Text = getData.TanggalLahir.ToString("dd-MM-yyyy");
            lblJenisKelamin.Text = getData.Gender;
            lblJabatanDD.Text = getData.SNama;
            lblAlamat.Text = getData.Alamat;
            lblUsername.Text = getData.Username;

            pnlOverlay.BringToFront();
            pnlOverlay.BackColor = Color.FromArgb(128, 0, 0, 0); // hitam transparan
            pnlOverlay.FillColor = Color.FromArgb(128, 0, 0, 0); // pastikan juga fill transparan
        }

        private void lblUserAccess_MouseEnter(object sender, EventArgs e)
        {
            lblUserAccess.ForeColor = Color.Blue;
        }

        private void lblUserAccess_MouseLeave(object sender, EventArgs e)
        {
            lblUserAccess.ForeColor = ColorTranslator.FromHtml("#016015");
        }

        private void pnlOverlay_Click(object sender, EventArgs e)
        {
            pnlOverlay.SendToBack();
            txtPassword.Clear();
        }


        private void btnGantiPassword_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                connection.UpdatePasswordKaryawanByUsername(username, txtPassword.Text);
                txtPassword.Text = null;
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

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormLogin login = new FormLogin();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void btnLaporanPenjualan_Click(object sender, EventArgs e)
        {
            var laporan = new LaporanPenjualan(tglmulai.Value, tglakhir.Value);
            laporan.Show();
        }

        private void btnLaporanStokKeluar_Click(object sender, EventArgs e)
        {
            var laporan = new LaporanStokKeluar(tglmulai.Value, tglakhir.Value);
            laporan.Show();
        }

        private void btnLaporanReturBarang_Click(object sender, EventArgs e)
        {
            var laporan = new LaporanReturBarang(tglmulai.Value, tglakhir.Value);
            laporan.Show();
        }

        private void btnLaporanPengiriman_Click(object sender, EventArgs e)
        {
            var laporan = new LaporanPengiriman(tglmulai.Value, tglakhir.Value);
            laporan.Show();
        }

        // --- Fungsi Dashboard Owner ---
        private void DashboardOwner_Load()
        {
            DateTime today = DateTime.Now.Date;
            DateTime awalBulan = new DateTime(today.Year, today.Month, 1);
            DateTime akhirBulan = today.AddDays(-1);

            // Set batas tanggal terlebih dahulu
            tglmulai.MinDate = new DateTime(2000, 1, 1); // Sesuai kebutuhan
            tglmulai.MaxDate = today;
            tglakhir.MinDate = new DateTime(2000, 1, 1); // Sesuai kebutuhan
            tglakhir.MaxDate = today;

            // Baru atur nilai default
            tglmulai.Value = awalBulan;
            tglakhir.Value = akhirBulan;
            chartPengirimanBulanan();
            LoadPieChartData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chartPengirimanBulanan();
            LoadPieChartData();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadPieChartPengirimanWithDateRange();
            LoadPieChartDataWithDateRange();
        }

        private void LoadPieChartData()
        {
            int jumlahPenjualan = 0;
            int jumlahRetur = 0;
            int jumlahStokKeluar = 0;

            try
            {
                SqlConnection conn = connection.conn;
                conn.Open();

                // Penjualan
                string queryPenjualan = @"SELECT ISNULL(SUM(dp.dp_kuantitas), 0) 
                                  FROM penjualan p 
                                  JOIN detail_transaksi_penjualan dp ON p.pnj_id = dp.pnj_id 
                                  WHERE p.pnj_status = 1";
                using (SqlCommand cmd = new SqlCommand(queryPenjualan, conn))
                {
                    jumlahPenjualan = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Retur
                string queryRetur = "SELECT ISNULL(SUM(rtr_jumlah_retur), 0) FROM retur_pembeli";
                using (SqlCommand cmd = new SqlCommand(queryRetur, conn))
                {
                    jumlahRetur = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Stok Keluar
                string queryStok = "SELECT ISNULL(SUM(sk_jumlah_keluar), 0) FROM stok_keluar";
                using (SqlCommand cmd = new SqlCommand(queryStok, conn))
                {
                    jumlahStokKeluar = Convert.ToInt32(cmd.ExecuteScalar());
                }

                conn.Close();

                int total = jumlahPenjualan + jumlahRetur + jumlahStokKeluar;
                if (total == 0) total = 1; // Hindari pembagian nol

                double persenPenjualan = jumlahPenjualan * 100.0 / total;
                double persenRetur = jumlahRetur * 100.0 / total;
                double persenStok = jumlahStokKeluar * 100.0 / total;

                // Setup Pie Chart
                var series = piechart3transaksi.Series[0];
                series.Points.Clear();
                series.ChartType = SeriesChartType.Pie;
                series["PieLabelStyle"] = "Inside"; // Bisa juga "Outside"
                series.LabelForeColor = Color.White;
                series.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                // Tambah data dengan label persen
                DataPoint dpPenjualan = new DataPoint(0, jumlahPenjualan);
                dpPenjualan.Label = $"Penjualan\n{jumlahPenjualan} ({persenPenjualan:F1}%)";
                series.Points.Add(dpPenjualan);

                DataPoint dpRetur = new DataPoint(0, jumlahRetur);
                dpRetur.Label = $"Retur\n{jumlahRetur} ({persenRetur:F1}%)";
                series.Points.Add(dpRetur);

                DataPoint dpStok = new DataPoint(0, jumlahStokKeluar);
                dpStok.Label = $"Stok Keluar\n{jumlahStokKeluar} ({persenStok:F1}%)";
                series.Points.Add(dpStok);

                piechart3transaksi.Titles.Clear();
                piechart3transaksi.Titles.Add("Perbandingan Penjualan, Retur, dan Stok Keluar");

                // Tampilkan ke TextBox
                tbjumlahpenjualan.Text = jumlahPenjualan.ToString();
                tbjumlahretur.Text = jumlahRetur.ToString();
                tbjumlahstok.Text = jumlahStokKeluar.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data PieChart.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPieChartDataWithDateRange()
        {
            int jumlahPenjualan = 0;
            int jumlahRetur = 0;
            int jumlahStokKeluar = 0;

            try
            {
                SqlConnection conn = connection.conn;
                conn.Open();

                // Ambil filter tanggal dari DateTimePicker
                DateTime tglMulai = tglmulai.Value.Date;
                DateTime tglSelesai = tglakhir.Value.Date.AddDays(1).AddSeconds(-1); // Akhir hari

                // Penjualan dengan filter tanggal
                string queryPenjualan = @"SELECT ISNULL(SUM(dp.dp_kuantitas), 0) 
                                  FROM penjualan p
                                  JOIN detail_transaksi_penjualan dp ON p.pnj_id = dp.pnj_id 
                                  WHERE p.pnj_status = 1 
                                  AND p.pnj_created_date BETWEEN @tglMulai AND @tglSelesai";

                using (SqlCommand cmd = new SqlCommand(queryPenjualan, conn))
                {
                    cmd.Parameters.AddWithValue("@tglMulai", tglMulai);
                    cmd.Parameters.AddWithValue("@tglSelesai", tglSelesai);
                    jumlahPenjualan = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Retur (misal retur tidak pakai tanggal, jika ingin bisa ditambahkan)
                string queryRetur = @"
            SELECT ISNULL(SUM(rtr_jumlah_retur), 0) AS total_retur
            FROM retur_pembeli
            WHERE rtr_tanggal_retur >= @tglMulai AND rtr_tanggal_retur < @tglSelesai";

                using (SqlCommand cmd = new SqlCommand(queryRetur, conn))
                {
                    cmd.Parameters.AddWithValue("@tglMulai", tglMulai);
                    cmd.Parameters.AddWithValue("@tglSelesai", tglSelesai);
                    jumlahRetur = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Query Stok Keluar
                string queryStok = @"
            SELECT ISNULL(SUM(sk_jumlah_keluar), 0) AS total_stok
            FROM stok_keluar
            WHERE sk_tanggal_keluar >= @tglMulai AND sk_tanggal_keluar < @tglSelesai";

                using (SqlCommand cmd = new SqlCommand(queryStok, conn))
                {
                    cmd.Parameters.AddWithValue("@tglMulai", tglMulai);
                    cmd.Parameters.AddWithValue("@tglSelesai", tglSelesai);
                    jumlahStokKeluar = Convert.ToInt32(cmd.ExecuteScalar());
                }


                conn.Close();

                int total = jumlahPenjualan + jumlahRetur + jumlahStokKeluar;
                if (total == 0) total = 1; // Hindari pembagian nol

                double persenPenjualan = jumlahPenjualan * 100.0 / total;
                double persenRetur = jumlahRetur * 100.0 / total;
                double persenStok = jumlahStokKeluar * 100.0 / total;

                // Setup Pie Chart
                var series = piechart3transaksi.Series[0];
                series.Points.Clear();
                series.ChartType = SeriesChartType.Pie;
                series["PieLabelStyle"] = "Inside";
                series.LabelForeColor = Color.White;
                series.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                // Tambah data ke chart
                DataPoint dpPenjualan = new DataPoint(0, jumlahPenjualan);
                dpPenjualan.Label = $"Penjualan\n{jumlahPenjualan} ({persenPenjualan:F1}%)";
                series.Points.Add(dpPenjualan);

                DataPoint dpRetur = new DataPoint(0, jumlahRetur);
                dpRetur.Label = $"Retur\n{jumlahRetur} ({persenRetur:F1}%)";
                series.Points.Add(dpRetur);

                DataPoint dpStok = new DataPoint(0, jumlahStokKeluar);
                dpStok.Label = $"Stok Keluar\n{jumlahStokKeluar} ({persenStok:F1}%)";
                series.Points.Add(dpStok);

                // Judul chart
                piechart3transaksi.Titles.Clear();
                piechart3transaksi.Titles.Add("Perbandingan Penjualan, Retur, dan Stok Keluar");

                // Tampilkan ke TextBox
                tbjumlahpenjualan.Text = jumlahPenjualan.ToString();
                tbjumlahretur.Text = jumlahRetur.ToString();
                tbjumlahstok.Text = jumlahStokKeluar.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data PieChart.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadPieChartPengirimanWithDateRange()
        {
            if (tglmulai.Value == null || tglakhir.Value == null)
            {
                MessageBox.Show("Harap pilih tanggal mulai dan tanggal selesai terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tglakhir.Value < tglmulai.Value)
            {
                MessageBox.Show("Tanggal selesai tidak boleh lebih awal dari tanggal mulai.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime startDate = tglmulai.Value.Date;
            DateTime endDate = tglakhir.Value.Date.AddDays(1); // supaya tanggal akhir termasuk

            int pengirimanBelum = 0;
            int pengirimanSedang = 0;
            int pengirimanSelesai = 0;

            string query = @"
        SELECT png_status_pengiriman, COUNT(*) AS jumlah 
        FROM pengiriman 
        WHERE png_modif_date >= @start AND png_modif_date < @end 
        GROUP BY png_status_pengiriman";
            DBConnect connection = new DBConnect();
            SqlConnection conn = connection.conn;
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@start", startDate);
                cmd.Parameters.AddWithValue("@end", endDate);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int status = reader.GetInt32(0);
                        int jumlah = reader.GetInt32(1);

                        switch (status)
                        {
                            case 0:
                                pengirimanBelum = jumlah;
                                break;
                            case 1:
                                pengirimanSedang = jumlah;
                                break;
                            case 2:
                                pengirimanSelesai = jumlah;
                                break;
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data pie chart pengiriman:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Set Data ke Chart
            int total = pengirimanBelum + pengirimanSedang + pengirimanSelesai;
            piechartpengiriman.Series.Clear();
            piechartpengiriman.Titles.Clear();
            piechartpengiriman.Series.Add("Pengiriman");
            piechartpengiriman.Series["Pengiriman"].ChartType = SeriesChartType.Pie;
            piechartpengiriman.Series["Pengiriman"].Points.Clear();

            if (total == 0)
            {
                piechartpengiriman.Titles.Add("Tidak Ada Data Pengiriman pada Rentang Tanggal");
                return;
            }

            double persenBelum = pengirimanBelum * 100.0 / total;
            double persenSedang = pengirimanSedang * 100.0 / total;
            double persenSelesai = pengirimanSelesai * 100.0 / total;

            piechartpengiriman.Series["Pengiriman"].Points.AddXY($"Belum Dikirim ({pengirimanBelum}, {persenBelum:0.0}%)", pengirimanBelum);
            piechartpengiriman.Series["Pengiriman"].Points.AddXY($"Sedang Dikirim ({pengirimanSedang}, {persenSedang:0.0}%)", pengirimanSedang);
            piechartpengiriman.Series["Pengiriman"].Points.AddXY($"Selesai Dikirim ({pengirimanSelesai}, {persenSelesai:0.0}%)", pengirimanSelesai);

            piechartpengiriman.Titles.Add("Status Pengiriman (Filter Tanggal)");
            tbjumlahpengiriman.Text = pengirimanSelesai.ToString();

        }


        private void chartPengirimanBulanan()
        {
            try
            {
                int pengirimanBelum = 0;
                int pengirimanSedang = 0;
                int pengirimanSelesai = 0;

                string query = @"
            SELECT png_status_pengiriman, COUNT(*) AS jumlah
            FROM pengiriman
            GROUP BY png_status_pengiriman";

                using (SqlCommand cmd = new SqlCommand(query, connection.conn))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int status = reader.GetInt32(0);
                            int jumlah = reader.GetInt32(1);

                            switch (status)
                            {
                                case 0: pengirimanBelum = jumlah; break;
                                case 1: pengirimanSedang = jumlah; break;
                                case 2: pengirimanSelesai = jumlah; break;
                            }
                        }
                    }
                    connection.Close();
                }

                int total = pengirimanBelum + pengirimanSedang + pengirimanSelesai;
                if (total == 0) total = 1; // Hindari divide-by-zero

                double persenBelum = pengirimanBelum * 100.0 / total;
                double persenSedang = pengirimanSedang * 100.0 / total;
                double persenSelesai = pengirimanSelesai * 100.0 / total;

                piechartpengiriman.Series.Clear();
                piechartpengiriman.Titles.Clear();
                piechartpengiriman.Titles.Add($"Status Pengiriman (Total: {pengirimanBelum + pengirimanSedang + pengirimanSelesai})");

                Series series = new Series
                {
                    Name = "Pengiriman",
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true
                };

                series.Points.Add(new DataPoint(0, pengirimanBelum)
                {
                    Label = $"Belum\n{persenBelum:F1}%",
                    LegendText = $"Belum Dikirim ({pengirimanBelum})"
                });

                series.Points.Add(new DataPoint(0, pengirimanSedang)
                {
                    Label = $"Sedang\n{persenSedang:F1}%",
                    LegendText = $"Sedang Dikirim ({pengirimanSedang})"
                });

                series.Points.Add(new DataPoint(0, pengirimanSelesai)
                {
                    Label = $"Selesai\n{persenSelesai:F1}%",
                    LegendText = $"Selesai Dikirim ({pengirimanSelesai})"
                });

                piechartpengiriman.Series.Add(series);

                // Isi TextBox jumlah selesai dan total
                tbjumlahpengiriman.Text = pengirimanSelesai.ToString();
                //tbTotalPengiriman.Text = (pengirimanBelum + pengirimanSedang + pengirimanSelesai).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat PieChart Pengiriman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
