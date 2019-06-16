using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CommonLibrary.Model.Common;

namespace GameClient.GUI.Login
{
    public partial class LoginFields : UserControl, IFieldsOwner
    { 
        public bool FieldsFilled {
            get => fields_filled;
            private set
            {
                btnLogin.Enabled = fields_filled = value;
                if (value)
                { 
                    FieldsFilledEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    FieldsNotFilledEvent?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler ChangeToRegisterUi;
        public event EventHandler FieldsFilledEvent;
        public event EventHandler FieldsNotFilledEvent;

        public event EventHandler<LoginFormEventArgs> Login;

        public LoginFields()
        {
            InitializeComponent();
            Reset();
        }

        public void Reset()
        {
            txtLoginUsername.ResetText();
            txtLoginPassword.ResetText();
            lblErrorMessage.Text = null;
            FieldsFilled = false;
        }

        public void FailLogin(string msg)
        {
            lblErrorMessage.Text = msg;
        }
        // Press on "Login" - try log in 
        private void OnLogin(object sender, EventArgs e)
        {
            Login?.Invoke(
                this,
                new LoginFormEventArgs(txtLoginUsername.Text, txtLoginPassword.Text)
            );
            // Change state, not explicit close
            //this.ParentForm.Close();

        }

        // Press on "Not registered yet" - change UI on register form
        private void OnRegistrationRequest(object sender, EventArgs e)
        {
            ChangeToRegisterUi?.Invoke(this, EventArgs.Empty);
        }

        // Change of login textboxes' text - check if basic requirements are complied
        private void OnLoginFormFilling(object sender, EventArgs e)
        {
            FieldsFilled = txtLoginUsername.Text != "" && txtLoginPassword.Text != "";
        }

        private bool fields_filled;
    }

}
