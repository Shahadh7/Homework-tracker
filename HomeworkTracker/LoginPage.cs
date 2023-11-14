namespace HomeworkTracker
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            panelSignup.Visible = false;

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
                MessageBox.Show("valid data");
            }



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Container obj = new Container();
            this.Hide();
            obj.Show();
        }

        private bool validateSingupData(string username, string password, string ConfPassword)
        {
            errorProvider1.Clear();

            bool usernameValid = false;
            bool passwordValid = false;
            bool passwordConfValid = false;

            
            //validate username
            if (username == "")
            {
                errorProvider1.SetError(txtboxSignupUsername, "Please enter the username.");
            }
            else
            {
                usernameValid = true;
            }

            //validate password
            if (password == "")
            { 
                errorProvider1.SetError(txtboxSignupPassword, "Password cannot be empty.");

            }
            else
            {
                passwordValid = true;
            }

            //validate confirm password
            if (ConfPassword == "")
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
    }
}