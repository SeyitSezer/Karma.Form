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
    }


}