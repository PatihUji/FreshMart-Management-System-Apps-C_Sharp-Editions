using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project3.Database;
using Project3.Master.Promo;

namespace Project3.Transaksi.Penjualan
{
    public partial class FormPenjualan: UserControl
    {
        public FormPenjualan()
        {
            InitializeComponent();
            ProdukInCart produk = new ProdukInCart();
            produk.setParentForm2(this);

            ComboBoxJenisPembelian();
            ComboBoxMetodePembayaran();
        }

        public void setTotalHarga(Double totalHarga)
        {
            txtTotalHarga.Text = FormatRupiah(totalHarga);
        }

        public Double getTotalHarga()
        {
            if (string.IsNullOrWhiteSpace(txtTotalHarga.Text)) return 0;

            try
            {
                string rupiah = txtTotalHarga.Text;

                // Bersihkan format rupiah
                string cleaned = rupiah.Replace("Rp", "")
                                       .Trim()
                                       .Replace(".", "")
                                       .Replace(",", ".");

                return double.Parse(cleaned, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                return 0;
            }
        }

        private double totalHargaSebelumDiskon = 0;

        public void HitungTotalHarga()
        {
            double total = 0;
            foreach (Control ctrl in fpKeranjang.Controls)
            {
                if (ctrl is ProdukInCart item)
                {
                    total += item.HargaPerItem * item.GetKuantitas();
                }
            }

            totalHargaSebelumDiskon = total;
            setTotalHarga(total);
        }

        public double getTotalHargaSebelumDiskon()
        {
            return totalHargaSebelumDiskon;
        }

        public static string FormatRupiah(Double amount)
        {
            return string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp{0:N2}", amount);
        }

        DBConnect connection = new DBConnect();
        private void ComboBoxJenisPembelian()
        {
            cbJenisPembelian.DataSource = connection.getListSettingByKategori("Jenis Pembelian");
            cbJenisPembelian.DisplayMember = "s_nama";
            cbJenisPembelian.ValueMember = "s_id";
            cbJenisPembelian.SelectedIndex = -1;
        }

        private void ComboBoxMetodePembayaran()
        {
            cbMetodePembayaran.DataSource = connection.getListMetodePembayaran();
            cbMetodePembayaran.DisplayMember = "mpb_nama";
            cbMetodePembayaran.ValueMember = "mpb_id";
            cbMetodePembayaran.SelectedIndex = -1;
        }

        public void setLblNamaKasir(String namaKasir)
        {
            lblNamaKasir.Text = namaKasir;
        }

        int kry_id;
        public void setIdKry(String username)
        {
            kry_id = connection.GetIdKaryawanByUsername(username);
        }

        public Penjualan parentForm;
        public void setParentForm(Penjualan form)
        {
            parentForm = form;
        }

        bool isPromoVisible = false;
        private void btnPromo_Click(object sender, EventArgs e)
        {
            if (!isPromoVisible)
            {
                isPromoVisible = true;
            }
            else
            {
                isPromoVisible = false;
            }

            parentForm.ckbPromo.Visible = isPromoVisible;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            bool adaProduk = false;
            foreach (Control ctrl in fpKeranjang.Controls)
            {
                if (ctrl is ProdukInCart)
                {
                    adaProduk = true;
                    break;
                }
            }

            if (!adaProduk || String.IsNullOrWhiteSpace(txtTotalDibayar.Text) || cbJenisPembelian.SelectedIndex == -1 || cbMetodePembayaran.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong!", "Validasi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // 1. Ambil produk dari keranjang
                List<DetailPenjualan> listProduk = new List<DetailPenjualan>();
                foreach (Control ctrl in fpKeranjang.Controls)
                {
                    if (ctrl is ProdukInCart item)
                    {
                        DetailPenjualan dp = new DetailPenjualan();
                        dp.P_id = item.p_id;
                        dp.Dp_kuantitas = item.GetKuantitas();
                        dp.Dp_subTotal = item.HargaPerItem * item.GetKuantitas();
                        listProduk.Add(dp);
                    }
                }

                // 2. Ambil promo yang diceklis
                List<DetailPromo> listPromo = new List<DetailPromo>();
                foreach (var obj in parentForm.ckbPromo.CheckedItems)
                {
                    if (obj is PromoADT promo)
                    {
                        listPromo.Add(new DetailPromo { Pr_id = promo.pr_id });
                    }
                }

                int s_id = (int)cbJenisPembelian.SelectedValue;
                int mpb_id = (int)cbMetodePembayaran.SelectedValue;
                double total = getTotalHarga();
                string createdBy = lblNamaKasir.Text;

                // 4. Konversi ke DataTable
                DataTable dtDetail = new DataTable();
                dtDetail.Columns.Add("p_id", typeof(int));
                dtDetail.Columns.Add("dp_kuantitas", typeof(int));
                dtDetail.Columns.Add("dp_subtotal", typeof(decimal));
                foreach (var item in listProduk)
                {
                    dtDetail.Rows.Add(item.P_id, item.Dp_kuantitas, item.Dp_subTotal);
                }

                DataTable dtPromo = new DataTable();
                dtPromo.Columns.Add("pr_id", typeof(int));
                foreach (var item in listPromo)
                {
                    dtPromo.Rows.Add(item.Pr_id);
                }

                // 5. Simpan ke database
                if (cbJenisPembelian.Text.Equals("Pengiriman"))
                {
                    connection.InsertPenjualan(s_id, mpb_id, kry_id, total, createdBy, 0, dtDetail, dtPromo);
                }
                else if(cbJenisPembelian.Text.Equals("Bawa Pulang"))
                {
                    connection.InsertPenjualan(s_id, mpb_id, kry_id, total, createdBy, 1, dtDetail, dtPromo);
                }

                clear();
                parentForm.loadDataProduk(parentForm.search);
            }
        }

        private void txtTotalDibayar_TextChanged(object sender, EventArgs e)
        {
            string text = txtTotalDibayar.Text.Replace(",", "").TrimStart('0');

            if (string.IsNullOrEmpty(text))
            {
                txtTotalDibayar.Text = "";
                return;
            }

            if (double.TryParse(text, out double value))
            {
                txtTotalDibayar.Text = value.ToString("N0");
                txtTotalDibayar.SelectionStart = txtTotalDibayar.Text.Length;

                hitungKembalian();
            }
            else
            {
                txtTotalDibayar.Text = "";
            }

            hitungKembalian();
        }

        private void txtTotalDibayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtTotalDibayar.Text.Length > 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public void hitungKembalian()
        {
            string totalDibayar = txtTotalDibayar.Text;
            string totalHarga = txtTotalHarga.Text;

            // Bersihkan format rupiah
            string cleaned1 = totalDibayar.Replace("Rp", "").Trim().Replace(".", "").Replace(",", ".");
            string cleaned2 = totalHarga.Replace("Rp", "").Trim().Replace(".", "").Replace(",", ".");

            Double tBayar =  double.Parse(cleaned1, System.Globalization.CultureInfo.InvariantCulture);
            Double tHarga =  double.Parse(cleaned2, System.Globalization.CultureInfo.InvariantCulture);

            Double kembalian = tBayar - tHarga;

            if (kembalian > 0)
            {
                txtKembalian.Text = FormatRupiah(kembalian);
            }
            else
            {
                txtKembalian.Text = null;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            cbMetodePembayaran.SelectedIndex = -1;
            cbJenisPembelian.SelectedIndex = -1;
            fpKeranjang.Controls.Clear();
            isPromoVisible = false;
            parentForm.ckbPromo.Visible = isPromoVisible;

            for (int i = 0; i < parentForm.ckbPromo.Items.Count; i++)
            {
                parentForm.ckbPromo.SetItemChecked(i, false);
            }

            totalHargaSebelumDiskon = 0;

            txtTotalHarga.Text = null;
            txtTotalDibayar.Text = null;
            txtKembalian.Text = null;
        }
    }
}
