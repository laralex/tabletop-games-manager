using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CommonLibrary.Implementation.ServerSide;

namespace GameClient.GUI.ServerManager
{
    public partial class ServersListDemo : UserControl
    {
        public ServersListDemo()
        {
            InitializeComponent();
        }

        public event EventHandler<JoinEventArgs> JoinClick;
        public event EventHandler RefreshClick;
        public event EventHandler CreateServerClick;

        private void OnJoin(object sender, EventArgs e)
        {
            // TODO: TRY connect to server and prepare client game (do in separate thread, connection timeout, server messages)
            // TODO: give signal to swap tab
            var selected_rows = tblServersList.SelectedRows;
            if (selected_rows != null && selected_rows.Count > 0)
            {
                JoinClick?.Invoke(this, new JoinEventArgs(selected_rows[0].Index));
            }
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            // TODO: clear table (? or update it for slightly better performance)
            // TODO: load servers from db
            // TODO: fill table
            RefreshClick?.Invoke(this, EventArgs.Empty);
            AppendServer(new GameServerEntry() { Name = "Пустышка сервер 1", MaxPlayers = 10 });
            AppendServer(new GameServerEntry() { Name = "Пустышка сервер 2", MaxPlayers = 40 });
            AppendServer(new GameServerEntry() { Name = "Пустышка сервер 3", MaxPlayers = 100 });
        }

        // NOTE: float, decimal, ????
        private string ToPingString(int ping_ms)
        {
            return ping_ms + " ms";
        }

        private string ToPlayersString(int players, int max_players)
        {
            return players + "/" + max_players;
        }

        // NOTE: Accept some internal representation, convert to appropriate string
        private string ToGameStatusString()
        {
            return "Alive";
        }

        private void AppendServer(GameServerEntry entry)
        {
            /* DEBUG
            var r = new Random();
            tblServersList.Rows.Add(
                "Server name",
                ToPlayersString(r.Next(1,10), r.Next(1,50)),
                ToGameStatusString(),
                ToPingString(r.Next(1, 100))
            );
            */
            tblServersList.Rows.Add(
                entry.Name,
                "? / " + entry.MaxPlayers
            );
        }

        public void SetServersList(List<GameServerEntry> servers)
        {
            tblServersList.Rows.Clear();
            servers.ForEach((e) => AppendServer(e));
        }

        private int PingCompare(string lhs, string rhs)
        {
            int lhs_ping = Convert.ToInt32(_retrieve_number.Match(lhs).Value);
            int rhs_ping = Convert.ToInt32(_retrieve_number.Match(rhs).Value);

            return lhs_ping - rhs_ping;   
        }

        private int PlayersCompare(string lhs, string rhs)
        {
            int lhs_players = Convert.ToInt32(_retrieve_number.Match(lhs).Value);
            int rhs_players = Convert.ToInt32(_retrieve_number.Match(rhs).Value);

            return lhs_players - rhs_players;
        }

        private int GameStatusCompare(string lhs, string rhs)
        {
            // FIXME: not literal string, but enums or some codes
            bool is_lhs_waiting = lhs != "Playing";
            bool is_rhs_waiting = rhs != "Playing";

            return is_lhs_waiting && is_rhs_waiting ? 0 : is_lhs_waiting ? 1 : -1;
        }

        // TODO: stable sort
        private void OnSortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            string lhs = e.CellValue1.ToString();
            string rhs = e.CellValue2.ToString();

            switch (e.Column.Name)
            {
                case "colPing":
                    e.SortResult = PingCompare(lhs, rhs);
                    break;
                case "colGameStatus":
                    e.SortResult = GameStatusCompare(lhs, rhs);
                    break;
                case "colPlayers":
                    e.SortResult = PlayersCompare(lhs, rhs);
                    break;
                default:
                    e.Handled = false;
                    return;
            }
            e.Handled = true;
        }

        private void OnNewServer(object sender, EventArgs e)
        {
            // TODO: wait data from dialog
            new ServerCreator.ServerCreationForm().ShowDialog();
            // TODO: add in database
            // TODO: add server in list
            // TODO: select new server
        }

        private Regex _retrieve_number = new Regex(@"\d+");


    }

}
