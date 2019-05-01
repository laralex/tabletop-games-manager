using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Player.GUI.Login
{
    public partial class LoginForm : Form
    {
        Regex username_valid_chars = new Regex("^[a-zA-Z0-9_.-]+$", RegexOptions.Compiled);
        Regex password_valid_chars = new Regex("^[a-zA-Z0-9]+$", RegexOptions.Compiled);
        public LoginForm()
        { 
            InitializeComponent();
            //lblErrorMessage.Text = null;
            //lblErrorMessage.Parent = pnlLogin;
        }

        // Press on "Login" - try sign in 
        private void OnLogin(object sender, EventArgs e)
        {
            // TODO: get user's hash from DB

            // TODO: check passwords hashes

            // TODO: login, pass to a next form
            this.Close();
        }

        // Press on "Register" - change UI on register form
        private void OnRegister(object sender, EventArgs e)
        {
            // Swap panels
            pnlLogin.Visible = pnlLogin.Enabled = false;
            pnlRegister.Visible = pnlRegister.Enabled = true;
            lblErrorMessage.Parent = pnlRegister;
            // Let panel fit
            this.Size = new Size(this.Size.Width, 215);
            
            // Clear fields
            lblErrorMessage.Text
                = txtLoginUsername.Text
                = txtLoginPassword.Text
                = null;
            btnRegisterConfirm.Enabled = false;
        }

        // Press on "Register" on register form - try to create a user
        private void OnRegisterConfirm(object sender, EventArgs e)
        {
            // TODO: if user not exists ...

            // TODO: add in DB

            // TODO: login, pass to a next form
            this.Close();
        }

        // Press on "Back to login" - change UI on login form
        private void OnBackToLogin(object sender, EventArgs e)
        {
            // Swap panels
            pnlRegister.Visible = pnlRegister.Enabled = false;
            pnlLogin.Visible = pnlLogin.Enabled = true;
            lblErrorMessage.Parent = pnlLogin;
            // Let panel fit
            this.Size = new Size(this.Size.Width, 180);
            // Clear fields
            lblErrorMessage.Text 
                = txtRegisterPassword.Text
                = txtRegisterRepeat.Text
                = txtRegisterUsername.Text
                = null;
            btnLogin.Enabled = false;
        }

        // Change of registration textboxes' text - check if basic requirements are complied
        private void OnRegisterFormFilling(object sender, EventArgs e)
        {
            btnRegisterConfirm.Enabled = false;

            if ( txtRegisterUsername.Text == ""
                 || txtRegisterPassword.Text == ""
                 || txtRegisterRepeat.Text == "" )
            {
                lblErrorMessage.Text = "Must fill all the fields";
                return;
            }

            if ( txtRegisterUsername.Text.Length < 4 )
            {
                lblErrorMessage.Text = "Username must be atleast 4 characters long";
                return;
            }

            if ( txtRegisterPassword.Text.Length < 3 )
            {
                lblErrorMessage.Text = "Password must be atleast 3 characters long";
                return;
            }

            if ( ! username_valid_chars.IsMatch(txtRegisterUsername.Text) )
            {
                lblErrorMessage.Text = "Username must contain only latin letters, \n numbers, '_' / '.' / '-' characters";
                return;
            }

            if ( ! password_valid_chars.IsMatch(txtRegisterPassword.Text) )
            {
                lblErrorMessage.Text = "Password must contain only latin letters, numbers";
                return;
            }

            if ( txtRegisterPassword.Text != txtRegisterRepeat.Text )
            {
                lblErrorMessage.Text = "Passwords must match";
                return;
            }

            btnRegisterConfirm.Enabled = true;
            lblErrorMessage.Text = "";
        }

        // Change of login textboxes' text - check if basic requirements are complied
        private void OnLoginFormFilling(object sender, EventArgs e)
        {
            btnLogin.Enabled = 
                txtLoginUsername.Text != "" && txtLoginPassword.Text != "";
        }

        private void OnTextBoxFocus(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    }
}
