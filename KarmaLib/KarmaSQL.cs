using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace KarmaLib
{
    public static class KarmaSQL
    {
        public static SqlConnection KarmaConnection = new SqlConnection();
        public static void ConnectDB(string DataBase, bool UseWindowsConnect = false)
        {
            string Server, UserName, Password;
            try
            {
                IniConfig _ReadConfig = new IniConfig(Application.StartupPath + "\\Config.ini");
                Server = _ReadConfig.Read("Server");
                UserName = _ReadConfig.Read("UserName");
                Password = _ReadConfig.Read("Password");
                if (KarmaConnection.State != ConnectionState.Open)
                {
                    if (!UseWindowsConnect)
                        KarmaConnection.ConnectionString = "Server=" + Server + "; Initial Catalog=" + DataBase + ";User ID=" + UserName + "; Password=" + Password + "; Application Name=Karma;WSID=Karma;";
                    else
                        KarmaConnection.ConnectionString = "Server=" + Server + "; Initial Catalog=" + DataBase + ";Integrated Security=True; Application Name=Karma;WSID=Karma;";
                    if (KarmaConnection.State == ConnectionState.Closed) KarmaConnection.Open();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Veritabanına Bağlanırken Hata Oluştu!" + Environment.NewLine + x.Message);
            }
            
        }
    }
}
