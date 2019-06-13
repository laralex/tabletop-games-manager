﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.Games
{
    public interface ITurnBasedGame : IGame
    {
        event EventHandler<TurnSwitchedEventArgs> TurnSwitched;
        event EventHandler<TurnSubmittedEventArgs> TurnSubmitted;

        bool IsTimeLimitedTurn { get; }
        void SwitchTurn(IPlayer next);
    }

    public class TurnSwitchedEventArgs : EventArgs
    {
        public IPlayer OldPlayer { get; }
        public IPlayer NewPlayer { get; }

        public TurnSwitchedEventArgs(IPlayer old_player, IPlayer new_player)
        {
            OldPlayer = old_player;
            NewPlayer = new_player;
        }
    }

    public class TurnSubmittedEventArgs : EventArgs
    {
        public IPlayer Player { get; }
        public int NewScore { get; }
        public TurnSubmittedEventArgs(IPlayer player, int new_score)
        {
            Player = player;
            NewScore = new_score;
        }
    }
}
