using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        protected override void OnCloseButtonClick(object sender, EventArgs e)
        {
            base.OnCloseButtonClick(sender, e);
            ClosePageButtonEventArgs _a = e as ClosePageButtonEventArgs;
            TabPages.Remove((_a.Page as XtraTabPage));
        }
    }
}
