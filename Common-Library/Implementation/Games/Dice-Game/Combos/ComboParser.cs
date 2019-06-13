using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Model.Games.Dice;

namespace CommonLibrary.Implementation.Games.Dice.Combos
{
    public class ComboParser
    {
        static ComboParser()
        {
            _combos = new Combo[] {
                new Combos.Single(),
                new Combos.Street(),
                new Combos.Set(),
                new Combos.Quad(),
                new Combos.Flash(),
                new Combos.FlashRoyale()
            };
        }
        public static AllCombosInDice ParseDice(List<Die> dice, bool is_sorted){
            if (dice == null)
            {
                return null;
            }
            List<Die> dice_copy = new List<Die>(dice);
            if (!is_sorted)
            {
                dice_copy = new List<Die>(dice);
                dice_copy.Sort((d1, d2) => { return (int)d1.Side - (int)d2.Side; });
            }

            List<ComboMaxResult> accum = new List<ComboMaxResult>();
            int accum_score = 0;
            ComboMaxResult cur_result, best_result = null;

            while (best_result != null)
            {
                int max_score = int.MinValue;
                foreach (Combo combo_type in _combos)
                {
                    cur_result = combo_type.GetMaxCombo(dice_copy, true);
                    if (cur_result.Score > max_score)
                    {
                        max_score = cur_result.Score;
                        best_result = cur_result;
                    }
                }
                if (best_result != null)
                {
                    accum_score += max_score;
                    accum.Add(best_result);
                    dice_copy.RemoveAll((e) => best_result.DiceInCombo.Contains(e));
                }
                
            }
            if (accum_score == 0)
            {
                return null;
            }
            return new AllCombosInDice(accum, accum_score);     
        }

        private static Combo[] _combos; 
    }

    public class AllCombosInDice
    {
        public int TotalScore { get; }
        public List<ComboMaxResult> Combos { get; }
        public AllCombosInDice(List<ComboMaxResult> combos, int total_score)
        {
            Combos = combos;
            TotalScore = total_score;
        }
    }
}
