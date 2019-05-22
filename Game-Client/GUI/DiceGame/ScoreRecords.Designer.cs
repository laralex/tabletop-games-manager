namespace GameClient.GUI.DiceGame
{
    partial class ScoreRecords
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
            this.tblRecords = new System.Windows.Forms.DataGridView();
            this.colCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // tblRecords
            // 
            this.tblRecords.AllowUserToAddRows = false;
            this.tblRecords.AllowUserToDeleteRows = false;
            this.tblRecords.AllowUserToResizeColumns = false;
            this.tblRecords.AllowUserToResizeRows = false;
            this.tblRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tblRecords.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRecords.ColumnHeadersVisible = false;
            this.tblRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCombo,
            this.colScore});
            this.tblRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblRecords.Enabled = false;
            this.tblRecords.Location = new System.Drawing.Point(0, 0);
            this.tblRecords.Margin = new System.Windows.Forms.Padding(10);
            this.tblRecords.MultiSelect = false;
            this.tblRecords.Name = "tblRecords";
            this.tblRecords.ReadOnly = true;
            this.tblRecords.RowHeadersVisible = false;
            this.tblRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRecords.Size = new System.Drawing.Size(150, 150);
            this.tblRecords.TabIndex = 2;
            // 
            // colCombo
            // 
            this.colCombo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCombo.HeaderText = "Combo";
            this.colCombo.Name = "colCombo";
            this.colCombo.ReadOnly = true;
            this.colCombo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCombo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colScore
            // 
            this.colScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.colScore.FillWeight = 100.7449F;
            this.colScore.HeaderText = "Score";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colScore.Width = 5;
            // 
            // ScoreRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblRecords);
            this.Name = "ScoreRecords";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.tblRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView tblRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
    }
}
