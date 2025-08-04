using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project3.Master.Produk;

namespace Project3
{
    public partial class CardStokKeluar: UserControl
    {
        private FormStockKeluar parentForm;
        public CardStokKeluar()
        {
            InitializeComponent();
        }

        private void CardStokKeluar_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string namaProduk, int jumlahStok)
        {
            lblNamaProduk.Text = namaProduk;
            lblJumlahStok.Text = jumlahStok.ToString();
        }

        public void SetParentForm(FormStockKeluar parent)
        {
            parentForm = parent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}