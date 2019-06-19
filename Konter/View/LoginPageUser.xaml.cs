using System.Windows;

namespace Konter
{
    /// <summary>
    /// Interaction logic for LoginPageUser.xaml
    /// </summary>
    public partial class LoginPageUser : Window
    {
        //new object
        private Controller.LoginUserController controlLogUser;
        public LoginPageUser()
        {
            InitializeComponent();
            //instance
            controlLogUser = new Controller.LoginUserController(this);
        }

        private void btnBackUser_Clicked(object sender, RoutedEventArgs e)
        {
            StartUp bukak = new StartUp();
            bukak.Show();
            this.Close();
        }

        public void btnLoginUser_Click(object sender, RoutedEventArgs e)
        {
            if (controlLogUser.LoginUser() == true)
            {
                TransactionRecord bukak = new TransactionRecord(controlLogUser.KdKaryawan);
                bukak.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username / password salah!");
                txtUsernameUser.Text = "";
                txtPasswordUser.Password = "";
                txtUsernameUser.Focus();
            }
        }
    }
}
