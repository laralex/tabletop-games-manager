using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Model.Games.Dice;

namespace CommonLibrary.Implementation.Games.Dice.Combos
{
    public class Combo
    {
        public virtual ComboMaxResult GetMaxCombo(List<Die> dice, bool is_sorted)
        {
            return null;
        }
    }
}
