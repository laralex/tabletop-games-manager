using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Player.GUI.DiceGame
{
    public enum DieValue { ONE, TWO, THREE, FOUR, FIVE, SIX, JOKER}
    public class DieControl : Button
    {
        public bool IsSelected { get; private set; }
        public Brush Background { get; private set; } = Brushes.DarkGreen;
        public Brush HoverBackground { get; private set; } = Brushes.DarkGreen;
        public Brush SelectBackground { get; private set; } = Brushes.DarkGreen;
        public Brush HoverSelectBackground { get; private set; } = Brushes.DarkGreen;
        public Color BorderColor { get; private set; }
        public DieValue Value
        {
            get => _value;
            set
            {
                _value = value;
                switch (value)
                {
                    case DieValue.THREE:
                        break;
                }
            }
        }
     
        public DieControl()
        {
            
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Call the OnPaint method of the base class.  
            base.OnPaint(pevent);
            // Call methods of the System.Drawing.Graphics object.  
            pevent.Graphics.DrawString("123", Font, new SolidBrush(ForeColor), ClientRectangle);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (IsSelected)
            {
                Background = HoverSelectBackground;
            }
            else
            {
                Background = SelectBackground;
            }
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (IsSelected)
            {
                Background = HoverBackground;
            }
            else
            {
                Background = _default_background;
            }
            base.OnMouseLeave(e);
        }

        protected override void OnClick(EventArgs e)
        {
            IsSelected = !IsSelected;
            OnMouseEnter(e);
            base.OnClick(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        private DieValue _value;
        private object _displayed_shape;
        private Brush _default_background = Brushes.Gray;
    }
}
