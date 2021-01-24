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
using KarmaStokLib;
using DevExpress.XtraTab;

namespace Karma_Form
{
    public partial class MainForm : KarmaForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateForm(KarmaForm AcilacakForm)
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
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //MainStatusBar.BackColor = Color.FromArgb(60, 60, 60);
            //MainMenu.BackColor = MainStatusBar.BackColor;
            //MainStatusBar.ForeColor = Color.White;
            //MainMenu.ForeColor = Color.White;
            ConnectDB("ETicaret");
            AppRunning = true;
        }

        private void BtnToolCari_Click(object sender, EventArgs e)
        {
            Point _local = new Point(DesktopTab.Width / 2, DesktopTab.Height / 2);
            //MnuRadial.ShowPopup(_local, true);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DialogResult.Yes == Sor("Program Kapatılacak, Devam Edilsin Mi?", "Onayınız Gerekiyor")) Application.Exit();
        }

        private void karmaButton1_Click(object sender, EventArgs e)
        {
            KarmaRehber rehber = new KarmaRehber("tblCategoryMas", "CategoryCode, CategoryName, CategoryNameEN","CategoryCode");
            rehber.ShowDialog();
        }

        private void MnuStoklar_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmStok());
        }
    }
}
