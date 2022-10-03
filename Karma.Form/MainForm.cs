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
using static KarmaUserLib.UserLib;
using KarmaLib;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Drawing.Helpers;

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
            BildirimList.Width = 0;
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

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            Notifications();
        }

        public void Notifications()
        {
            BildirimList.Groups[0].Items.Clear();
            var x = GetUserNotifications(1).ToArray();
            NotifyButton.Caption = x.Length.ToString();
            if (x.Length > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!x[i].IsPopup)
                    {
                        GenelAlert.Show(this, x[i].NotifyModule, x[i].NotifyMessage);
                        UpdateData("tblUserNotify", new List<string> { "IsPopup" }, new List<object> { true }, " AND ID = " + x[i].NotifyID.ToString());
                    }
                    var btn = new KarmaBildirimItem(x[i].NotifyID, x[i].ClickEvent, x[i].NotifyModule, x[i].NotifyMessage, x[i].NotificationDate.ToString("dd.MM.yyyy hh:mm:ss"), NotifyButtonClick);
                    BildirimList.Groups[0].Items.Add(btn);
                }
            }
            else
            {
                foreach (var item in x)
                {
                    if (!item.IsPopup)
                    {
                        GenelAlert.Show(this, item.NotifyModule, item.NotifyMessage);
                        UpdateData("tblUserNotify", new List<string> { "IsPopup" }, new List<object> { true }, " AND ID = " + item.NotifyID.ToString());
                    }
                    var btn = new KarmaBildirimItem(item.NotifyID, item.ClickEvent, item.NotifyModule, item.NotifyMessage, item.NotificationDate.ToString("dd.MM.yyyy hh:mm:ss"), NotifyButtonClick);
                    BildirimList.Groups[0].Items.Add(btn);
                }
            }
        }

        private void NotifyButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            BildirimList.Width = BildirimList.Width > 0 ? 0 : 280;
        }

        private void NotifyButtonClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            KarmaBildirimItem item = (KarmaBildirimItem)e.Item;
            if (item.IsRead) return;
            var x = FindFormByName(item.EventForm);
            if (x == null) return;
            string deger = item.EventObject.Substring(item.EventObject.IndexOf(";")+1);

            if (x.Controls.Find(item.EventObject.Substring(0, item.EventObject.IndexOf(";")), true)[0] is KarmaTextBox)
                (x.Controls.Find(item.EventObject.Substring(0, item.EventObject.IndexOf(";")), true)[0] as KarmaTextBox).KarmaSetValue(deger);
            else if (x.Controls.Find(item.EventObject.Substring(0, item.EventObject.IndexOf(";")), true)[0] is KarmaCheck)
                (x.Controls.Find(item.EventObject.Substring(0, item.EventObject.IndexOf(";")), true)[0] as KarmaCheck).KarmaSetValue(deger);
            else if (x.Controls.Find(item.EventObject.Substring(0, item.EventObject.IndexOf(";")), true)[0] is KarmaComboBox)
                (x.Controls.Find(item.EventObject.Substring(0, item.EventObject.IndexOf(";")), true)[0] as KarmaComboBox).KarmaSetValue(deger);

            PleaseWait(new Thread(() => CreateForm((KarmaForm)x)));
            x.ActiveControl = x.Controls.Find(item.EventObject.Substring(0, item.EventObject.IndexOf(";")), true)[0];
            x.Controls.Find(item.EventObject.Substring(0, item.EventObject.IndexOf(";")), true)[0].Focus();
            item.IsRead = true;
            UpdateData("tblUserNotify", new List<string>() { "IsRead", "ReadDate" }, new List<object>() { true, DateTime.Now }, " AND ID = " + item.NotifyID.ToString());
        }

       
    }
}
