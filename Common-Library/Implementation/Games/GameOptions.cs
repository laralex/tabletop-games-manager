using System;
namespace CommonLibrary.Implementation.Games
{
    /// <summary>
    /// Common options of some game server
    /// </summary>
    [Serializable]
    public class GameOptions
    {
        public int MaxPlayers { get; set; }
    }
}
