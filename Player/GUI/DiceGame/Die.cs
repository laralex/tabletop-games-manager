using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WindowsLib;
using System.Windows.Media;
using System.Resources;

namespace Player.GUI.DiceGame
{
    public enum DieSide { ONE, TWO, THREE, FOUR, FIVE, SIX, JOKER}
    
    public partial class Die : UserControl
    {
        public DieSide Side {
            get => _value;
            set
            {
                _value = value;
                if ((int)value < Images.Length)
                {
                    imageBox.Image = Images[(int)value];
                    imageBox.Update();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                
            }
        }

        public bool Selected
        {
            get => _is_selected;
        }

        new public bool Enabled
        {
            get => _is_enabled;
            set
            {
                _is_enabled = value;
            }
        }
        public static Image[] Images {
            get;
        }
        public Die()
        {
            InitializeComponent();
            this.Side = DieSide.SIX;
        }

        static Die()
        {      
            try
            {
                {
                    //Image.FromFile(Path.GetFullPath("Die-sides/one.gif"))
                    Images = new Image[] {
                        global::Player.Properties.Resources.one,
                        global::Player.Properties.Resources.two,
                        global::Player.Properties.Resources.three,
                        global::Player.Properties.Resources.four,
                        global::Player.Properties.Resources.five,
                        global::Player.Properties.Resources.six,
                        global::Player.Properties.Resources.joker
                    };
                }
                    
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Images = new Image[] { };
            }
        }
        
        private DieSide _value;
        private bool _is_enabled;
        private bool _is_selected;
    }
}
