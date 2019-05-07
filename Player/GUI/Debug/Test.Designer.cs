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
            this.dieControl1 = new Player.GUI.DiceGame.DieControl();
            this.die1 = new Player.GUI.DiceGame.Die();
            this.game1 = new Player.GUI.DiceGame.Game();
            this.SuspendLayout();
            // 
            // dieControl1
            // 
            this.dieControl1.Location = new System.Drawing.Point(12, 12);
            this.dieControl1.Name = "dieControl1";
            this.dieControl1.Size = new System.Drawing.Size(75, 23);
            this.dieControl1.TabIndex = 2;
            this.dieControl1.Text = "dieControl1";
            this.dieControl1.UseVisualStyleBackColor = true;
            this.dieControl1.Value = Player.GUI.DiceGame.DieValue.ONE;
            // 
            // die1
            // 
            this.die1.Location = new System.Drawing.Point(12, 41);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(101, 32);
            this.die1.TabIndex = 1;
            // 
            // game1
            // 
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
            this.Controls.Add(this.dieControl1);
            this.Controls.Add(this.die1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion
        private DiceGame.Die die1;
        private DiceGame.DieControl dieControl1;
        private DiceGame.Game game1;
    }
}