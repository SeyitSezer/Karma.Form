using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarmaObjects
{
    public partial class KarmaPanel : Panel
    {
        public KarmaPanel()
        {
            InitializeComponent();
        }

        public KarmaPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public string KarmaTableName { get; set; }
        public string KarmaColumnNames { get; set; }
        public KarmaTextBox KarmaMasterTextBox { get; set; }
        public KarmaButton KarmaMasterButton { get; set; }
    }
}
