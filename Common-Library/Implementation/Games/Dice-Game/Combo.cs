using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.DiceGame
{
    public abstract class Combo
    {
        public static string Name { get; }
        public int Score { get; }

        public abstract bool IsCombo(DieModel[] dice);
    }
}
