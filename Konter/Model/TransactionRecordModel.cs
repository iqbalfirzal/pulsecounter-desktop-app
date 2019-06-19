using System;
using System.Data.SqlClient;
using System.Data;

namespace Konter.Model
{
    class TransactionRecordModel
    {
        // object class Connection
        private SqlConnection conn;
        private SqlCommand command;

        // deklarasi variabel tambahan
        private string query;
        private bool hasil;

        // constructor
        public TransactionRecordModel()
        {
            conn = Connection.KoneksiDataBase.GetSqlConnect();
        }

        // declar variabel
        private string kd_Transaksi;
        private string Kd_Karyawan;
        private string nomor_Handphone;
        private string kd_Pulsa;

        ///interface for acc data
        public string GetKd_Transaksi()
        {
            return kd_Transaksi;
        }

        public void SetKd_Transaksi(string kd_Transaksi)
        {
            this.kd_Transaksi = kd_Transaksi;
        }

        public string GetNomor_Handphone()
        {
            return nomor_Handphone;
        }

        public void SettNomor_Handphone(string nomor_Handphone)
        {
            this.nomor_Handphone = nomor_Handphone;
        }
        public string GetKd_Pulsa()
        {
            return kd_Pulsa;
        }

        public void SetKd_Pulsa(string kd_Pulsa)
        {
            this.kd_Pulsa = kd_Pulsa;
        }

        public string GetKd_Karyawan()
        {
            return Kd_Karyawan;
        }

        public void SetKd_Karyawan(string Kd_Karyawan)
        {
            this.Kd_Karyawan = Kd_Karyawan;
        }

        // menampilkan data
        public DataSet SelectedTransaction()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                // MASIH ERROR BELUM BISA AMBIL KODE KARYAWAN
                command.CommandText = "SELECT t.kd_Transaksi, t.nomor_Handphone, p.nominal, p.Harga, k.Nama, t.tanggal_Transaksi FROM Transaksi t INNER JOIN pulsa p ON t.kd_Pulsa = p.kd_Pulsa INNER JOIN Karyawan k ON t.kd_Karyawan = k.kd_Karyawan WHERE k.kd_Karyawan = '"+ Kd_Karyawan + "'";
                // ==========================================
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Transaksi");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

        // mengambil data kode pulsa
        public DataSet SelectedCodePulsa()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT kd_Pulsa, keterangan FROM Pulsa";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Pulsa");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

        // menambahkan data
        public Boolean InsertedTransaction()
        {
            hasil = false;
            try
            {
                query = "INSERT INTO Transaksi VALUES ('" + nomor_Handphone + "',GETDATE(),'" + kd_Pulsa + "','" + Kd_Karyawan + "')";
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
        public Boolean DeletedTransaction()
        {
            hasil = false;
            try
            {
                query = "DELETE FROM Transaksi WHERE kd_Transaksi = '" + kd_Transaksi + "'";
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
