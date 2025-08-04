using Project3.Database;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Project3.Dashboard
{
    public partial class DashboardKasir : Form
    {
        DBConnect connection = new DBConnect();
        private string userAccess;
        public DashboardKasir(String user)
        {
            InitializeComponent();
            this.userAccess = user;

        }

        private void DashboardKasir_Load(object sender, EventArgs e)
        {
            LoadJumlahPenjualanPengiriman();
            LoadPieChartData();
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
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void LoadPieChartData()
        {
            int jumlahPenjualan = 0;
            int jumlahPengiriman = 0;

            try
            {
                string queryPenjualan = "SELECT COUNT(*) AS jumlah FROM penjualan WHERE pnj_status = 1";
                string queryPengiriman = "SELECT COUNT(*) AS jumlah FROM pengiriman WHERE png_status_pengiriman = 2";

                connection.Open();

                using (SqlCommand cmdPenjualan = new SqlCommand(queryPenjualan, connection.conn))
                {
                    jumlahPenjualan = Convert.ToInt32(cmdPenjualan.ExecuteScalar());
                }

                using (SqlCommand cmdPengiriman = new SqlCommand(queryPengiriman, connection.conn))
                {
                    jumlahPengiriman = Convert.ToInt32(cmdPengiriman.ExecuteScalar());
                }

                connection.Close();

                int total = jumlahPenjualan + jumlahPengiriman;
                if (total == 0) total = 1; // Hindari pembagian dengan nol

                double persenPenjualan = (jumlahPenjualan * 100.0) / total;
                double persenPengiriman = (jumlahPengiriman * 100.0) / total;

                string labelPenjualan = $"Penjualan";
                string labelPengiriman = $"Pengiriman Selesai";

                chart1.Series.Clear();
                chart1.Titles.Clear();

                chart1.Titles.Add("Perbandingan Pengiriman & Penjualan");

                Series series = new Series
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                    Label = "#VALX (#VAL, #PERCENT)" // ✅ label diperbaiki di sini
                };

                series.Points.AddXY(labelPenjualan, jumlahPenjualan);
                series.Points.AddXY(labelPengiriman, jumlahPengiriman);

                chart1.Legends[0].Enabled = true;
                chart1.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data chart: " + ex.Message);
            }
        }

        private void tbnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadJumlahPenjualanPengiriman()
        {
            try
            {
                string queryPenjualan = "SELECT COUNT(*) AS jumlah FROM penjualan WHERE pnj_status = 1";
                string queryPengiriman = "SELECT COUNT(*) AS jumlah FROM pengiriman WHERE png_status_pengiriman = 2";

                using (SqlCommand cmdPenjualan = new SqlCommand(queryPenjualan, connection.conn))
                using (SqlCommand cmdPengiriman = new SqlCommand(queryPengiriman, connection.conn))
                {
                    if (connection.conn.State != ConnectionState.Open)
                        connection.Open();

                    int jumlahPenjualan = Convert.ToInt32(cmdPenjualan.ExecuteScalar());
                    int jumlahPengiriman = Convert.ToInt32(cmdPengiriman.ExecuteScalar());

                    tbjumlahpenjualan.Text = jumlahPenjualan.ToString();
                    tbjumlahpengiriman.Text = jumlahPengiriman.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data jumlah.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            loadPieChartDataWithRange();
        }

        private void loadPieChartDataWithRange()
        {
            if (tglmulai.Value == null || tglakhir.Value == null)
            {
                MessageBox.Show("Harap pilih tanggal mulai dan tanggal selesai terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tglakhir.Value.Date < tglmulai.Value.Date)
            {
                MessageBox.Show("Tanggal selesai tidak boleh lebih awal dari tanggal mulai.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jumlahPenjualan = 0;
            int jumlahPengiriman = 0;

            DateTime startDate = tglmulai.Value.Date;
            DateTime endDate = tglakhir.Value.Date.AddDays(1); // Agar termasuk tanggal akhir

            try
            {
                connection.Open();

                // Penjualan
                SqlCommand cmdPenjualan = new SqlCommand("SELECT COUNT(*) AS jumlah FROM penjualan WHERE pnj_status = 1 AND pnj_created_date >= @start AND pnj_created_date < @end", connection.conn);
                cmdPenjualan.Parameters.AddWithValue("@start", startDate);
                cmdPenjualan.Parameters.AddWithValue("@end", endDate);
                jumlahPenjualan = (int)cmdPenjualan.ExecuteScalar();

                // Pengiriman
                SqlCommand cmdPengiriman = new SqlCommand("SELECT COUNT(*) AS jumlah FROM pengiriman WHERE png_status_pengiriman = 2 AND png_modif_date >= @start AND png_modif_date < @end", connection.conn);
                cmdPengiriman.Parameters.AddWithValue("@start", startDate);
                cmdPengiriman.Parameters.AddWithValue("@end", endDate);
                jumlahPengiriman = (int)cmdPengiriman.ExecuteScalar();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int total = jumlahPenjualan + jumlahPengiriman;
            if (total == 0)
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Tidak Ada Data dalam Rentang Tanggal");
                return;
            }

            double persenPenjualan = (jumlahPenjualan * 100.0) / total;
            double persenPengiriman = (jumlahPengiriman * 100.0) / total;

            string labelPenjualan = $"Penjualan ({jumlahPenjualan}, {persenPenjualan:F1}%)";
            string labelPengiriman = $"Pengiriman Selesai ({jumlahPengiriman}, {persenPengiriman:F1}%)";

            // Tampilkan ke textbox (jika ada)
            tbjumlahpenjualan.Text = jumlahPenjualan.ToString();
            tbjumlahpengiriman.Text = jumlahPengiriman.ToString();

            // Tampilkan chart
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Perbandingan Penjualan dan Pengiriman (Filter Tanggal)");

            var series = chart1.Series.Add("Data");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series.Points.AddXY(labelPenjualan, jumlahPenjualan);
            series.Points.AddXY(labelPengiriman, jumlahPengiriman);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadJumlahPenjualanPengiriman();
            LoadPieChartData();
        }

        private void tbtgl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
