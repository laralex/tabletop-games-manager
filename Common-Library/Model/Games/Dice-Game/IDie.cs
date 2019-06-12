using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommonLibrary.Model;

namespace CommonLibrary.Model.Games.Dice
{
    public enum DieSide { ONE, TWO, THREE, FOUR, FIVE, SIX, JOKER }
    public interface IDie
    {
        bool Selected { get; set; }
        DieSide Side { get; set; }

    }
}
