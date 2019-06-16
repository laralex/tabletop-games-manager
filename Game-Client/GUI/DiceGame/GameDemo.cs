using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CommonLibrary.Model.Games.Dice;
using CommonLibrary.Implementation.Games.Dice;
using DieModel = CommonLibrary.Implementation.Games.Dice.Die;
namespace GameClient.GUI.DiceGame
{
    public partial class DiceGameControlDemo : UserControl
    {
       
        public DiceGameControlDemo()
        {
            InitializeComponent();
            current_die_size = max_die_control_side;
            resize_timer = new Timer();
            resize_timer.Interval = 1000; // ms
            resize_timer.Tick += (sender, e) => OnGameBoardResizeEnd();
            DieModel[] new_dice = new DieModel[] {
                new DieModel(DieSide.ONE, true),
                new DieModel(DieSide.JOKER, true),
                new DieModel(DieSide.FIVE, false),
                new DieModel(DieSide.FIVE),
                new DieModel(DieSide.SIX),
                new DieModel(DieSide.TWO)
            };
            
            InitBoard(new_dice);
        }

        public void InitBoard(DieModel[] dice)
        {

            Die die, prototype_die = CreateDie();

            tblDiceBoard.Controls.Clear();

            for (int i = 0; i < dice.Length; ++i)
            {
                die = (Die)prototype_die.Clone();
                die.Side = dice[i].Side;
                die.Selected = dice[i].Selected;
                die.Click += OnDieClick;
                tblDiceBoard.Controls.Add(die);
            }

            tblDiceBoard.Update();
        }

        private Die CreateDie()
        {
            Die die = new Die();
            die.Size = new Size(current_die_size, current_die_size);
            die.MaximumSize = new Size(max_die_control_side, max_die_control_side);
            die.MinimumSize = new Size(min_die_control_side, min_die_control_side);
            die.Anchor = AnchorStyles.None;
            die.Margin = new Padding(die_horizontal_margin, die_vertical_margin, die_horizontal_margin, die_vertical_margin);
            //prototype_die.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //prototype_die.AutoSize = true;
            return die;
        }

        private void OnDieClick(object sender, EventArgs e)
        {
            Die die = (sender as PictureBox).Parent as Die;
            die.ToggleSelected();
        }

        private void OnReroll(object sender, EventArgs e)
        {
            
        }

        private void OnEndTurn(object sender, EventArgs e)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string str = new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
            scoreBoard.AddPlayer(str, (uint)rnd.Next(5,5000));
        }

        private void OnGameBoardResize(object sender, EventArgs e)
        {
            resize_timer.Start();  
        }

        private void OnGameBoardResizeEnd()
        {
            resize_timer.Stop();

            int guess_die_size = GetFittingDieSide(tblCentering.Size);
            int height_required = RowsNumber(guess_die_size) * DieSpacingV(guess_die_size);
            int width_required = ColsNumber(guess_die_size) * DieSpacingH(guess_die_size);
            if (height_required < tblCentering.Size.Height && width_required < tblCentering.Size.Width)
            {
                current_die_size = guess_die_size;
                UpdateDice(current_die_size);
                tblDiceBoard.PerformLayout();
            }
        }

        private void OnGameBoardLayout(object sender, LayoutEventArgs e)
        {
            
            //e.AffectedProperty.
        }

        private int current_die_size;
        private const int min_die_control_side = 20;
        private const int max_die_control_side = 100;
        private const int die_vertical_margin = 7;
        private const int die_horizontal_margin = 15;

        private Timer resize_timer;
        private int RowsNumber(int side_size)
        {
                int cols = ColsNumber(side_size);
                if (cols == 0) return tblDiceBoard.Controls.Count;
                int remainder = tblDiceBoard.Controls.Count % cols;
                return tblDiceBoard.Controls.Count / cols + (remainder > 0 ? 1 : 0);
        }

        private int ColsNumber(int side_size)
        {
                int total_dice = tblDiceBoard.Controls.Count;
                return tblDiceBoard.Size.Width / DieSpacingH(side_size);
        }


        private int DieSpacingH(int side_size)
        {
            return 2 * die_horizontal_margin + side_size;
        }

        private int DieSpacingV(int side_size)
        {
            return 2 * die_vertical_margin + side_size;
        }

        private int GetFittingDieSide (Size limit)
        {
            int total_dice = tblDiceBoard.Controls.Count;
            int half = (max_die_control_side - min_die_control_side) / 2;
            int guess = (max_die_control_side + min_die_control_side) / 2;
            while (half != 0)
            {
                int cols = limit.Width / DieSpacingH(guess);
                cols = cols == 0 ? 1 : cols;
                int remainder = total_dice % cols;
                int rows = total_dice / cols + (remainder > 0 ? 1 : 0);
                half = half / 2;
                
                if (rows * DieSpacingV(guess) <= limit.Height)
                {
                    guess += half;
                }
                else
                {
                    guess -= half;
                }
                
            }
            //return Math.Max((guess / 5) * 5, min_die_control_side) ;
            return Math.Max(guess - 10, min_die_control_side);
            /*for (int i = max_die_control_side; i >= min_die_control_side; i -= 2)
            {
                int cols = limit.Width / DieSpacingH(i);
                cols = cols == 0 ? 1 : cols;
                int remainder = total_dice % cols;
                int rows = total_dice / cols + (remainder > 0 ? 1 : 0);
                if (rows * DieSpacingV(i) <= limit.Height)
                {
                    return i;
                }
            }
            return min_die_control_side;
            */
        }

        private void UpdateDice(int new_side)
        {
            foreach (Control c in tblDiceBoard.Controls)
            {
                c.Size = new Size(new_side, new_side);
            }
        }
        //private const float die_scale = 0.7f;
    }
}
