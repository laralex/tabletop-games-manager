using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Model.Games.Dice;
using CommonLibrary.Implementation.Games.Dice.Combos;
using CommonLibrary.Implementation.Games.Dice;

namespace CommonLibrary.Model.Games.Dice.Combos
{
    // In "Dice" game, players select and discard dice in exchange to score. 
    // Different combinations of dice give different scores
    // To provide better flexibility, each combo-type is not hardcoded,
    // but it is separate class, which implement ICombo
    public interface ICombo
    {
        ComboMaxResult GetMaxCombo(List<Die> dice, bool is_sorted);
    }
}
