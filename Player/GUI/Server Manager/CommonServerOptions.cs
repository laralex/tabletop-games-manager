using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Player.GUI.ServerManager
{
    public partial class CommonServerOptions : UserControl, IFieldsOwner
    {
        public CommonServerOptions()
        {
            InitializeComponent();
        }

        public bool FieldsFilled { get => txtName.Text != ""; }

        public event EventHandler FieldsFilledEvent;
        public event EventHandler FieldsNotFilledEvent;

        public void ResetFields()
        {
            txtName.ResetText();
            numMaxPlayers.Value = Convert.ToDecimal(numMaxPlayers.Tag);
        }

        private void OnFieldChange(object sender, EventArgs e)
        {
            if (FieldsFilled)
            {
                FieldsFilledEvent?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                FieldsNotFilledEvent?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
