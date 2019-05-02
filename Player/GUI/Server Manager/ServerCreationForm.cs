using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Player.GUI.ServerManager
{
    public partial class ServerCreationForm : Form
    {
        // FIXME: when numbericupdown field is filled with empty string, OK button is still active
        private bool serverFormFilled, diceFormFilled;
        public bool FieldsFilled => serverSubform.FieldsFilled && dicegameSubform.FieldsFilled;

        public ServerCreationForm()
        {
            InitializeComponent();

            serverFormFilled = serverSubform.FieldsFilled;
            diceFormFilled = dicegameSubform.FieldsFilled;

            serverSubform.FieldsFilledEvent += (object sender, EventArgs e) => {
                serverFormFilled = true;
                btnOK.Enabled = diceFormFilled;
            }; ;
            dicegameSubform.FieldsFilledEvent += (object sender, EventArgs e) => {
                diceFormFilled = true;
                btnOK.Enabled = serverFormFilled; 
            };

            serverSubform.FieldsNotFilledEvent += (object sender, EventArgs e) => {
                serverFormFilled = btnOK.Enabled = false;
            };
            dicegameSubform.FieldsNotFilledEvent += (object sender, EventArgs e) => {
                diceFormFilled = btnOK.Enabled = false;
            };
        }

        public void ResetFields()
        {
            serverSubform.ResetFields();
            dicegameSubform.ResetFields();
        }

        private void OnToDefaults(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void OnServerCreation(object sender, EventArgs e)
        {
            // TODO: db check

            // TODO: add in db

            // TODO: close dialog, add server in servers list
            this.Close();
        }
    }
}
