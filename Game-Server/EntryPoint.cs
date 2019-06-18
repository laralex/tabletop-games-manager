using CommonLibrary.Implementation.Games;
using CommonLibrary.Implementation.Games.Dice;
using CommonLibrary.Implementation.ServerSide;
using CommonLibrary.Implementation.ServerSide.Authentication;
using CommonLibrary.Model.ServerSide;
using GameServer.Debug;
using GameServer.Games.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public class EntryPoint
    {
        /// <summary>
        /// Dice server now uses CLI arguments, 
        /// e.g. "DICE testServer 5 90 1000 5 0"
        /// Pass:
        /// 1) game_type = "DICE"
        /// 2) server_name = "testServer"
        /// 3) max_players_to_connect = 5
        /// 4) time_of_one_turn_in_sec = 90
        /// 5) score_goal = 1000
        /// 6) dice_number = 5
        /// 7) is_joker_allowed = 0 (only 0 supported)
        /// </summary>
        public static void Main(string[] args)
        {
            string GameType = args[0];
            string Name = args[1];
            int MaxPlayers = Convert.ToInt32(args[2]);
            int TurnTimeSecs = Convert.ToInt32(args[3]);
            int ScoreGoal = Convert.ToInt32(args[4]);
            int DiceNumber = Convert.ToInt32(args[5]);
            bool IsJokerAllowed = Convert.ToInt32(args[6]) > 0;

            GameOptions game_options = null;
           
            IGameServer server = null;
            switch (GameType) {
                case "DICE":
                    var d_game_options = new DiceGameOptions();
                    d_game_options.MaxPlayers = MaxPlayers;
                    d_game_options.TurnTimeSecs = TurnTimeSecs;
                    d_game_options.ScoreGoal = ScoreGoal;
                    d_game_options.DiceNumber = DiceNumber;
                    d_game_options.IsJokerAllowed = IsJokerAllowed;

                    game_options = d_game_options;

                    server = new DiceGameServer(d_game_options, Name);
                    break;
                default:
                    break;
            }
            if (server != null)
            {
                server.Initialize();
                GameServerConsole debug_console = new GameServerConsole(server);
                server.Start();
                server.Dispose();
            } 
        } 
        
    }
}



/*   Debug code:       
            DiceGameController game = new DiceGameController();
            var users = new List<UserSocket>();
            users.Add(new UserSocket() {
                User = new UserEntry("qwert", null),
                Socket = new System.Net.IPEndPoint(19827412, 50000)
            });
            users.Add(new UserSocket() {
                User = new UserEntry("dead", null),
                Socket = new System.Net.IPEndPoint(10827412, 60000)
            });
            users.Add(new UserSocket() {
                User = new UserEntry("best", null),
                Socket = new System.Net.IPEndPoint(29827412, 40000)
            });
            game.StartupGame(game_options, users);
            //game.StartFirstTurn();
 */
