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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KarmaLib.KarmaLib;
using static KarmaLib.KarmaSQL;

namespace KarmaLauncher
{
    public partial class Launcher : KarmaForm
    {
        public Launcher()
        {
            AppRunning = true;
            InitializeComponent();
            pictureBox1.Size = new Size(192, 192);
        }


        private void Launcher_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(520, 224);
            //BtnGiris.Left = UserName.Left + UserName.Width - 120;
            //BtnGiris.Top = Password.Top + 29;
        }
        void Test()
        {
            return;
            for (int i = 0; i < 10000; i++)
            {
                //karmaLabel5.Text = i.ToString();
            }
        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\Options\\KarmaSettings.opt") && DialogResult.Yes == Sor("Yapılandırma Ayarları Eksik, Şimdi Ayarlamak İster Misiniz?"))
            {
                var a = new Config();
                a.ShowDialog();
            }
            else
            {/*
                if (string.IsNullOrEmpty(Sirket.Text))
                {
                    Mesaj("Şirket Seçimi Yapılmadı!");
                    Sirket.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Yil.Text))
                {
                    Mesaj("Yıl Seçimi Yapılmadı!");
                    Yil.Focus();
                    return;
                }*/
                if (File.Exists(Application.StartupPath + "\\Karma_Form.exe"))
                {
                    //Process.Start(Application.StartupPath + "\\Karma_Form.exe", "\"KarmaLauncher\" \"" + Sirket.Text + "\" \"" + Yil.Text + "\"");
                    Process.Start(Application.StartupPath + "\\Karma_Form.exe", "KarmaLauncher");
                    Application.Exit();
                }
                else
                {
                    Mesaj("Karma.Form Bulunamadı!");
                    Application.Exit();
                }
            }
        }
    }
}
