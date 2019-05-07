using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Player.GUI.DiceGame
{
    public partial class Die : UserControl
    {
        public Die()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Call the OnPaint method of the base class.  
            base.OnPaint(pevent);
            // Call methods of the System.Drawing.Graphics object.  
            pevent.Graphics.DrawString("123", Font, new SolidBrush(ForeColor), ClientRectangle);
        }
    }
}
