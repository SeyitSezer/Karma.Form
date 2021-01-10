using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmaObjects
{
    public static class ObjectsDefaults
    {
        public static Font GenelYaziTipi()
        {
            return new Font("Roboto", 9);
        }
        private static StyleController _Style = new StyleController();
        public static StyleController KarmaStyle()
        {
            _Style.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            _Style.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            _Style.Appearance.Font = GenelYaziTipi();

            return _Style;
        }
    }
}
