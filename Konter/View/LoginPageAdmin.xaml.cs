using System.Windows;

namespace Konter
{
    /// <summary>
    /// Interaction logic for LoginPageAdmin.xaml
    /// </summary>
    public partial class LoginPageAdmin : Window
    {
        //new object
        private Controller.LoginAdminController controlLogAdmin;
        public LoginPageAdmin()
        {
            InitializeComponent();
            //instance
            controlLogAdmin = new Controller.LoginAdminController(this);
        }
        // button login click and calling login function
        private void btnLoginAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (controlLogAdmin.LoginAdmin() == true)
            {
                AdminPage bukak = new AdminPage();
                this.Close();
                bukak.Show();
            }
            else
            {
                MessageBox.Show("Username / password salah!");
                txtUsernameAdmin.Text = "";
                txtPasswordAdmin.Password = "";
                txtUsernameAdmin.Focus();
            }
        }
        private void btnBackAdmin_Clicked(object sender, RoutedEventArgs e)
        {
            StartUp bukak = new StartUp();
            bukak.Show();
            this.Close();
        }
    }
}
