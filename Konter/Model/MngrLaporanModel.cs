using System;
using System.Data.SqlClient;
using System.Data;

namespace Konter.Model
{
    class MngrLaporanModel
    {
        // object class Connection
        private SqlConnection conn;
        private SqlCommand command;

        // deklarasi variabel tambahan
        private string query;
        private bool hasil;

        // constructor

        public MngrLaporanModel()
        {
            conn = Connection.KoneksiDataBase.GetSqlConnect();
        }

        // declar variabel
        private string kd_Transaksi;

        ///interface for acc data
        public string GetKd_Transaksi()
        {
            return kd_Transaksi;
        }

        public void SetKd_Transaksi(string kd_Transaksi)
        {
            this.kd_Transaksi = kd_Transaksi;
        }

        // menampilkan data
        public DataSet SelectedLaporan()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT t.kd_Transaksi, t.nomor_Handphone, p.nominal, p.Harga, k.Nama, t.tanggal_Transaksi FROM Transaksi t INNER JOIN pulsa p ON t.kd_Pulsa = p.kd_Pulsa INNER JOIN Karyawan k ON t.kd_Karyawan = k.kd_Karyawan";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Karyawan");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

        // mereset data
        public Boolean ResetedLaporan()
        {
            hasil = false;
            try
            {
                query = "DELETE FROM Transaksi";
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
