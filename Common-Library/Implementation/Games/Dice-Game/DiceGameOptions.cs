using CommonLibrary.Implementation.Games;

namespace CommonLibrary.Implementation.Games.Dice
{
    public class DiceGameOptions : GameOptions
    {
        public int TurnTimeSecs { get; set; }
        public int ScoreGoal { get; set; }
        public int DiceNumber { get; set; }
        public bool IsJokerAllowed { get; set; }
    }
}