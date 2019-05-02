using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Player.GUI.Login
{
    public partial class LoginFields : UserControl
    {
        public event EventHandler ChangeToRegisterUi;

        public LoginFields()
        {
            InitializeComponent();
            ResetFields();
        }

        public void ResetFields()
        {
            txtLoginUsername.ResetText();
            txtLoginPassword.ResetText();
            btnLogin.Enabled = false;
            lblErrorMessage.Text = "";
        }

        // Press on "Login" - try sign in 
        private void OnLogin(object sender, EventArgs e)
        {
            // TODO: get user's hash from DB

            // TODO: check passwords hashes

            // TODO: login, pass to a next form
            // Change state, not explicit close
            this.ParentForm.Close();
        }

        // Press on "Register" - change UI on register form
        private void OnRegister(object sender, EventArgs e)
        {
            ChangeToRegisterUi.Invoke(this, EventArgs.Empty);
        }

        // Change of login textboxes' text - check if basic requirements are complied
        private void OnLoginFormFilling(object sender, EventArgs e)
        {
            btnLogin.Enabled =
                txtLoginUsername.Text != "" && txtLoginPassword.Text != "";
        }
    }
}
