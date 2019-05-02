namespace Player.GUI.Login
{
    partial class RegistrationFields
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
            System.Windows.Forms.Label lblRegisterRepeat;
            System.Windows.Forms.Label lblRegisterUsername;
            System.Windows.Forms.Label lblRegisterPassword;
            System.Windows.Forms.Button btnBack;
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.txtRegisterRepeat = new System.Windows.Forms.TextBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.btnRegisterConfirm = new System.Windows.Forms.Button();
            lblRegisterRepeat = new System.Windows.Forms.Label();
            lblRegisterUsername = new System.Windows.Forms.Label();
            lblRegisterPassword = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegisterRepeat
            // 
            lblRegisterRepeat.AutoSize = true;
            lblRegisterRepeat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            lblRegisterRepeat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblRegisterRepeat.Location = new System.Drawing.Point(14, 83);
            lblRegisterRepeat.Name = "lblRegisterRepeat";
            lblRegisterRepeat.Size = new System.Drawing.Size(49, 17);
            lblRegisterRepeat.TabIndex = 15;
            lblRegisterRepeat.Text = "Repeat";
            // 
            // lblRegisterUsername
            // 
            lblRegisterUsername.AutoSize = true;
            lblRegisterUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            lblRegisterUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblRegisterUsername.Location = new System.Drawing.Point(14, 23);
            lblRegisterUsername.Name = "lblRegisterUsername";
            lblRegisterUsername.Size = new System.Drawing.Size(67, 17);
            lblRegisterUsername.TabIndex = 10;
            lblRegisterUsername.Text = "Username";
            // 
            // lblRegisterPassword
            // 
            lblRegisterPassword.AutoSize = true;
            lblRegisterPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            lblRegisterPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblRegisterPassword.Location = new System.Drawing.Point(14, 53);
            lblRegisterPassword.Name = "lblRegisterPassword";
            lblRegisterPassword.Size = new System.Drawing.Size(64, 17);
            lblRegisterPassword.TabIndex = 12;
            lblRegisterPassword.Text = "Password";
            // 
            // btnBack
            // 
            btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnBack.Location = new System.Drawing.Point(259, 111);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(100, 25);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back to login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += new System.EventHandler(this.OnBackToLogin);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblErrorMessage.Location = new System.Drawing.Point(3, 138);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(394, 37);
            this.lblErrorMessage.TabIndex = 16;
            this.lblErrorMessage.Text = "ERR_MSG";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRegisterRepeat
            // 
            this.txtRegisterRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegisterRepeat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRegisterRepeat.Location = new System.Drawing.Point(85, 80);
            this.txtRegisterRepeat.Name = "txtRegisterRepeat";
            this.txtRegisterRepeat.Size = new System.Drawing.Size(275, 25);
            this.txtRegisterRepeat.TabIndex = 14;
            this.txtRegisterRepeat.UseSystemPasswordChar = true;
            this.txtRegisterRepeat.Click += new System.EventHandler(this.OnTextBoxFocus);
            this.txtRegisterRepeat.TextChanged += new System.EventHandler(this.OnRegisterFormFilling);
            this.txtRegisterRepeat.Enter += new System.EventHandler(this.OnTextBoxFocus);
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegisterUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRegisterUsername.Location = new System.Drawing.Point(85, 20);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(275, 25);
            this.txtRegisterUsername.TabIndex = 11;
            this.txtRegisterUsername.TextChanged += new System.EventHandler(this.OnRegisterFormFilling);
            this.txtRegisterUsername.Enter += new System.EventHandler(this.OnTextBoxFocus);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegisterPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRegisterPassword.Location = new System.Drawing.Point(85, 50);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(275, 25);
            this.txtRegisterPassword.TabIndex = 13;
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            this.txtRegisterPassword.Click += new System.EventHandler(this.OnTextBoxFocus);
            this.txtRegisterPassword.TextChanged += new System.EventHandler(this.OnRegisterFormFilling);
            this.txtRegisterPassword.Enter += new System.EventHandler(this.OnTextBoxFocus);
            // 
            // btnRegisterConfirm
            // 
            this.btnRegisterConfirm.Enabled = false;
            this.btnRegisterConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegisterConfirm.Location = new System.Drawing.Point(84, 110);
            this.btnRegisterConfirm.Name = "btnRegisterConfirm";
            this.btnRegisterConfirm.Size = new System.Drawing.Size(100, 25);
            this.btnRegisterConfirm.TabIndex = 17;
            this.btnRegisterConfirm.Text = "Register";
            this.btnRegisterConfirm.UseVisualStyleBackColor = true;
            this.btnRegisterConfirm.Click += new System.EventHandler(this.OnRegisterConfirm);
            // 
            // RegistrationFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(btnBack);
            this.Controls.Add(this.btnRegisterConfirm);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(lblRegisterRepeat);
            this.Controls.Add(this.txtRegisterRepeat);
            this.Controls.Add(lblRegisterUsername);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(lblRegisterPassword);
            this.Name = "RegistrationFields";
            this.Size = new System.Drawing.Size(400, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.TextBox txtRegisterRepeat;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Button btnRegisterConfirm;
    }
}
