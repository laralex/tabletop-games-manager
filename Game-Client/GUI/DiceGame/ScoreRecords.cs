using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CommonLibrary.Model;
using CommonLibrary.Model.Common;

namespace GameClient.GUI.DiceGame
{
    public partial class ScoreRecords : UserControl, IResetable 
    {
        public bool CurrentComboIsVisible {
            get => _is_current_combo_visible;
            set
            {
                _is_current_combo_visible = value;
                tblRecords.Rows[tblRecords.Rows.Count-1].Visible = value;    
            }
        }
        public string CurrentComboName
        {
            get => (string)_current_combo_row.Cells[0].Value;
            set
            {
                _current_combo_row.Cells[0].Value = value;
            }
        }

        public int CurrentComboScore
        {
            get => (int)_current_combo_row.Cells[1].Value;
            set
            {
                _current_combo_row.Cells[1].Value = value;
            }
        }

        public bool Failure { get; set; }

        public ScoreRecords()
        {
            InitializeComponent();
            tblRecords.Rows.Add("Total", 0);
            tblRecords.Rows.Add("Combo", 0);
            _current_combo_row = tblRecords.Rows[1];
        }

        public void Reset()
        {
            Failure = false;
            CurrentComboIsVisible = false;
            tblRecords.Rows.Clear();
            tblRecords.Rows.Add("Total", 0);
            tblRecords.Rows[0].DefaultCellStyle.BackColor = Color.SandyBrown;
            tblRecords.ClearSelection();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Reset();
            tblRecords.RowsDefaultCellStyle.SelectionBackColor = tblRecords.DefaultCellStyle.BackColor;
            
            _current_combo_row.DefaultCellStyle.BackColor = _current_color;
            tblRecords.Rows.Add("1+5+5", 25);
            tblRecords.Rows.Add("Flash royale", 350);
            tblRecords.Rows.Add("Flash (4)", 1000);
            CurrentComboIsVisible = true;
            CurrentComboName = "3+3";
            CurrentComboScore = 50;
        }

        private Color _default_color = Color.SandyBrown;
        private Color _failure_color = Color.Crimson;
        private Color _current_color = Color.LightGray;

        private DataGridViewRow _current_combo_row;

        private bool _is_current_combo_visible;
        private string _current_combo_name;
    }
}
