
using System;
using System.Collections.Generic;

using CommonLibrary.Model.Games.Dice.Combos;

namespace CommonLibrary.Implementation.Games.Dice.Combos
{
    /// <summary>
    /// Flash combo - 5 dice with same value.
    /// Score = 40 * dice value
    /// e.g. flash 4, 4, 4, 4, 4 => Score=40*4  
    /// </summary>
    public class Flash : ICombo
    {
        public ComboMaxResult GetMaxCombo(List<Die> dice, bool is_sorted)
        {
            if (dice == null)
            {
                return null;
            }
            List<Die> dice_copy = dice;
            if (!is_sorted)
            {
                dice_copy = new List<Die>(dice);
                dice_copy.Sort((d1, d2) => { return (int)d1.Side - (int)d2.Side; });
            }

            byte[] found_combo_sides = new byte[6];
            ComboMaxResult result = new ComboMaxResult();
            result.Name = "Flash of ";
            for (int i = 0; i < dice_copy.Count; ++i)
            {
                Die die = dice_copy[i];
                if (die.Side == DieSide.JOKER || die.Side == DieSide.ONE)
                {
                    continue;
                }
                ++found_combo_sides[(int)die.Side];
            }


            DieSide best_side = DieSide.ONE;
            bool combo_exists = false;

            for (int i = 5; i > 0; --i)
            {
                if (found_combo_sides[i] >= 5)
                {
                    best_side = (DieSide)(i);
                    result.Score = (i + 1) * 40;
                    result.Name += Convert.ToString(i + 1);
                    combo_exists = true;
                    break;
                }
            }

            if (!combo_exists)
            {
                return null;
            }

            for (int i = 0, limit = 5; i < dice_copy.Count && limit > 0; ++i)
            {
                if (dice_copy[i].Side == best_side)
                {
                    --limit;
                    result.DiceInCombo.Add(dice_copy[i]);
                }
            }
            return result;
        }
    }
}
