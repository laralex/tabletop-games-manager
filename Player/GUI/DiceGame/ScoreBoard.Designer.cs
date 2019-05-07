namespace Player.GUI.DiceGame
{
    partial class ScoreBoard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblScoreBoard = new System.Windows.Forms.DataGridView();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblScoreBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // tblScoreBoard
            // 
            this.tblScoreBoard.AllowUserToAddRows = false;
            this.tblScoreBoard.AllowUserToDeleteRows = false;
            this.tblScoreBoard.AllowUserToResizeColumns = false;
            this.tblScoreBoard.AllowUserToResizeRows = false;
            this.tblScoreBoard.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblScoreBoard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblScoreBoard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblScoreBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblScoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblScoreBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPosition,
            this.colPlayer,
            this.colScore});
            this.tblScoreBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblScoreBoard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblScoreBoard.EnableHeadersVisualStyles = false;
            this.tblScoreBoard.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tblScoreBoard.Location = new System.Drawing.Point(0, 0);
            this.tblScoreBoard.Margin = new System.Windows.Forms.Padding(10);
            this.tblScoreBoard.MultiSelect = false;
            this.tblScoreBoard.Name = "tblScoreBoard";
            this.tblScoreBoard.ReadOnly = true;
            this.tblScoreBoard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblScoreBoard.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblScoreBoard.RowHeadersVisible = false;
            this.tblScoreBoard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.tblScoreBoard.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tblScoreBoard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblScoreBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblScoreBoard.Size = new System.Drawing.Size(121, 106);
            this.tblScoreBoard.TabIndex = 1;
            this.tblScoreBoard.SelectionChanged += new System.EventHandler(this.OnSelection);
            // 
            // colPosition
            // 
            this.colPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPosition.HeaderText = "#";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPosition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPosition.Width = 19;
            // 
            // colPlayer
            // 
            this.colPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlayer.HeaderText = "Player";
            this.colPlayer.Name = "colPlayer";
            this.colPlayer.ReadOnly = true;
            this.colPlayer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPlayer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colScore
            // 
            this.colScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colScore.FillWeight = 100.7449F;
            this.colScore.HeaderText = "Score";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colScore.Width = 59;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tblScoreBoard);
            this.Name = "ScoreBoard";
            this.Size = new System.Drawing.Size(121, 106);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.tblScoreBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView tblScoreBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
    }
}
