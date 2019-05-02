using System;
using System.Drawing;

namespace Player.GUI
{
    // This object contains drawable text, which appearence must be overridden
    interface ITextOwner
    {
        // Overrides font of all text
        void SetFont(Font font);
    }
}
