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
using KarmaLib;
using static KarmaLib.KarmaLib;

namespace KarmaStokLib
{
    public partial class FrmStok : KarmaForm
    {
        public FrmStok()
        {
            InitializeComponent();
            PnlStokMas.AddChildPanel(PnlStokAyar);
            PnlStokMas.AddChildPanel(PnlStokPlan);
        }

        private void GrdStoklar_DoubleClick(object sender, EventArgs e)
        {
            karmaTab1.SelectedTabPage = PgeStokIslem;
            karmaTextBox1_Leave(sender, e);
        }

        private void karmaTextBox1_Leave(object sender, EventArgs e)
        {
            GrdStokFiyat.GetData("SELECT * FROM ViewStokFiyat WHERE StokKodu = " + StokKodu.GetSQLText);
            GrdStokGrup.GetData("SELECT * FROM ViewStokGrup WHERE StokKodu = " + StokKodu.GetSQLText);
        }

       

        private void FrmStok_Load(object sender, EventArgs e)
        {
        }
    }
}
