using KarmaLib;
using KarmaObjects;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static KarmaLib.KarmaLib;
using System.IO;

namespace KarmaLauncher
{
    public partial class Config : KarmaForm
    {

        public Config()
        {
            InitializeComponent();

        }

        private void BtnCheckDBConnect_Click(object sender, EventArgs e)
        {
            SqlConnection KarmaConnection = new SqlConnection();
            string Server, UserName, Password, DataBase;
            try
            {
                Server = VTServer.Text;
                UserName = VTUserName.Text;
                Password = VTPassword.Text;
                DataBase = VTDatabase.Text;
                if (KarmaConnection.State != ConnectionState.Open)
                {
                    KarmaConnection.ConnectionString = "Server=" + Server + "; Initial Catalog=" + DataBase + ";User ID=" + UserName + "; Password=" + Password + "; Application Name=Karma;WSID=Karma;";
                    if (KarmaConnection.State == ConnectionState.Closed) KarmaConnection.Open();
                    MessageBox.Show("Başarıyla Bağlantı Kuruldu");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Sınama Başarısız Oldu!" + Environment.NewLine + x.Message, "Hata");
            }
        }

        private void Config_Shown(object sender, EventArgs e)
        {
            GrpLicense.Enabled = !LisansVarmi;
            if (!Directory.Exists(Application.StartupPath + "\\Options")) Directory.CreateDirectory(Application.StartupPath + "\\Options");
            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                if (File.Exists(Application.StartupPath + "\\Options\\KarmaSettings.opt"))
                {
                    if (File.Exists(Application.StartupPath + "\\Options\\Config.ini")) File.Delete(Application.StartupPath + "\\Options\\Config.ini");
                    KarmaSecurity.DosyaCoz(Application.StartupPath + "\\Options\\KarmaSettings.opt", Application.StartupPath + "\\Options\\Config.ini", SecurityKey);
                    IniConfig _ReadConfig = new IniConfig(Application.StartupPath + "\\Options\\Config.ini");
                    VTServer.Text = _ReadConfig.Read("Karma","Server");
                    VTUserName.Text = _ReadConfig.Read("Karma","UserName");
                    VTPassword.Text = _ReadConfig.Read("Karma","Password");
                    VTDatabase.Text = _ReadConfig.Read("Karma", "DataBase");
                    DGFiyat.Text = _ReadConfig.Read("Karma","FiyatDigit");
                    DGGenel.Text = _ReadConfig.Read("Karma", "GenelDigit");
                    DGMiktar.Text = _ReadConfig.Read("Karma", "MiktarDigit");
                    DGTutar.Text = _ReadConfig.Read("Karma", "TutarDigit");
                }
            }
            catch 
            {
                
            }
            finally
            {
                File.Delete(Application.StartupPath + "\\Options\\Config.ini");
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + "\\Options\\KarmaSettings.opt")) File.Delete(Application.StartupPath + "\\Options\\KarmaSettings.opt");
                IniConfig _ReadConfig = new IniConfig(Application.StartupPath + "\\Options\\Config.ini");
                _ReadConfig.Write("Karma", "Server", VTServer.Text);
                _ReadConfig.Write("Karma", "UserName", VTUserName.Text);
                _ReadConfig.Write("Karma", "Password", VTPassword.Text);
                _ReadConfig.Write("Karma", "DataBase", VTDatabase.Text);
                _ReadConfig.Write("Karma", "FiyatDigit", DGFiyat.Text);
                _ReadConfig.Write("Karma", "GenelDigit", DGGenel.Text);
                _ReadConfig.Write("Karma", "MiktarDigit", DGMiktar.Text);
                _ReadConfig.Write("Karma", "TutarDigit", DGTutar.Text);
                KarmaSecurity.DosyaSifrele(Application.StartupPath + "\\Options\\Config.ini", Application.StartupPath + "\\Options\\KarmaSettings.opt", SecurityKey);
            }
            catch
            {
                
            }
            finally
            {
                File.Delete(Application.StartupPath + "\\Options\\Config.ini");
            }
        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(Application.StartupPath + "\\Options\\Config.ini");
        }
    }
}
