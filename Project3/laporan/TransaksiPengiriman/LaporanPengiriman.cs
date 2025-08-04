using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3.Laporan.TransaksiPengiriman
{
    public partial class LaporanPengiriman : Form
    {
        DateTime tglMulai;
        DateTime tglSelesai;
        public LaporanPengiriman(DateTime tglMulai, DateTime tglSelesai)
        {
            InitializeComponent();
            this.tglMulai = tglMulai;
            this.tglSelesai = tglSelesai;
        }

        private void LaporanPengiriman_Load(object sender, EventArgs e)
        {

            var adapter = new Project3.Database.TheFreshChoiceTableAdapters.sp_laporan_pengirimanTableAdapter();
            var dataTable = new Project3.Database.TheFreshChoice.sp_laporan_pengirimanDataTable();

            adapter.Fill(dataTable, tglMulai, tglSelesai);

            ReportDataSource rds = new ReportDataSource("dsPengiriman", (DataTable)dataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = @"..\..\Laporan\TransaksiPengiriman\ReportPengiriman.rdlc";

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        //private void btnFilter_Click(object sender, EventArgs e)
        //{
        //    this.reportViewer1.RefreshReport();
        //    var adapter = new Project3.Database.TheFreshChoiceTableAdapters.sp_laporan_pengirimanTableAdapter();
        //    var dataTable = new Project3.Database.TheFreshChoice.sp_laporan_pengirimanDataTable();

        //    // 2. Isi data menggunakan parameter
        //    //adapter.Fill(dataTable, DateTime.Parse("2025-07-21"), DateTime.Parse("2025-07-21"));
        //    //adapter.Fill(dataTable, null, null);
        //    adapter.Fill(dataTable, tglmulai.Value, tglselesai.Value);

        //    // 3. Siapkan ReportDataSource
        //    ReportDataSource rds = new ReportDataSource("dsPengiriman", (DataTable)dataTable);

        //    // 4. Set report ke ReportViewer
        //    reportViewer1.LocalReport.DataSources.Clear();
        //    reportViewer1.LocalReport.DataSources.Add(rds);
        //    reportViewer1.LocalReport.ReportEmbeddedResource = "Project3.Laporan.TransaksiPengiriman.ReportPengiriman.rdlc"; // ganti sesuai path reportmu

        //    // 5. Refresh ReportViewer
        //    reportViewer1.RefreshReport();
        //}

        //private void btnBersihkan_Click(object sender, EventArgs e)
        //{
        //    DateTime now = DateTime.Now;
        //    tglmulai.Value = new DateTime(now.Year, 1, 1);
        //    //tglakhir.Value = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
        //    tglselesai.Value = DateTime.Today.AddDays(-1);

        //    this.reportViewer1.RefreshReport();
        //    var adapter = new Project3.Database.TheFreshChoiceTableAdapters.sp_laporan_pengirimanTableAdapter();
        //    var dataTable = new Project3.Database.TheFreshChoice.sp_laporan_pengirimanDataTable();

        //    // 2. Isi data menggunakan parameter
        //    //adapter.Fill(dataTable, DateTime.Parse("2025-07-21"), DateTime.Parse("2025-07-21"));
        //    //adapter.Fill(dataTable, null, null);
        //    adapter.Fill(dataTable, tglmulai.Value, tglselesai.Value);

        //    // 3. Siapkan ReportDataSource
        //    ReportDataSource rds = new ReportDataSource("dsPengiriman", (DataTable)dataTable);

        //    // 4. Set report ke ReportViewer
        //    reportViewer1.LocalReport.DataSources.Clear();
        //    reportViewer1.LocalReport.DataSources.Add(rds);
        //    reportViewer1.LocalReport.ReportEmbeddedResource = "Project3.Laporan.TransaksiPengiriman.ReportPengiriman.rdlc"; // ganti sesuai path reportmu

        //    // 5. Refresh ReportViewer
        //    reportViewer1.RefreshReport();
        //}
    }
}
