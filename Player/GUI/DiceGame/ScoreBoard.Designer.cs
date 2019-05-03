namespace Player.GUI.Dice_Game
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
            this.tblScoreBoard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tblScoreBoard.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblScoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblScoreBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPosition,
            this.colPlayer,
            this.colScore});
            this.tblScoreBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblScoreBoard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblScoreBoard.Location = new System.Drawing.Point(0, 0);
            this.tblScoreBoard.Margin = new System.Windows.Forms.Padding(10);
            this.tblScoreBoard.MultiSelect = false;
            this.tblScoreBoard.Name = "tblScoreBoard";
            this.tblScoreBoard.ReadOnly = true;
            this.tblScoreBoard.RowHeadersVisible = false;
            this.tblScoreBoard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblScoreBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblScoreBoard.Size = new System.Drawing.Size(260, 271);
            this.tblScoreBoard.TabIndex = 1;
            // 
            // colPosition
            // 
            this.colPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPosition.HeaderText = "#";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.Width = 39;
            // 
            // colPlayer
            // 
            this.colPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPlayer.HeaderText = "Player";
            this.colPlayer.Name = "colPlayer";
            this.colPlayer.ReadOnly = true;
            this.colPlayer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPlayer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPlayer.Width = 42;
            // 
            // colScore
            // 
            this.colScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colScore.FillWeight = 100.7449F;
            this.colScore.HeaderText = "Score";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tblScoreBoard);
            this.Name = "ScoreBoard";
            this.Size = new System.Drawing.Size(260, 271);
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
