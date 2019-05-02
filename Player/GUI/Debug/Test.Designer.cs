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
            this.serversList1 = new Player.GUI.ServerManager.ServersList();
            this.SuspendLayout();
            // 
            // serversList1
            // 
            this.serversList1.AutoSize = true;
            this.serversList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.serversList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversList1.Location = new System.Drawing.Point(0, 0);
            this.serversList1.Name = "serversList1";
            this.serversList1.Size = new System.Drawing.Size(800, 450);
            this.serversList1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serversList1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ServerManager.ServersList serversList1;
    }
}