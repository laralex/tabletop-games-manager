namespace Player.GUI.Debug
{
    partial class Test
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.game1 = new Player.GUI.DiceGame.Game();
            this.SuspendLayout();
            // 
            // game1
            // 
            this.game1.AutoSize = true;
            this.game1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.game1.Dock = System.Windows.Forms.DockStyle.Right;
            this.game1.Location = new System.Drawing.Point(109, 0);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(691, 579);
            this.game1.TabIndex = 3;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.game1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DiceGame.Game game1;
    }
}