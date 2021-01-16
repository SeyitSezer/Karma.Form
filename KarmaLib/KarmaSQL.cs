using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static KarmaLib.KarmaLib;

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
                Mesaj("Veritabanına Bağlanırken Hata Oluştu!" + Environment.NewLine + x.Message, "Hata");
            }
            
        }

        public static void Insert(string TableName, List<string> Columns, List<object> Values)
        {
            SqlCommand _Insert = new SqlCommand("INSERT INTO " + TableName + "(", KarmaConnection);
            try
            {
                string _cols = "";
                foreach (string i in Columns)
                {
                    _cols += i + ",";
                }
                _cols = _cols.Substring(0, _cols.Length - 2) + ") VALUES(";
                string _params = "";
                int _paramsay = 1;
                foreach (object vals in Values)
                {
                    _Insert.Parameters.AddWithValue("@P" + _paramsay.ToString(), vals);
                    _params += "@P" + _paramsay.ToString() + ",";
                    _paramsay++;
                }
                _params = _params.Substring(0, _params.Length - 2) + ")";
                _Insert.CommandText += _cols + _params;
                _Insert.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                Mesaj(HataMesajiHazirla(_Insert.CommandText,  x.Message, typeof(KarmaSQL), KarmaConnection.Database), "Hata");
            }
        }

        public static void Delete(string TableName, string FilterNotWhere)
        {
            SqlCommand _delete = new SqlCommand("DELETE " + TableName + " WHERE 1=1 AND " + FilterNotWhere, KarmaConnection);
            try
            {
                _delete.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                Mesaj(HataMesajiHazirla(_delete.CommandText, x.Message, typeof(KarmaSQL), KarmaConnection.Database), "Hata");
            }
        }

        public static void Update(string TableName, List<string> Columns, List<object> Values, string FilterNotWhere)
        {
            SqlCommand _Update = new SqlCommand("UPDATE " + TableName + " SET ", KarmaConnection);
            try
            {
                var cols = Columns.ToArray();
                var vals = Values.ToArray();
                if (cols.Length != vals.Length)
                {
                    Mesaj("Alan ve Değer Listesi Eşit Değil, İşleme Devam Edilemiyor!");
                    return;
                }
                for(int i = 0; i < cols.Length; i++)
                {
                    _Update.CommandText += cols[i] + " = @P" + (i + 1).ToString() +", ";
                    _Update.Parameters.AddWithValue("@P" + (i + 1).ToString(), vals[i]);
                }
                _Update.CommandText = _Update.CommandText.Substring(0, _Update.CommandText.Length - 2);
                _Update.CommandText += " WHERE 1=1 " + FilterNotWhere;
                _Update.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                Mesaj(HataMesajiHazirla(_Update.CommandText, x.Message, typeof(KarmaSQL), KarmaConnection.Database), "Hata");
            }
        }
    }
}
