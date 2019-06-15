using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Model.Games.Dice;

namespace CommonLibrary.Implementation.Games.Dice.Combos
{
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
