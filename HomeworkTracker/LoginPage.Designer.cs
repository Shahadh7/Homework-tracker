namespace HomeworkTracker
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelImage = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelLogin = new Panel();
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            panelSignup = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lblSignup = new Label();
            txtboxSignupPasswordConf = new CustomControls.RJControls.CustomTextBox();
            lblConfirmPassword = new Label();
            lblLoginLink = new Label();
            btnSignUp = new CustomControls.RJControls.CustomButton();
            txtboxSignupPassword = new CustomControls.RJControls.CustomTextBox();
            label4 = new Label();
            txtboxSignupUsername = new CustomControls.RJControls.CustomTextBox();
            label5 = new Label();
            lblLogin = new Label();
            lblSignupLink = new Label();
            btnLogin = new CustomControls.RJControls.CustomButton();
            txtboxLoginPassword = new CustomControls.RJControls.CustomTextBox();
            lblPassword = new Label();
            txtboxLoginUsername = new CustomControls.RJControls.CustomTextBox();
            lblUsername = new Label();
            errorProvider1 = new ErrorProvider(components);
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogin.SuspendLayout();
            panelSignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelImage
            // 
            panelImage.BackColor = Color.FromArgb(9, 64, 103);
            panelImage.Controls.Add(label1);
            panelImage.Controls.Add(pictureBox1);
            panelImage.Dock = DockStyle.Left;
            panelImage.Location = new Point(0, 0);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(400, 592);
            panelImage.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(367, 45);
            label1.TabIndex = 1;
            label1.Text = "HOMEWORK TRACKER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.task_mangement_vector;
            pictureBox1.Location = new Point(0, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 394);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(216, 238, 254);
            panelLogin.Controls.Add(nightControlBox2);
            panelLogin.Controls.Add(panelSignup);
            panelLogin.Controls.Add(lblLogin);
            panelLogin.Controls.Add(lblSignupLink);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(txtboxLoginPassword);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtboxLoginUsername);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Dock = DockStyle.Right;
            panelLogin.Location = new Point(402, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(388, 592);
            panelLogin.TabIndex = 1;
            // 
            // nightControlBox2
            // 
            nightControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox2.BackColor = Color.Transparent;
            nightControlBox2.CloseHoverColor = Color.FromArgb(255, 128, 128);
            nightControlBox2.CloseHoverForeColor = Color.White;
            nightControlBox2.DefaultLocation = true;
            nightControlBox2.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox2.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox2.EnableCloseColor = Color.Black;
            nightControlBox2.EnableMaximizeButton = false;
            nightControlBox2.EnableMaximizeColor = Color.Black;
            nightControlBox2.EnableMinimizeButton = true;
            nightControlBox2.EnableMinimizeColor = Color.Black;
            nightControlBox2.Location = new Point(249, 0);
            nightControlBox2.MaximizeHoverColor = Color.FromArgb(255, 128, 128);
            nightControlBox2.MaximizeHoverForeColor = Color.White;
            nightControlBox2.MinimizeHoverColor = Color.FromArgb(255, 128, 128);
            nightControlBox2.MinimizeHoverForeColor = Color.White;
            nightControlBox2.Name = "nightControlBox2";
            nightControlBox2.Size = new Size(139, 31);
            nightControlBox2.TabIndex = 9;
            // 
            // panelSignup
            // 
            panelSignup.Controls.Add(nightControlBox1);
            panelSignup.Controls.Add(lblSignup);
            panelSignup.Controls.Add(txtboxSignupPasswordConf);
            panelSignup.Controls.Add(lblConfirmPassword);
            panelSignup.Controls.Add(lblLoginLink);
            panelSignup.Controls.Add(btnSignUp);
            panelSignup.Controls.Add(txtboxSignupPassword);
            panelSignup.Controls.Add(label4);
            panelSignup.Controls.Add(txtboxSignupUsername);
            panelSignup.Controls.Add(label5);
            panelSignup.Dock = DockStyle.Right;
            panelSignup.Location = new Point(0, 0);
            panelSignup.Name = "panelSignup";
            panelSignup.Size = new Size(388, 592);
            panelSignup.TabIndex = 8;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(249, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 18;
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignup.ForeColor = Color.FromArgb(9, 64, 103);
            lblSignup.Location = new Point(27, 118);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(121, 40);
            lblSignup.TabIndex = 9;
            lblSignup.Text = "Sign up";
            // 
            // txtboxSignupPasswordConf
            // 
            txtboxSignupPasswordConf.BackColor = SystemColors.Window;
            txtboxSignupPasswordConf.BorderColor = Color.Transparent;
            txtboxSignupPasswordConf.BorderFocusColor = Color.CornflowerBlue;
            txtboxSignupPasswordConf.BorderRadius = 5;
            txtboxSignupPasswordConf.BorderSize = 2;
            txtboxSignupPasswordConf.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxSignupPasswordConf.ForeColor = Color.FromArgb(64, 64, 64);
            txtboxSignupPasswordConf.Location = new Point(27, 385);
            txtboxSignupPasswordConf.Margin = new Padding(4);
            txtboxSignupPasswordConf.Multiline = false;
            txtboxSignupPasswordConf.Name = "txtboxSignupPasswordConf";
            txtboxSignupPasswordConf.Padding = new Padding(10, 7, 10, 7);
            txtboxSignupPasswordConf.PasswordChar = true;
            txtboxSignupPasswordConf.PlaceholderColor = Color.DarkGray;
            txtboxSignupPasswordConf.PlaceholderText = "Enter confirm password";
            txtboxSignupPasswordConf.Size = new Size(324, 31);
            txtboxSignupPasswordConf.TabIndex = 15;
            txtboxSignupPasswordConf.UnderlinedStyle = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmPassword.Location = new Point(27, 356);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(166, 25);
            lblConfirmPassword.TabIndex = 14;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblLoginLink
            // 
            lblLoginLink.AutoSize = true;
            lblLoginLink.Cursor = Cursors.Hand;
            lblLoginLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginLink.Location = new Point(36, 487);
            lblLoginLink.Name = "lblLoginLink";
            lblLoginLink.Size = new Size(233, 21);
            lblLoginLink.TabIndex = 17;
            lblLoginLink.Text = "Already have an account? Log in";
            lblLoginLink.Click += label3_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(239, 69, 101);
            btnSignUp.BackgroundColor = Color.FromArgb(239, 69, 101);
            btnSignUp.BorderColor = Color.Transparent;
            btnSignUp.BorderRadius = 5;
            btnSignUp.BorderSize = 0;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(27, 440);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(324, 33);
            btnSignUp.TabIndex = 16;
            btnSignUp.Text = "Sign up";
            btnSignUp.TextColor = Color.White;
            btnSignUp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtboxSignupPassword
            // 
            txtboxSignupPassword.BackColor = SystemColors.Window;
            txtboxSignupPassword.BorderColor = Color.Transparent;
            txtboxSignupPassword.BorderFocusColor = Color.CornflowerBlue;
            txtboxSignupPassword.BorderRadius = 5;
            txtboxSignupPassword.BorderSize = 2;
            txtboxSignupPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxSignupPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtboxSignupPassword.Location = new Point(27, 298);
            txtboxSignupPassword.Margin = new Padding(4);
            txtboxSignupPassword.Multiline = false;
            txtboxSignupPassword.Name = "txtboxSignupPassword";
            txtboxSignupPassword.Padding = new Padding(10, 7, 10, 7);
            txtboxSignupPassword.PasswordChar = true;
            txtboxSignupPassword.PlaceholderColor = Color.DarkGray;
            txtboxSignupPassword.PlaceholderText = "Enter password";
            txtboxSignupPassword.Size = new Size(324, 31);
            txtboxSignupPassword.TabIndex = 13;
            txtboxSignupPassword.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 269);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // txtboxSignupUsername
            // 
            txtboxSignupUsername.BackColor = SystemColors.Window;
            txtboxSignupUsername.BorderColor = Color.Transparent;
            txtboxSignupUsername.BorderFocusColor = Color.CornflowerBlue;
            txtboxSignupUsername.BorderRadius = 5;
            txtboxSignupUsername.BorderSize = 2;
            txtboxSignupUsername.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxSignupUsername.ForeColor = Color.FromArgb(64, 64, 64);
            txtboxSignupUsername.Location = new Point(27, 205);
            txtboxSignupUsername.Margin = new Padding(4);
            txtboxSignupUsername.Multiline = false;
            txtboxSignupUsername.Name = "txtboxSignupUsername";
            txtboxSignupUsername.Padding = new Padding(10, 7, 10, 7);
            txtboxSignupUsername.PasswordChar = false;
            txtboxSignupUsername.PlaceholderColor = Color.DarkGray;
            txtboxSignupUsername.PlaceholderText = "Enter username";
            txtboxSignupUsername.Size = new Size(324, 31);
            txtboxSignupUsername.TabIndex = 11;
            txtboxSignupUsername.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 176);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 10;
            label5.Text = "Username";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(9, 64, 103);
            lblLogin.Location = new Point(27, 118);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(94, 40);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // lblSignupLink
            // 
            lblSignupLink.AutoSize = true;
            lblSignupLink.Cursor = Cursors.Hand;
            lblSignupLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSignupLink.Location = new Point(36, 400);
            lblSignupLink.Name = "lblSignupLink";
            lblSignupLink.Size = new Size(212, 21);
            lblSignupLink.TabIndex = 8;
            lblSignupLink.Text = "New here? Create an account";
            lblSignupLink.Click += label2_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(239, 69, 101);
            btnLogin.BackgroundColor = Color.FromArgb(239, 69, 101);
            btnLogin.BorderColor = Color.Transparent;
            btnLogin.BorderRadius = 5;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(27, 353);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(324, 33);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtboxLoginPassword
            // 
            txtboxLoginPassword.BackColor = SystemColors.Window;
            txtboxLoginPassword.BorderColor = Color.Transparent;
            txtboxLoginPassword.BorderFocusColor = Color.CornflowerBlue;
            txtboxLoginPassword.BorderRadius = 5;
            txtboxLoginPassword.BorderSize = 2;
            txtboxLoginPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxLoginPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtboxLoginPassword.Location = new Point(27, 298);
            txtboxLoginPassword.Margin = new Padding(4);
            txtboxLoginPassword.Multiline = false;
            txtboxLoginPassword.Name = "txtboxLoginPassword";
            txtboxLoginPassword.Padding = new Padding(10, 7, 10, 7);
            txtboxLoginPassword.PasswordChar = true;
            txtboxLoginPassword.PlaceholderColor = Color.DarkGray;
            txtboxLoginPassword.PlaceholderText = "Enter password";
            txtboxLoginPassword.Size = new Size(324, 31);
            txtboxLoginPassword.TabIndex = 6;
            txtboxLoginPassword.UnderlinedStyle = true;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(27, 269);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(99, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtboxLoginUsername
            // 
            txtboxLoginUsername.BackColor = SystemColors.Window;
            txtboxLoginUsername.BorderColor = Color.Transparent;
            txtboxLoginUsername.BorderFocusColor = Color.CornflowerBlue;
            txtboxLoginUsername.BorderRadius = 5;
            txtboxLoginUsername.BorderSize = 2;
            txtboxLoginUsername.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxLoginUsername.ForeColor = Color.FromArgb(64, 64, 64);
            txtboxLoginUsername.Location = new Point(27, 205);
            txtboxLoginUsername.Margin = new Padding(4);
            txtboxLoginUsername.Multiline = false;
            txtboxLoginUsername.Name = "txtboxLoginUsername";
            txtboxLoginUsername.Padding = new Padding(10, 7, 10, 7);
            txtboxLoginUsername.PasswordChar = false;
            txtboxLoginUsername.PlaceholderColor = Color.DarkGray;
            txtboxLoginUsername.PlaceholderText = "Enter Username";
            txtboxLoginUsername.Size = new Size(324, 31);
            txtboxLoginUsername.TabIndex = 4;
            txtboxLoginUsername.UnderlinedStyle = true;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(27, 176);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 25);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 238, 254);
            ClientSize = new Size(790, 592);
            Controls.Add(panelLogin);
            Controls.Add(panelImage);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelImage.ResumeLayout(false);
            panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelSignup.ResumeLayout(false);
            panelSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelImage;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelLogin;
        private Label lblUsername;
        private CustomControls.RJControls.CustomTextBox txtboxLoginUsername;
        private CustomControls.RJControls.CustomTextBox txtboxLoginPassword;
        private Label lblPassword;
        private CustomControls.RJControls.CustomButton btnLogin;
        private Label lblSignupLink;
        private Panel panelSignup;
        private CustomControls.RJControls.CustomTextBox txtboxSignupPasswordConf;
        private Label lblConfirmPassword;
        private Label lblLoginLink;
        private CustomControls.RJControls.CustomButton btnSignUp;
        private CustomControls.RJControls.CustomTextBox txtboxSignupPassword;
        private Label label4;
        private CustomControls.RJControls.CustomTextBox txtboxSignupUsername;
        private Label label5;
        private Label lblLogin;
        private Label lblSignup;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private ErrorProvider errorProvider1;
    }
}