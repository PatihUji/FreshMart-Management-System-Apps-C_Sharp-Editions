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
    public partial class DashboardCS : Form
    {
        private DBConnect connection = new DBConnect();

        public DashboardCS()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            chartBulanan();
        }

        private void chartRetur_Click(object sender, EventArgs e)
        {

        }

        private void DashboardCS_Load(object sender, EventArgs e)
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

        private void chartBulanan()
        {
            try
            {
                // Tanggal default: 1 Januari hingga hari sebelum hari ini
                DateTime defaultStart = new DateTime(DateTime.Now.Year, 1, 1);
                DateTime defaultEnd = DateTime.Now.Date.AddDays(-1);

                // Ambil dari DateTimePicker jika tersedia, jika tidak pakai default
                DateTime startDate = tglmulai.Value.Date != DateTime.MinValue ? tglmulai.Value.Date : defaultStart;
                DateTime endDate = tglakhir.Value.Date != DateTime.MinValue ? tglakhir.Value.Date.AddDays(1) : defaultEnd.AddDays(1); // +1 hari agar inclusive

                // Reset Chart
                chartRetur.Series.Clear();
                chartRetur.Titles.Clear();
                chartRetur.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chartRetur.ChartAreas[0].AxisX.Interval = 1;

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

                        tbjumlahretur.Text = totalStok.ToString("N0"); // Format angka ribuan
                    }
                    connection.Close();
                }

                chartRetur.Series.Add(series);
                chartRetur.Titles.Add("Stok Keluar Bulanan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data Bar Chart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbjumlahstok_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chartBulanan();
        }
    }
}
