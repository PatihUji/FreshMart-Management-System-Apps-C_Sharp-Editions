using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Project3.Master.Karyawan;

namespace Project3.Transaksi.Penjualan
{
    public partial class ProdukInCart: UserControl
    {
        public Penjualan parentForm1;
        public FormPenjualan parentForm2;

        public void setParentForm1(Penjualan form)
        {
            parentForm1 = form;
        }

        public void setParentForm2(FormPenjualan form)
        {
            parentForm2 = form;
        }

        int kuantitas;
        public int p_id { get; private set; }
        private double hargaPerItem;

        public double HargaPerItem => hargaPerItem;
        public double harga;
        public int GetKuantitas()
        {
            return (int)nupKuantitas.Value;
        }

        public ProdukInCart(int id, String fileName, String namaProduk, String jenisProduk, Double harga)
        {
            InitializeComponent();
            setDataProduktoCart(id, fileName, namaProduk, jenisProduk, harga);
            kuantitas = 1;
            nupKuantitas.Value = kuantitas;
        }

        public ProdukInCart() { }

        public void setDataProduktoCart(int id, String fileName, String namaProduk, String jenisProduk, Double harga)
        {
            this.p_id = id;
            this.hargaPerItem = harga;

            String pathGambar = Path.Combine(Application.StartupPath, @"..\..\Pict\Produk", fileName);
            if (File.Exists(pathGambar))
            {
                using (var bmpTemp = new Bitmap(pathGambar))
                {
                    imvProduk.Image = new Bitmap(bmpTemp); // supaya file tidak terkunci
                }
            }
            else
            {
                using (var bmpTemp = new Bitmap(Path.Combine(Application.StartupPath, @"..\..\Pict\Produk\image_not_found.jpg")))
                {
                    imvProduk.Image = new Bitmap(bmpTemp); // supaya file tidak terkunci
                }
            }

            lblNamaProduk.Text = namaProduk;
            lblJenisProduk.Text = jenisProduk;
            lblHargaByKuantitas.Text = FormatRupiah(harga);
        }

        public static string FormatRupiah(Double amount)
        {
            return string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp{0:N2}", amount);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose(); // optional: untuk membebaskan resource

                parentForm2?.HitungTotalHarga();
            }
        }

        public void TambahKuantitas(int jumlah)
        {
            kuantitas += jumlah;
            nupKuantitas.Value = kuantitas;

            double total = hargaPerItem * kuantitas;
            lblHargaByKuantitas.Text = FormatRupiah(total);

            parentForm2?.HitungTotalHarga();
        }

        private void nupKuantitas_ValueChanged(object sender, EventArgs e)
        {
            kuantitas = Convert.ToInt32(nupKuantitas.Value);

            double total = hargaPerItem * kuantitas;
            lblHargaByKuantitas.Text = FormatRupiah(total);

            parentForm2?.HitungTotalHarga();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
