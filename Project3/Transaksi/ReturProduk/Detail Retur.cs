using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Transaksi.Retur_Barang
{
    public class Detail_Retur
    {
        public int P_id { get; set; }
        public string P_nama { get; set; }
        public int Drp_kuantitas { get; set; }
        public string Drp_alasan { get; set; }

        public Detail_Retur(int p_id, string p_nama, int drp_kuantitas, string drp_alasan)
        {
            P_id = p_id;
            P_nama = p_nama;
            Drp_kuantitas = drp_kuantitas;
            Drp_alasan = drp_alasan;
        }

        public Detail_Retur(string p_nama, int drp_kuantitas, string drp_alasan)
        {
            P_nama = p_nama;
            Drp_kuantitas = drp_kuantitas;
            Drp_alasan = drp_alasan;
        }
    }
}

   