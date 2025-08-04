using Project3.Database;
using Project3.Master.Produk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3.Transaksi.Pengiriman
{
    public partial class Pengiriman : Form
    {
        DBConnect connection = new DBConnect();
        private string userAccess;
        private int currentPage = 1;
        private int pageSize = 8;
        private DataTable allData;

        
        int status = 0; // Default: hanya tampilkan yang aktif
        private bool kolomGambarSudahDitambahkan = false;

        public Pengiriman(String user)
        {
            InitializeComponent();
            this.userAccess = user;
        }

        private void Pengiriman_Load(object sender, EventArgs e)
        {
            formPengiriman.SetUserAccess(userAccess);
            formPengiriman.setParentForm(this);
            AturKolomIkonPengiriman();
            LoadPengiriman();
            LoadPage();
        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset ke halaman pertama saat ganti status
            status = cbstatus.SelectedIndex; // Ubah status sesuai pilihan ComboBox
            addButton();
            LoadPengiriman();
        }

        private void LoadPengiriman()
        {
            //int status = 0; // misalnya default belum dikirim
            if (status == 0)
            {
                allData = connection.GetListPenjualanToPengiriman();
                //dgvPengiriman.DataSource = dt;
                
            }
            else
            {
                allData= connection.GetListPengirimanByStatus(status);
                //dgvPengiriman.DataSource = dt;

            }
            dgvPengiriman.Columns.Clear();
            kolomGambarSudahDitambahkan = false;
            LoadPage();

        }

        public void LoadPage()
        {
            if (allData == null || allData.Rows.Count == 0)
            {
                dgvPengiriman.DataSource = null;
                lblPageInfo.Text = "0";
                return;
            }

            var rows = allData.AsEnumerable()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize);

            DataTable dt = rows.Any() ? rows.CopyToDataTable() : allData.Clone();
            dgvPengiriman.DataSource = dt;

            addButton();
            FormatGrid();

            lblPageInfo.Text = $"{currentPage}";
        }

        private void addButton()
        {
            if (kolomGambarSudahDitambahkan) return;

            string statusText = cbstatus.SelectedItem?.ToString();
            if (statusText == "Belum Dikirim")
                status = 0;
            else if (statusText == "Sedang Dikirim")
                status = 1;
            else if (statusText == "Selesai Dikirim")
                status = 2;

            if (status == 0)
            {
                // Tombol Tambah Pengiriman
                DataGridViewImageColumn btnAdd = new DataGridViewImageColumn
                {
                    Name = "btnAdd",
                    HeaderText = "",
                    Image = Properties.Resources.plus_icon, // pastikan ada ikon add di Resources
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvPengiriman.Columns.Add(btnAdd);
            }
            else if (status == 1)
            {
                // Tombol Tandai Selesai
                DataGridViewImageColumn btnDone = new DataGridViewImageColumn
                {
                    Name = "btnDone",
                    HeaderText = "",
                    Image = Properties.Resources.done_icon, // pastikan ada ikon done di Resources
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvPengiriman.Columns.Add(btnDone);
            }
            else if (status == 2)
            {
                // Tombol Detail Pengiriman
                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn
                {
                    Name = "btnDetail",
                    HeaderText = "",
                    Image = Properties.Resources.ikon_gambar, // pastikan ada ikon detail di Resources
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 50
                };
                dgvPengiriman.Columns.Add(btnDetail);
            }

            kolomGambarSudahDitambahkan = true;
        }


        private void FormatGrid()
        {
            if (status == 0)
            {
                // Format untuk status "Belum Dikirim"
                if (dgvPengiriman.Columns.Contains("pnj_id"))
                    dgvPengiriman.Columns["pnj_id"].HeaderText = "ID Penjualan";

                if (dgvPengiriman.Columns.Contains("pnj_created_by"))
                    dgvPengiriman.Columns["pnj_created_by"].HeaderText = "Dibuat Oleh";

                if (dgvPengiriman.Columns.Contains("pnj_created_date"))
                {
                    dgvPengiriman.Columns["pnj_created_date"].HeaderText = "Tanggal Transaksi";
                    dgvPengiriman.Columns["pnj_created_date"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
                }

                if (dgvPengiriman.Columns.Contains("pnj_total_harga"))
                {
                    dgvPengiriman.Columns["pnj_total_harga"].HeaderText = "Total Harga";
                    dgvPengiriman.Columns["pnj_total_harga"].DefaultCellStyle.Format = "C";
                    dgvPengiriman.Columns["pnj_total_harga"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
                }
            }
            else if (status == 1 || status == 2)
            {
                // Format untuk "Sedang Dikirim" atau "Selesai Dikirim"
                string[] hiddenCols = {
            "png_id", "png_jam_pengiriman", "png_status_pengiriman",
            "png_modif_by", "png_modif_date"
        };

                foreach (string col in hiddenCols)
                {
                    if (dgvPengiriman.Columns.Contains(col))
                        dgvPengiriman.Columns[col].Visible = false;
                }

                if (dgvPengiriman.Columns.Contains("pnj_id"))
                    dgvPengiriman.Columns["pnj_id"].HeaderText = "ID Penjualan";

                if (dgvPengiriman.Columns.Contains("kry_nama"))
                    dgvPengiriman.Columns["kry_nama"].HeaderText = "Nama Pengirim";

                if (dgvPengiriman.Columns.Contains("png_tanggal_pengiriman"))
                {
                    dgvPengiriman.Columns["png_tanggal_pengiriman"].HeaderText = "Tanggal Pengiriman";
                    dgvPengiriman.Columns["png_tanggal_pengiriman"].DefaultCellStyle.Format = "dd-MM-yyyy";
                }

                if (dgvPengiriman.Columns.Contains("png_alamat_pengiriman"))
                    dgvPengiriman.Columns["png_alamat_pengiriman"].HeaderText = "Alamat";

                if (dgvPengiriman.Columns.Contains("png_nama_penerima"))
                    dgvPengiriman.Columns["png_nama_penerima"].HeaderText = "Penerima";

                if (dgvPengiriman.Columns.Contains("png_total_harga"))
                {
                    dgvPengiriman.Columns["png_total_harga"].HeaderText = "Total Harga";
                    dgvPengiriman.Columns["png_total_harga"].DefaultCellStyle.Format = "C";
                    dgvPengiriman.Columns["png_total_harga"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        


        private void dgvPengiriman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= dgvPengiriman.Rows.Count || e.ColumnIndex >= dgvPengiriman.Columns.Count) return;

            string columnName = dgvPengiriman.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvPengiriman.Rows[e.RowIndex];

            if (columnName == "btnAdd")
            {
                formPengiriman.setFormPengiriman(
                    Convert.ToInt32(row.Cells["pnj_id"].Value),
                    Convert.ToDouble(row.Cells["pnj_total_harga"].Value)
                );
            }
            else if (columnName == "btnDone")
            {
                int pnj_id = Convert.ToInt32(row.Cells["pnj_id"].Value);

                DialogResult result = MessageBox.Show("Tandai pengiriman ini sebagai selesai?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DBConnect db = new DBConnect();
                        db.SelesaiPengiriman(pnj_id, userAccess); // userAccess = nama user aktif

                        MessageBox.Show("Pengiriman telah ditandai sebagai selesai.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPengiriman(); // refresh tabel
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (columnName == "btnDetail")

                setDataDetail(
                    Convert.ToInt32(row.Cells["pnj_id"].Value),
                    row.Cells["kry_nama"].Value.ToString(),
                    row.Cells["png_nama_penerima"].Value.ToString(),
                    row.Cells["png_alamat_pengiriman"].Value.ToString(),
                    Convert.ToDateTime(row.Cells["png_tanggal_pengiriman"].Value)
                );
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPage = (int)Math.Ceiling((double)allData.Rows.Count / pageSize);
            if (currentPage < totalPage)
            {
                currentPage++;
                LoadPage();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
            }
        }

        private void AturKolomIkonPengiriman()
        {
            foreach (DataGridViewColumn col in dgvPengiriman.Columns)
            {
                if (col is DataGridViewImageColumn &&
                    (col.Name == "btnAdd" || col.Name == "btnDone" || col.Name == "btnDetail"))
                {
                    col.Width = 50;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            dgvPengiriman.RowTemplate.Height = 50;
            dgvPengiriman.RowTemplate.DefaultCellStyle.Padding = new Padding(0);
        }

        // === Detail Pengiriman ===
        private void loadDataDetail(int pnj_id)
        {
            dgvDetail.DataSource = connection.GetListDetailPenjualan(pnj_id);

            // Ganti header kolom yang ditampilkan
            if (dgvDetail.Columns.Contains("p_nama"))
                dgvDetail.Columns["p_nama"].HeaderText = "Produk";

            if (dgvDetail.Columns.Contains("dp_kuantitas"))
                dgvDetail.Columns["dp_kuantitas"].HeaderText = "Jumlah";
                dgvDetail.Columns["dp_kuantitas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void setDataDetail(int pnj_id, String namaKaryawan, String namaPenerima, String alamatTujuan, DateTime tglDikirim)
        {
            lblNamaKaryawan.Text = namaKaryawan;
            lblNamaPenerima.Text = namaPenerima;
            lblAlamat.Text = alamatTujuan;
            lblTglDikirim.Text = tglDikirim.ToString("dd-MM-yyyy");
            loadDataDetail(pnj_id);

            pnlOverlayDetail.Visible = true;
            pnlOverlayDetail.BringToFront();
            pnlOverlayDetail.BackColor = Color.FromArgb(128, 0, 0, 0); // hitam transparan
            pnlOverlayDetail.FillColor = Color.FromArgb(128, 0, 0, 0); // pastikan juga fill transparan
        }

        private void pnlOverlayDetail_Click(object sender, EventArgs e)
        {
            pnlOverlayDetail.SendToBack();
            pnlOverlayDetail.Visible = false;
        }
    }
}
