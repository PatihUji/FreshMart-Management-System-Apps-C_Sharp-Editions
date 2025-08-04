using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Master.Promo
{
    public class PromoADT
    {
        public int pr_id { get; set; }
        public string pr_nama { get; set; }
        public double pr_persentase { get; set; }

        public PromoADT(int pr_id, string pr_nama, double pr_persentase)
        {
            this.pr_id = pr_id;
            this.pr_nama = pr_nama;
            this.pr_persentase = pr_persentase;
        }

        public override string ToString()
        {
            return pr_nama; // Untuk ditampilkan di ComboBox atau CheckedListBox
        }
    }
}
