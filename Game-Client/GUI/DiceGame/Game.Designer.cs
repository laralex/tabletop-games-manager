namespace GameClient.GUI.DiceGame
{
    partial class DiceGameControl
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
            this.SuspendLayout();
            // 
            // DiceGameControl
            // 
            this.Name = "DiceGameControl";
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripStatusLabel statusGameTime;
        private System.Windows.Forms.Panel pnlGameField;
        private System.Windows.Forms.FlowLayoutPanel tblDiceBoard;
        private System.Windows.Forms.TableLayoutPanel tblCentering;
    }
}
