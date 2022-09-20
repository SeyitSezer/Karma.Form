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
        }

        private void GrdStoklar_DoubleClick(object sender, EventArgs e)
        {
            karmaTab1.SelectedTabPage = PgeStokIslem;
        }

        
    }
}
