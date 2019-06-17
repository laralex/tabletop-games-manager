using CommonLibrary.Implementation.Games.Dice;
using CommonLibrary.Implementation.ServerSide;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameClient.GUI.ServerManager.ServerCreator
{
    public partial class ServerCreationForm : Form
    {
        // FIXME: when numbericupdown field is filled with empty string, OK button is still active
        
        public bool FieldsFilled => serverSubform.FieldsFilled && dicegameSubform.FieldsFilled;

        public event EventHandler<ServerCreationEventArgs> OptionsSubmitted;
        public ServerCreationForm()
        {
            InitializeComponent();

            _server_form_filled = serverSubform.FieldsFilled;
            _dice_form_filled = dicegameSubform.FieldsFilled;

            serverSubform.FieldsFilledEvent += (object sender, EventArgs e) => {
                _server_form_filled = true;
                btnOK.Enabled = _dice_form_filled;
            };
            dicegameSubform.FieldsFilledEvent += (object sender, EventArgs e) => {
                _dice_form_filled = true;
                btnOK.Enabled = _server_form_filled; 
            };

            serverSubform.FieldsNotFilledEvent += (object sender, EventArgs e) => {
                _server_form_filled = btnOK.Enabled = false;
            };
            dicegameSubform.FieldsNotFilledEvent += (object sender, EventArgs e) => {
                _dice_form_filled = btnOK.Enabled = false;
            };
        }

        public void ResetFields()
        {
            serverSubform.Reset();
            dicegameSubform.Reset();
        }

        private void OnToDefaults(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void OnServerCreation(object sender, EventArgs e)
        {
            var options = new DiceGameServerEntry()
            {
                Name = serverSubform.txtName.Text,
                MaxPlayers = (int)serverSubform.numMaxPlayers.Value,
                TurnTimeSec = (int)dicegameSubform.numTurnTime.Value,
                ScoreGoal = (int)dicegameSubform.numScoreGoal.Value,
                IsJokerAllowed = dicegameSubform.chkIncludedJoker.Checked,
                DiceNumber = (int)dicegameSubform.numDiceNumber.Value
            };
            OptionsSubmitted?.Invoke(
                this,
                new ServerCreationEventArgs(options)
            );
            this.Close();
        }

        private bool _server_form_filled, _dice_form_filled;
    }

    public class ServerCreationEventArgs : EventArgs
    {
        public GameServerEntry Options;

        public ServerCreationEventArgs(GameServerEntry options)
        {
            Options = options;
        }
    }
}
