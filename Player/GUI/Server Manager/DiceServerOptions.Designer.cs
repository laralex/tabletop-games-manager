namespace Player.GUI.ServerManager
{
    partial class DiceServerOptions
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
            System.Windows.Forms.Label lblTurnTime;
            System.Windows.Forms.Label lblScoreGoal;
            System.Windows.Forms.Label lblDiceOptions;
            System.Windows.Forms.Label lblDiceNumber;
            System.Windows.Forms.Label lblIncludedJoker;
            this.numTurnTime = new System.Windows.Forms.NumericUpDown();
            this.numScoreGoal = new System.Windows.Forms.NumericUpDown();
            this.numDiceNumber = new System.Windows.Forms.NumericUpDown();
            this.chkIncludedJoker = new System.Windows.Forms.CheckBox();
            lblTurnTime = new System.Windows.Forms.Label();
            lblScoreGoal = new System.Windows.Forms.Label();
            lblDiceOptions = new System.Windows.Forms.Label();
            lblDiceNumber = new System.Windows.Forms.Label();
            lblIncludedJoker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTurnTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScoreGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiceNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurnTime
            // 
            lblTurnTime.AutoSize = true;
            lblTurnTime.Location = new System.Drawing.Point(15, 57);
            lblTurnTime.Name = "lblTurnTime";
            lblTurnTime.Size = new System.Drawing.Size(77, 13);
            lblTurnTime.TabIndex = 9;
            lblTurnTime.Text = "Turn time (sec)";
            // 
            // lblScoreGoal
            // 
            lblScoreGoal.AutoSize = true;
            lblScoreGoal.Location = new System.Drawing.Point(15, 31);
            lblScoreGoal.Name = "lblScoreGoal";
            lblScoreGoal.Size = new System.Drawing.Size(58, 13);
            lblScoreGoal.TabIndex = 7;
            lblScoreGoal.Text = "Score goal";
            // 
            // lblDiceOptions
            // 
            lblDiceOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblDiceOptions.Location = new System.Drawing.Point(-3, 0);
            lblDiceOptions.Name = "lblDiceOptions";
            lblDiceOptions.Size = new System.Drawing.Size(436, 25);
            lblDiceOptions.TabIndex = 5;
            lblDiceOptions.Text = "Dice game options";
            lblDiceOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiceNumber
            // 
            lblDiceNumber.AutoSize = true;
            lblDiceNumber.Location = new System.Drawing.Point(15, 83);
            lblDiceNumber.Name = "lblDiceNumber";
            lblDiceNumber.Size = new System.Drawing.Size(67, 13);
            lblDiceNumber.TabIndex = 12;
            lblDiceNumber.Text = "Dice number";
            // 
            // lblIncludedJoker
            // 
            lblIncludedJoker.AutoSize = true;
            lblIncludedJoker.Location = new System.Drawing.Point(15, 108);
            lblIncludedJoker.Name = "lblIncludedJoker";
            lblIncludedJoker.Size = new System.Drawing.Size(88, 13);
            lblIncludedJoker.TabIndex = 13;
            lblIncludedJoker.Text = "Include Joker die";
            // 
            // numTurnTime
            // 
            this.numTurnTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numTurnTime.Location = new System.Drawing.Point(110, 55);
            this.numTurnTime.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numTurnTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTurnTime.Name = "numTurnTime";
            this.numTurnTime.Size = new System.Drawing.Size(296, 20);
            this.numTurnTime.TabIndex = 8;
            this.numTurnTime.Tag = "60";
            this.numTurnTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numTurnTime.ValueChanged += new System.EventHandler(this.OnFieldChange);
            // 
            // numScoreGoal
            // 
            this.numScoreGoal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numScoreGoal.Location = new System.Drawing.Point(110, 29);
            this.numScoreGoal.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numScoreGoal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScoreGoal.Name = "numScoreGoal";
            this.numScoreGoal.Size = new System.Drawing.Size(296, 20);
            this.numScoreGoal.TabIndex = 10;
            this.numScoreGoal.Tag = "1000";
            this.numScoreGoal.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numScoreGoal.ValueChanged += new System.EventHandler(this.OnFieldChange);
            // 
            // numDiceNumber
            // 
            this.numDiceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numDiceNumber.Location = new System.Drawing.Point(110, 81);
            this.numDiceNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDiceNumber.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDiceNumber.Name = "numDiceNumber";
            this.numDiceNumber.Size = new System.Drawing.Size(296, 20);
            this.numDiceNumber.TabIndex = 11;
            this.numDiceNumber.Tag = "5";
            this.numDiceNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDiceNumber.ValueChanged += new System.EventHandler(this.OnFieldChange);
            // 
            // chkIncludedJoker
            // 
            this.chkIncludedJoker.AutoSize = true;
            this.chkIncludedJoker.Location = new System.Drawing.Point(110, 108);
            this.chkIncludedJoker.Name = "chkIncludedJoker";
            this.chkIncludedJoker.Size = new System.Drawing.Size(15, 14);
            this.chkIncludedJoker.TabIndex = 14;
            this.chkIncludedJoker.Tag = "0";
            this.chkIncludedJoker.UseVisualStyleBackColor = true;
            // 
            // DiceServerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.chkIncludedJoker);
            this.Controls.Add(lblIncludedJoker);
            this.Controls.Add(lblDiceNumber);
            this.Controls.Add(this.numDiceNumber);
            this.Controls.Add(this.numScoreGoal);
            this.Controls.Add(lblTurnTime);
            this.Controls.Add(this.numTurnTime);
            this.Controls.Add(lblScoreGoal);
            this.Controls.Add(lblDiceOptions);
            this.Name = "DiceServerOptions";
            this.Size = new System.Drawing.Size(433, 125);
            ((System.ComponentModel.ISupportInitialize)(this.numTurnTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScoreGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiceNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.NumericUpDown numTurnTime;
        internal System.Windows.Forms.NumericUpDown numScoreGoal;
        internal System.Windows.Forms.NumericUpDown numDiceNumber;
        internal System.Windows.Forms.CheckBox chkIncludedJoker;
    }
}
