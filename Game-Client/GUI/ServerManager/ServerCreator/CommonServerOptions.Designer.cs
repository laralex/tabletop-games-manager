namespace GameClient.GUI.ServerManager.ServerCreator
{
    partial class CommonServerOptions
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
            System.Windows.Forms.Label lblCommonOptions;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblMaxPlayers;
            this.txtName = new System.Windows.Forms.TextBox();
            this.numMaxPlayers = new System.Windows.Forms.NumericUpDown();
            lblCommonOptions = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblMaxPlayers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCommonOptions
            // 
            lblCommonOptions.Dock = System.Windows.Forms.DockStyle.Top;
            lblCommonOptions.Location = new System.Drawing.Point(0, 0);
            lblCommonOptions.Name = "lblCommonOptions";
            lblCommonOptions.Size = new System.Drawing.Size(433, 25);
            lblCommonOptions.TabIndex = 0;
            lblCommonOptions.Text = "Server options";
            lblCommonOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(15, 31);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(35, 13);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblMaxPlayers
            // 
            lblMaxPlayers.AutoSize = true;
            lblMaxPlayers.Location = new System.Drawing.Point(15, 56);
            lblMaxPlayers.Name = "lblMaxPlayers";
            lblMaxPlayers.Size = new System.Drawing.Size(87, 13);
            lblMaxPlayers.TabIndex = 4;
            lblMaxPlayers.Text = "Maximum players";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(55, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(351, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.OnFieldChange);
            // 
            // numMaxPlayers
            // 
            this.numMaxPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaxPlayers.Location = new System.Drawing.Point(110, 54);
            this.numMaxPlayers.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMaxPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxPlayers.Name = "numMaxPlayers";
            this.numMaxPlayers.Size = new System.Drawing.Size(296, 20);
            this.numMaxPlayers.TabIndex = 3;
            this.numMaxPlayers.Tag = "4";
            this.numMaxPlayers.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // CommonServerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(lblMaxPlayers);
            this.Controls.Add(this.numMaxPlayers);
            this.Controls.Add(lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(lblCommonOptions);
            this.Name = "CommonServerOptions";
            this.Size = new System.Drawing.Size(433, 77);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.NumericUpDown numMaxPlayers;
    }
}
