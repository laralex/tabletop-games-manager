
using System.Collections.Generic;

using CommonLibrary.Model.Games.Dice.Combos;

namespace CommonLibrary.Implementation.Games.Dice.Combos
{
    /// <summary>
    /// Flash Royale combo - 5 dice with same value ONE.
    /// Score = 350  
    /// </summary>
    public class FlashRoyale : ICombo
    {
        public ComboMaxResult GetMaxCombo(List<Die> dice, bool is_sorted)
        {
            if (dice == null)
            {
                return null;
            }
            List<Die> dice_copy = dice;

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
