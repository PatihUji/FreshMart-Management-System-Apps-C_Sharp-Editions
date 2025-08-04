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
using System.Web.UI.WebControls;

namespace Project3.Transaksi.Penjualan
{
    public partial class ListShowProduk: UserControl
    {
        public Penjualan parentForm1;
        public void setParentForm1(Penjualan form)
        {
            parentForm1 = form;
        }

        int p_id;
        String fileName;
        String namaProduk;
        Double harga;
        String satuan;
        String jenisProduk;
        Int32 stok;
        public ListShowProduk(int p_id, String fileName, String namaProduk, Double harga, String satuan, String jenisProduk, Int32 stok)
        {
            InitializeComponent();
            setDataProduk(p_id, fileName, namaProduk, harga, satuan, jenisProduk, stok);
            this.p_id = p_id;
            this.fileName = fileName;
            this.namaProduk = namaProduk;
            this.harga = harga;
            this.satuan = satuan;
            this.jenisProduk = jenisProduk;
            this.stok = stok;
        }

        public void setDataProduk(int p_id, String fileName, String namaProduk, Double harga, String satuan, String jenisProduk, Int32 stok)
        {
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

            lblHargaDanSatuan.Text = FormatRupiah(harga) + " / " + satuan;

            lblJenisProduk.Text = jenisProduk;

            lblStokTersisa.Text = stok.ToString() + " stok tersisa";


        }

        public static string FormatRupiah(Double amount)
        {
            return string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp{0:N2}", amount);
        }

        private void displayCaseProduk_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (Control ctrl in parentForm1.formPenjualan.fpKeranjang.Controls)
                {
                    if (ctrl is ProdukInCart existingItem)
                    {
                        if (existingItem.p_id == this.p_id)
                        {
                            // Tambahkan kuantitas
                            existingItem.TambahKuantitas(1);
                            return; // Jangan tambah item baru lagi
                        }
                    }
                }

                var item = new ProdukInCart(p_id, fileName, namaProduk, jenisProduk, harga);
                item.setParentForm2(parentForm1.formPenjualan); // <- tambahkan ini!
                parentForm1.formPenjualan.fpKeranjang.Controls.Add(item);
                parentForm1.formPenjualan.HitungTotalHarga(); // update total setelah ditambahkan
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah ke keranjang: " + ex.Message);
            }
        }

        private void imvProduk_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (Control ctrl in parentForm1.formPenjualan.fpKeranjang.Controls)
                {
                    if (ctrl is ProdukInCart existingItem)
                    {
                        if (existingItem.p_id == this.p_id)
                        {
                            // Tambahkan kuantitas
                            existingItem.TambahKuantitas(1);
                            return; // Jangan tambah item baru lagi
                        }
                    }
                }

                var item = new ProdukInCart(p_id, fileName, namaProduk, jenisProduk, harga);
                item.setParentForm2(parentForm1.formPenjualan); // <- tambahkan ini!
                parentForm1.formPenjualan.fpKeranjang.Controls.Add(item);
                parentForm1.formPenjualan.HitungTotalHarga(); // update total setelah ditambahkan
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah ke keranjang: " + ex.Message);
            }
        }
    }
}
