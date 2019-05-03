namespace Player.GUI.Application
{
    partial class AppForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serverInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.diceGameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFromServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFromothersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFromAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.createNewServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lobbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.diceRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLobby = new System.Windows.Forms.StatusStrip();
            this.statusLobbyUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLobbyBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tabLobby = new System.Windows.Forms.TabPage();
            this.serversList1 = new Player.GUI.ServerManager.ServersList();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.contextMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusLobby.SuspendLayout();
            this.tabLobby.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverInfoToolStripMenuItem1,
            this.diceGameRulesToolStripMenuItem,
            this.disconnectFromServerToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(197, 70);
            // 
            // serverInfoToolStripMenuItem1
            // 
            this.serverInfoToolStripMenuItem1.Name = "serverInfoToolStripMenuItem1";
            this.serverInfoToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.serverInfoToolStripMenuItem1.Text = "Server Info";
            // 
            // diceGameRulesToolStripMenuItem
            // 
            this.diceGameRulesToolStripMenuItem.Name = "diceGameRulesToolStripMenuItem";
            this.diceGameRulesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.diceGameRulesToolStripMenuItem.Text = "Dice game rules";
            // 
            // disconnectFromServerToolStripMenuItem
            // 
            this.disconnectFromServerToolStripMenuItem.Name = "disconnectFromServerToolStripMenuItem";
            this.disconnectFromServerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.disconnectFromServerToolStripMenuItem.Text = "Disconnect from server";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.applicationToolStripMenuItem,
            this.seversToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(417, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "&Application";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // seversToolStripMenuItem
            // 
            this.seversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentServerToolStripMenuItem,
            this.connectedServersToolStripMenuItem,
            this.toolStripSeparator1,
            this.createNewServerToolStripMenuItem,
            this.connectToServerToolStripMenuItem,
            this.lobbyToolStripMenuItem});
            this.seversToolStripMenuItem.Name = "seversToolStripMenuItem";
            this.seversToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.seversToolStripMenuItem.Text = "&Servers";
            // 
            // currentServerToolStripMenuItem
            // 
            this.currentServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverInfoToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.disconnectFromothersToolStripMenuItem});
            this.currentServerToolStripMenuItem.Name = "currentServerToolStripMenuItem";
            this.currentServerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.currentServerToolStripMenuItem.Text = "&Current server";
            // 
            // serverInfoToolStripMenuItem
            // 
            this.serverInfoToolStripMenuItem.Name = "serverInfoToolStripMenuItem";
            this.serverInfoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.serverInfoToolStripMenuItem.Text = "Server &Info";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            // 
            // disconnectFromothersToolStripMenuItem
            // 
            this.disconnectFromothersToolStripMenuItem.Name = "disconnectFromothersToolStripMenuItem";
            this.disconnectFromothersToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.disconnectFromothersToolStripMenuItem.Text = "Disconnect from &others";
            // 
            // connectedServersToolStripMenuItem
            // 
            this.connectedServersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectFromAllToolStripMenuItem});
            this.connectedServersToolStripMenuItem.Name = "connectedServersToolStripMenuItem";
            this.connectedServersToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.connectedServersToolStripMenuItem.Text = "&All servers";
            // 
            // disconnectFromAllToolStripMenuItem
            // 
            this.disconnectFromAllToolStripMenuItem.Name = "disconnectFromAllToolStripMenuItem";
            this.disconnectFromAllToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.disconnectFromAllToolStripMenuItem.Text = "&Disconnect from all";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // createNewServerToolStripMenuItem
            // 
            this.createNewServerToolStripMenuItem.Name = "createNewServerToolStripMenuItem";
            this.createNewServerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.createNewServerToolStripMenuItem.Text = "&New server";
            // 
            // connectToServerToolStripMenuItem
            // 
            this.connectToServerToolStripMenuItem.Name = "connectToServerToolStripMenuItem";
            this.connectToServerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.connectToServerToolStripMenuItem.Text = "Connec&t to server";
            // 
            // lobbyToolStripMenuItem
            // 
            this.lobbyToolStripMenuItem.Name = "lobbyToolStripMenuItem";
            this.lobbyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lobbyToolStripMenuItem.Text = "&Lobby";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationFeaturesToolStripMenuItem,
            this.toolStripSeparator2,
            this.diceRulesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // applicationFeaturesToolStripMenuItem
            // 
            this.applicationFeaturesToolStripMenuItem.Name = "applicationFeaturesToolStripMenuItem";
            this.applicationFeaturesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.applicationFeaturesToolStripMenuItem.Text = "How to use game manager";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // diceRulesToolStripMenuItem
            // 
            this.diceRulesToolStripMenuItem.Name = "diceRulesToolStripMenuItem";
            this.diceRulesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.diceRulesToolStripMenuItem.Text = "Dice rules";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnMenuAbout);
            // 
            // statusLobby
            // 
            this.statusLobby.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLobbyUser,
            this.statusLobbyBar});
            this.statusLobby.Location = new System.Drawing.Point(0, 339);
            this.statusLobby.Name = "statusLobby";
            this.statusLobby.Size = new System.Drawing.Size(417, 22);
            this.statusLobby.TabIndex = 3;
            this.statusLobby.Text = "statusStrip1";
            // 
            // statusLobbyUser
            // 
            this.statusLobbyUser.Name = "statusLobbyUser";
            this.statusLobbyUser.Size = new System.Drawing.Size(102, 17);
            this.statusLobbyUser.Text = "User: USER_NAME";
            // 
            // statusLobbyBar
            // 
            this.statusLobbyBar.Name = "statusLobbyBar";
            this.statusLobbyBar.Size = new System.Drawing.Size(100, 16);
            // 
            // tabLobby
            // 
            this.tabLobby.Controls.Add(this.serversList1);
            this.tabLobby.Location = new System.Drawing.Point(4, 22);
            this.tabLobby.Name = "tabLobby";
            this.tabLobby.Padding = new System.Windows.Forms.Padding(3);
            this.tabLobby.Size = new System.Drawing.Size(409, 289);
            this.tabLobby.TabIndex = 0;
            this.tabLobby.Text = "Lobby";
            this.tabLobby.UseVisualStyleBackColor = true;
            // 
            // serversList1
            // 
            this.serversList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.serversList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversList1.Location = new System.Drawing.Point(3, 3);
            this.serversList1.Name = "serversList1";
            this.serversList1.Size = new System.Drawing.Size(403, 283);
            this.serversList1.TabIndex = 0;
            // 
            // tabsControl
            // 
            this.tabsControl.ContextMenuStrip = this.contextMenu;
            this.tabsControl.Controls.Add(this.tabLobby);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Location = new System.Drawing.Point(0, 24);
            this.tabsControl.Multiline = true;
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(417, 315);
            this.tabsControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabsControl.TabIndex = 4;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(417, 361);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.statusLobby);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(430, 400);
            this.Name = "AppForm";
            this.Text = "Lar.Alex Games";
            this.contextMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusLobby.ResumeLayout(false);
            this.statusLobby.PerformLayout();
            this.tabLobby.ResumeLayout(false);
            this.tabsControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFromothersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFromAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem createNewServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lobbyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationFeaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diceRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem diceGameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFromServerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusLobby;
        private System.Windows.Forms.ToolStripStatusLabel statusLobbyUser;
        private System.Windows.Forms.ToolStripProgressBar statusLobbyBar;
        private System.Windows.Forms.TabPage tabLobby;
        private ServerManager.ServersList serversList1;
        private System.Windows.Forms.TabControl tabsControl;
    }
}