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
    public partial class DashboardQC : Form
    {
        DBConnect connection = new DBConnect();
        private string userAccess;
        public DashboardQC(String user)
        {
            InitializeComponent();
            this.userAccess = user;
        }

        private void DashboardQC_Load(object sender, EventArgs e)
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
            chartBulanan();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tglakhir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tglmulai_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            chartBulanan();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tglmulai.Value = new DateTime(DateTime.Now.Year, 1, 1);
            tglakhir.Value = DateTime.Today.AddDays(-1);
            chartBulanan();
        }

        private void chartbatang_Click(object sender, EventArgs e)
        {

        }

        private void chartBulanan()
        {
            try
            {
                // Default tanggal jika tidak dipilih
                DateTime defaultStart = new DateTime(DateTime.Now.Year, 1, 1);
                DateTime defaultEnd = new DateTime(DateTime.Now.Year, 12, 31);

                // Ambil dari DateTimePicker (jika null gunakan default)
                DateTime startDate = tglmulai.Value != null ? tglmulai.Value.Date : defaultStart;
                DateTime endDate = tglakhir.Value != null ? tglakhir.Value.Date.AddDays(1) : defaultEnd.AddDays(1); // supaya inclusive

                chartStok.Series.Clear();
                chartStok.Titles.Clear();
                chartStok.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chartStok.ChartAreas[0].AxisX.Interval = 1;

                Series series = new Series("Stok Keluar per Bulan")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                string query = @"
            SELECT FORMAT(sk_tanggal_keluar, 'MMMM yyyy', 'id-ID') AS bulan_tahun,
                   SUM(sk_jumlah_keluar) AS total
            FROM stok_keluar
            WHERE sk_tanggal_keluar >= @start AND sk_tanggal_keluar < @end
            GROUP BY FORMAT(sk_tanggal_keluar, 'MMMM yyyy', 'id-ID')
            ORDER BY MIN(sk_tanggal_keluar) ASC";

                using (SqlCommand cmd = new SqlCommand(query, connection.conn))
                {
                    cmd.Parameters.AddWithValue("@start", startDate);
                    cmd.Parameters.AddWithValue("@end", endDate);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int totalStok = 0;

                        while (reader.Read())
                        {
                            string bulanTahun = reader.GetString(0);
                            int jumlah = reader.GetInt32(1);

                            series.Points.AddXY(bulanTahun, jumlah);
                            totalStok += jumlah;
                        }

                        tbjumlahstok.Text = totalStok.ToString();
                    }
                    connection.Close();
                }

                chartStok.Series.Add(series);
                chartStok.Titles.Add("Stok Keluar Bulanan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data Bar Chart: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbjumlahstok_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
