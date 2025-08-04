using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using Project3.Master.Karyawan;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Project3.Master.Promo;
using Project3.Transaksi.Retur_Barang;
using Project3.Master.Produk;
using static System.Windows.Forms.AxHost;

namespace Project3.Database
    {
    public class DBConnect
    {
        public readonly SqlConnection conn;

        public DBConnect()
        {
            //string connectionString = "Server=localhost ;Initial Catalog=TheFreshChoice;TrustServerCertificate=true;User ID=PROJ3CT;password=1234";
            string connectionString = "Server=localhost;Initial Catalog=TheFreshChoice;Integrated Security=True;TrustServerCertificate=True;";

            conn = new SqlConnection(connectionString);
        }

        public void Open()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }

        public void Close()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }

        public int LoginKaryawan(string username, string password, out string jabatan)
        {
            jabatan = null;
            int result = -99;

            try
            {
                Open();
                using (SqlCommand cmd = new SqlCommand("sp_login_karyawan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlParameter jabatanParam = new SqlParameter("@jabatan", SqlDbType.VarChar, 50)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(jabatanParam);

                    cmd.ExecuteNonQuery();

                    jabatan = Convert.ToString(jabatanParam.Value);

                    SqlParameter returnParam = new SqlParameter("@ReturnVal", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(returnParam);

                    cmd.ExecuteNonQuery();
                    result = (int)returnParam.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat login: " + ex.Message);
            }
            finally
            {
                Close();
            }

            return result;
        }

        public string GetUserLoginName(string username)
        {
            string namaKaryawan = null;
            string query = "SELECT dbo.udf_getUserLogin(@username) AS NamaKaryawan";

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            namaKaryawan = reader["NamaKaryawan"] != DBNull.Value
                                ? reader["NamaKaryawan"].ToString()
                                : null;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengambil nama karyawan: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return namaKaryawan;
        }

        public KaryawanADT GetProfileByUsername(string username)
        {
            KaryawanADT data = null;
            string query = @"SELECT kry_nama, kry_tgl_lahir, kry_gender, s_nama, kry_alamat, kry_username, kry_password FROM karyawan k
                             JOIN setting s ON k.s_id = s.s_id
                             WHERE kry_username = @username";

            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                Open(); // panggil metode Open milik class
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    data = new KaryawanADT(
                        reader["kry_nama"].ToString(),
                        reader["s_nama"].ToString(),
                        Convert.ToDateTime(reader["kry_tgl_lahir"]),
                        reader["kry_gender"].ToString(),
                        reader["kry_username"].ToString(),
                        reader["kry_alamat"].ToString()
                    );
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null && !reader.IsClosed) reader.Close();
                if (cmd != null) cmd.Dispose();
                Close(); // tutup koneksi
            }

            return data;
        }

        public bool isKaryawanExist(int kry_id)
        {
            bool exist = false;

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.udf_isKaryawanExist(@kry_id)", conn))
                {
                    cmd.Parameters.AddWithValue("@kry_id", kry_id);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        exist = Convert.ToBoolean(result);
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data setting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return exist;
        }

        public void InsertKaryawan(Int32 s_id, String kry_nama, DateTime kry_tgl_lahir, String kry_alamat, String kry_gender, String kry_username, String kry_password, String kry_created_by)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_insert_karyawan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@s_id", s_id);
                    cmd.Parameters.AddWithValue("@kry_nama", kry_nama);
                    cmd.Parameters.AddWithValue("@kry_tgl_lahir", kry_tgl_lahir);
                    cmd.Parameters.AddWithValue("@kry_alamat", kry_alamat);
                    cmd.Parameters.AddWithValue("@kry_gender", kry_gender);
                    cmd.Parameters.AddWithValue("@kry_username", (object)kry_username ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@kry_password", (object)kry_password ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@kry_created_by", kry_created_by);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public DataTable getListSettingByKategori(String kategori)
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("SELECT s_id, s_nama FROM setting WHERE s_kategori = '" + kategori + "' AND s_status = 1", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data setting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public void UpdateKaryawan(Int32 kry_id, Int32 s_id, String kry_nama, DateTime kry_tgl_lahir, String kry_alamat, String kry_gender, String kry_username, String kry_modif_by)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_update_karyawan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@s_id", s_id);
                    cmd.Parameters.AddWithValue("@kry_nama", kry_nama);
                    cmd.Parameters.AddWithValue("@kry_tgl_lahir", kry_tgl_lahir);
                    cmd.Parameters.AddWithValue("@kry_alamat", kry_alamat);
                    cmd.Parameters.AddWithValue("@kry_gender", kry_gender);
                    cmd.Parameters.AddWithValue("@kry_username", (object)kry_username ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@kry_modif_by", kry_modif_by);
                    cmd.Parameters.AddWithValue("@kry_id", kry_id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memperbarui data karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public void UpdatePasswordKaryawanByUsername(String username, string password)
        {
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE karyawan SET kry_password = '" + password + "' WHERE kry_username = '" + username + "'", conn))
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Password berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengubah password : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        public DataTable GetListKaryawan(string search, int? status, string sortColumn = "kry_nama", string sortOrder = "ASC")
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_getList_karyawan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Kirim NULL ke SQL jika nilainya null
                    cmd.Parameters.AddWithValue("@search", (object)search ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                    cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menampilkan data karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public void SetStatusKaryawan(Int32 kry_id, String kry_modif_by)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_setStatus_karyawan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@kry_id", kry_id);
                    cmd.Parameters.AddWithValue("@modif_by", kry_modif_by);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil diubah statusnya!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengubah status data karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        //INSERT SETTING
        public void InsertSetting(string s_nama, string s_kategori, string s_created_by)
        {
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_insert_setting", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@s_nama", s_nama);
                    cmd.Parameters.AddWithValue("@s_kategori", s_kategori);
                    cmd.Parameters.AddWithValue("@s_created_by", s_created_by);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data setting berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data setting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        public bool isSettingExist(int s_id)
        {
            bool exist = false;

            try
            {
                Open(); // Pastikan method Open() membuka koneksi SQL

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.udf_isSettingExist(@s_id)", conn))
                {
                    cmd.Parameters.AddWithValue("@s_id", s_id);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        exist = Convert.ToBoolean(result);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengecek data setting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close(); // Tutup koneksi
            }

            return exist;
        }

        public void UpdateSetting(int s_id, string s_nama, string s_kategori, string s_modif_by)
        {
            try
            {
                Open(); // ini adalah method koneksi SQL kamu

                using (SqlCommand cmd = new SqlCommand("sp_update_setting", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@s_id", s_id);
                    cmd.Parameters.AddWithValue("@s_nama", s_nama);
                    cmd.Parameters.AddWithValue("@s_kategori", s_kategori);
                    cmd.Parameters.AddWithValue("@s_modif_by", s_modif_by);
                    cmd.Parameters.AddWithValue("@s_modif_date", DateTime.Now);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data setting berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memperbarui data setting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close(); // koneksi ditutup
            }
        }

        public DataTable GetListSetting(string search, int? status, string sortColumn = "s_id", string sortOrder = "ASC")
        {
            DataTable dt = new DataTable();

            try
            {
                Open(); // Pastikan ini method koneksi kamu

                using (SqlCommand cmd = new SqlCommand("sp_getList_setting", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Handle NULL dengan DBNull
                    cmd.Parameters.AddWithValue("@search", (object)search ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                    cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menampilkan data setting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public void setStatusSetting(int s_id, string modif_by)
        {
            try
            {
                Open(); // Pastikan koneksi ke database terbuka

                using (SqlCommand cmd = new SqlCommand("sp_setStatus_setting", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@s_id", s_id);
                    cmd.Parameters.AddWithValue("@s_modif_by", modif_by);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Status data setting berhasil diubah (Nonaktifkan)!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengubah status data setting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close(); // Tutup koneksi
            }
        }

        //INSERT PROMO
        public void InsertPromo(string pr_nama, decimal pr_persentase, DateTime pr_tanggal_mulai, DateTime pr_tanggal_berakhir, string pr_created_by)
        {
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_insert_promo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pr_nama", pr_nama);
                    cmd.Parameters.AddWithValue("@pr_persentase", pr_persentase);
                    cmd.Parameters.AddWithValue("@pr_tanggal_mulai", pr_tanggal_mulai);
                    cmd.Parameters.AddWithValue("@pr_tanggal_berakhir", pr_tanggal_berakhir);
                    cmd.Parameters.AddWithValue("@pr_created_by", pr_created_by);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Promo berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menambahkan promo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        public bool isPromoExist(int pr_id)
        {
            bool exist = false;

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.udf_isPromoExist(@pr_id)", conn))
                {
                    cmd.Parameters.AddWithValue("@pr_id", pr_id);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        exist = Convert.ToBoolean(result);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengecek data promo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return exist;
        }

        public void UpdatePromo(int pr_id, string pr_nama, decimal pr_persentase, DateTime pr_tanggal_mulai, DateTime pr_tanggal_berakhir, string pr_modif_by)
        {
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_update_promo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pr_id", pr_id);
                    cmd.Parameters.AddWithValue("@pr_nama", pr_nama);
                    cmd.Parameters.AddWithValue("@pr_persentase", pr_persentase);
                    cmd.Parameters.AddWithValue("@pr_tanggal_mulai", pr_tanggal_mulai);
                    cmd.Parameters.AddWithValue("@pr_tanggal_berakhir", pr_tanggal_berakhir);
                    cmd.Parameters.AddWithValue("@pr_modif_by", pr_modif_by);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Promo berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memperbarui data promo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        public DataTable GetListPromo(string search, int? status, string sortColumn = "pr_nama", string sortOrder = "ASC")
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_getList_promo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@search", (object)search ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                    cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menampilkan data promo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public void SetStatusPromo(int pr_id, string modif_by)
        {
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_setStatus_promo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pr_id", pr_id);
                    cmd.Parameters.AddWithValue("@modif_by", modif_by);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Status promo berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengubah status promo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        //==================================================================================================
        //                                         METODE PEMBAYARAN
        //==================================================================================================
        public bool isMetodePembayaranExist(int mpb_id)
        {
            bool exist = false;

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.udf_isMetodePembayaranExist(@mpb_id)", conn))
                {
                    cmd.Parameters.AddWithValue("@mpb_id", mpb_id);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        exist = Convert.ToBoolean(result);
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data setting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return exist;
        }

        public void InsertMetodePembayaran(string mpb_nama, string mpb_created)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_insert_metodePembayaran", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@mpb_nama", mpb_nama);
                    cmd.Parameters.AddWithValue("@mpb_created_by", mpb_created);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data Metode Pembayaran : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public void UpdateMetodePembayaran(Int32 mpb_id, string mpb_nama, string mpb_modif_by)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_update_metodePembayaran", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@mpb_id", mpb_id);                // <- PARAMETER INI PENTING
                    cmd.Parameters.AddWithValue("@mpb_nama", mpb_nama);
                    cmd.Parameters.AddWithValue("@mpb_modif_by", mpb_modif_by);

                    cmd.ExecuteNonQuery();
                }


                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memperbarui data metode pembayaran: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public DataTable GetListMetodePembayaran(string search, int? status, string sortColumn = "mpb_id", string sortOrder = "ASC")
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_getList_metode_pembayaran", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Kirim NULL ke SQL jika nilainya null
                    cmd.Parameters.AddWithValue("@search", (object)search ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                    cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menampilkan data Metode Pembayaran: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public void SetStatusMetodePembayaran(Int32 mpb_id, string modif_by)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_setStatus_metodePembayaran", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@mpb_id", mpb_id);
                    cmd.Parameters.AddWithValue("@modif_by", modif_by);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil diubah statusnya!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengubah status data metode pembayaran: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public bool isProdukExist(int p_id)
        {
            bool exist = false;

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.udf_isProdukExist(@p_id)", conn))
                {
                    cmd.Parameters.AddWithValue("@p_id", p_id);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        exist = Convert.ToBoolean(result);
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data jenis produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return exist;
        }

        public void InsertProduk(int jp_id, String p_nama, Double p_harga, String p_satuan, int p_stok, String p_deskripsi, String p_gambar, String createdBy)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_insert_produk", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@jp_id", jp_id);
                    cmd.Parameters.AddWithValue("@p_nama", p_nama);
                    cmd.Parameters.AddWithValue("@p_harga", p_harga);
                    cmd.Parameters.AddWithValue("@p_satuan", p_satuan);
                    cmd.Parameters.AddWithValue("@p_stok", p_stok);
                    cmd.Parameters.AddWithValue("@p_deskripsi", p_deskripsi);
                    cmd.Parameters.AddWithValue("@p_gambar", p_gambar);
                    cmd.Parameters.AddWithValue("@p_created_by", createdBy);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public void UpdateProduk(Int32 p_id, Int32 jp_id, String p_nama, Double p_harga, String p_satuan, Int32 stok, String p_deskripsi, String p_gambar, String modifBy)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_update_produk", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@jp_id", jp_id);
                    cmd.Parameters.AddWithValue("@p_nama", p_nama);
                    cmd.Parameters.AddWithValue("@p_harga", p_harga);
                    cmd.Parameters.AddWithValue("@p_satuan", p_satuan);
                    cmd.Parameters.AddWithValue("@p_stok", stok);
                    cmd.Parameters.AddWithValue("@p_deskripsi", p_deskripsi);
                    cmd.Parameters.AddWithValue("@p_gambar", p_gambar);
                    cmd.Parameters.AddWithValue("@p_modif_by", modifBy);
                    cmd.Parameters.AddWithValue("@p_id", p_id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memperbarui data produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public DataTable GetListProduk(string search, int? status, string sortColumn = "p_id", string sortOrder = "ASC")
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_getList_produk", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Kirim NULL ke SQL jika nilainya null
                    cmd.Parameters.AddWithValue("@search", (object)search ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                    cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menampilkan data produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public void SetStatusProduk(Int32 p_id, String p_modif_by)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_setStatus_produk", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_id", p_id);
                    cmd.Parameters.AddWithValue("@modif_by", p_modif_by);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil diubah statusnya!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengubah status data produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public DataTable getListJenisProdukByNama()
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("SELECT jp_id, jp_nama FROM jenis_produk WHERE jp_status = 1", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data jenis produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        //==================================================================================================
        //                                         JENIS PRODUK
        //==================================================================================================
        public bool isJenisProdukExist(int jp_id)
        {
            bool exist = false;

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.udf_isJenisProdukExist(@jp_id)", conn))
                {
                    cmd.Parameters.AddWithValue("@jp_id", jp_id);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        exist = Convert.ToBoolean(result);
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data setting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return exist;
        }

        public void InsertJenisProduk(string jp_nama, string jp_created)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_insert_JenisProduk", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@jp_nama", jp_nama);
                    cmd.Parameters.AddWithValue("@jp_created_by", jp_created);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data Jenis Produk : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public void UpdateJenisProduk(Int32 jp_id, string jp_nama, string modif_by)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_update_jenisProduk", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@jp_id", jp_id);
                    cmd.Parameters.AddWithValue("@jp_nama", jp_nama);
                    cmd.Parameters.AddWithValue("@jp_modif_by", modif_by);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memperbarui data karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public DataTable GetListJenisProduk(string search, int? status, string sortColumn = "jp_id", string sortOrder = "ASC")
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_getList_jenis_produk", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Kirim NULL ke SQL jika nilainya null
                    cmd.Parameters.AddWithValue("@search", (object)search ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@sortColumn", sortColumn);
                    cmd.Parameters.AddWithValue("@sortOrder", sortOrder);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menampilkan data Jenis Produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public void SetStatusJenisProduk(Int32 jp_id, string userAccess)
        {
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_setStatus_jenisProduk", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@jp_id", jp_id);
                    cmd.Parameters.AddWithValue("@jp_modif_by", userAccess);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil diubah statusnya!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengubah status data jenis produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        //==================================================================================================
        //                                           PENJUALAN
        //==================================================================================================
        public DataTable getListMetodePembayaran()
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("SELECT mpb_id, mpb_nama FROM metode_pembayaran WHERE mpb_status = 1", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal memasukkan data metode pembayaran : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public List<PromoADT> getListNamaPromo()
        {
            List<PromoADT> list = new List<PromoADT>();

            try
            {
                Open(); // dari class DBConnect

                using (SqlCommand cmd = new SqlCommand("SELECT pr_id, pr_nama, pr_persentase FROM promo WHERE pr_status = 1", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["pr_id"]);
                        string nama = reader["pr_nama"].ToString();
                        double persentase = Convert.ToDouble(reader["pr_persentase"]);

                        list.Add(new PromoADT(id, nama, persentase));
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengambil data promo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close(); // dari class DBConnect
            }

            return list;
        }

        public int GetIdKaryawanByUsername(string username)
        {
            int id = 0;

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("SELECT kry_id FROM karyawan WHERE kry_status = 1 AND kry_username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32(reader.GetOrdinal("kry_id"));
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengambil ID karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return id;
        }

        public bool InsertPenjualan(int s_id, int mpb_id, int kry_id, double total_harga, string createdBy, int? pnj_status, DataTable detailTransaksi, DataTable detailPromo)
        {
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_insert_penjualan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameter biasa
                    cmd.Parameters.AddWithValue("@s_id", s_id);
                    cmd.Parameters.AddWithValue("@mpb_id", mpb_id);
                    cmd.Parameters.AddWithValue("@kry_id", kry_id);
                    cmd.Parameters.AddWithValue("@pnj_total_harga", total_harga);
                    cmd.Parameters.AddWithValue("@pnj_created_by", createdBy);
                    cmd.Parameters.AddWithValue("@pnj_status", pnj_status ?? 1); // default ke 1 jika null

                    // Parameter structured (DataTable)
                    SqlParameter tvpDetail = cmd.Parameters.AddWithValue("@detail_transaksi_penjualan", detailTransaksi);
                    tvpDetail.SqlDbType = SqlDbType.Structured;
                    tvpDetail.TypeName = "detail_transaksi_penjualan_type";

                    SqlParameter tvpPromo = cmd.Parameters.AddWithValue("@detail_promo_penjualan", detailPromo);
                    tvpPromo.SqlDbType = SqlDbType.Structured;
                    tvpPromo.TypeName = "detail_promo_penjualan_type";

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Transaksi berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menambahkan transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Close();
            }
        }

        public DataTable GetListPenjualan(string search, int? status)
        {
            DataTable dtPenjualan = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_getList_penjualan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@search", search ?? (object)DBNull.Value);

                    if (status.HasValue)
                        cmd.Parameters.AddWithValue("@status", status.Value);
                    else
                        cmd.Parameters.AddWithValue("@status", DBNull.Value);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtPenjualan);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data penjualan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dtPenjualan;
        }

        public DataTable GetListDetailPenjualan(int pnj_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT p.p_nama, dtp.dp_kuantitas, p.p_harga 
                                                        FROM detail_transaksi_penjualan dtp
                                                        JOIN produk p ON dtp.p_id = p.p_id
                                                        WHERE dtp.pnj_id = @pnj_id", conn))
                {
                    cmd.Parameters.AddWithValue("@pnj_id", pnj_id);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        // === Stok Keluar ===
        public bool InsertStokKeluar(int kry_id, int sk_jumlah_keluar, string sk_keterangan, string sk_created_by, DataTable detailStokKeluar)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_insert_stok_keluar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Sesuai parameter di stored procedure
                    cmd.Parameters.AddWithValue("@kry_id", kry_id);
                    cmd.Parameters.AddWithValue("@sk_jumlah_keluar", sk_jumlah_keluar);
                    cmd.Parameters.AddWithValue("@sk_keterangan", sk_keterangan);
                    cmd.Parameters.AddWithValue("@sk_created_by", sk_created_by);

                    // Parameter tabel untuk TVP (Table-Valued Parameter)
                    SqlParameter tvpParam = cmd.Parameters.AddWithValue("@detail_transaksi_stok_keluar", detailStokKeluar);
                    tvpParam.SqlDbType = SqlDbType.Structured;
                    tvpParam.TypeName = "detail_transaksi_stok_keluar_type"; // Pastikan ini sudah dibuat di SQL Server

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan stok keluar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open) conn.Close();
                return false;
            }
        }


        public DataTable GetListNamaProduk()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT p_id, p_nama FROM produk WHERE p_status = 1 ORDER BY p_nama ASC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }

        public int GetStokProdukById(int p_id)
        {
            try
            {
                string query = "SELECT p_stok FROM produk WHERE p_id = @p_id AND p_status = 1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@p_id", p_id);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    if (result != null)
                        return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }

            return 0;
        }

        public DataTable GetListStokKeluar(string search, int? status)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_getList_stok_keluar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@search", search ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", status.HasValue ? (object)status : DBNull.Value);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return dt;
        }

        public DataTable GetDetailStokKeluarById(int sk_id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT d.p_id, p.p_nama, d.dsk_kuantitas 
                               FROM detail_transaksi_stok_keluar d 
                               JOIN produk p ON d.p_id = p.p_id 
                               WHERE d.sk_id = @sk_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sk_id", sk_id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }

        public DataRow GetStokKeluarById(int sk_id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM stok_keluar WHERE sk_id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", sk_id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }

        //=== Pengiriman ===
        public DataTable getListKaryawanBySID()
        {
            DataTable dt = new DataTable();

            try
            {
                Open(); // Pastikan koneksi terbuka

                using (SqlCommand cmd = new SqlCommand("SELECT kry_id, kry_nama FROM karyawan WHERE s_id = 6 AND kry_status = 1", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengambil data karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close(); // Tutup koneksi setelah selesai
            }

            return dt;
        }

        public DataTable GetListPenjualanToPengiriman()
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_getList_penjualan_to_pengiriman", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menampilkan data penjualan untuk pengiriman:\n" + ex.Message, "Kesalahan SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public DataTable GetListPengirimanByStatus(int statusPengiriman)
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_getList_pengiriman_by_status", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@status_pengiriman", statusPengiriman);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menampilkan data pengiriman berdasarkan status:\n" + ex.Message, "Kesalahan SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public void UpdatePengiriman(Int32 pnj_id, Int32 kry_id, String alamat_pengiriman, DateTime tanggal_pengiriman, TimeSpan jam_pengiriman, Int32 status_pengiriman, String nama_penerima, String modifBy)
        {

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_update_pengiriman", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pnj_id", pnj_id);
                    cmd.Parameters.AddWithValue("@kry_id", kry_id);
                    cmd.Parameters.AddWithValue("@alamat_pengiriman", alamat_pengiriman);
                    cmd.Parameters.AddWithValue("@tanggal_pengiriman", tanggal_pengiriman);
                    cmd.Parameters.AddWithValue("@jam_pengiriman", jam_pengiriman);
                    cmd.Parameters.AddWithValue("@status_pengiriman", status_pengiriman);
                    cmd.Parameters.AddWithValue("@nama_penerima", nama_penerima);
                    cmd.Parameters.AddWithValue("@modif_by", modifBy);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal menambahkan data pengiriman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

        }

        public void SelesaiPengiriman(int pnj_id, string modifBy)
        {
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_selesai_pengiriman", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pnj_id", pnj_id);
                    cmd.Parameters.AddWithValue("@modif_by", modifBy);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Pengiriman berhasil diselesaikan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyelesaikan pengiriman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        //=== Retur Produk ===
        public DataTable getListPenjualanByKategori(string search, int? status, string kategori)
        {
            DataTable dt = new DataTable();

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand("sp_getList_penjualan_by_category", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@search", string.IsNullOrEmpty(search) ? (object)DBNull.Value : search);
                    cmd.Parameters.AddWithValue("@status", status.HasValue ? (object)status.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@kategori", kategori);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengambil data penjualan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return dt;
        }

        public List<ReturBarang> GetListReturBarang(string search)
        {
            List<ReturBarang> list = new List<ReturBarang>();

            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_getList_retur_pembeli", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@search", search ?? (object)DBNull.Value);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rtr_id = reader.GetInt32(reader.GetOrdinal("rtr_id"));
                            DateTime tanggalRetur = reader.GetDateTime(reader.GetOrdinal("rtr_tanggal_retur"));
                            // plusDays(2) di Java, di C# tambahkan 2 hari
                            tanggalRetur = tanggalRetur.AddDays(2);

                            int jumlahRetur = reader.GetInt32(reader.GetOrdinal("rtr_jumlah_retur"));
                            int pnj_id = reader.GetInt32(reader.GetOrdinal("pnj_id"));
                            int kry_id = reader.GetInt32(reader.GetOrdinal("kry_id"));
                            string namaKaryawan = reader.GetString(reader.GetOrdinal("nama_karyawan"));

                            list.Add(new ReturBarang(rtr_id, tanggalRetur, jumlahRetur, pnj_id, kry_id, namaKaryawan));
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Tampilkan error atau logging sesuai kebutuhan
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return list;
        }

        public DataTable GetListDetailReturBarang(int rtr_id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT p.p_nama, drp.drp_kuantitas, drp.drp_alasan 
                     FROM detail_transaksi_retur_pembeli drp
                     JOIN produk p ON drp.p_id = p.p_id
                     WHERE drp.rtr_id = @rtr_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rtr_id", rtr_id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }
        
        public bool InsertReturBarang(int kry_id, int pnj_id, int rtr_jumlah_retur, string createdBy, List<Detail_Retur> detailReturList)
        {
            try
            {

                using (SqlCommand cmd = new SqlCommand("sp_insert_retur_barang", conn))
                {
                    Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameter biasa
                    cmd.Parameters.AddWithValue("@kry_id", kry_id);
                    cmd.Parameters.AddWithValue("@pnj_id", pnj_id);
                    cmd.Parameters.AddWithValue("@rtr_jumlah_retur", rtr_jumlah_retur);
                    cmd.Parameters.AddWithValue("@rtr_created_by", createdBy);

                    // Siapkan Table-Valued Parameter
                    DataTable dt = new DataTable();
                    dt.Columns.Add("p_id", typeof(int));
                    dt.Columns.Add("drp_alasan", typeof(string));
                    dt.Columns.Add("drp_kuantitas", typeof(int));

                    foreach (var detail in detailReturList)
                    {
                        dt.Rows.Add(detail.P_id, detail.Drp_alasan, detail.Drp_kuantitas);
                    }

                    SqlParameter tvpParam = cmd.Parameters.AddWithValue("@detail_transaksi_retur_barang", dt);
                    tvpParam.SqlDbType = SqlDbType.Structured;
                    tvpParam.TypeName = "detail_transaksi_retur_barang_type";

                    cmd.ExecuteNonQuery();
                }


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan retur: " + ex.Message);
                return false;
            }

            finally
            {
                Close();
            }
        }

        public int GetKuantitasProdukTerjualById(int p_id)
        {
            string query = "SELECT dp_kuantitas FROM detail_transaksi_penjualan WHERE p_id = @p_id";
            int kuantitas = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    Open();
                    cmd.Parameters.AddWithValue("@p_id", p_id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kuantitas += reader.GetInt32(reader.GetOrdinal("dp_kuantitas"));
                        }
                    }
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Close();
            }

            return kuantitas;
        }

    }

}
