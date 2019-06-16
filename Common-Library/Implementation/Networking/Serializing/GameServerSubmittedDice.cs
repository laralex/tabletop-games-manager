using CommonLibrary.Implementation.Games.Dice;
using System;
using System.Collections.Generic;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    /// <summary>
    /// When players submit combo, they gain score.
    /// Server notifies other players about changes in scores
    /// </summary>
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
