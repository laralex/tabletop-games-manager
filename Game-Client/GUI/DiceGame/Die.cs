using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media;
using System.Resources;
using System.Reflection;
using CommonLibrary.Model.DiceGame;
using CommonLibrary.Implementation.DiceGame;

namespace GameClient.GUI.DiceGame
{
    
    
    public partial class Die : UserControl, ICloneable
    {
        public DieSide Side {
            get => _value;
            set
            {
                _value = value;
                if ((int)value >= Images.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                UpdateImage();
            }
        }

        public bool Selected
        {
            get => _is_selected;
            set
            {
                _is_selected = value;
                _current_image_arr = value ? GoldenImages : Images;
                UpdateImage();
            }
        }

        new public bool Enabled
        {
            get => _is_enabled;
            set
            {
                _is_enabled = value;
            }
        }
        public static Image[] Images { get; }
        public static Image[] GoldenImages { get; }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        public Die()
        {
            InitializeComponent();
            this._value = DieSide.FIVE;
            this._is_selected = false;
            _current_image_arr = Images;
            UpdateImage();
        }

        public void ToggleSelected()
        {
            Selected = !_is_selected;
        }

        static Die()
        {
            Images = new Image[] {
                global::GameClient.Properties.Resources.one,
                global::GameClient.Properties.Resources.two,
                global::GameClient.Properties.Resources.three,
                global::GameClient.Properties.Resources.four,
                global::GameClient.Properties.Resources.five,
                global::GameClient.Properties.Resources.six,
                global::GameClient.Properties.Resources.joker
            };

            GoldenImages = new Image[]
            {
                global::GameClient.Properties.Resources.one_g,
                global::GameClient.Properties.Resources.two_g,
                global::GameClient.Properties.Resources.three_g,
                global::GameClient.Properties.Resources.four_g,
                global::GameClient.Properties.Resources.five_g,
                global::GameClient.Properties.Resources.six_g,
                global::GameClient.Properties.Resources.joker_g
            };
        }
        
        private DieSide _value;
        private bool _is_enabled;
        private bool _is_selected;
        private Image[] _current_image_arr; 

        private void UpdateImage()
        {
            imageBox.Image = _current_image_arr[(int)this.Side];
            imageBox.Update();
        }

        public object Clone()
        {
            PropertyInfo[] controlProperties = typeof(Die).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            Die instance = Activator.CreateInstance<Die>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(this, null), null);
                }
            }

            return instance;
        }
    }
}
