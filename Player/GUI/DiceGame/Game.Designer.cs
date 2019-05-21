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
            this.statusGamePlaying = new System.Windows.Forms.StatusStrip();
            this.statusGameUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusGameScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusGameTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.barTurnTime = new System.Windows.Forms.ProgressBar();
            this.lblTurnTime = new System.Windows.Forms.Label();
            this.lblFailure = new System.Windows.Forms.Label();
            this.btnReroll = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.pnlPlayerPanel = new System.Windows.Forms.Panel();
            this.pnlGameField = new System.Windows.Forms.Panel();
            this.tblDiceBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.tblCentering = new System.Windows.Forms.TableLayoutPanel();
            this.scoreRecords = new Player.GUI.DiceGame.ScoreRecords();
            this.scoreBoard = new Player.GUI.DiceGame.ScoreBoard();
            this.statusGamePlaying.SuspendLayout();
            this.pnlPlayerPanel.SuspendLayout();
            this.pnlGameField.SuspendLayout();
            this.tblCentering.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusGamePlaying
            // 
            this.statusGamePlaying.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusGameUser,
            this.statusGameScore,
            this.statusGameTime});
            this.statusGamePlaying.Location = new System.Drawing.Point(0, 558);
            this.statusGamePlaying.Name = "statusGamePlaying";
            this.statusGamePlaying.Size = new System.Drawing.Size(847, 22);
            this.statusGamePlaying.TabIndex = 5;
            this.statusGamePlaying.Text = "statusStrip1";
            // 
            // statusGameUser
            // 
            this.statusGameUser.Name = "statusGameUser";
            this.statusGameUser.Size = new System.Drawing.Size(115, 17);
            this.statusGameUser.Text = "Turn of USER_NAME";
            // 
            // statusGameScore
            // 
            this.statusGameScore.Name = "statusGameScore";
            this.statusGameScore.Size = new System.Drawing.Size(131, 17);
            this.statusGameScore.Text = "Score: SCORE_NUMBER";
            // 
            // statusGameTime
            // 
            this.statusGameTime.Name = "statusGameTime";
            this.statusGameTime.Size = new System.Drawing.Size(107, 17);
            this.statusGameTime.Text = "Time left: TIME sec";
            // 
            // barTurnTime
            // 
            this.barTurnTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barTurnTime.Location = new System.Drawing.Point(5, 262);
            this.barTurnTime.Name = "barTurnTime";
            this.barTurnTime.Size = new System.Drawing.Size(201, 23);
            this.barTurnTime.TabIndex = 8;
            // 
            // lblTurnTime
            // 
            this.lblTurnTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTurnTime.Location = new System.Drawing.Point(5, 243);
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
            this.btnReroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReroll.Location = new System.Drawing.Point(5, 291);
            this.btnReroll.Name = "btnReroll";
            this.btnReroll.Size = new System.Drawing.Size(92, 23);
            this.btnReroll.TabIndex = 11;
            this.btnReroll.Text = "Reroll";
            this.btnReroll.UseVisualStyleBackColor = true;
            this.btnReroll.Click += new System.EventHandler(this.OnReroll);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndTurn.Location = new System.Drawing.Point(116, 291);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(90, 23);
            this.btnEndTurn.TabIndex = 12;
            this.btnEndTurn.Text = "End turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.OnEndTurn);
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
            this.pnlPlayerPanel.Location = new System.Drawing.Point(632, 219);
            this.pnlPlayerPanel.Name = "pnlPlayerPanel";
            this.pnlPlayerPanel.Size = new System.Drawing.Size(212, 336);
            this.pnlPlayerPanel.TabIndex = 14;
            // 
            // pnlGameField
            // 
            this.pnlGameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameField.Controls.Add(this.tblCentering);
            this.pnlGameField.Location = new System.Drawing.Point(70, 70);
            this.pnlGameField.Name = "pnlGameField";
            this.pnlGameField.Size = new System.Drawing.Size(487, 423);
            this.pnlGameField.TabIndex = 16;
            // 
            // tblDiceBoard
            // 
            this.tblDiceBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDiceBoard.AutoSize = true;
            this.tblDiceBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblDiceBoard.Location = new System.Drawing.Point(3, 208);
            this.tblDiceBoard.Name = "tblDiceBoard";
            this.tblDiceBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tblDiceBoard.Size = new System.Drawing.Size(481, 6);
            this.tblDiceBoard.TabIndex = 14;
            this.tblDiceBoard.Layout += new System.Windows.Forms.LayoutEventHandler(this.OnGameBoardLayout);
            this.tblDiceBoard.Resize += new System.EventHandler(this.OnGameBoardResize);
            // 
            // tblCentering
            // 
            this.tblCentering.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblCentering.ColumnCount = 1;
            this.tblCentering.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCentering.Controls.Add(this.tblDiceBoard, 0, 0);
            this.tblCentering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCentering.Location = new System.Drawing.Point(0, 0);
            this.tblCentering.Name = "tblCentering";
            this.tblCentering.RowCount = 1;
            this.tblCentering.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCentering.Size = new System.Drawing.Size(487, 423);
            this.tblCentering.TabIndex = 0;
            // 
            // scoreRecords
            // 
            this.scoreRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreRecords.CurrentComboIsVisible = true;
            this.scoreRecords.CurrentComboName = "3+3";
            this.scoreRecords.CurrentComboScore = 50;
            this.scoreRecords.Failure = false;
            this.scoreRecords.Location = new System.Drawing.Point(5, 26);
            this.scoreRecords.Name = "scoreRecords";
            this.scoreRecords.Size = new System.Drawing.Size(201, 214);
            this.scoreRecords.TabIndex = 13;
            // 
            // scoreBoard
            // 
            this.scoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreBoard.AutoSize = true;
            this.scoreBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreBoard.Location = new System.Drawing.Point(637, 3);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.SelectedPlayer = "sadex";
            this.scoreBoard.Size = new System.Drawing.Size(201, 177);
            this.scoreBoard.TabIndex = 7;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlPlayerPanel);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.statusGamePlaying);
            this.Controls.Add(this.pnlGameField);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(847, 580);
            this.statusGamePlaying.ResumeLayout(false);
            this.statusGamePlaying.PerformLayout();
            this.pnlPlayerPanel.ResumeLayout(false);
            this.pnlGameField.ResumeLayout(false);
            this.tblCentering.ResumeLayout(false);
            this.tblCentering.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusGamePlaying;
        private System.Windows.Forms.ToolStripStatusLabel statusGameUser;
        private System.Windows.Forms.ToolStripStatusLabel statusGameScore;
        private System.Windows.Forms.Timer timer;
        private ScoreBoard scoreBoard;
        private System.Windows.Forms.ProgressBar barTurnTime;
        private System.Windows.Forms.Label lblTurnTime;
        private System.Windows.Forms.Label lblFailure;
        private System.Windows.Forms.Button btnReroll;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Panel pnlPlayerPanel;
        private ScoreRecords scoreRecords;
        private System.Windows.Forms.ToolStripStatusLabel statusGameTime;
        private System.Windows.Forms.Panel pnlGameField;
        private System.Windows.Forms.FlowLayoutPanel tblDiceBoard;
        private System.Windows.Forms.TableLayoutPanel tblCentering;
    }
}
