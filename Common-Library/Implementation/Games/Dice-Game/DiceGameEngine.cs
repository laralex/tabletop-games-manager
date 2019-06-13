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
    public class DiceGameEngine //: ITurnBasedGame
    {
        public bool IsTimeLimitedTurn { get; protected set; }
        public List<Die> SelectedDice
        {
            get => _dice?.Where((e) => e.Selected == true).ToList();
        }

        public List<Die> AllDice
        {
            get => _dice?.ToList();
        }

        public DiceGamePlayer CurrentPlayer {
            get
            {
                if (_players.Count == 0)
                {
                    return null;
                }
                return _players[_current_player_idx];
            }
        }

        public int CurrentPlayerTurnScore { get; set; }

        public DiceGameEngine()
        {
            _players = new List<DiceGamePlayer>();
            _combo_parser = new ComboParser();
        }
        public void SetPlayers(List<IPlayer> new_players, int new_current)
        {
            if (new_players == null)
            {
                _players = new List<DiceGamePlayer>();
                _current_player_idx = -1;
                return;
            }
            _players = new_players.ConvertAll((e) => e as DiceGamePlayer);
            _current_player_idx = new_current;
        }

        public void AddPlayer(IPlayer new_player, int order)
        {
            if (_players.Count == 0)
            {
                _players.Add(new_player as DiceGamePlayer);
                _current_player_idx = 0;
                return;
            }
            if (order <= _current_player_idx)
            {
                ++_current_player_idx;
            }
            _players.Insert(
                Math.Min(order, _players.Count), 
                new_player as DiceGamePlayer
            );
        }

        public void KickPlayer(IPlayer player)
        {
            if (_players.Count == 0)
            {
                return;
            }
            if (_players.Remove(player as DiceGamePlayer))
            {
                _current_player_idx = Math.Min(_players.Count, _current_player_idx - 1);
            }
        }

        public void CreateDice(int number_of_dice)
        {
            _dice = new Die[number_of_dice];
            for(int i = 0; i < number_of_dice; ++i)
            {
                _dice[i] = new Die(DieSide.ONE, false);        
            }
        }

        public void SwitchTurnToNextPlayer()
        {
            if (_players.Count == 0)
            {
                return;
            }
            ++ _current_player_idx;
            if (_current_player_idx >= _players.Count)
            {
                _current_player_idx = 0;
            }
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
            if (_dice == null || index >= _dice.Length)
            {
                throw new IndexOutOfRangeException();
            }
            _dice[index].Selected = value;
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
                _dice.ToList(),
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

        public AllCombosInDice CalculateGainOf(List<Die> selected)
        {
            return ComboParser.ParseDice(selected, is_sorted: false);
        }

        public AllCombosInDice CalculateGainOfSelected()
        {
            return CalculateGainOf(SelectedDice);
        }

        private List<DiceGamePlayer> _players;
        private int _current_player_idx;
        private Die[] _dice;
        private ComboParser _combo_parser;
    }


   

}
