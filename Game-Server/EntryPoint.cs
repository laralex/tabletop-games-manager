using CommonLibrary.Implementation.Games;
using CommonLibrary.Implementation.Games.Dice;
using CommonLibrary.Model.ServerSide;
using GameServer.Debug;
using GameServer.Games.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string GameType = args[0];
            string Name = args[1];
            int MaxPlayers = Convert.ToInt32(args[2]);
            int TurnTimeSecs = Convert.ToInt32(args[3]);
            int ScoreGoal = Convert.ToInt32(args[4]);
            int DiceNumber = Convert.ToInt32(args[5]);
            bool IsJokerAllowed = Convert.ToInt32(args[6]) > 0;

            GameOptions game_options;
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
