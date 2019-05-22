using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameClient.GUI.DiceGame
{
    public partial class ScoreBoard : UserControl
    {
        //public BindingSource Data { get; }
        public string SelectedPlayer
        {
            get => (string)_selected_player?.Cells[1].Value;
            set
            {
                _selected_player = SeekPlayer(value);
                if (_selected_player != null)
                {
                    tblScoreBoard.ClearSelection();
                    _selected_player.Selected = true;
                }
                
            }
        }
        public ScoreBoard()
        {
            InitializeComponent();
            tblScoreBoard.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 192, 192);
            //tblScoreBoard..BackColor = Color.FromArgb(192, 192, 192);
            //tblScoreBoard.DataSource = dataSource;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            AddPlayer("Laralex");
            AddPlayer("ALex", 1);
            AddPlayer("ALex", 1000);
            AddPlayer("fsdex", 3000);
            AddPlayer("4asex", 1000);
            AddPlayer("ALex", 1);
            AddPlayer("AasfLex", 1000);
            AddPlayer("sadex", 2000);
            AddPlayer("4sex", 1000);
            SelectedPlayer = "sadex";
            SelectedPlayer = "Laralex";
            SelectedPlayer = "sadex";
        }

        public void AddPlayer(string username, uint score = 0)
        {
            if (SeekPlayer(username) == null)
            {
                tblScoreBoard.Rows.Add(0, username, score);
                SortBoard();
                if (_selected_player != null)
                {
                    tblScoreBoard.FirstDisplayedScrollingRowIndex = _selected_player.Index;
                }
            }
        }


        public void RemovePlayer(string username)
        {
            var player = SeekPlayer(username);
            tblScoreBoard.Rows.Remove(player);
        }

        public bool HasPlayer(string username)
        {
            return SeekPlayer(username) != null;
        }

        public void SortBoard()
        {
            tblScoreBoard.Sort(colScore, ListSortDirection.Descending);
            int index = 1;
            foreach (DataGridViewRow row in tblScoreBoard.Rows)
            {
                row.Cells[0].Value = index++;
            }
        }

        public bool UpdateOrAddPlayer(string username, uint score)
        {
            DataGridViewRow player = SeekPlayer(username);
            if (player != null)
            {
                player.Cells[2].Value = score;
                SortBoard();
            }
            else
            {
                AddPlayer(username, score);
            }
            return false;
        }

        public uint ScoreOf(string username)
        {
            var player = SeekPlayer(username);
            if (player != null)
            {
                return (uint)player.Cells[2].Value;
            }
            return 0;
        }

        private DataGridViewRow SeekPlayer(string username)
        {
            foreach (DataGridViewRow row in tblScoreBoard.Rows)
            {
                if (row.Cells[1].Value.Equals(username))
                {
                    return row;
                }
            }
            return null;
        }

        private void OnSelection(object sender, EventArgs e)
        {
            if (_selected_player != null)
            {
                _selected_player.Selected = true;
                tblScoreBoard.FirstDisplayedScrollingRowIndex = _selected_player.Index;
            }
        }
        private struct ScoreBoardEntry
        {
            string Username { get; }
            uint Score { get; set; }
            public ScoreBoardEntry(string username, uint score = 0)
            {
                Username = username;
                Score = score;
            }
        }

        private DataGridViewRow _selected_player;
    }
}
