using KarmaObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarmaLauncher
{
    public partial class Launcher : KarmaForm
    {
        public Launcher()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(192, 192);
        }

        private void karmaButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists("Karma.Form.exe")) Process.Start("Karma.Form.exe", "KarmaLauncher");
            else MessageBox.Show("Karma.Form Bulunamadı!");
            Application.Exit();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            this.Size = new Size(520, 224);
            karmaButton1.Left = UserName.Left + UserName.Width - 120;
            karmaButton1.Top = Password.Top + 29;
        }
    }
}
