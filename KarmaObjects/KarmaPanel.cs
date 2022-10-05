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
    public partial class KarmaPanel : GroupControl
    {
        public KarmaPanel()
        {
            InitializeComponent();
            //if (!(Parent is null))
            //    BackColor = Parent.BackColor;
            if (Text.Length <= 0 || Text == Name) ShowCaption = false;
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }
        public override string Text
        {
            get
            {
                ShowCaption = (base.Text.Length > 0 && base.Text != Name);
                return base.Text;
            }
            set => base.Text = value;
        }
        public KarmaPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        KarmaGrid controlgrid;
        public string KarmaTableName { get; set; }
        public string KarmaColumnNames { get; set; }
        public KarmaObject KarmaMasterTextBox { get; set; }
        public KarmaObject KarmaSecTextBox { get; set; }
        public KarmaButton KarmaMasterButton { get; set; }
        public KarmaGrid KarmaGridControl { get { return controlgrid; } set { controlgrid = value; if (!(controlgrid is null)) controlgrid.MasterPanel = this; } }
        public List<KarmaPanel> KarmaChildPanels = new List<KarmaPanel>();
        public void AddChildPanel(KarmaPanel panel)
        {
            bool sonuc = false;
            foreach (var x in KarmaChildPanels)
            {
                sonuc = x == panel;
                if (sonuc) break;
            }
            if (!sonuc) KarmaChildPanels.Add(panel);
        }

        public bool KarmaAddSirketWhere { get; set; } = false;
        public bool KarmaAddYilWhere { get; set; } = false;
        string SQLFilter
        {
            get
            {
                string x = KarmaMasterTextBox.KarmaFieldName + "=" + KarmaMasterTextBox.GetSQLText;
                if (!(KarmaSecTextBox is null))
                    x += " AND " + KarmaSecTextBox.KarmaFieldName + "=" + KarmaSecTextBox.GetSQLText;

                return x;
            }
        }

        public void KarmaOnPost()
        {
            if (!(KarmaMasterTextBox is null) && !string.IsNullOrEmpty(KarmaTableName) && !KarmaMasterTextBox.IsNull)
            {
                List<string> Columns = new List<string>();
                List<object> Values = new List<object>();
                Columns.Add(KarmaMasterTextBox.KarmaFieldName);
                Values.Add(KarmaMasterTextBox.GetFieldData);
                if (!(KarmaSecTextBox is null))
                {
                    Columns.Add(KarmaSecTextBox.KarmaFieldName);
                    Values.Add(KarmaSecTextBox.GetFieldData);
                }
                foreach (Control a in Controls)
                {
                    if (a is KarmaObject && a != KarmaMasterTextBox)
                    {
                        if ((!(KarmaSecTextBox is null) && a != KarmaSecTextBox) || KarmaSecTextBox is null)
                        {
                            if (!string.IsNullOrEmpty((a as KarmaObject).KarmaFieldName))
                            {
                                Columns.Add((a as KarmaObject).KarmaFieldName);
                                Values.Add((a as KarmaObject).GetFieldData);
                            }
                        }
                    }

                }
                if (GetSQLData("SELECT * FROM " + KarmaTableName + " WHERE " + SQLFilter, KarmaAddSirketWhere, KarmaAddYilWhere).Rows.Count == 0)
                    Insert(KarmaTableName, Columns, Values);
                else
                    UpdateData(KarmaTableName, Columns, Values, " AND " + SQLFilter);
                if (!(KarmaGridControl is null))
                {
                    KarmaGridControl.GetData(KarmaGridControl.KarmaSQLText);
                }
            }
            foreach (var item in KarmaChildPanels)
            {
                item.KarmaOnPost();
            }
            KarmaOnNew();
        }

        public void KarmaOnDelete()
        {
            if (!(KarmaMasterTextBox is null) && !string.IsNullOrEmpty(KarmaTableName) && !KarmaMasterTextBox.IsNull)
            {
                DeleteData(KarmaTableName, SQLFilter);
            }
            if (!(KarmaGridControl is null))
            {
                KarmaGridControl.GetData(KarmaGridControl.KarmaSQLText);
            }
            foreach (var item in KarmaChildPanels)
            {
                item.KarmaOnDelete();
                KarmaOnNew();
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
                    if (_cnt is KarmaCheck)
                    {
                        (_cnt as KarmaCheck).IsOn = false;
                    }
                }
            }
            foreach (var item in KarmaChildPanels)
            {
                item.KarmaOnNew();
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
                        if (_cnt is KarmaCheck)
                        {
                            if (a.FieldName == (_cnt as KarmaCheck).KarmaFieldName)
                                (_cnt as KarmaCheck).IsOn = ((GridView)KarmaGridControl.MainView).GetRowCellValue(((GridView)KarmaGridControl.MainView).FocusedRowHandle, a.FieldName).ToString() == (_cnt as KarmaCheck).KarmaCheckedValue;
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
                var x = GetSQLData("SELECT * FROM " + KarmaTableName + " WHERE " + SQLFilter, KarmaAddSirketWhere, KarmaAddYilWhere);
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
                                            case KarmaFieldTypes.String:
                                                (a as KarmaComboBox).EditValue = x.Rows[0][c].ToString();
                                                break;
                                            case KarmaFieldTypes.Date:
                                                (a as KarmaComboBox).EditValue = Convert.ToDateTime(x.Rows[0][c].ToString());
                                                break;
                                            case KarmaFieldTypes.Time:
                                                (a as KarmaComboBox).EditValue = Convert.ToDateTime(x.Rows[0][c].ToString());
                                                break;
                                            case KarmaFieldTypes.Numeric:
                                                (a as KarmaComboBox).EditValue = x.Rows[0][c].ToInt();
                                                break;
                                            case KarmaFieldTypes.Guide:
                                                (a as KarmaComboBox).EditValue = x.Rows[0][c].ToString();
                                                break;
                                            default:
                                                break;
                                        }

                                    }
                                }
                            }
                            else if (a is KarmaCheck)
                            {
                                if ((a as KarmaCheck).KarmaFieldName == c.ColumnName)
                                    (a as KarmaCheck).IsOn = (a as KarmaCheck).KarmaCheckedValue.ToLower() == x.Rows[0][c].ToString().ToLower();
                            }
                        }
                    }
                }
            }
            foreach (var item in KarmaChildPanels)
            {
                item.KarmaLoadFromTable();
            }
        }
    }
}
