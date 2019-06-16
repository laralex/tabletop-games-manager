using System;
using System.Collections.Generic;
using System.Linq;

using CommonLibrary.Implementation.Games.Dice.Combos;
using CommonLibrary.Model.Games;

namespace CommonLibrary.Implementation.Games.Dice
{
    /// <summary>
    /// Holds dice and active players
    /// Has functions for controlling them, 
    /// but it doesn't implement actual game logic
    /// </summary>
    public class DiceGameEngine //: ITurnBasedGame
    {
        public bool IsTimeLimitedTurn { get; protected set; }
        public Die[] Dice { get; private set; }
        public List<Die> SelectedDice
        {
            get => Dice?.Where((e) => e.Selected == true).ToList();
        }

        public List<Die> AllDice
        {
            get => Dice?.ToList();
        }

        public DiceGamePlayer CurrentPlayer {
            get
            {
                if (_players.Count == 0)
                {
                    return null;
                }
                return _players[_current_player];
            }
        }

        public int CurrentPlayerTurnScore { get; set; }

        public DiceGameEngine()
        {
            _players = new List<DiceGamePlayer>();
            _combo_parser = new ComboParser();
        }
        public void SetPlayers(List<IPlayer> new_players, int new_current_idx)
        {
            if (new_players == null)
            {
                _players = new List<DiceGamePlayer>();
                _current_player = -1;
                return;
            }

            _players = new_players.ConvertAll((e) => e as DiceGamePlayer);
            if (new_current_idx >= _players.Count || new_current_idx < 0)
            {
                throw new IndexOutOfRangeException("New current player index is out of boundaries");
            }
            _current_player = new_current_idx;
        }

        public void AddPlayer(IPlayer new_player, int order_idx)
        {
            if (_players.Count == 0)
            {
                _players.Add(new_player as DiceGamePlayer);
                _current_player = 0;
                return;
            }

            IPlayer current = CurrentPlayer;

            _players.Insert(
                Math.Min(order_idx, _players.Count),
                new_player as DiceGamePlayer
            );

            SwitchTurnTo(current);
        }

        public bool KickPlayer(IPlayer player)
        {
            if (_players.Count == 0)
            {
                throw new InvalidOperationException("No players in the list");
            }
            bool is_current = CurrentPlayer == player;

            if (_players.Remove(player as DiceGamePlayer))
            {
                if (is_current)
                {
                    SwitchTurnToNextPlayer();
                } else
                {
                    SwitchTurnTo(player);
                }
                return true;
            }
            return false;
        }

        public void CreateDice(int number_of_dice)
        {
            Dice = new Die[number_of_dice];
            for (int i = 0; i < number_of_dice; ++i)
            {
                Dice[i] = new Die(DieSide.ONE, false);
            }
        }

        public void SwitchTurnToNextPlayer()
        {
            if (_players.Count == 0)
            {
                return;
            }
            ++_current_player;
            if (_current_player >= _players.Count)
            {
                _current_player = 0;
            }
        }

        public void SwitchTurnTo(IPlayer player)
        {
            _current_player = _players.IndexOf((DiceGamePlayer)player);
        }

        public void Reroll(List<Die> dice_to_reroll)
        {
            var rnd = new Random();
            int min_side = 0, max_side = 5;
            dice_to_reroll.ForEach(
                (e) => e.Side = (DieSide)rnd.Next(min_side, max_side + 1)
            );
        }

        public void SetDieSelection(int index, bool value)
        {
            if (Dice == null || index >= Dice.Length)
            {
                throw new IndexOutOfRangeException();
            }
            Dice[index].Selected = value;
        }

        public void DeselectAll()
        {
            var to_deselect = SelectedDice;
            foreach (var e in to_deselect)
            {
                e.Selected = false;
            }
        }

        public int CurrentDiceMaxScoreGain()
        {
            var result = ComboParser.ParseDice(
                Dice.ToList(),
                is_sorted: false
            );

            return result.TotalScore;
        }

        public bool IsFailure(List<Die> selected)
        {
            var parsed_combos = CalculateGainOf(selected);
            return parsed_combos.TotalScore == 0;
        }

        public bool IsCurrentDiceFailure()
        {
            return IsFailure(AllDice);
        }

        public AllCombosInDice CalculateGainOf(List<Die> dice)
        {
            return ComboParser.ParseDice(dice, is_sorted: false);
        }

        public AllCombosInDice CalculateGainOfSelected()
        {
            return CalculateGainOf(SelectedDice);
        }

        private List<DiceGamePlayer> _players;
        private int _current_player;
        private ComboParser _combo_parser;
    }


   

}
