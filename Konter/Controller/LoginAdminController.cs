namespace Konter.Controller
{
    class LoginAdminController
    {
        //new object
        private LoginPageAdmin viewLogin;
        private Model.LoginAdminModel modelAdmin;

        //construct -> instance
        public LoginAdminController(LoginPageAdmin viewLogin)
        {
            this.viewLogin = viewLogin;
            modelAdmin = new Model.LoginAdminModel();
        }

        // validation login function
        public bool LoginAdmin()
        {
            bool hasil = modelAdmin.Login(viewLogin.txtUsernameAdmin.Text, viewLogin.txtPasswordAdmin.Password);
            return hasil;
        }
    }
}
