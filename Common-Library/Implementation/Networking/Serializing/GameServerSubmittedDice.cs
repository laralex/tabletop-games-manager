using CommonLibrary.Implementation.Games.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    [Serializable]
    public class GameServerSubmittedDice
    {
        public GameServerSubmittedDice(List<Die> dice, int scoreGain, int totalScore)
        {
            Dice = dice;
            ScoreGain = scoreGain;
            TotalScore = totalScore;
        }

        public List<Die> Dice { get; set; }
        public int ScoreGain { get; set; }
        public int TotalScore { get; set; }
    }
}
