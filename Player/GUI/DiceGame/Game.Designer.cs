namespace Player.GUI.DiceGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.statusGamePlaying = new System.Windows.Forms.StatusStrip();
            this.statusGameUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusGameBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusGameScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.scoreRecords = new Player.GUI.DiceGame.ScoreRecords();
            this.scoreBoard = new Player.GUI.DiceGame.ScoreBoard();
            this.barTurnTime = new System.Windows.Forms.ProgressBar();
            this.lblTurnTime = new System.Windows.Forms.Label();
            this.lblFailure = new System.Windows.Forms.Label();
            this.btnReroll = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPlayerPanel = new System.Windows.Forms.Panel();
            this.die1 = new Player.GUI.DiceGame.Die(DieValue.ONE);
            this.die3 = new Player.GUI.DiceGame.Die(DieValue.FIVE);
            this.statusGamePlaying.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPlayerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusGamePlaying
            // 
            this.statusGamePlaying.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusGameUser,
            this.statusGameBar,
            this.statusGameScore});
            this.statusGamePlaying.Location = new System.Drawing.Point(0, 533);
            this.statusGamePlaying.Name = "statusGamePlaying";
            this.statusGamePlaying.Size = new System.Drawing.Size(734, 22);
            this.statusGamePlaying.TabIndex = 5;
            this.statusGamePlaying.Text = "statusStrip1";
            // 
            // statusGameUser
            // 
            this.statusGameUser.Name = "statusGameUser";
            this.statusGameUser.Size = new System.Drawing.Size(115, 17);
            this.statusGameUser.Text = "Turn of USER_NAME";
            // 
            // statusGameBar
            // 
            this.statusGameBar.Name = "statusGameBar";
            this.statusGameBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusGameScore
            // 
            this.statusGameScore.Name = "statusGameScore";
            this.statusGameScore.Size = new System.Drawing.Size(131, 17);
            this.statusGameScore.Text = "Score: SCORE_NUMBER";
            // 
            // scoreRecords
            // 
            this.scoreRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreRecords.CurrentComboIsVisible = true;
            this.scoreRecords.CurrentComboName = "3+3";
            this.scoreRecords.CurrentComboScore = ((uint)(50u));
            this.scoreRecords.Failure = false;
            this.scoreRecords.Location = new System.Drawing.Point(5, 25);
            this.scoreRecords.Name = "scoreRecords";
            this.scoreRecords.Size = new System.Drawing.Size(201, 150);
            this.scoreRecords.TabIndex = 6;
            // 
            // scoreBoard
            // 
            this.scoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreBoard.AutoSize = true;
            this.scoreBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreBoard.Location = new System.Drawing.Point(524, 3);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(201, 177);
            this.scoreBoard.TabIndex = 7;
            // 
            // barTurnTime
            // 
            this.barTurnTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barTurnTime.Location = new System.Drawing.Point(5, 229);
            this.barTurnTime.Name = "barTurnTime";
            this.barTurnTime.Size = new System.Drawing.Size(201, 23);
            this.barTurnTime.TabIndex = 8;
            // 
            // lblTurnTime
            // 
            this.lblTurnTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTurnTime.Location = new System.Drawing.Point(5, 210);
            this.lblTurnTime.Name = "lblTurnTime";
            this.lblTurnTime.Size = new System.Drawing.Size(201, 16);
            this.lblTurnTime.TabIndex = 9;
            this.lblTurnTime.Text = "30 sec";
            this.lblTurnTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFailure
            // 
            this.lblFailure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFailure.Location = new System.Drawing.Point(5, 6);
            this.lblFailure.Name = "lblFailure";
            this.lblFailure.Size = new System.Drawing.Size(201, 16);
            this.lblFailure.TabIndex = 10;
            this.lblFailure.Text = "FAILURE_MSG";
            this.lblFailure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReroll
            // 
            this.btnReroll.Location = new System.Drawing.Point(5, 258);
            this.btnReroll.Name = "btnReroll";
            this.btnReroll.Size = new System.Drawing.Size(92, 23);
            this.btnReroll.TabIndex = 11;
            this.btnReroll.Text = "Reroll";
            this.btnReroll.UseVisualStyleBackColor = true;
            this.btnReroll.Click += new System.EventHandler(this.OnReroll);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndTurn.Location = new System.Drawing.Point(116, 258);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(90, 23);
            this.btnEndTurn.TabIndex = 12;
            this.btnEndTurn.Text = "End turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.die1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.die3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(77, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 394);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // pnlPlayerPanel
            // 
            this.pnlPlayerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayerPanel.Controls.Add(this.scoreRecords);
            this.pnlPlayerPanel.Controls.Add(this.lblFailure);
            this.pnlPlayerPanel.Controls.Add(this.btnEndTurn);
            this.pnlPlayerPanel.Controls.Add(this.lblTurnTime);
            this.pnlPlayerPanel.Controls.Add(this.btnReroll);
            this.pnlPlayerPanel.Controls.Add(this.barTurnTime);
            this.pnlPlayerPanel.Location = new System.Drawing.Point(519, 219);
            this.pnlPlayerPanel.Name = "pnlPlayerPanel";
            this.pnlPlayerPanel.Size = new System.Drawing.Size(212, 311);
            this.pnlPlayerPanel.TabIndex = 14;
            // 
            // die1
            // 
            this.die1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("die1.BackgroundImage")));
            this.die1.Location = new System.Drawing.Point(3, 3);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(96, 82);
            this.die1.TabIndex = 0;
            // 
            // die3
            // 
            this.die3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("die3.BackgroundImage")));
            this.die3.Location = new System.Drawing.Point(3, 200);
            this.die3.Name = "die3";
            this.die3.Size = new System.Drawing.Size(150, 150);
            this.die3.TabIndex = 2;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlPlayerPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.statusGamePlaying);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(734, 555);
            this.statusGamePlaying.ResumeLayout(false);
            this.statusGamePlaying.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlPlayerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusGamePlaying;
        private System.Windows.Forms.ToolStripStatusLabel statusGameUser;
        private System.Windows.Forms.ToolStripProgressBar statusGameBar;
        private System.Windows.Forms.ToolStripStatusLabel statusGameScore;
        private System.Windows.Forms.Timer timer;
        private ScoreRecords scoreRecords;
        private ScoreBoard scoreBoard;
        private System.Windows.Forms.ProgressBar barTurnTime;
        private System.Windows.Forms.Label lblTurnTime;
        private System.Windows.Forms.Label lblFailure;
        private System.Windows.Forms.Button btnReroll;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlPlayerPanel;
        private Die die1;
        private Die die3;
    }
}
