namespace Player.GUI.ServerManager
{
    partial class ServerCreationForm
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
            System.Windows.Forms.Button btnToDefaults;
            System.Windows.Forms.Panel pnlButtons;
            System.Windows.Forms.TableLayoutPanel tableLayout;
            this.btnOK = new System.Windows.Forms.Button();
            this.serverSubform = new Player.GUI.ServerManager.CommonServerOptions();
            this.dicegameSubform = new Player.GUI.ServerManager.DiceServerOptions();
            btnToDefaults = new System.Windows.Forms.Button();
            pnlButtons = new System.Windows.Forms.Panel();
            tableLayout = new System.Windows.Forms.TableLayoutPanel();
            pnlButtons.SuspendLayout();
            tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(9, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OnServerCreation);
            // 
            // btnToDefaults
            // 
            btnToDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnToDefaults.Location = new System.Drawing.Point(200, 10);
            btnToDefaults.Name = "btnToDefaults";
            btnToDefaults.Size = new System.Drawing.Size(75, 23);
            btnToDefaults.TabIndex = 4;
            btnToDefaults.Text = "To defaults";
            btnToDefaults.UseVisualStyleBackColor = true;
            btnToDefaults.Click += new System.EventHandler(this.OnToDefaults);
            // 
            // pnlButtons
            // 
            pnlButtons.AutoSize = true;
            pnlButtons.Controls.Add(this.btnOK);
            pnlButtons.Controls.Add(btnToDefaults);
            pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlButtons.Location = new System.Drawing.Point(3, 511);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new System.Drawing.Size(287, 45);
            pnlButtons.TabIndex = 5;
            // 
            // tableLayout
            // 
            tableLayout.AutoSize = true;
            tableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayout.ColumnCount = 1;
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayout.Controls.Add(this.serverSubform, 0, 0);
            tableLayout.Controls.Add(this.dicegameSubform, 0, 1);
            tableLayout.Controls.Add(pnlButtons, 0, 2);
            tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayout.Location = new System.Drawing.Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 3;
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayout.Size = new System.Drawing.Size(189, 265);
            tableLayout.TabIndex = 6;
            // 
            // serverSubform
            // 
            this.serverSubform.AutoSize = true;
            this.serverSubform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.serverSubform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverSubform.Location = new System.Drawing.Point(3, 3);
            this.serverSubform.Name = "serverSubform";
            this.serverSubform.Size = new System.Drawing.Size(287, 77);
            this.serverSubform.TabIndex = 2;
            // 
            // dicegameSubform
            // 
            this.dicegameSubform.AutoSize = true;
            this.dicegameSubform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dicegameSubform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dicegameSubform.Location = new System.Drawing.Point(3, 113);
            this.dicegameSubform.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.dicegameSubform.Name = "dicegameSubform";
            this.dicegameSubform.Size = new System.Drawing.Size(287, 365);
            this.dicegameSubform.TabIndex = 1;
            // 
            // ServerCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(189, 265);
            this.Controls.Add(tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ServerCreationForm";
            this.Text = "Create new server";
            pnlButtons.ResumeLayout(false);
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DiceServerOptions dicegameSubform;
        private CommonServerOptions serverSubform;
        private System.Windows.Forms.Button btnOK;
    }
}