using KarmaObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using static KarmaLib.KarmaLib;
using static KarmaLib.KarmaSQL;
using static KarmaLib.KarmaTableHelper;
using KarmaStokLib;
using DevExpress.XtraTab;
using System.Threading;
using KarmaUserLib;
using KarmaLib;
using DevExpress.LookAndFeel;

namespace Karma_Form
{
    public partial class MainForm : KarmaForm
    {
        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void CreateForm(KarmaForm AcilacakForm)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                XtraTabPage _Page = new XtraTabPage();
                AcilacakForm.TopLevel = false;
                _Page.Controls.Add(AcilacakForm);
                AcilacakForm.Show();
                _Page.Text = AcilacakForm.Text;
                AcilacakForm.FormBorderStyle = FormBorderStyle.None;
                AcilacakForm.Dock = DockStyle.Fill;
                MainTabControl.TabPages.Add(_Page);
                MainTabControl.SelectedTabPage = _Page;
            });
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            KarmaLib.KarmaLib.MainForm = this;
            ConnectDB("SzrBase");
            AppRunning = true;
            StatusServerName.Caption = $"Çalışılan Şirket: {DatabaseName}({AppServer})";
            AppVersion.Caption = VersionInfos.KarmaFormExe;
            //GetTableColumnList("tblStocks");
            UserLookAndFeel.Default.SkinName = Properties.Settings.Default.Theme;
        }



        private void MnuStoklar_ItemClick(object sender, ItemClickEventArgs e)
        {
            PleaseWait(new Thread(() => CreateForm(new FrmStok())));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Theme = LookAndFeel.ActiveSkinName;
            Properties.Settings.Default.Palette = LookAndFeel.ActiveSvgPaletteName;
            Properties.Settings.Default.Save();
            e.Cancel = (DialogResult.Yes != Sor("Program Kapatılacak, Devam Edilsin Mi?", 1, "Onayınız Gerekiyor"));
        }

        private void MnuUserSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            PleaseWait(new Thread(() => CreateForm(new FrmUserSettings())));
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            PleaseWait(new Thread(() => CreateForm(new FrmStok())));
        }

        private void MainTabControl_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            SelectTheme.Enabled = MainTabControl.TabPages.Count <= 1;
        }
    }        
}
