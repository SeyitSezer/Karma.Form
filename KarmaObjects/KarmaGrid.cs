using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KarmaLib.KarmaLib;
using static KarmaLib.KarmaSQL;

namespace KarmaObjects
{
    public class KarmaGrid : GridControl
    {
        public GridView KarmaView = new GridView();
        #region Menü İşlemleri
        private ContextMenuStrip _PopupMenu;
        ToolStripMenuItem _ExportOptions ,_ExportCSV, _ExportDocX, _ExportPDF, _ExportXLS, _ExportXLSX, _ExportHTML, _ExportTxt;
        #endregion
        public KarmaGrid()
        {
            
        }
        public string KarmaSQLText { get; set; }
        public bool KarmaSQLCalistir { get; set; } = false;
        protected override void OnCreateControl()
        {
            if(ViewCollection.Count == 0 && !AppRunning)
            {
                KarmaView.GridControl = this;
                KarmaView.Name = this.Name.Replace("Grd", "View");
                KarmaView.OptionsFind.AlwaysVisible = true;
                KarmaView.OptionsFind.FindNullPrompt = "Arama Yapmak İçin Buraya Yazın";
                KarmaView.OptionsFind.ShowFindButton = false;
                KarmaView.OptionsView.BestFitMode = GridBestFitMode.Fast;
                KarmaView.GroupPanelText = "Gruplamak İçin Sütunu Sürükleyip Buraya Bırakın";
                KarmaView.FocusRectStyle = DrawFocusRectStyle.RowFullFocus;
                ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { KarmaView });
                MainView = KarmaView;
                KarmaView.OptionsMenu.EnableGroupPanelMenu = false;
                KarmaView.OptionsMenu.EnableColumnMenu = false;
            }
           
            base.OnCreateControl();
            ((GridView)MainView).OptionsBehavior.Editable = false;
            ((GridView)MainView).OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            if (!(ContextMenuStrip is null)) _PopupMenu = ContextMenuStrip;
            else
            {
                _PopupMenu = new ContextMenuStrip();
                ContextMenuStrip = _PopupMenu;
            }
            SetPopupMenu();
            if(KarmaSQLCalistir && !string.IsNullOrEmpty(KarmaSQLText))
            {
                DataSource = GetSQLData(KarmaSQLText);
            }
        }

        public void GetData(string SQLText)
        {

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

            _ExportOptions.DropDownItems.AddRange(new ToolStripMenuItem[]{ _ExportCSV , _ExportDocX, _ExportPDF, _ExportXLS, _ExportXLSX, _ExportHTML, _ExportTxt });
            _PopupMenu.Items.Add(_ExportOptions);
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
            return ((GridView)MainView).GetRowCellValue(((GridView)MainView).FocusedRowHandle,ColumnName);
        }
    }
}
