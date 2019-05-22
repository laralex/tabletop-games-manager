using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model
{
    public interface ITurnBasedGame : IGame
    {
        event EventHandler<TurnSwitchedEventArgs> TurnSwitched;
        event EventHandler<TurnSubmittedEventArgs> TurnSubmitted;
    }

    public class TurnSwitchedEventArgs : EventArgs
    {
        public IPlayer NewPlayer { get; }
        public TurnSwitchedEventArgs(IPlayer new_player)
        {
            NewPlayer = new_player;
        }
    }

    public class TurnSubmittedEventArgs : EventArgs
    {
        public IPlayer Player { get; }
        public TurnSubmittedEventArgs(IPlayer player)
        {
            Player = player;
        }
    }
}
