using CommonLibrary.Implementation.Games;
using System;

namespace CommonLibrary.Implementation.Games.Dice
{
    [Serializable]
    public class DiceGameOptions : GameOptions
    {
        public int TurnTimeSecs { get; set; }
        public int ScoreGoal { get; set; }
        public int DiceNumber { get; set; }
        public bool IsJokerAllowed { get; set; }
    }
}