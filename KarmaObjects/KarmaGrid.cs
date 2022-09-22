using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KarmaLib.KarmaLib;
using static KarmaLib.KarmaSQL;

namespace KarmaObjects
{
    
    public class KarmaGrid : GridControl
    {
        void KarmaView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            e.Info.ImageIndex = -1;
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle+1).ToString();
        }
        public GridView KarmaView = new GridView();
        #region Menü İşlemleri
        private ContextMenuStrip _PopupMenu;
        ToolStripMenuItem _ExportOptions, _ExportCSV, _ExportDocX, _ExportPDF, _ExportXLS, _ExportXLSX, _ExportHTML, _ExportTxt
            , _Yenile;
        #endregion
        public KarmaGrid()
        {
        }
        public KarmaPanel MasterPanel;
        public string KarmaSQLText { get; set; }
        public bool KarmaSQLCalistir { get; set; } = false;
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            //((GridView)MainView).IndicatorWidth = 30;
            ((GridView)MainView).GridControl = this;
            ((GridView)MainView).Name = this.Name.Replace("Grd", "View");
            ((GridView)MainView).OptionsFind.AlwaysVisible = true;
            ((GridView)MainView).OptionsFind.FindNullPrompt = "Arama Yapmak İçin Buraya Yazın";
            ((GridView)MainView).OptionsFind.ShowFindButton = false;
            ((GridView)MainView).OptionsView.BestFitMode = GridBestFitMode.Fast;
            ((GridView)MainView).GroupPanelText = "Gruplamak İçin Sütunu Sürükleyip Buraya Bırakın";
            ((GridView)MainView).FocusRectStyle = DrawFocusRectStyle.RowFullFocus;
            //ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { KarmaView });
            ((GridView)MainView).OptionsMenu.EnableGroupPanelMenu = false;
            ((GridView)MainView).OptionsMenu.EnableColumnMenu = false;
            ((GridView)MainView).OptionsBehavior.Editable = false;
            ((GridView)MainView).OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            ((GridView)MainView).OptionsFind.FindDelay = 100;
            ((GridView)MainView).OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            ((GridView)MainView).CustomDrawRowIndicator += KarmaView_CustomDrawRowIndicator;
            if (!(ContextMenuStrip is null)) _PopupMenu = ContextMenuStrip;
            else
            {
                _PopupMenu = new ContextMenuStrip();
                ContextMenuStrip = _PopupMenu;
            }
            SetPopupMenu();
            if (AppRunning && KarmaSQLCalistir && !string.IsNullOrEmpty(KarmaSQLText))
            {
                DataSource = GetSQLData(KarmaSQLText);
            }
        }

        public void GetData(string SQLText)
        {
            KarmaSQLText = SQLText;
            DataSource = GetSQLData(SQLText);
        }

        #region Menu İşlemleri
        private void SetPopupMenu()
        {
            _ExportOptions = new ToolStripMenuItem("Verileri Dışarıya Aktar");
            _ExportCSV = new ToolStripMenuItem("CSV Olarak Kaydet");
            _ExportCSV.Click += MnuExportCSVClick;

            _ExportDocX = new ToolStripMenuItem("DocX Olarak Kaydet");
            _ExportDocX.Click += MnuExportDocXClick;

            _ExportPDF = new ToolStripMenuItem("PDF Olarak Kaydet");
            _ExportPDF.Click += MnuExportPDFClick;

            _ExportXLS = new ToolStripMenuItem("XLS Olarak Kaydet");
            _ExportXLS.Click += MnuExportXLSClick;

            _ExportHTML = new ToolStripMenuItem("Html Olarak Kaydet");
            _ExportHTML.Click += MnuExportHTMLClick;

            _ExportTxt = new ToolStripMenuItem("Txt Olarak Kaydet");
            _ExportTxt.Click += MnuExportTxtClick;

            _ExportXLSX = new ToolStripMenuItem("XLSX Olarak Kaydet");
            _ExportXLSX.Click += MnuExportXLSXClick;

            _Yenile = new ToolStripMenuItem("Yeniden Yükle");
            _Yenile.Click += _Yenile_Click;

            _ExportOptions.DropDownItems.AddRange(new ToolStripMenuItem[] { _ExportCSV, _ExportDocX, _ExportPDF, _ExportXLS, _ExportXLSX, _ExportHTML, _ExportTxt });
            _PopupMenu.Items.Add(_ExportOptions);
            _PopupMenu.Items.Add(_Yenile);
        }

        private void _Yenile_Click(object sender, EventArgs e)
        {
            GetData(KarmaSQLText);
        }

        private string _SaveExportFileName(string FileType)
        {
            SaveFileDialog _ExpSaveDialog = new SaveFileDialog();
            _ExpSaveDialog.Filter = FileType + " Dosyası|*." + FileType;
            _ExpSaveDialog.FileName = Name + "_" + DateTime.Now.ToString() + "." + FileType;
            _ExpSaveDialog.OverwritePrompt = false;
            _ExpSaveDialog.CreatePrompt = true;
            if (_ExpSaveDialog.ShowDialog() == DialogResult.OK)
                return _ExpSaveDialog.FileName;
            else
                return "";
        }
        public void MnuExportCSVClick(object Sender, EventArgs e)
        {
            var _FileName = _SaveExportFileName("Csv");
            if (_FileName != "") ExportToCsv(_FileName);
        }
        public void MnuExportDocXClick(object Sender, EventArgs e)
        {
            var _FileName = _SaveExportFileName("Docx");
            if (_FileName != "") ExportToCsv(_FileName);
        }
        public void MnuExportPDFClick(object Sender, EventArgs e)
        {
            var _FileName = _SaveExportFileName("Pdf");
            if (_FileName != "") ExportToCsv(_FileName);
        }
        public void MnuExportXLSClick(object Sender, EventArgs e)
        {
            var _FileName = _SaveExportFileName("Xls");
            if (_FileName != "") ExportToCsv(_FileName);
        }
        public void MnuExportXLSXClick(object Sender, EventArgs e)
        {
            var _FileName = _SaveExportFileName("Xlsx");
            if (_FileName != "") ExportToCsv(_FileName);
        }
        public void MnuExportHTMLClick(object Sender, EventArgs e)
        {
            var _FileName = _SaveExportFileName("Html");
            if (_FileName != "") ExportToCsv(_FileName);
        }
        public void MnuExportTxtClick(object Sender, EventArgs e)
        {
            var _FileName = _SaveExportFileName("Txt");
            if (_FileName != "") ExportToCsv(_FileName);
        }
        #endregion

        public object GetValueByColumnName(string ColumnName)
        {
            return ((GridView)MainView).GetRowCellValue(((GridView)MainView).FocusedRowHandle, ColumnName);
        }
        protected override void OnDoubleClick(EventArgs ev)
        {
            if (!(MasterPanel is null))
            {
                MasterPanel.KarmaLoadFromGrid();
                MasterPanel.Focus();
            }
            base.OnDoubleClick(ev);
        }
    }
}
