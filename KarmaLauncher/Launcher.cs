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
using static KarmaUserLib.UserLib;
using KarmaLib;
using static KarmaLib.KarmaSirketLib;
using KarmaUserLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KarmaLauncher
{
    public partial class Launcher : KarmaForm
    {
        public Launcher()
        {
            ConnectDB("SzrBase");
            AppRunning = true;
            InitializeComponent();
            pictureBox1.Size = new Size(192, 192);
        }


        private void Launcher_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(520, 224);
            //BtnGiris.Left = UserName.Left + UserName.Width - 120;
            //BtnGiris.Top = Password.Top + 29;
            if (((DataTable)Sirket.Properties.DataSource).Rows.Count == 1)
                Sirket.ItemIndex = 0;
            if (((DataTable)Yil.Properties.DataSource).Rows.Count == 1)
                Yil.ItemIndex = 0;
            else if (((DataTable)Yil.Properties.DataSource).Rows.Count > 1)
                Yil.ItemIndex = ((DataTable)Yil.Properties.DataSource).Rows.Count -1;
            UserName.Text = "Admin";
            Password.Text = "123";
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
            {
                if(UserName.IsNull)
                {
                    Mesaj("Kullanıcı adı boş olamaz!");
                    UserName.Focus();
                    return;
                }
                var data = GetSQLData($"SELECT * FROM tblUsers WHERE UserName = " + UserName.GetSQLText, false, false);
                if (data.Rows.Count == 0)
                {
                    Mesaj("Böyle bir kullanıcı bulunamadı!");
                    UserName.Focus();
                    return;
                }
                else
                {
                    if (data.Rows[0]["UserPassword"].ToString() != Password.Text)
                    {
                        Mesaj("Kullanıcı şifresi hatalı!");
                        Password.Text = "";
                        Password.Focus();
                        return;
                    }
                    CurrentUser = new User()
                    {
                        UserID = data.Rows[0]["ID"].ToInt(),
                        UserName = UserName.Text,
                        UserNickName = data.Rows[0]["NickName"].ToString(),
                        IsAdmin = data.Rows[0]["SysAdmin"].ToBool(),
                        EMailAdress = data.Rows[0]["eMail"].ToString(),
                        FullName = data.Rows[0]["FullName"].ToString(),
                        GSMNumber = data.Rows[0]["GSMNumber"].ToString(),
                        UserDetails = new UserDetails()
                        {
                            ImportData = true,
                            ExportData = true
                        }
                    };

                }
                
                if (Sirket.IsNull)
                {
                    Mesaj("Şirket Seçimi Yapılmadı!");
                    Sirket.Focus();
                    return;
                }
                if (Yil.IsNull)
                {
                    Mesaj("Yıl Seçimi Yapılmadı!");
                    Yil.Focus();
                    return;
                }
                var csirket = GetSQLData("SELECT * FROM tblSirket WHERE SirketKodu =" + Sirket.GetSQLText, false, false);
                var cyil = GetSQLData("SELECT * FROM tblCalismaYili WHERE SirketKodu =" + Sirket.GetSQLText + " AND CalismaYili =" + Yil.GetSQLText, false, false);
                CurrentSirket = new Sirket()
                {
                    ID = csirket.Rows[0]["ID"].ToInt(),
                    SirketKodu = csirket.Rows[0]["SirketKodu"].ToString(),
                    Unvan = csirket.Rows[0]["Unvan"].ToString(),
                    KisaUnvan = csirket.Rows[0]["KisaUnvan"].ToString(),
                    Adres = csirket.Rows[0]["Adres"].ToString(),
                    VergiDairesi = csirket.Rows[0]["VergiDairesi"].ToString(),
                    VergiNo = csirket.Rows[0]["VergiNo"].ToString(),
                    FaksNo = csirket.Rows[0]["FaksNo"].ToString(),
                    Telefon = csirket.Rows[0]["Telefon"].ToString(),
                    WebSitesi = csirket.Rows[0]["WebSitesi"].ToString(),
                    EMail = csirket.Rows[0]["EMail"].ToString()
                };
                CurrentCalismaYil = new CalismaYili()
                {
                    Yil = cyil.Rows[0]["CalismaYili"].ToInt(),
                    SirketKodu = cyil.Rows[0]["SirketKodu"].ToString(),
                    BaslamaTarihi = cyil.Rows[0]["BasTarih"].ToDate(),
                    BitisTarihi =cyil.Rows[0]["BitTarih"].ToDate(),
                };
                
                //if (File.Exists(Application.StartupPath + "\\Karma_Form.exe"))
                //{
                    //Process.Start(Application.StartupPath + "\\Karma_Form.exe", "\"KarmaLauncher\" \"" + Sirket.Text + "\" \"" + Yil.Text + "\"");
                    //Process.Start(Application.StartupPath + "\\Karma_Form.exe", "KarmaLauncher");
                    Karma_Form.MainForm _Main = new Karma_Form.MainForm();
                    this.Hide();
                    _Main.ShowDialog();
                    Close();
                //}
                //else
                //{
                //    Mesaj("Karma.Form Bulunamadı!");
                //    Application.Exit();
                //}
            }
        }
    }
}
