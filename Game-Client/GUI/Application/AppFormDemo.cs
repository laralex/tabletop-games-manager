using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameClient.GUI.Application
{
    public partial class AppFormDemo : Form
    {
        public AppFormDemo()
        {
            InitializeComponent();
        }

        private void OnMenuAbout(object sender, EventArgs e)
        {
            new AboutBox().Show(this);
        }

        private void GreateGameView()
        {

        }

    }
}
