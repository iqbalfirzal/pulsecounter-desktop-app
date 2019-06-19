using System.Data.SqlClient;

namespace Konter.Model
{
    class LoginUserModel
    {
        //object class connection
        private SqlConnection connect;
        //deklarasi variabel
        private string query;
        private bool hasil;

        //constuctor
        public LoginUserModel()
        {
            connect = Connection.KoneksiDataBase.GetSqlConnect();
        }
        //enkapsulasi
        //1.information hiding
        private string nama;
        private string code;
        private string password;

        //2.interface for acc data
        public string GetNama()
        {
            return nama;
        }
        public void SetNama(string nama)
        {
            this.nama = nama;
        }
        public string GetCode()
        {
            return code;
        }
        public void SetCode(string code)
        {
            this.code = code;
        }
        public string GetPassword()
        {
            return password;
        }
        public void Setpassword(string password)
        {
            this.password = password;
        }

        // fungsi
        //login
        public bool Login(string username, string password)
        {
            query = "SELECT * FROM Karyawan WHERE USERNAME='" + username + "'" + " AND PASSWORD=HASHBYTES('sha1','" + password + "')";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                if (reader.GetString(1).ToString() == username)
                {
                    hasil = true;
                    this.code = reader.GetString(0).ToString();
                }
                else
                {
                    hasil = false;
                }
            }
            connect.Close();
            return hasil;
        }
    }
}
