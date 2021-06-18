using DevExpress.XtraEditors;
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
using static KarmaLib.KarmaLib;

namespace KarmaUserLib
{
    public partial class FrmUserSettings : KarmaForm
    {
        public FrmUserSettings()
        {
            InitializeComponent();
        }

        private void UserSettings_KFClearButtonClick(object Sender, EventArgs e)
        {
            if (DialogResult.Yes != Sor("Seçenekler sıfırlanacak, devam edilsin mi?")) return;
        }
    }
}