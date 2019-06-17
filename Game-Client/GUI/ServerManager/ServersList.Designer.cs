namespace GameClient.GUI.ServerManager
{
    partial class ServersList
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
            this.tblServersList = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAllServers = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCreateServer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblServersList)).BeginInit();
            this.SuspendLayout();
            // 
            // tblServersList
            // 
            this.tblServersList.AllowUserToAddRows = false;
            this.tblServersList.AllowUserToDeleteRows = false;
            this.tblServersList.AllowUserToResizeRows = false;
            this.tblServersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblServersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblServersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colPlayers});
            this.tblServersList.Location = new System.Drawing.Point(7, 37);
            this.tblServersList.Margin = new System.Windows.Forms.Padding(10);
            this.tblServersList.Name = "tblServersList";
            this.tblServersList.ReadOnly = true;
            this.tblServersList.RowHeadersVisible = false;
            this.tblServersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblServersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblServersList.Size = new System.Drawing.Size(405, 295);
            this.tblServersList.TabIndex = 0;
            this.tblServersList.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.OnSortCompare);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Server";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPlayers
            // 
            this.colPlayers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPlayers.FillWeight = 58.40708F;
            this.colPlayers.HeaderText = "Players";
            this.colPlayers.Name = "colPlayers";
            this.colPlayers.ReadOnly = true;
            this.colPlayers.Width = 66;
            // 
            // lblAllServers
            // 
            this.lblAllServers.AutoSize = true;
            this.lblAllServers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllServers.Location = new System.Drawing.Point(26, 10);
            this.lblAllServers.Name = "lblAllServers";
            this.lblAllServers.Size = new System.Drawing.Size(87, 21);
            this.lblAllServers.TabIndex = 1;
            this.lblAllServers.Text = "All Servers";
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(134, 8);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.OnJoin);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(215, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.OnRefresh);
            // 
            // btnCreateServer
            // 
            this.btnCreateServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateServer.Location = new System.Drawing.Point(324, 8);
            this.btnCreateServer.Name = "btnCreateServer";
            this.btnCreateServer.Size = new System.Drawing.Size(88, 23);
            this.btnCreateServer.TabIndex = 4;
            this.btnCreateServer.Text = "New Server";
            this.btnCreateServer.UseVisualStyleBackColor = true;
            this.btnCreateServer.Click += new System.EventHandler(this.OnNewServer);
            // 
            // ServersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnCreateServer);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.lblAllServers);
            this.Controls.Add(this.tblServersList);
            this.Name = "ServersList";
            this.Size = new System.Drawing.Size(422, 342);
            ((System.ComponentModel.ISupportInitialize)(this.tblServersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblServersList;
        private System.Windows.Forms.Label lblAllServers;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCreateServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlayers;
    }
}
