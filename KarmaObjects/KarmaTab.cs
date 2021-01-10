using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmaObjects
{
    public class KarmaTab : XtraTabControl
    {
        public KarmaTab()
        {
            ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
        }
        protected override void OnCloseButtonClick(object sender, EventArgs e)
        {
            base.OnCloseButtonClick(sender, e);
            ClosePageButtonEventArgs _a = e as ClosePageButtonEventArgs;
            TabPages.Remove((_a.Page as XtraTabPage));
        }
    }
}
