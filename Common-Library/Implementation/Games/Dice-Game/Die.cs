using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Model;

namespace CommonLibrary.Implementation.Games.Dice
{
    public enum DieSide { ONE, TWO, THREE, FOUR, FIVE, SIX, JOKER }
    public class Die
    {
        public bool Selected { get; set; }
        public DieSide Side { get; set; }

        public Die(DieSide side, bool is_selected)
        {
            Side = side;
            Selected = is_selected;
        }
    }
}
