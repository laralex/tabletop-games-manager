using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Model;

namespace CommonLibrary.Implementation.DiceGame
{
    public enum DieSide { ONE, TWO, THREE, FOUR, FIVE, SIX, JOKER }
    public class DieModel
    {
        public int DieIndex { get; set; }
        public bool Selected { get; set; }
        public DieSide Side { get; set; }

        public DieModel(DieSide side, int index = 0, bool selected = false)
        {
            DieIndex = index;
            Selected = selected;
            Side = side;
        }

    }
}
