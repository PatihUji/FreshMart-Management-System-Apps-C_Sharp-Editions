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

namespace Project3.Laporan.TransaksiRetur
{
    public partial class LaporanReturBarang : Form
    {
        DateTime tglMulai;
        DateTime tglSelesai;
        public LaporanReturBarang(DateTime tglMulai, DateTime tglSelesai)
        {
            InitializeComponent();
            this.tglMulai = tglMulai;
            this.tglSelesai = tglSelesai;
        }

        private void LaporanReturBarang_Load(object sender, EventArgs e)
        {
            var adapter = new Project3.Database.TheFreshChoiceTableAdapters.sp_laporan_retur_pembeliTableAdapter();
            var dataTable = new Project3.Database.TheFreshChoice.sp_laporan_retur_pembeliDataTable();

            adapter.Fill(dataTable, tglMulai, tglSelesai);

            ReportDataSource rds = new ReportDataSource("dsReturBarang", (DataTable)dataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = @"..\..\Laporan\TransaksiRetur\ReportReturBarang.rdlc";

            reportViewer1.RefreshReport();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void tglselesai_ValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void reportViewer1_Load(object sender, EventArgs e)
        //{

        //}

        //private void btnFilter_Click(object sender, EventArgs e)
        //{
        //    this.reportViewer1.RefreshReport();
        //    var adapter = new Project3.Database.TheFreshChoiceTableAdapters.sp_laporan_retur_pembeliTableAdapter();
        //    var dataTable = new Project3.Database.TheFreshChoice.sp_laporan_retur_pembeliDataTable();

        //    // 2. Isi data menggunakan parameter
        //    //adapter.Fill(dataTable, DateTime.Parse("2025-07-21"), DateTime.Parse("2025-07-21"));
        //    //adapter.Fill(dataTable, null, null);
        //    adapter.Fill(dataTable, tglmulai.Value, tglselesai.Value);

        //    // 3. Siapkan ReportDataSource
        //    ReportDataSource rds = new ReportDataSource("dsReturBarang", (DataTable)dataTable);

        //    // 4. Set report ke ReportViewer
        //    reportViewer1.LocalReport.DataSources.Clear();
        //    reportViewer1.LocalReport.DataSources.Add(rds);
        //    reportViewer1.LocalReport.ReportEmbeddedResource = "Project3.Laporan.TransaksiRetur.ReportReturBarang.rdlc"; // ganti sesuai path reportmu

        //    // 5. Refresh ReportViewer
        //    reportViewer1.RefreshReport();
        //}

        //private void tglmulai_ValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void btnBersihkan_Click(object sender, EventArgs e)
        //{
        //    DateTime now = DateTime.Now;
        //    tglmulai.Value = new DateTime(now.Year, 1, 1);
        //    //tglakhir.Value = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
        //    tglselesai.Value = DateTime.Today.AddDays(-1);

        //    this.reportViewer1.RefreshReport();
        //    var adapter = new Project3.Database.TheFreshChoiceTableAdapters.sp_laporan_retur_pembeliTableAdapter();
        //    var dataTable = new Project3.Database.TheFreshChoice.sp_laporan_retur_pembeliDataTable();

        //    // 2. Isi data menggunakan parameter
        //    //adapter.Fill(dataTable, DateTime.Parse("2025-07-21"), DateTime.Parse("2025-07-21"));
        //    //adapter.Fill(dataTable, null, null);
        //    adapter.Fill(dataTable, tglmulai.Value, tglselesai.Value);

        //    // 3. Siapkan ReportDataSource
        //    ReportDataSource rds = new ReportDataSource("dsReturBarang", (DataTable)dataTable);

        //    // 4. Set report ke ReportViewer
        //    reportViewer1.LocalReport.DataSources.Clear();
        //    reportViewer1.LocalReport.DataSources.Add(rds);
        //    reportViewer1.LocalReport.ReportEmbeddedResource = "Project3.Laporan.TransaksiRetur.ReportReturBarang.rdlc"; // ganti sesuai path reportmu

        //    // 5. Refresh ReportViewer
        //    reportViewer1.RefreshReport();
        //}

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
