using Project3.Database;
using Project3.Master.JenisProduk;
using Project3.Master.Karyawan;
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

namespace Project3.Transaksi.Pengiriman
{
    public partial class FormPengiriman : UserControl
    {
        
        public FormPengiriman()
        {
            InitializeComponent();
        }

        string userAccess;
        //public Karyawan parentForm;

        public void SetUserAccess(string userAccess)
        {
            this.userAccess = userAccess;
        }

        public Pengiriman parentForm;


        public void setParentForm(Pengiriman form)
        {
            parentForm = form;
        }

        DBConnect connection = new DBConnect();
        int p_id = 0;

        private void cbkurir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxDriver()
        {
            DataTable dt = connection.getListKaryawanBySID();

            // Tambahkan baris kosong di atas
            DataRow kosong = dt.NewRow();
            kosong["kry_id"] = 0;
            kosong["kry_nama"] = "-- Pilih Driver --";
            dt.Rows.InsertAt(kosong, 0);

            cbkurir.DataSource = dt;
            cbkurir.DisplayMember = "kry_nama";
            cbkurir.ValueMember = "kry_id";
            cbkurir.SelectedIndex = 0;
        }

        private void FormPengiriman_Load(object sender, EventArgs e)
        {
            ComboBoxDriver();
            //tbjam.MaxLength = 2;
            //tbmenit.MaxLength = 2;

        }

        int pnj_id = 0;
        public void setFormPengiriman(int pnj_id, double totalHarga)
        {
            this.pnj_id = pnj_id; // kalau kamu butuh simpan ID ke field class
            tbidpenjualan.Text = pnj_id.ToString();
            tbtotalharga.Text = totalHarga.ToString("N0"); // format ribuan

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            cbkurir.SelectedIndex = -1;
            tbidpenjualan.Clear();
            tbalamat.Clear();
            tbnama.Clear();
            tbtotalharga.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbkurir.SelectedIndex <= 0)
            {
                MessageBox.Show("Silakan pilih kurir/driver.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbidpenjualan.Text) ||
                string.IsNullOrWhiteSpace(tbnama.Text) ||
                string.IsNullOrWhiteSpace(tbalamat.Text) ||
                string.IsNullOrWhiteSpace(tbtotalharga.Text))
            {
                MessageBox.Show("Semua kolom wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan waktuPengiriman = tbjam.Value.TimeOfDay;
            DateTime sekarang = DateTime.Now;
            TimeSpan jamSekarang = sekarang.TimeOfDay;

            if (waktuPengiriman < jamSekarang)
            {
                MessageBox.Show("Waktu pengiriman tidak boleh kurang dari waktu yang sekarang!.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPenjualan = int.Parse(tbidpenjualan.Text);
            int driverId = Convert.ToInt32(cbkurir.SelectedValue);
            string alamat = tbalamat.Text.Trim();
            string namaPenerima = tbnama.Text.Trim();
            //double totalHarga = double.Parse(tbtotalharga.Text.Replace(",", ""));

            try
            {
                connection.UpdatePengiriman(idPenjualan, driverId, alamat, tbtgl.Value, waktuPengiriman, 1, namaPenerima, userAccess);
                MessageBox.Show("Data pengiriman berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbjam_TextChanged(object sender, EventArgs e)
        {
            //ValidateTimeInput();
        }

        private void tbmenit_TextChanged(object sender, EventArgs e)
        {
            //ValidateTimeInput();
        }



        //private void ValidateTimeInput()
        //{
        //    if (int.TryParse(tbjam.Text, out int jam) && int.TryParse(tbmenit.Text, out int menit))
        //    {
        //        if (jam < 0 || jam > 23 || menit < 0 || menit > 59)
        //        {
        //            MessageBox.Show("Format waktu tidak valid (jam: 0–23, menit: 0–59)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // Ambil waktu sekarang
        //        DateTime sekarang = DateTime.Now;
        //        DateTime inputWaktu = new DateTime(sekarang.Year, sekarang.Month, sekarang.Day, jam, menit, 0);

        //        // Bandingkan
        //        if (inputWaktu < sekarang)
        //        {
        //            MessageBox.Show("Waktu tidak boleh kurang dari waktu sekarang!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //            // Reset input ke waktu sekarang
        //            tbjam.Text = sekarang.Hour.ToString("D2");
        //            tbmenit.Text = sekarang.Minute.ToString("D2");
        //        }
        //    }
        //}

        private void tbjam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // blok karakter selain angka
            }
        }

        private void tbmenit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // blok karakter selain angka
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbtotalharga_TextChanged(object sender, EventArgs e)
        {
            string text = tbtotalharga.Text.Replace(",", "").TrimStart('0');

            if (string.IsNullOrEmpty(text))
            {
                tbtotalharga.Text = "";
                return;
            }

            if (double.TryParse(text, out double value))
            {
                tbtotalharga.Text = value.ToString("N0");
                tbtotalharga.SelectionStart = tbtotalharga.Text.Length;
            }
            else
            {
                tbtotalharga.Text = "";
            }
        }

        private void tbtgl_ValueChanged(object sender, EventArgs e)
        {
            DateTime hariIni = DateTime.Today;
        }

        private void tbnama_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbnama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tbnama.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbalamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbalamat.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
