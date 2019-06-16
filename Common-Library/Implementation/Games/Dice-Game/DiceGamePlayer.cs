using System;
using CommonLibrary.Model.Games;

namespace CommonLibrary.Implementation.Games.Dice
{
    /// <summary>
    /// Player of game "Dice" - has name and current score
    /// </summary>
    [Serializable]
    public class DiceGamePlayer : IPlayer
    {
        public string Name { get; private set; }
        public int Score {
            get => _score;
            set { _score = Math.Max(value, 0); }
        }
        public DiceGamePlayer(string name, int init_score = 0)
        {
            Name = name;
            Score = init_score;
        }

        public int AddScore(int points)
        {
            return Score += points;
        }

        public int SubtractScore(int points)
        {
            return Math.Max(Score -= points, 0);
        }

        private int _score;
    }

}
