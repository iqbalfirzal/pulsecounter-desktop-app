// header untuk menggunakan library yang berkaitan dengan database
using System;
using System.Data.SqlClient;
using System.Data;

namespace Konter.Model
{
    class MngrPulsaModel
    {
        // object class Connection
        private SqlConnection conn;
        private SqlCommand command;

        // deklarasi variabel tambahan
        private string query;
        private bool hasil;

        // constructor
        public MngrPulsaModel()
        {
            conn = Connection.KoneksiDataBase.GetSqlConnect();
        }

        ////enkapsulasi
        ////information hiding
        private string kd_Pulsa;
        private string nominal;
        private string Harga;
        private string nama_Jenis;
        private string nama_Provider;
        private string keterangan;

        ////interface for acc data
        public string GetKd_Pulsa()
        {
            return kd_Pulsa;
        }

        public void SetKd_Pulsa(string kd_Pulsa)
        {
            this.kd_Pulsa = kd_Pulsa;
        }

        public string GetNominal()
        {
            return nominal;
        }

        public void SetNominal(string nominal)
        {
            this.nominal = nominal;
        }

        public string GetHarga()
        {
            return Harga;
        }

        public void SetHarga(string Harga)
        {
            this.Harga = Harga;
        }

        public string GetNama_Jenis()
        {
            return nama_Jenis;
        }

        public void SetNama_Jenis(string nama_Jenis)
        {
            this.nama_Jenis = nama_Jenis;
        }

        public string GetNama_Provider()
        {
            return nama_Provider;
        }

        public void SetNama_Provider(string nama_Provider)
        {
            this.nama_Provider = nama_Provider;
        }

        public string GetKeterangan()
        {
            return keterangan;
        }

        public void SetKeterangan(string keterangan)
        {
            this.keterangan = keterangan;
        }

        // menampilkan data
        public DataSet SelectedPulsa()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT p.kd_Pulsa, p.nominal, p.Harga, jp.nama_Jenis, pv.nama_Provider, p.keterangan FROM Pulsa p INNER JOIN Jenis_Pulsa jp ON p.kd_Jenis_Pulsa = jp.kd_Jenis_Pulsa INNER JOIN Provider pv ON p.kd_Provider = pv.kd_Provider";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Pulsa");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

        // mengambil data kode
        public DataSet SelectedJenisPulsa()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT kd_Jenis_Pulsa, nama_Jenis FROM Jenis_Pulsa";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Jenis_Pulsa");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }
        public DataSet SelectedProvider()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT kd_Provider, nama_Provider FROM Provider";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Provider");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

        // menambahkan data
        public Boolean InsertedPulsa()
        {
            hasil = false;
            try
            {
                query = "INSERT INTO Pulsa VALUES ('" + kd_Pulsa + "','" + Harga + "','" + nominal + "','" + keterangan + "','" + nama_Jenis + "','" + nama_Provider + "')";
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
        public Boolean UpdatedPulsa()
        {
            hasil = false;
            try
            {
                query = "UPDATE Pulsa SET kd_Pulsa = '" + kd_Pulsa + "', Harga = '" + Harga + "', nominal = '" + nominal + "', kd_Jenis_Pulsa = '" + nama_Jenis + "', kd_Provider = '" + nama_Provider + "' WHERE kd_Pulsa = '" + kd_Pulsa + "'";
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
        public Boolean DeletedPulsa()
        {
            hasil = false;
            try
            {
                query = "DELETE FROM Pulsa WHERE kd_Pulsa = '" + kd_Pulsa + "'";
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
