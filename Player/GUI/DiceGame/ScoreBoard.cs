using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Player.GUI.Dice_Game
{
    public partial class ScoreBoard : UserControl
    {
        public ScoreBoard()
        {
            InitializeComponent();
            AddPlayer("Laralex");
            AddPlayer("ALex", 1);
            AddPlayer("ALex", 1000);
            AddPlayer("sdex", 2000);
            AddPlayer("4ex", 1000);

        }

        public void AddPlayer(string username, int score = 0)
        {
            if (!HasPlayer(username))
            {
                tblScoreBoard.Rows.Add(tblScoreBoard.Rows.Count + 1, username, score.ToString());
                SortBoard();
            }
        }

        public void RemovePlayer(string username)
        {
            foreach (DataGridViewRow row in tblScoreBoard.Rows)
            {
                if (row.Cells["colPlayer"].Value.Equals(username))
                {
                    tblScoreBoard.Rows.Remove(row);
                }
            }
        }

        public bool HasPlayer(string username)
        {
            foreach (DataGridViewRow row in tblScoreBoard.Rows)
            {
                if (row.Cells["colPlayer"].Value.Equals(username))
                {
                    return true;
                }
            }
            return false;
        }

        public void SortBoard()
        {
            tblScoreBoard.Sort(colScore, ListSortDirection.Descending);
        }

    }
}
