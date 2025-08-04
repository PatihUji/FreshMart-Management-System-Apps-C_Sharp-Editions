using Project3.Laporan.TransaksiPengiriman;
using Project3.Laporan.TransaksiPenjualan;
using Project3.SideBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());


            //Application.Run(new LaporanPengiriman(DateTime.Parse("2024-07-21"), DateTime.Parse("2025-07-21")));
        }
    }
}
