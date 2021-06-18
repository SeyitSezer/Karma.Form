using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KarmaLib.KarmaLib;

namespace KarmaObjects
{
    public partial class KarmaTab : XtraTabControl
    {
        public KarmaTab()
        {
            InitializeComponent();
            ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
        }

        public KarmaTab(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool KarmaCloseButtonMessageActive { get; set; } = true;
        protected override void OnCloseButtonClick(object sender, EventArgs e)
        {
            base.OnCloseButtonClick(sender, e);
            ClosePageButtonEventArgs _a = e as ClosePageButtonEventArgs;
            if (KarmaCloseButtonMessageActive && Sor(_a.Page.Text + " Kapatılsın mı?") == System.Windows.Forms.DialogResult.Yes)
            {
                TabPages.Remove((_a.Page as XtraTabPage));
            }

        }
    }
}
