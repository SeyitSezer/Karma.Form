using System;
using System.Drawing;
using DevExpress.XtraEditors;
using System.IO;
using static KarmaLib.KarmaLib;
using static KarmaLib.KarmaSQL;
using DevExpress.XtraTab;

namespace KarmaObjects
{
    public partial class KarmaForm : XtraForm
    {
        public KarmaForm()
        {
            InitializeComponent();
        }

        private void KarmaForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                if(Parent is null)
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