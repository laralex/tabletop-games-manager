namespace GameClient.GUI.Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginSubform = new GameClient.GUI.Login.LoginFields();
            this.registrationSubform = new GameClient.GUI.Login.RegistrationFields();
            this.SuspendLayout();
            // 
            // loginSubform
            // 
            resources.ApplyResources(this.loginSubform, "loginSubform");
            this.loginSubform.Name = "loginSubform";
            // 
            // registrationSubform
            // 
            resources.ApplyResources(this.registrationSubform, "registrationSubform");
            this.registrationSubform.Name = "registrationSubform";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginSubform);
            this.Controls.Add(this.registrationSubform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginFields loginSubform;
        private RegistrationFields registrationSubform;
    }
}

