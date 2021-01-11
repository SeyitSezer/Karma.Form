using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmaObjects
{
    public class KarmaGrid : GridControl
    {
        public GridView KarmaView = new GridView();
        public KarmaGrid()
        {
            KarmaView.GridControl = this;
            KarmaView.Name = this.Name.Replace("Grid", "View");
            KarmaView.OptionsFind.AlwaysVisible = true;
            KarmaView.OptionsFind.FindNullPrompt = "Arama Yapmak İçin Buraya Yazın";
            KarmaView.OptionsFind.ShowFindButton = false;
            KarmaView.OptionsView.BestFitMode = GridBestFitMode.Fast;
            ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {KarmaView});
        }
    }
}
