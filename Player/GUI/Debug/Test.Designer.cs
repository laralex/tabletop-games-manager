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
            this.die1 = new Player.GUI.DiceGame.Die();
            this.SuspendLayout();
            // 
            // die1
            // 
            this.die1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.die1.Enabled = false;
            this.die1.Location = new System.Drawing.Point(271, 98);
            this.die1.Name = "die1";
            this.die1.Side = Player.GUI.DiceGame.DieSide.SIX;
            this.die1.Size = new System.Drawing.Size(255, 251);
            this.die1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.die1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private DiceGame.Die die1;
    }
}