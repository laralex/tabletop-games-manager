using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.Games
{
    /// <summary>
    /// Minimal representation for a player (name)
    /// </summary>
    public interface IPlayer
    {
        string Name { get; }
        // int Score { get; }
    }
}
