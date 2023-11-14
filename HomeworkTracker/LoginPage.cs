namespace HomeworkTracker
{
    public partial class LoginPage : Form
    {

        bool isLoggedIn;
        public LoginPage()
        {
            InitializeComponent();
            panelSignup.Visible = false;
            bool isLoggedIn = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelSignup.Visible = false;
            txtboxLoginUsername.Focus();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtboxSignupUsername.Text;
            string password = txtboxSignupPassword.Text;
            string passwordConf = txtboxSignupPasswordConf.Text;

            bool isValid = validateSingupData(username, password, passwordConf);

            if(isValid)
            {
                DataAccess db = new DataAccess();
                db.SignUp(username, password);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtboxLoginUsername.Text;
            string password = txtboxLoginPassword.Text;

            bool isValid = validateLoginData(username, password);

            if (isValid)
            {
                DataAccess db = new DataAccess();
                isLoggedIn = db.Login(username, password);

                if(isLoggedIn)
                {
                    Container obj = new Container();
                    this.Hide();
                    obj.Show();
                }
            }
        }

        private bool validateSingupData(string username, string password, string ConfPassword)
        {
            errorProvider1.Clear();

            bool usernameValid = false;
            bool passwordValid = false;
            bool passwordConfValid = false;

            
            //validate username
            if (username == string.Empty)
            {
                errorProvider1.SetError(txtboxSignupUsername, "Username cannot be empty.");
            }
            else
            {
                usernameValid = true;
            }

            //validate password
            if (password == string.Empty)
            { 
                errorProvider1.SetError(txtboxSignupPassword, "Password cannot be empty.");

            }
            else
            {
                passwordValid = true;
            }

            //validate confirm password
            if (ConfPassword == string.Empty)
            {
                errorProvider1.SetError(txtboxSignupPasswordConf, "Confirm Password cannot be empty.");
            }
            else if(ConfPassword != password)
            {
                errorProvider1.SetError(txtboxSignupPasswordConf, "Password does not match.");
            }
            else
            {
                passwordConfValid = true;
            }


            if (usernameValid && passwordValid && passwordConfValid) {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validateLoginData(string username, string password)
        {
            errorProvider1.Clear();

            bool usernameValid = false;
            bool passwordValid = false;

            //validate username
            if (username == string.Empty)
            {
                errorProvider1.SetError(txtboxLoginUsername, "Username cannot be empty.");
            }
            else
            {
                usernameValid = true;
            }

            //validate password
            if (password == string.Empty)
            {
                errorProvider1.SetError(txtboxLoginPassword, "Password cannot be empty.");

            }
            else
            {
                passwordValid = true;
            }

            if (usernameValid && passwordValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}