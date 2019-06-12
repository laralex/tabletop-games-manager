using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Implementation.Games.Dice;
using CommonLibrary.Implementation.Games.Dice.Combos;

using CommonLibrary.Model.Games;
using CommonLibrary.Model.Games.Dice;

namespace CommonLibrary.Implementation.Games.Dice
{
    public class DiceGame : ITurnBasedGame
    {
        public bool IsTimeLimitedTurn { get; protected set; }

        public event EventHandler<TurnSwitchedEventArgs> TurnSwitched;
        public event EventHandler<TurnSubmittedEventArgs> TurnSubmitted;
        public event EventHandler<GameStartedEventArgs> GameStarted;
        public event EventHandler<GameEndedEventArgs> GameEnded;
        public event EventHandler<PlayerStateEventArgs> PlayerJoined;
        public event EventHandler<PlayerStateEventArgs> PlayerLeaved;
        public event EventHandler<PlayerStateEventArgs> SpectatorJoined;
        public event EventHandler<PlayerStateEventArgs> SpectatorLeaved;
        public event EventHandler<DieSelectChangedEventArgs> DieSelectChanged;
        public event EventHandler<DiceSubmittedEventArgs> DiceSubmitted;
        public event EventHandler<RerollEventArgs> Reroll;

        public void AddPlayer(IPlayer new_player)
        {
            throw new NotImplementedException();
        }

        public void KickPlayer(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public void ShutdownGame()
        {
            throw new NotImplementedException();
        }

        public void StartupGame(GameOptions options)
        {
            throw new NotImplementedException();
        }

        public void SwtichTurn(IPlayer next)
        {
            throw new NotImplementedException();
        }
    }


   

}
