namespace Konter.Controller
{
    class LoginUserController
    {
        //1. buat object
        private LoginPageUser viewLogin;
        private Model.LoginUserModel modelUser;
        public string KdKaryawan;

        //construct -> instance
        public LoginUserController(LoginPageUser viewLogin)
        {
            this.viewLogin = viewLogin;
            modelUser = new Model.LoginUserModel();
        }

        //fungsi validasi login
        public bool LoginUser()
        {
            bool hasil = modelUser.Login(viewLogin.txtUsernameUser.Text, viewLogin.txtPasswordUser.Password);
            this.KdKaryawan = modelUser.GetCode();
            return hasil;
        }
    }
}
