using System;
using System.Drawing;
using DevExpress.XtraEditors;
using System.IO;
using static KarmaLib.KarmaLib;
using static KarmaLib.KarmaSQL;
using DevExpress.XtraTab;
using System.Windows.Forms;

namespace KarmaObjects
{
    public partial class KarmaForm : XtraForm
    {
        public KarmaForm()
        {
            InitializeComponent();
        }
        bool NavigatorPanel, NavFirstButton, NavPreviousButton, NavNextButton, NavLastButton, NavNewButton, NavSaveButton, NavClearButton, NavDeleteButton;

        public string KarmaTableName { get; set; }

        public bool KarmaNavigatorPanel { get { return NavigatorPanel; } set { NavigatorPanel = value; SetNavigatorPanel(); } }
        public bool KarmaNavFirstButton { get { return NavFirstButton; } set { NavFirstButton = value; SetNavigatorPanel(); } }
        public bool KarmaNavPreviousButton { get { return NavPreviousButton; } set { NavPreviousButton = value; SetNavigatorPanel(); } }
        public bool KarmaNavNextButton { get { return NavNextButton; } set { NavNextButton = value; SetNavigatorPanel(); } }
        public bool KarmaNavLastButton { get { return NavLastButton; } set { NavLastButton = value; SetNavigatorPanel(); } }

        

        public bool KarmaNavNewButton { get { return NavNewButton; } set { NavNewButton = value; SetNavigatorPanel(); } }
        public bool KarmaNavSaveButton { get { return NavSaveButton; } set { NavSaveButton = value; SetNavigatorPanel(); } }
        public bool KarmaNavClearButton { get { return NavClearButton; } set { NavClearButton = value; SetNavigatorPanel(); } }
        public bool KarmaNavDeleteButton { get { return NavDeleteButton; } set { NavDeleteButton = value; SetNavigatorPanel(); } }

        private void SetNavigatorPanel()
        {
            PnlNavigator.Visible = NavigatorPanel;
            BtnFirst.Visible = NavFirstButton;
            BtnPrevious.Visible = NavPreviousButton;
            BtnNext.Visible = NavNextButton;
            BtnLast.Visible = NavNextButton;
            BtnNew.Visible = NavNewButton;
            BtnSave.Visible = NavSaveButton;
            BtnDelete.Visible = NavDeleteButton;
            BtnClear.Visible = NavClearButton;
        }
        protected override void OnCreateControl()
        {
            SetNavigatorPanel();
            base.OnCreateControl();
        }

        private void KarmaForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                if (Parent is null)
                {

                }
                else
                {
                    (Parent as XtraTabPage).TabControl.TabPages.Remove((Parent as XtraTabPage));
                }
            }
        }
        public event NewButtonClick KFNewButtonClick;
        public delegate void NewButtonClick(object Sender, EventArgs e);
        public event DeleteButtonClick KFDeleteButtonClick;
        public delegate void DeleteButtonClick(object Sender, EventArgs e);
        public event ClearButtonClick KFClearButtonClick;
        public delegate void ClearButtonClick(object Sender, EventArgs e);
        public event SaveButtonClick KFSaveButtonClick;
        public delegate void SaveButtonClick(object Sender, EventArgs e);
        public event FirstButtonClick KFFirstButtonClick;
        public delegate void FirstButtonClick(object Sender, EventArgs e);
        public event PrevButtonClick KFPrevButtonClick;
        public delegate void PrevButtonClick(object Sender, EventArgs e);
        public event NextButtonClick KFNextButtonClick;
        public delegate void NextButtonClick(object Sender, EventArgs e);
        public event LastButtonClick KFLastButtonClick;
        public delegate void LastButtonClick(object Sender, EventArgs e);
        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (!(KFNewButtonClick is null)) KFNewButtonClick(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!(KFDeleteButtonClick is null)) KFDeleteButtonClick(sender, e);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (!(KFClearButtonClick is null)) KFClearButtonClick(sender, e);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!(KFSaveButtonClick is null)) KFSaveButtonClick(sender, e);
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            if (!(KFFirstButtonClick is null)) KFFirstButtonClick(sender, e);
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (!(KFPrevButtonClick is null)) KFPrevButtonClick(sender, e);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!(KFNextButtonClick is null)) KFNextButtonClick(sender, e);
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            if (!(KFLastButtonClick is null)) KFLastButtonClick(sender, e);
        }

    }


}