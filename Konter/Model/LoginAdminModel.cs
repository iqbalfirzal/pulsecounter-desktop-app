// data sql client header
using System.Data.SqlClient;

namespace Konter.Model
{
    class LoginAdminModel
    {
        // object class connection
        private SqlConnection connect;
        // variable declaration
        private string query;
        private bool hasil;

        // constuctor
        public LoginAdminModel()
        {
            connect = Connection.KoneksiDataBase.GetSqlConnect();
        }
        // encapsulation
        // 1.information hiding
        private string nama;
        private string password;

        // 2.interface for acc data
        public string GetNama()
        {
            return nama;
        }
        public void SetNama(string nama)
        {
            this.nama = nama;
        }
        public string GetPassword()
        {
            return password;
        }
        public void Setpassword(string password)
        {
            this.password = password;
        }

        // login function
        public bool Login(string username, string password)
        {
            query = "SELECT * FROM Manager WHERE USERNAME='" + username + "'" + " AND PASSWORD=HASHBYTES('sha1','" + password + "')";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(1).ToString() == username)
                {
                    hasil = true;
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
