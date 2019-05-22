using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameClient.GUI.ServerManager.ServerCreator
{
    public partial class DiceServerOptions : UserControl, IFieldsOwner
    {
        public DiceServerOptions()
        {
            InitializeComponent();
            Reset();
        }

        public bool FieldsFilled => true;

        public event EventHandler FieldsFilledEvent;
        public event EventHandler FieldsNotFilledEvent;

        public void Reset()
        {
            numScoreGoal.Value = Convert.ToDecimal(numScoreGoal.Tag);
            numTurnTime.Value = Convert.ToDecimal(numTurnTime.Tag);
            numDiceNumber.Value = Convert.ToDecimal(numDiceNumber.Tag);
            chkIncludedJoker.Checked = Convert.ToInt32(chkIncludedJoker.Tag) > 0;
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
