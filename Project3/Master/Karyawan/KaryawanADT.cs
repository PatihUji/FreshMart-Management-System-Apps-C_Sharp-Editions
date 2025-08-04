using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project3.Master.Karyawan
{
    public class KaryawanADT
    {
        private int id;
        private int sid;
        private String sNama;
        private String nama;
        private DateTime tanggalLahir;
        private String gender;
        private String username;
        private String password;
        private String alamat;
        private int status;
        private String createdBy;
        private DateTime createdDate;
        private String modifBy;
        private DateTime modifDate;

        public KaryawanADT(string nama, string jabatan, DateTime tglLahir, string gender, string username, string alamat)
        {
            this.Nama = nama;
            this.SNama = jabatan;
            this.TanggalLahir = tglLahir;
            this.Gender = gender;
            this.Username = username;
            this.Alamat = alamat;
        }

        public int Id { get => id; set => id = value; }
        public int Sid { get => sid; set => sid = value; }
        public string SNama { get => sNama; set => sNama = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TanggalLahir { get => tanggalLahir; set => tanggalLahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public int Status { get => status; set => status = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public string ModifBy { get => modifBy; set => modifBy = value; }
        public DateTime ModifDate { get => modifDate; set => modifDate = value; }
    }
}
