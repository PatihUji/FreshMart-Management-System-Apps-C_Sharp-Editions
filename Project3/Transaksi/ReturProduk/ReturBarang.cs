using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Transaksi.Retur_Barang
{
    public class ReturBarang
    {
        public int Rtr_id { get; set; }
        public DateTime Rtr_tanggal_retur { get; set; }
        public int Rtr_jumlah_retur { get; set; }
        public int Pnj_id { get; set; }
        public int Kry_id { get; set; }
        public string Nama_karyawan { get; set; }

        public ReturBarang(int rtr_id, DateTime tanggal_retur, int jumlah_retur, int pnj_id, int kry_id, string nama_karyawan)
        {
            Rtr_id = rtr_id;
            Rtr_tanggal_retur = tanggal_retur;
            Rtr_jumlah_retur = jumlah_retur;
            Pnj_id = pnj_id;
            Kry_id = kry_id;
            Nama_karyawan = nama_karyawan;
        }
    }
}
