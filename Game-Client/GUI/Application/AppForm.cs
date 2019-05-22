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
    public partial class AppForm : Form
    {
        public AppForm()
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
