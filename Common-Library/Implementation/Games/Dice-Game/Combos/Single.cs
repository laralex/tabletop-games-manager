
using System.Collections.Generic;

using CommonLibrary.Model.Games.Dice.Combos;

namespace CommonLibrary.Implementation.Games.Dice.Combos
{
    /// <summary>
    /// Single combo - single 1 gives 10 score
    /// single 5 gives 5 score
    /// </summary>
    public class Single : ICombo
    {
        public ComboMaxResult GetMaxCombo(List<Die> dice, bool is_sorted)
        {
            List<Die> dice_copy = dice;
            byte[] found_combo_sides = new byte[6];
            ComboMaxResult result = new ComboMaxResult();
            for (int i = 0; i < dice_copy.Count; ++i)
            {
                Die die = dice_copy[i];
                if (die.Side == DieSide.JOKER)
                {
                    continue;
                }
                ++found_combo_sides[(int)die.Side];
            }

            int search_count = 1;
            DieSide search_for = DieSide.ONE;
            bool combo_exists = true;
            if (found_combo_sides[0] >= 2)
            {
                result.Score = 20;
                result.Name = "1+1";
                search_count = 2;
            }
            else if (found_combo_sides[0] == 1)
            {
                result.Score = 10;
                result.Name = "1";
            }
            else
            {
                search_for = DieSide.FIVE;
                if (found_combo_sides[4] >= 2)
                {
                    result.Score = 10;
                    result.Name = "5+5";
                    search_count = 2;
                }
                else if (found_combo_sides[4] == 1)
                {
                    result.Score = 5;
                    result.Name = "5";
                }
                else
                {
                    combo_exists = false;
                }
            }
            if (!combo_exists)
            {
                return null;
            }
            for (int i = 0; i < dice_copy.Count && search_count > 0; ++i)
            {
                Die die = dice_copy[i];
                if (die.Side == search_for)
                {
                    result.DiceInCombo.Add(die);
                    --search_count;
                }
            }
            return result;
        }
    }
}
