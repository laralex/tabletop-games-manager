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
    public enum DieValue { ONE, TWO, THREE, FOUR, FIVE, SIX, JOKER}
    
    public partial class Die : UserControl
    {
        public DieValue Side {
            get => _value;
            set
            {
                _value = value;
                if ((int)value < Images.Length)
                {
                    BackgroundImage = Images[(int)value];
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
        }
        public static Image[] Images {
            get;
        }
        public Die(DieValue init_value)
        {
            InitializeComponent();
            this.Side = init_value;
        }

        static Die()
        {      
            try
            {
                {
                    //Image.FromFile(Path.GetFullPath("Die-sides/one.gif"))
                    Images = new Image[] {
                        (Image)Properties.Resources.one,
                        Properties.Resources.three,
                        Properties.Resources.four,
                        Properties.Resources.five,
                        Properties.Resources.six,
                        Properties.Resources.joker,
                    };
                }
                    
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Images = new Image[] { };
            }
        }
        
        private DieValue _value = DieValue.JOKER;
        private bool _is_enabled;
        private bool _is_selected;
    }
}
