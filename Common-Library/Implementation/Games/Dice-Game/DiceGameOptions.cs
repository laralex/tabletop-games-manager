namespace CommonLibrary.Implementation.Games.Dice
{
    public class DiceGameOptions
    {
        public int TurnTimeSecs { get; set; }
        public int ScoreGoal { get; set; }
        public int DiceNumber { get; set; }
        public bool IsJokerAllowed { get; set; }
    }
}