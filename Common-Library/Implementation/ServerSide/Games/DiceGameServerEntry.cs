
namespace CommonLibrary.Implementation.ServerSide
{

    // ! Unused now

    /// <summary>
    /// Registration data of Dice Game Server 
    /// </summary>
    public class DiceGameServerEntry : GameServerEntry
    {
        public int? TurnTimeSec { get; set; }
        public int ScoreGoal { get; set; }
        public int DiceNumber { get; set; }
        public bool IsJokerAllowed { get; set; }
    }
}
