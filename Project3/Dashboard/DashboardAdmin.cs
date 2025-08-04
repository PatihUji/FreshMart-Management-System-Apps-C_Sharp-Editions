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

namespace Project3.Dashboard
{
    public partial class DashboardAdmin : Form
    {
        private String userAccess;

        public String getUserAccess()
        {
            return userAccess;
        }

        DBConnect db = new DBConnect();

        public DashboardAdmin(String userAccess)
        {
            InitializeComponent();
            this.userAccess = userAccess;

            tbStokProduk();
            tbJumlahKaryawan();
        }


        public void tbStokProduk()
        {
            string query = "SELECT SUM(p_stok) FROM produk";

            try
            {
                db.conn.Open(); // akses conn dari DBConnect

                SqlCommand cmd = new SqlCommand(query, db.conn);
                object result = cmd.ExecuteScalar();

                int totalStok = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                tbjumlahproduk.Text = totalStok.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil total stok: " + ex.Message);
            }
            finally
            {
                if (db.conn.State == ConnectionState.Open)
                    db.conn.Close();
            }
        }

        public void tbJumlahKaryawan()
        {
            string query = "SELECT COUNT(*) FROM karyawan WHERE kry_status = 1";

            try
            {
                db.conn.Open(); // akses koneksi dari DBConnect

                SqlCommand cmd = new SqlCommand(query, db.conn);
                object result = cmd.ExecuteScalar();

                int totalKaryawan = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                tbjmlhkry.Text = totalKaryawan.ToString(); // pastikan nama TextBox sesuai
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil jumlah karyawan: " + ex.Message);
            }
            finally
            {
                if (db.conn.State == ConnectionState.Open)
                    db.conn.Close();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbSatuan_TextChanged(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            string query = "SELECT SUM(p_stok) FROM produk";

            try
            {
                db.conn.Open(); // akses conn dari DBConnect

                SqlCommand cmd = new SqlCommand(query, db.conn);
                object result = cmd.ExecuteScalar();

                int totalStok = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                tbjumlahproduk.Text = totalStok.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil total stok: " + ex.Message);
            }
            finally
            {
                if (db.conn.State == ConnectionState.Open)
                    db.conn.Close();
            }
        }
    }
}
