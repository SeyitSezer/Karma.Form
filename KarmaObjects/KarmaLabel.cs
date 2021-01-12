using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarmaObjects
{
    public class KarmaLabel : Label, KarmaObject
    {
        public Control KarmaFocusControl { get; set; }
        public bool ReadOnly { get; set; }

        public KarmaLabel()
        {
            Font = ObjectsDefaults.GenelYaziTipi();
        }
        protected override void OnCreateControl()
        {
            if (!(KarmaFocusControl is null))
            {
                KarmaFocusControl.Top = Top + 2;
                KarmaFocusControl.Left = Left + Width + 10;
            }
            base.OnCreateControl();
        }
    }
}
