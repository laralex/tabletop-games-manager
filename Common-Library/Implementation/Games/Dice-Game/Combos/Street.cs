
using System.Collections.Generic;

using CommonLibrary.Model.Games.Dice.Combos;

namespace CommonLibrary.Implementation.Games.Dice.Combos
{
    /// <summary>
    /// Street combo - 5 dice in order.
    /// e.g. 1,2,3,4,5 => Score=100,
    /// e.g. 2,3,4,5,6 => Score=200
    /// </summary>
    public class Street : ICombo
    {
        public ComboMaxResult GetMaxCombo(List<Die> dice, bool is_sorted)
        {
            List<Die> dice_copy = dice;

            byte[] found_combo_sides = new byte[6];
            ComboMaxResult result = new ComboMaxResult();
            result.Name = "Five-Street up to ";
            for (int i = 0; i < dice_copy.Count; ++i)
            {
                Die die = dice_copy[i];
                if (die.Side == DieSide.JOKER)
                {
                    continue;
                }
                ++found_combo_sides[(int)die.Side];
            }

            bool is_up_to_5 = false;
            for (int i = 5; i >= 1; --i)
            {
                if (found_combo_sides[i] == 0)
                {
                    for (int j = 4; j >= 0; --j)
                    {
                        if (found_combo_sides[j] == 0)
                        {
                            return null;
                        }
                    }
                    result.Name += "5";
                    result.Score = 100;
                    is_up_to_5 = true;
                }
            }
            result.Name += "6";
            result.Score = 200;
            int cur_side = 0, limit = 4;
            if (is_up_to_5)
            {
                cur_side = 1;
                limit = 5;
            }

            for (int i = cur_side; i <= limit; ++i)
            {
                result.DiceInCombo.Add(
                    dice_copy.Find((e) => e.Side == (DieSide)i)
                );
            }

            return result;
        }
    }
}
