using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Implementation.Games;

namespace CommonLibrary.Model.Games
{
    public interface IGame
    {
        event EventHandler<GameStartedEventArgs> GameStarted;
        event EventHandler<GameEndedEventArgs> GameEnded;
        event EventHandler<PlayerStateEventArgs> PlayerJoined;
        event EventHandler<PlayerStateEventArgs> PlayerLeaved;
        event EventHandler<PlayerStateEventArgs> SpectatorJoined;
        event EventHandler<PlayerStateEventArgs> SpectatorLeaved;
        //event EventHandler<ServerClosedEventArgs> ServerClosed;

        void StartupGame(GameOptions options);
        void ShutdownGame();
        void AddPlayer(IPlayer new_player);
        void KickPlayer(IPlayer player);
    }

    public class GameStartedEventArgs : EventArgs
    {
        public IPlayer[] Players { get; protected set; }
        public GameStartedEventArgs(IPlayer[] players)
        {
            Players = players;
        }
    }

    public class GameEndedEventArgs : EventArgs
    {
        public IPlayer Winner { get; }
        public GameEndedEventArgs(IPlayer winner)
        {
            Winner = winner;
        }
    }

    public class PlayerStateEventArgs : EventArgs
    {
        public IPlayer Player { get; }
        public PlayerStateEventArgs(IPlayer player)
        {
            Player = player;
        }
    }
}
