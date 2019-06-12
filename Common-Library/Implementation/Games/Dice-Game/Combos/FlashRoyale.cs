using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Model.Games.Dice;

namespace CommonLibrary.Implementation.Games.Dice.Combos
{
    public class FlashRoyale : Combo
    {
        public override ComboMaxResult GetMaxCombo(List<IDie> dice, bool is_sorted)
        {
            if (dice == null)
            {
                return null;
            }
            List<IDie> dice_copy = dice;

            ComboMaxResult result = new ComboMaxResult();
            result.Name = "Flash Royale";
            result.Score = 350;

            int limit = 5;   
            for (int i = 0; i < dice_copy.Count && limit > 0; ++i)
            {
                if (dice_copy[i].Side == DieSide.ONE)
                {
                    --limit;
                    result.DiceInCombo.Add(dice_copy[i]);
                }
            }
            if (limit == 0)
            {
                return result;
            }
            return null;
        }
    }
}
