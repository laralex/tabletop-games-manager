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
            this.statusGameBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusGameScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusGamePlaying.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusGamePlaying
            // 
            this.statusGamePlaying.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusGameUser,
            this.statusGameBar,
            this.statusGameScore});
            this.statusGamePlaying.Location = new System.Drawing.Point(0, 407);
            this.statusGamePlaying.Name = "statusGamePlaying";
            this.statusGamePlaying.Size = new System.Drawing.Size(551, 22);
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
            // DiceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.statusGamePlaying);
            this.Name = "DiceGame";
            this.Size = new System.Drawing.Size(551, 429);
            this.statusGamePlaying.ResumeLayout(false);
            this.statusGamePlaying.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusGamePlaying;
        private System.Windows.Forms.ToolStripStatusLabel statusGameUser;
        private System.Windows.Forms.ToolStripProgressBar statusGameBar;
        private System.Windows.Forms.ToolStripStatusLabel statusGameScore;
        private System.Windows.Forms.Timer timer;
    }
}
