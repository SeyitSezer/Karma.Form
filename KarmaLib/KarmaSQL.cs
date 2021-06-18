using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static KarmaLib.KarmaLib;
using System.IO;
using DevExpress.Data.Db;
using DevExpress.DataAccess.Native.Sql;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;

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
                if (File.Exists(Application.StartupPath + "\\Options\\Config.ini")) File.Delete(Application.StartupPath + "\\Options\\Config.ini");
                KarmaSecurity.DosyaCoz(Application.StartupPath + "\\Options\\KarmaSettings.opt", Application.StartupPath + "\\Options\\Config.ini", SecurityKey);
                IniConfig _ReadConfig = new IniConfig(Application.StartupPath + "\\Options\\Config.ini");
                Server = _ReadConfig.Read("Karma","Server");
                UserName = _ReadConfig.Read("Karma", "UserName");
                Password = _ReadConfig.Read("Karma", "Password");
                MiktarDigit = Convert.ToInt32(_ReadConfig.Read("Karma", "MiktarDigit"));
                TutarDigit = Convert.ToInt32(_ReadConfig.Read("Karma", "TutarDigit"));
                FiyatDigit = Convert.ToInt32(_ReadConfig.Read("Karma", "FiyatDigit"));
                GenelDigit = Convert.ToInt32(_ReadConfig.Read("Karma", "GenelDigit"));
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
            finally
            {
                File.Delete(Application.StartupPath + "\\Options\\Config.ini");
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
                _cols = _cols.Substring(0, _cols.Length - 1) + ") VALUES(";
                string _params = "";
                int _paramsay = 1;
                foreach (object vals in Values)
                {
                    _Insert.Parameters.AddWithValue("@P" + _paramsay.ToString(), vals);
                    _params += "@P" + _paramsay.ToString() + ",";
                    _paramsay++;
                }
                _params = _params.Substring(0, _params.Length - 1) + ")";
                _Insert.CommandText += _cols + _params;
                _Insert.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                Mesaj(HataMesajiHazirla(_Insert.CommandText,  x.Message, typeof(KarmaSQL), KarmaConnection.Database), "Hata");
            }
        }

        public static void DeleteData(string TableName, string FilterNotWhere)
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

        public static void UpdateData(string TableName, List<string> Columns, List<object> Values, string FilterNotWhere)
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

        public static DataTable GetSQLData(string SQLText)
        {
            DataTable _Result = new DataTable();

            SqlDataAdapter _GetData = new SqlDataAdapter(SQLText, KarmaConnection);
            _GetData.Fill(_Result);
            return _Result;
        }

        public static DataSet GetSQLDataSet(string SQLText)
        {
            DataSet _Result = new DataSet();

            SqlDataAdapter _GetData = new SqlDataAdapter(SQLText, KarmaConnection);
            _GetData.Fill(_Result);
            return _Result;
        }
    }
}
