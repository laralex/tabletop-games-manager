using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Player.GUI.DiceGame
{
    public partial class Game : UserControl
    {
        public Game()
        {
            InitializeComponent();
            current_die_size = max_die_control_side;
            InitBoard(10);
        }

        public void InitBoard(int dice_number)
        {

            Die die, prototype_die = CreateDie();

            tblDiceBoard.Controls.Clear();
            //tblDiceBoard.MaximumSize = pnlGameField.Size;

            for (int i = 0; i < dice_number; ++i)
            {
                die = (Die)prototype_die.Clone();
                die.Side = (DieSide)(i % 7);
                die.Click += OnDieClick;
                tblDiceBoard.Controls.Add(die);
            }

            //tblDiceBoard.Location = new Point(5, 5);
            tblDiceBoard.Update();
            //var tbl_size = tblDiceBoard.Size;
            /*var board_size = pnlGameField.Size;
            int max_fit_in_width = board_size.Width / max_die_control_side;
            int fit_ratio = (int)Math.Ceiling((double)dice_number / max_fit_in_width);

            int cols = Math.Min(max_fit_in_width, dice_number);
            int rows = (int)Math.Ceiling((double)dice_number / cols);
             
            int dice_in_last = dice_number % cols;

            Size tbl_size = new Size
            {
                Width  = Math.Min(cols * max_die_control_side, board_size.Width),
                Height = Math.Min(rows * max_die_control_side, board_size.Height)
            };

            
            tblDiceBoard.Size = tbl_size;

            int col_size = tbl_size.Width / cols;
            int row_size = tbl_size.Height / rows;
              */
            //tblDiceBoard.ColumnCount = cols;
            //tblDiceBoard.RowCount = rows;
            //tblDiceBoard.ColumnStyles.Clear();
            //tblDiceBoard.RowStyles.Clear();

            /*for (int r = 0, limit = cols; r < rows; ++r)
            {
                tblDiceBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, row_size));
                if (r == rows - 1)
                {
                    limit = dice_in_last;
                }
                for (int c = 0; c < limit; ++c)
                {
                    if (r == 0)
                    {
                        tblDiceBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, col_size));
                    }
                    
                    this.tblDiceBoard.Controls.Add(die, c, r);
                }
                
            } */


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

        }

        private void OnGameBoardResize(object sender, EventArgs e)
        {
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
