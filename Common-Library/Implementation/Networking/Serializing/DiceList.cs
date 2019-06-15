using CommonLibrary.Implementation.Games.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
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
