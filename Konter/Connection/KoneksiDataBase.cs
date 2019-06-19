using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Menambahkan header untuk dapat menggunakan kode yang berhubungan dengan database sql server
using System.Data.SqlClient;

namespace Konter.Connection
{
    class KoneksiDataBase
    {
        // Deklarasi field variable dengan akses private
        private static SqlConnection SqlConnect;

        // Fungsi untuk koneksi ke database sql server dengan akses publik
        public static SqlConnection GetSqlConnect()
        {
            SqlConnect = new SqlConnection();
            SqlConnect.ConnectionString = "Data Source = THREMOS-PC\\SQLEXPRESS;" +
                                       "Initial Catalog = Pembukuan_Counter_Pulsa;" +
                                       "Integrated Security = True;";
            return SqlConnect;
        }
    }
}
