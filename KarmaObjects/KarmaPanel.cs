using DevExpress.DataAccess.Native.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KarmaLib.KarmaLib;
using static KarmaLib.KarmaSQL;

namespace KarmaObjects
{
    public partial class KarmaPanel : PanelControl
    {
        public KarmaPanel()
        {
            InitializeComponent();
            if (!(Parent is null))
            BackColor = Parent.BackColor;
        }

        public KarmaPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        KarmaGrid controlgrid;
        public string KarmaTableName { get; set; }
        public string KarmaColumnNames { get; set; }
        public KarmaTextBox KarmaMasterTextBox { get; set; }
        public KarmaButton KarmaMasterButton { get; set; }
        public KarmaGrid KarmaGridControl { get { return controlgrid; } set { controlgrid = value; if (!(controlgrid is null)) controlgrid.MasterPanel = this; } }
        public KarmaPanel[] KarmaChildPanels { get; set; }

        public void KarmaOnPost()
        {
            if (!(KarmaMasterTextBox is null) && !string.IsNullOrEmpty(KarmaTableName) && !KarmaMasterTextBox.IsNull)
            {
                List<string> Columns = new List<string>();
                List<object> Values = new List<object>();
                Columns.Add(KarmaMasterTextBox.KarmaFieldName);
                Values.Add(KarmaMasterTextBox.GetFieldData);
                foreach (Control a in Controls)
                {
                    if (a is KarmaTextBox && a != KarmaMasterTextBox)
                    {
                        Columns.Add((a as KarmaTextBox).KarmaFieldName);
                        Values.Add((a as KarmaTextBox).GetFieldData);
                    }
                    else if (a is KarmaComboBox)
                    {
                        Columns.Add((a as KarmaComboBox).KarmaFieldName);
                        Values.Add((a as KarmaComboBox).GetFieldData);
                    }
                }
                if (GetSQLData("SELECT * FROM " + KarmaTableName + " WHERE " + KarmaMasterTextBox.KarmaFieldName + "=" + KarmaMasterTextBox.GetSQLText).Rows.Count == 0)
                    Insert(KarmaTableName, Columns, Values);
                else
                    UpdateData(KarmaTableName, Columns, Values, " AND " + KarmaMasterTextBox.KarmaFieldName + "=" + KarmaMasterTextBox.GetSQLText);
                KarmaOnNew();
                if (!(KarmaGridControl is null))
                {
                    KarmaGridControl.GetData(KarmaGridControl.KarmaSQLText);
                }
            }
        }

        public void KarmaOnDelete()
        {
            if (!(KarmaMasterTextBox is null) && !string.IsNullOrEmpty(KarmaTableName) && !KarmaMasterTextBox.IsNull)
            {
                DeleteData(KarmaTableName, KarmaMasterTextBox.KarmaFieldName + "=" + KarmaMasterTextBox.GetSQLText);
            }
            KarmaOnNew();
            if (!(KarmaGridControl is null))
            {
                KarmaGridControl.GetData(KarmaGridControl.KarmaSQLText);
            }
        }

        public void KarmaOnNew()
        {
            foreach (Control a in Controls)
            {
                foreach (Control _cnt in Controls)
                {
                    if (_cnt is KarmaTextBox)
                    {
                        (_cnt as KarmaTextBox).Text = "";
                    }
                    if (_cnt is KarmaComboBox)
                    {
                        (_cnt as KarmaComboBox).EditValue = null;
                    }
                }
            }
        }
        public void KarmaLoadFromGrid()
        {
            if (!(KarmaGridControl is null))
            {
                foreach (GridColumn a in ((GridView)KarmaGridControl.MainView).Columns)
                {
                    foreach (Control _cnt in Controls)
                    {
                        if (_cnt is KarmaTextBox)
                        {
                            if (a.FieldName == (_cnt as KarmaTextBox).KarmaFieldName)
                                (_cnt as KarmaTextBox).Text = ((GridView)KarmaGridControl.MainView).GetRowCellValue(((GridView)KarmaGridControl.MainView).FocusedRowHandle, a.FieldName).ToString();
                        }
                        if (_cnt is KarmaComboBox)
                        {
                            if (a.FieldName == (_cnt as KarmaComboBox).KarmaFieldName)
                                (_cnt as KarmaComboBox).EditValue = ((GridView)KarmaGridControl.MainView).GetRowCellValue(((GridView)KarmaGridControl.MainView).FocusedRowHandle, a.FieldName).ToString();
                        }
                    }

                }
            }
        }

        public void KarmaLoadFromTable()
        {
            if (!(KarmaMasterTextBox is null) && !string.IsNullOrEmpty(KarmaTableName) && !KarmaMasterTextBox.IsNull)
            {
                List<string> Columns = new List<string>();
                List<object> Values = new List<object>();
                var x = GetSQLData("SELECT * FROM " + KarmaTableName + " WHERE " + KarmaMasterTextBox.KarmaFieldName + "=" + KarmaMasterTextBox.GetSQLText);
                if (x.Rows.Count > 0)
                {
                    foreach (Control a in Controls)
                    {
                        foreach (System.Data.DataColumn c in x.Columns)
                        {
                            if (a is KarmaTextBox && a != KarmaMasterTextBox)
                            {
                                if ((a as KarmaTextBox).KarmaFieldName == c.ColumnName)
                                    (a as KarmaTextBox).Text = x.Rows[0][c].ToString();
                            }
                            else if (a is KarmaComboBox)
                            {
                                if ((a as KarmaComboBox).KarmaFieldName == c.ColumnName)
                                {
                                    if ((a as KarmaComboBox).KarmaValueType == KarmaValueTypes.ItemIndex)
                                        (a as KarmaComboBox).ItemIndex = x.Rows[0][c].ToInt();
                                    if ((a as KarmaComboBox).KarmaValueType == KarmaValueTypes.Text)
                                        (a as KarmaComboBox).SelectedText = x.Rows[0][c].ToString();
                                    if ((a as KarmaComboBox).KarmaValueType == KarmaValueTypes.Lookup)
                                    {
                                        switch ((a as KarmaComboBox).KarmaFieldType)
                                        {
                                            case KarmaFieldTypes.String: (a as KarmaComboBox).EditValue = x.Rows[0][c].ToString();
                                                break;
                                            case KarmaFieldTypes.Date: (a as KarmaComboBox).EditValue = Convert.ToDateTime(x.Rows[0][c].ToString());
                                                break;
                                            case KarmaFieldTypes.Time: (a as KarmaComboBox).EditValue = Convert.ToDateTime(x.Rows[0][c].ToString());
                                                break;
                                            case KarmaFieldTypes.Numeric: (a as KarmaComboBox).EditValue = x.Rows[0][c].ToInt();
                                                break;
                                            case KarmaFieldTypes.Guide: (a as KarmaComboBox).EditValue = x.Rows[0][c].ToString();
                                                break;
                                            default:
                                                break;
                                        }
                                        
                                    }
                                }                                    
                            }
                        }
                    }
                }
            }
        }
    }
}
