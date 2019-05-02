using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Player.GUI.Login
{
    public partial class RegistrationFields : UserControl
    {
        Regex username_valid_chars = new Regex("^[a-zA-Z0-9_.-]+$", RegexOptions.Compiled);
        Regex password_valid_chars = new Regex("^[a-zA-Z0-9]+$", RegexOptions.Compiled);

        public event EventHandler ChangeToLoginUi;

        public RegistrationFields()
        {
            InitializeComponent();
            ResetFields();
        }

        public void ResetFields()
        {
            txtRegisterUsername.ResetText();
            txtRegisterPassword.ResetText();
            txtRegisterRepeat.ResetText();
            btnRegisterConfirm.Enabled = false;
            lblErrorMessage.Text = "";
        }


        // Press on "Register" on register form - try to create a user
        private void OnRegisterConfirm(object sender, EventArgs e)
        {
            // TODO: if user not exists ...

            // TODO: add in DB

            // TODO: login, pass to a next form
            // Change state, not explicit close
            this.ParentForm.Close();
        }       

        // Press on "Back to login" - change UI on login form
        private void OnBackToLogin(object sender, EventArgs e)
        {
            ChangeToLoginUi.Invoke(this, EventArgs.Empty);
        }

        // Change of registration textboxes' text - check if basic requirements are complied
        private void OnRegisterFormFilling(object sender, EventArgs e)
        {
            btnRegisterConfirm.Enabled = false;

            if (txtRegisterUsername.Text == ""
                 || txtRegisterPassword.Text == ""
                 || txtRegisterRepeat.Text == "")
            {
                lblErrorMessage.Text = "Must fill all the fields";
                return;
            }

            if (txtRegisterUsername.Text.Length < 4)
            {
                lblErrorMessage.Text = "Username must be atleast 4 characters long";
                return;
            }

            if (txtRegisterPassword.Text.Length < 3)
            {
                lblErrorMessage.Text = "Password must be atleast 3 characters long";
                return;
            }

            if (!username_valid_chars.IsMatch(txtRegisterUsername.Text))
            {
                lblErrorMessage.Text = "Username must contain only latin letters, \n numbers, '_' / '.' / '-' characters";
                return;
            }

            if (!password_valid_chars.IsMatch(txtRegisterPassword.Text))
            {
                lblErrorMessage.Text = "Password must contain only latin letters, numbers";
                return;
            }

            if (txtRegisterPassword.Text != txtRegisterRepeat.Text)
            {
                lblErrorMessage.Text = "Passwords must match";
                return;
            }

            btnRegisterConfirm.Enabled = true;
            lblErrorMessage.Text = "";
        }

        private void OnTextBoxFocus(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    }

    
}
