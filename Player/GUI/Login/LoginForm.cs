using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Player.GUI.Login
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        { 
            InitializeComponent();

            loginSubform.Show();
            loginSubform.ChangeToRegisterUi += OnChangeToRegisterUi;

            registrationSubform.Hide();
            registrationSubform.ChangeToLoginUi += OnChangeToLoginUi;
        }

        private void OnChangeToLoginUi(object sender, EventArgs e)
        {
            registrationSubform.Hide();
            loginSubform.ResetFields();
            loginSubform.Show();
            this.Size = new Size(this.Size.Width, 180);
            this.Text = "Login";
        }

        private void OnChangeToRegisterUi(object sender, EventArgs e)
        {
            loginSubform.Hide();
            registrationSubform.ResetFields();
            registrationSubform.Show();
            this.Size = new Size(this.Size.Width, 215);
            this.Text = "Register User";
        }

    }
}
