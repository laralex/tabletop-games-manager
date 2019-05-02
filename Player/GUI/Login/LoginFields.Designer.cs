namespace Player.GUI.Login
{
    partial class LoginFields
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
            System.Windows.Forms.Button btnRegister;
            System.Windows.Forms.Label lblLoginUsername;
            System.Windows.Forms.Label lblLoginPassword;
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            btnRegister = new System.Windows.Forms.Button();
            lblLoginUsername = new System.Windows.Forms.Label();
            lblLoginPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblErrorMessage.Location = new System.Drawing.Point(0, 109);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(400, 41);
            this.lblErrorMessage.TabIndex = 17;
            this.lblErrorMessage.Text = "ERR_MSG";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnRegister.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            btnRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRegister.Location = new System.Drawing.Point(244, 81);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(116, 25);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Not registered yet ?";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += new System.EventHandler(this.OnRegister);
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            lblLoginUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblLoginUsername.Location = new System.Drawing.Point(14, 23);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new System.Drawing.Size(67, 17);
            lblLoginUsername.TabIndex = 11;
            lblLoginUsername.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(85, 81);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 25);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.OnLogin);
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLoginUsername.Location = new System.Drawing.Point(85, 20);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(275, 25);
            this.txtLoginUsername.TabIndex = 12;
            this.txtLoginUsername.TextChanged += new System.EventHandler(this.OnLoginFormFilling);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLoginPassword.Location = new System.Drawing.Point(85, 50);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(275, 25);
            this.txtLoginPassword.TabIndex = 14;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            this.txtLoginPassword.TextChanged += new System.EventHandler(this.OnLoginFormFilling);
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            lblLoginPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblLoginPassword.Location = new System.Drawing.Point(14, 53);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new System.Drawing.Size(64, 17);
            lblLoginPassword.TabIndex = 13;
            lblLoginPassword.Text = "Password";
            // 
            // LoginFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(btnRegister);
            this.Controls.Add(lblLoginUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(lblLoginPassword);
            this.Name = "LoginFields";
            this.Size = new System.Drawing.Size(400, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
    }
}
