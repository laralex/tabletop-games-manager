using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Implementation.DiceGame;

namespace CommonLibrary.Model.DiceGame
{
    public interface IDiceGame : ITurnBasedGame
    {
        event EventHandler<DieSelectChangedEventArgs> DieSelectChanged;
        event EventHandler<ComboSubmittedEventArgs> ComboSubmitted;
        event EventHandler<RerollEventArgs> Reroll;
        
        void StartGame(DiceGameOptions options);
    }


    public class DiceGameTurnSubmittedEventArgs : TurnSubmittedEventArgs
    {
        public int ScoreGained { get; }
        public int TotalScore { get; }
        public bool IsFailure { get; }
        public DiceGameTurnSubmittedEventArgs(IPlayer player, int total_score, int score_gain = 0) : base(player)
        {
            ScoreGained = Math.Max(0, score_gain);
            TotalScore = total_score;
            IsFailure = (score_gain > 0);
        }
    }

    public class DieSelectChangedEventArgs : EventArgs
    {
        public DieModel ChangedDie { get; }
        public DieSelectChangedEventArgs (DieModel die)
        {
            ChangedDie = die;
        }
    }

    public class ComboSubmittedEventArgs : EventArgs
    {
        public Combo Combo { get; }
        public ComboSubmittedEventArgs(Combo combo)
        {
            Combo = combo;
        }
    }

    public class DiceGameStartedEventArgs : GameStartedEventArgs
    {
        public DiceGameOptions GameOptions { get; }
        public DiceGameStartedEventArgs(DiceGameOptions options, IPlayer[] players) : base(players)
        {
            GameOptions = options;
        }
    }

    public class ServerClosedEventArgs : EventArgs
    {
        public enum ServerCloseType {
            InternalError,
            ClosedByHost,
            DisconnectedFromHost
        }

        public ServerCloseType WhyClosedType;
        public string WhyClosedMessage;
        public ServerClosedEventArgs(ServerCloseType why_closed, string why_closed_msg)
        {
            WhyClosedType = why_closed;
            WhyClosedMessage = why_closed_msg;
        }
    }    

    public class RerollEventArgs : EventArgs
    {
        public DieModel[] NewDice { get; }
        public RerollEventArgs(DieModel[] new_dice)
        {
            NewDice = new_dice; 
        }
    }
}
