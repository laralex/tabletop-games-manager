namespace GameClient.GUI.Application
{
    partial class AppFormDemo
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
            this.seversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFromAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.diceRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLobby = new System.Windows.Forms.StatusStrip();
            this.statusLobbyUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabLobby = new System.Windows.Forms.TabPage();
            this.lobbyServersList = new GameClient.GUI.ServerManager.ServersList();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.diceGame1 = new GameClient.GUI.DiceGame.DiceGameControl();
            this.contextMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusLobby.SuspendLayout();
            this.tabLobby.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.tabGame.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(764, 24);
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
            this.logOutToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "&Application";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.OnLogOut);
            // 
            // seversToolStripMenuItem
            // 
            this.seversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentServerToolStripMenuItem,
            this.connectedServersToolStripMenuItem});
            this.seversToolStripMenuItem.Enabled = false;
            this.seversToolStripMenuItem.Name = "seversToolStripMenuItem";
            this.seversToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.seversToolStripMenuItem.Text = "&Servers";
            // 
            // currentServerToolStripMenuItem
            // 
            this.currentServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverInfoToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.currentServerToolStripMenuItem.Name = "currentServerToolStripMenuItem";
            this.currentServerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.currentServerToolStripMenuItem.Text = "&Current server";
            // 
            // serverInfoToolStripMenuItem
            // 
            this.serverInfoToolStripMenuItem.Name = "serverInfoToolStripMenuItem";
            this.serverInfoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.serverInfoToolStripMenuItem.Text = "Server &Info";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            // 
            // connectedServersToolStripMenuItem
            // 
            this.connectedServersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectFromAllToolStripMenuItem});
            this.connectedServersToolStripMenuItem.Name = "connectedServersToolStripMenuItem";
            this.connectedServersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.connectedServersToolStripMenuItem.Text = "&All servers";
            // 
            // disconnectFromAllToolStripMenuItem
            // 
            this.disconnectFromAllToolStripMenuItem.Name = "disconnectFromAllToolStripMenuItem";
            this.disconnectFromAllToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.disconnectFromAllToolStripMenuItem.Text = "&Disconnect from all";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationFeaturesToolStripMenuItem,
            this.toolStripSeparator2,
            this.diceRulesToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
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
            this.statusLobbyUser});
            this.statusLobby.Location = new System.Drawing.Point(0, 473);
            this.statusLobby.Name = "statusLobby";
            this.statusLobby.Size = new System.Drawing.Size(764, 22);
            this.statusLobby.TabIndex = 3;
            this.statusLobby.Text = "statusStrip1";
            // 
            // statusLobbyUser
            // 
            this.statusLobbyUser.Name = "statusLobbyUser";
            this.statusLobbyUser.Size = new System.Drawing.Size(102, 17);
            this.statusLobbyUser.Text = "User: USER_NAME";
            // 
            // tabLobby
            // 
            this.tabLobby.Controls.Add(this.lobbyServersList);
            this.tabLobby.Location = new System.Drawing.Point(4, 22);
            this.tabLobby.Name = "tabLobby";
            this.tabLobby.Padding = new System.Windows.Forms.Padding(3);
            this.tabLobby.Size = new System.Drawing.Size(756, 423);
            this.tabLobby.TabIndex = 0;
            this.tabLobby.Text = "Lobby";
            this.tabLobby.UseVisualStyleBackColor = true;
            // 
            // lobbyServersList
            // 
            this.lobbyServersList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lobbyServersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lobbyServersList.Location = new System.Drawing.Point(3, 3);
            this.lobbyServersList.Name = "lobbyServersList";
            this.lobbyServersList.Size = new System.Drawing.Size(750, 417);
            this.lobbyServersList.TabIndex = 0;
            // 
            // tabsControl
            // 
            this.tabsControl.ContextMenuStrip = this.contextMenu;
            this.tabsControl.Controls.Add(this.tabLobby);
            this.tabsControl.Controls.Add(this.tabGame);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Location = new System.Drawing.Point(0, 24);
            this.tabsControl.Multiline = true;
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(764, 449);
            this.tabsControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabsControl.TabIndex = 4;
            // 
            // tabGame
            // 
            this.tabGame.Controls.Add(this.diceGame1);
            this.tabGame.Location = new System.Drawing.Point(4, 22);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(756, 423);
            this.tabGame.TabIndex = 1;
            this.tabGame.Text = "[Dice] Laralex";
            this.tabGame.UseVisualStyleBackColor = true;
            // 
            // diceGame1
            // 
            this.diceGame1.AutoSize = true;
            this.diceGame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diceGame1.Location = new System.Drawing.Point(3, 3);
            this.diceGame1.Name = "diceGame1";
            this.diceGame1.Size = new System.Drawing.Size(750, 417);
            this.diceGame1.TabIndex = 0;
            // 
            // AppFormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(764, 495);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.statusLobby);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(430, 400);
            this.Name = "AppFormDemo";
            this.Text = "Lar Game Manager";
            this.contextMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusLobby.ResumeLayout(false);
            this.statusLobby.PerformLayout();
            this.tabLobby.ResumeLayout(false);
            this.tabsControl.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem connectedServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFromAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationFeaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diceRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem diceGameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFromServerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusLobby;
        private System.Windows.Forms.ToolStripStatusLabel statusLobbyUser;
        private System.Windows.Forms.TabPage tabLobby;
        private ServerManager.ServersList lobbyServersList;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabGame;
        private DiceGame.DiceGameControl diceGame1;
    }
}