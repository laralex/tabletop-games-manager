using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model
{
    public interface IGame
    {
        event EventHandler<GameStartedEventArgs> GameStarted;
        event EventHandler<GameEndedEventArgs> GameEnded;
        event EventHandler<PlayerStateEventArgs> PlayerJoined;
        event EventHandler<PlayerStateEventArgs> PlayerLeaved;
        //event EventHandler<SpectatorStateEventArgs> SpectatorJoined;
        //event EventHandler<SpectatorStateEventArgs> SpectatorLeaved;
        //event EventHandler<ServerClosedEventArgs> ServerClosed;
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
