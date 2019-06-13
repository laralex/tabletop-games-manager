using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Games.Dice.Combos
{
    public class Set : Combo
    {

        public override ComboMaxResult GetMaxCombo(List<Die> dice, bool is_sorted)
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
            result.Name = "Set of ";
            for (int i = 0; i < dice_copy.Count; ++i)
            {
                Die die = dice_copy[i];
                if (die.Side == DieSide.JOKER)
                {
                    continue;
                }
                ++found_combo_sides[(int)die.Side];
            }


            DieSide best_side = DieSide.ONE;
            bool combo_exists = false;
            if (found_combo_sides[0] >= 3)
            {
                result.Score = 100;
                result.Name += "1";
                best_side = DieSide.ONE;
                combo_exists = true;
            }
            else
            {
                for (int i = 5; i > 0; --i)
                {
                    if (found_combo_sides[i] >= 3)
                    {
                        best_side = (DieSide)(i + 1);
                        result.Score = (i + 1) * 10;
                        result.Name += Convert.ToString(i + 1);
                        combo_exists = true;
                        break;
                    }
                }
            }

            if (!combo_exists)
            {
                return null;
            }

            for (int i = 0, limit = 3; i < dice_copy.Count && limit > 0; ++i)
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
