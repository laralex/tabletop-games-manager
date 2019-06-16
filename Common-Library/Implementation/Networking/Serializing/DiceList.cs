using CommonLibrary.Implementation.Games.Dice;
using System;
using System.Collections.Generic;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    /// <summary>
    /// Game Engine rerolls some dice and server sends new values of dice
    /// </summary>
    [Serializable]
    public class DiceList
    {
        public List<Die> Dice;
        public List<int> ChangedIndices;

        public DiceList(List<Die> dice, List<int> indices)
        {
            Dice = dice;
            ChangedIndices = indices;
        }
    }
}
