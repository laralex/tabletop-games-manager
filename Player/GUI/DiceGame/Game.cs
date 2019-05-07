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
    public partial class Game : UserControl
    {
        uint s;
        public Game()
        {
            InitializeComponent();
            s = scoreBoard.ScoreOf("Laralex");
        }

        private void OnReroll(object sender, EventArgs e)
        {
            
            scoreBoard.UpdateOrAddPlayer("Laralex", s += 100);
            //scoreBoard.AddPlayer(new Random().NextDouble().GetHashCode().ToString(), (uint)new Random().Next(1,10000));
        }
    }
}
