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

namespace Karma_Form
{
    public partial class MainForm : KarmaForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainStatusBar.BackColor = Color.FromArgb(60, 60, 60);
            MainMenu.BackColor = MainStatusBar.BackColor;
            MainStatusBar.ForeColor = Color.White;
            MainMenu.ForeColor = Color.White;
        }

        private void BtnToolCari_Click(object sender, EventArgs e)
        {
            Point _local = new Point(DesktopTab.Width / 2, DesktopTab.Height / 2);
            MnuRadial.ShowPopup(_local, true);
        }
    }
}
