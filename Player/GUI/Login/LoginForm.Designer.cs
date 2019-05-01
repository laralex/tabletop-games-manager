namespace Player.GUI.Login
{
    partial class LoginForm
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
            System.Windows.Forms.Label lblLoginUsername;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            System.Windows.Forms.Label lblLoginPassword;
            System.Windows.Forms.Button btnRegister;
            System.Windows.Forms.Label lblRegisterUsername;
            System.Windows.Forms.Label lblRegisterPassword;
            System.Windows.Forms.Label lblRegisterRepeat;
            System.Windows.Forms.Button btnBack;
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegisterConfirm = new System.Windows.Forms.Button();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.txtRegisterRepeat = new System.Windows.Forms.TextBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            lblLoginUsername = new System.Windows.Forms.Label();
            lblLoginPassword = new System.Windows.Forms.Label();
            btnRegister = new System.Windows.Forms.Button();
            lblRegisterUsername = new System.Windows.Forms.Label();
            lblRegisterPassword = new System.Windows.Forms.Label();
            lblRegisterRepeat = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginUsername
            // 
            resources.ApplyResources(lblLoginUsername, "lblLoginUsername");
            lblLoginUsername.Name = "lblLoginUsername";
            // 
            // lblLoginPassword
            // 
            resources.ApplyResources(lblLoginPassword, "lblLoginPassword");
            lblLoginPassword.Name = "lblLoginPassword";
            // 
            // btnRegister
            // 
            resources.ApplyResources(btnRegister, "btnRegister");
            btnRegister.Name = "btnRegister";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += new System.EventHandler(this.OnRegister);
            // 
            // lblRegisterUsername
            // 
            resources.ApplyResources(lblRegisterUsername, "lblRegisterUsername");
            lblRegisterUsername.Name = "lblRegisterUsername";
            // 
            // lblRegisterPassword
            // 
            resources.ApplyResources(lblRegisterPassword, "lblRegisterPassword");
            lblRegisterPassword.Name = "lblRegisterPassword";
            // 
            // lblRegisterRepeat
            // 
            resources.ApplyResources(lblRegisterRepeat, "lblRegisterRepeat");
            lblRegisterRepeat.Name = "lblRegisterRepeat";
            // 
            // btnBack
            // 
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.Name = "btnBack";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += new System.EventHandler(this.OnBackToLogin);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.OnLogin);
            // 
            // btnRegisterConfirm
            // 
            resources.ApplyResources(this.btnRegisterConfirm, "btnRegisterConfirm");
            this.btnRegisterConfirm.Name = "btnRegisterConfirm";
            this.btnRegisterConfirm.UseVisualStyleBackColor = true;
            this.btnRegisterConfirm.Click += new System.EventHandler(this.OnRegisterConfirm);
            // 
            // txtLoginUsername
            // 
            resources.ApplyResources(this.txtLoginUsername, "txtLoginUsername");
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Click += new System.EventHandler(this.OnTextBoxFocus);
            this.txtLoginUsername.TextChanged += new System.EventHandler(this.OnLoginFormFilling);
            this.txtLoginUsername.Enter += new System.EventHandler(this.OnTextBoxFocus);
            // 
            // txtLoginPassword
            // 
            resources.ApplyResources(this.txtLoginPassword, "txtLoginPassword");
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.UseSystemPasswordChar = true;
            this.txtLoginPassword.Click += new System.EventHandler(this.OnTextBoxFocus);
            this.txtLoginPassword.TextChanged += new System.EventHandler(this.OnLoginFormFilling);
            this.txtLoginPassword.Enter += new System.EventHandler(this.OnTextBoxFocus);
            // 
            // pnlLogin
            // 
            resources.ApplyResources(this.pnlLogin, "pnlLogin");
            this.pnlLogin.Controls.Add(btnRegister);
            this.pnlLogin.Controls.Add(lblLoginUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtLoginUsername);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Controls.Add(lblLoginPassword);
            this.pnlLogin.Name = "pnlLogin";
            // 
            // pnlRegister
            // 
            resources.ApplyResources(this.pnlRegister, "pnlRegister");
            this.pnlRegister.Controls.Add(this.lblErrorMessage);
            this.pnlRegister.Controls.Add(btnBack);
            this.pnlRegister.Controls.Add(lblRegisterRepeat);
            this.pnlRegister.Controls.Add(this.txtRegisterRepeat);
            this.pnlRegister.Controls.Add(this.btnRegisterConfirm);
            this.pnlRegister.Controls.Add(lblRegisterUsername);
            this.pnlRegister.Controls.Add(this.txtRegisterUsername);
            this.pnlRegister.Controls.Add(this.txtRegisterPassword);
            this.pnlRegister.Controls.Add(lblRegisterPassword);
            this.pnlRegister.Name = "pnlRegister";
            // 
            // lblErrorMessage
            // 
            resources.ApplyResources(this.lblErrorMessage, "lblErrorMessage");
            this.lblErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorMessage.Name = "lblErrorMessage";
            // 
            // txtRegisterRepeat
            // 
            resources.ApplyResources(this.txtRegisterRepeat, "txtRegisterRepeat");
            this.txtRegisterRepeat.Name = "txtRegisterRepeat";
            this.txtRegisterRepeat.UseSystemPasswordChar = true;
            this.txtRegisterRepeat.Click += new System.EventHandler(this.OnTextBoxFocus);
            this.txtRegisterRepeat.TextChanged += new System.EventHandler(this.OnRegisterFormFilling);
            this.txtRegisterRepeat.Enter += new System.EventHandler(this.OnTextBoxFocus);
            // 
            // txtRegisterUsername
            // 
            resources.ApplyResources(this.txtRegisterUsername, "txtRegisterUsername");
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Click += new System.EventHandler(this.OnTextBoxFocus);
            this.txtRegisterUsername.TextChanged += new System.EventHandler(this.OnRegisterFormFilling);
            this.txtRegisterUsername.Enter += new System.EventHandler(this.OnTextBoxFocus);
            // 
            // txtRegisterPassword
            // 
            resources.ApplyResources(this.txtRegisterPassword, "txtRegisterPassword");
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            this.txtRegisterPassword.Click += new System.EventHandler(this.OnTextBoxFocus);
            this.txtRegisterPassword.TextChanged += new System.EventHandler(this.OnRegisterFormFilling);
            this.txtRegisterPassword.Enter += new System.EventHandler(this.OnTextBoxFocus);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.TextBox txtRegisterRepeat;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnRegisterConfirm;
        private System.Windows.Forms.Button btnLogin;
    }
}

