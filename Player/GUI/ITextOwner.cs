using System;
using System.Drawing;

namespace Player.GUI
{
    /// <summary>
    /// This object contains drawable text, which appearence must be overridden
    /// </summary>
    interface ITextOwner
    {
        /// <summary>
        /// Overrides font of all text
        /// </summary>
        /// <param name="font">New font</param>
        void SetFont(Font font);
    }
}
