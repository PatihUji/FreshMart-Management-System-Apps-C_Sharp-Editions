using Project3.Database;
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
    public partial class FormProduk : UserControl
    {
        string userAccess;

        string namaFileGambar = "";
        string pathFolderGambar = @"\Properties\Resources.Designer.cs\Resources"; // sesuaikan dengan lokasi folder kamu

        public FormProduk()
        {
            InitializeComponent();
        }

        public void SetUserAccess(string userAccess)
        {
            this.userAccess = userAccess;  
        }

        public void setParentForm(Produk form)
        {
            parentForm = form;
        }

        DBConnect connection = new DBConnect();
        int p_id = 0;

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Produk parentForm;

        //public void setParentForm(Produk form)
        //{
        //    parentForm = form;
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tbNama.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbJenisProduk.SelectedIndex == -1 || imageViewProduk.Image == null)
            {
                MessageBox.Show("Jenis Produk dan Gambar wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Boolean curent = false;

            if (String.IsNullOrWhiteSpace(tbNama.Text) || String.IsNullOrWhiteSpace(tbDeskripsi.Text) || String.IsNullOrWhiteSpace(tbharga.Text) || cbJenisProduk.SelectedIndex == -1 || String.IsNullOrWhiteSpace(tbSatuan.Text) || String.IsNullOrWhiteSpace(tbStok.Text) || imageViewProduk.Image == null)
            {
                MessageBox.Show("Data tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                String nama = tbNama.Text;
                Int32 jenisProduk = Convert.ToInt32(cbJenisProduk.SelectedValue);
                Double harga = Convert.ToDouble(tbharga.Text);
                //double harga = tbharga.Text;
                String satuan = tbSatuan.Text;
                int stok = Convert.ToInt32(tbStok.Text);
                String deskripsi = tbDeskripsi.Text;
                string gambar = namaFileGambar;

                if (p_id != 0 && connection.isProdukExist(p_id))
                {
                    connection.UpdateProduk(p_id, jenisProduk, nama, harga, satuan, stok, deskripsi, gambar, userAccess);
                    parentForm.LoadAllData();
                    parentForm.LoadPage();
                }
                else
                {
                    connection.InsertProduk(jenisProduk, nama, harga, satuan, stok, deskripsi, gambar, userAccess);
                    parentForm.LoadAllData();
                    parentForm.LoadPage();
                }
                Clear();
            }
        }

        private void ComboBoxJenisProduk()
        {
            DataTable dt = connection.getListJenisProdukByNama();

            // Tambahkan baris kosong di atas
            DataRow kosong = dt.NewRow();
            kosong["jp_id"] = 0;
            kosong["jp_nama"] = "-- Pilih Jenis --";
            dt.Rows.InsertAt(kosong, 0);

            cbJenisProduk.DataSource = dt;
            cbJenisProduk.DisplayMember = "jp_nama";
            cbJenisProduk.ValueMember = "jp_id";
            cbJenisProduk.SelectedIndex = 0; // default ke item kosong
        }


        public void Clear()
        {
            tbNama.Clear();
            tbDeskripsi.Clear();
            tbharga.Clear();
            tbSatuan.Clear();
            tbStok.Clear();
            cbJenisProduk.SelectedIndex = -1;
            //cbJenisProduk
            imageViewProduk.Image = null;
            namaFileGambar = "";
            p_id = 0;
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sumber = ofd.FileName;
                namaFileGambar = Path.GetFileName(sumber);
                string folderTujuan = Path.Combine(Application.StartupPath, @"..\..\Pict\Produk");

                if (!Directory.Exists(folderTujuan))
                {
                    Directory.CreateDirectory(folderTujuan);
                }

                string tujuan = Path.Combine(folderTujuan, namaFileGambar);

                File.Copy(sumber, tujuan, true);
                imageViewProduk.Image = Image.FromFile(tujuan);
            }
        }

        private void cbJenisProduk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            ComboBoxJenisProduk();
        }

        public void setForm(int p_id, int jp_id, string nama, string deskripsi, double harga, string satuan, int stok, string gambar)
        {
            this.p_id = p_id;
            tbNama.Text = nama;
            tbDeskripsi.Text = deskripsi;
            tbharga.Text = harga.ToString("N0"); // Format ribuan
            tbSatuan.Text = satuan;
            tbStok.Text = stok.ToString();
            cbJenisProduk.SelectedValue = jp_id;
            namaFileGambar = gambar;

            if (!string.IsNullOrEmpty(namaFileGambar))
            {
                string pathGambar = Path.Combine(Application.StartupPath, @"..\..\Pict\Produk", namaFileGambar);
                if (File.Exists(pathGambar))
                {
                    using (var bmpTemp = new Bitmap(pathGambar))
                    {
                        imageViewProduk.Image = new Bitmap(bmpTemp); // supaya file tidak terkunci
                    }
                }
                else
                {
                    imageViewProduk.Image = null;
                    MessageBox.Show("Gambar tidak ditemukan: " + pathGambar, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //private void ComboBoxJenisProduk()
        //{
        //    cbJenisProduk.DataSource = connection.getListJenisProdukByNama();
        //    cbJenisProduk.DisplayMember = "jp_nama";
        //    cbJenisProduk.ValueMember = "jp_id";
        //    cbJenisProduk.SelectedIndex = -1;
        //}

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tbNama_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tbNama.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbharga_TextChanged(object sender, EventArgs e)
        {
            string text = tbharga.Text.Replace(",", "").TrimStart('0');

            if (string.IsNullOrEmpty(text))
            {
                tbharga.Text = "";
                return;
            }

            if (double.TryParse(text, out double value))
            {
                tbharga.Text = value.ToString("N0");
                tbharga.SelectionStart = tbharga.Text.Length;
            }
            else
            {
                tbharga.Text = "";
            }
        }

        private void tbharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSatuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tbSatuan.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // tidak boleh 0 di awal
            if (tbStok.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        private void tbDeskripsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbDeskripsi.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
