
using System.Collections.Generic;

namespace CommonLibrary.Implementation.Games.Dice.Combos
{
    /// <summary>
    /// Represent result of applying combo (used in "Dice" game engine)
    /// Stores score, that combo may give,
    /// fancy name of combo (like "Flash Royale" or "Street of 5 to 6"),
    /// and comprised in combo dice  
    /// </summary>
    public class ComboMaxResult
    {
        public List<Die> DiceInCombo;
        public int Score;
        public string Name;

        public ComboMaxResult()
        {
            DiceInCombo = new List<Die>();
        }
    }
}
