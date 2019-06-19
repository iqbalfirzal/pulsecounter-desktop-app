using System;
using System.Windows;

namespace Konter
{
    /// <summary>
    /// Interaction logic for StartUp.xaml
    /// </summary>
    public partial class StartUp : Window
    {
        public StartUp()
        {
            InitializeComponent();
        }
        private void btnLoginAdmin_Clicked(object sender, RoutedEventArgs e)
        {
            LoginPageAdmin bukak = new LoginPageAdmin();
            bukak.Show();
            this.Close();
        }
        private void btnLoginUser_Clicked(object sender, RoutedEventArgs e)
        {
            LoginPageUser bukak = new LoginPageUser();
            bukak.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
