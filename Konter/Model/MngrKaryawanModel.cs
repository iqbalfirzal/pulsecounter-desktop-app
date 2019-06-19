// header untuk menggunakan library yang berkaitan dengan database
using System;
using System.Data.SqlClient;
using System.Data;

namespace Konter.Model
{
    class MngrKaryawanModel
    {
        // object class Connection
        private SqlConnection conn;
        private SqlCommand command;

        //declare variabel
        private string query;
        private bool hasil;

        // constructor
        public MngrKaryawanModel()
        {
            conn = Connection.KoneksiDataBase.GetSqlConnect();
        }

        //enkapsulasi
        //information hiding
        private string kd_Karyawan;
        private string USERNAME;
        private string PASSWORD;
        private string Nama;
        private string Gender;
        private string Tempat_Lahir;
        private string Tanggal_Lahir;
        private string Alamat;
        private string Nomor_Handphone;
        private string Gaji;

        //interface for acc data
        public string GetKd_Karyawan()
        {
            return kd_Karyawan;
        }

        public void SetKd_Karyawan(string kd_Karyawan)
        {
            this.kd_Karyawan = kd_Karyawan;
        }

        public string GetUSERNAME()
        {
            return USERNAME;
        }

        public void SetUSERNAME(string USERNAME)
        {
            this.USERNAME = USERNAME;
        }

        public string GetPASSWORD()
        {
            return PASSWORD;
        }

        public void SetPASSWORD(string PASSWORD)
        {
            this.PASSWORD = PASSWORD;
        }

        public string GetNama()
        {
            return Nama;
        }

        public void SetNama(string Nama)
        {
            this.Nama = Nama;
        }

        public string GetGender()
        {
            return Gender;
        }

        public void SetGender(string Gender)
        {
            this.Gender = Gender;
        }

        public string GetTempat_Lahir()
        {
            return Tempat_Lahir;
        }

        public void SetTempat_Lahir(string Tempat_Lahir)
        {
            this.Tempat_Lahir = Tempat_Lahir;
        }

        public string GetTanggal_Lahir()
        {
            return Tanggal_Lahir;
        }

        public void SetTanggal_Lahir(string Tanggal_Lahir)
        {
            this.Tanggal_Lahir = Tanggal_Lahir;
        }

        public string GetAlamat()
        {
            return Alamat;
        }

        public void SetAlamat(string Alamat)
        {
            this.Alamat = Alamat;
        }

        public string GetNomor_Handphone()
        {
            return Nomor_Handphone;
        }

        public void SetNomor_Handphone(string Nomor_Handphone)
        {
            this.Nomor_Handphone = Nomor_Handphone;
        }

        public string GetGaji()
        {
            return Gaji;
        }

        public void SetGaji(string Gaji)
        {
            this.Gaji = Gaji;
        }

        // menampilkan data
        public DataSet SelectedKaryawan()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT kd_Karyawan, Nama, Gender, Tempat_Lahir, Tanggal_Lahir, Alamat, Nomor_Handphone, Gaji, USERNAME FROM Karyawan";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Karyawan");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

        // menambahkan data
        public Boolean InsertKaryawan()
        {
            hasil = false;
            try
            {
                query = "INSERT INTO Karyawan VALUES ('" + kd_Karyawan + "','" + USERNAME + "',HASHBYTES('sha1','" + PASSWORD + "'),'" + Nama + "','" + Gender + "','" + Tempat_Lahir + "','" + Tanggal_Lahir + "','" + Alamat + "','" + Nomor_Handphone + "','" + Gaji + "')";
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                conn.Close();
            }
            catch (SqlException)
            {
                hasil = false;
            }
            return hasil;
        }

        // mengubah data
        public Boolean UpdateKaryawan()
        {
            hasil = false;
            try
            {
                query = "UPDATE Karyawan SET kd_Karyawan = '" + kd_Karyawan + "', USERNAME = '" + USERNAME + "', PASSWORD = HASHBYTES('sha1','" + PASSWORD + "'), Nama = '" + Nama + "', Gender = '" + Gender + "', Tempat_Lahir = '" + Tempat_Lahir + "', Tanggal_Lahir = '" + Tanggal_Lahir + "', Alamat = '" + Alamat + "', Nomor_Handphone = '" + Nomor_Handphone + "', Gaji = '" + Gaji + "' WHERE kd_Karyawan = '" + kd_Karyawan + "'";
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                conn.Close();
            }
            catch (SqlException)
            {
                hasil = false;
            }
            return hasil;
        }

        // menghapus data
        public Boolean DeleteKaryawan()
        {
            hasil = false;
            try
            {
                query = "DELETE FROM Karyawan WHERE kd_Karyawan = '" + kd_Karyawan + "'";
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                conn.Close();
            }
            catch (SqlException)
            {
                hasil = false;
            }
            return hasil;
        }
    }
}
