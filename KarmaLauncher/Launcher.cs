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
using static KarmaLib.KarmaLib;

namespace KarmaLauncher
{
    public partial class Launcher : KarmaForm
    {
        public Launcher()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(192, 192);
        }


        private void Launcher_Load(object sender, EventArgs e)
        {
            this.Size = new Size(520, 224);
            BtnGiris.Left = UserName.Left + UserName.Width - 120;
            BtnGiris.Top = Password.Top + 29;
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if(Sor("Gördün mü Len") == DialogResult.Yes)
            Mesaj("Ömer Gördün mü?");
            KarmaLib.KarmaSecurity.DosyaSifrele("seyit.txt", "seyit2.txt", "87eMZYB_fsbq7E^j");
            KarmaLib.KarmaSecurity.DosyaCoz("seyit2.txt", "seyit3.txt", "87eMZYB_fsbq7E^j");
            if (string.IsNullOrEmpty(Sirket.Text))
            {
                MessageBox.Show("Şirket Seçimi Yapılmadı!");
                Sirket.Focus();
                return;
            }
            if(string.IsNullOrEmpty(Yil.Text))
            {
                MessageBox.Show("Yıl Seçimi Yapılmadı!");
                Yil.Focus();
                return;
            }
            if (File.Exists("Karma.Form.exe"))
            {
                Process.Start("Karma.Form.exe", "KarmaLauncher " + Sirket.Text + " " + Yil.Text);
            }
            else
            {
                MessageBox.Show("Karma.Form Bulunamadı!");
                Application.Exit();
            }
        }
    }
}
