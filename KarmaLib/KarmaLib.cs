using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Threading;

namespace KarmaLib
{
    public static class KarmaLib
    {

        public static string AppServer, DatabaseName;
        public static Form MainForm { get; set; }
        private static string SecureKey = "SeyitSeyitSeyit1";
        public static Image KarmaBase64ToImage(string base64Image)
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64Image)))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        public static XtraForm FindFormByName(string FormName)
        {
            XtraForm xtraForm = null;
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Reflection.Assembly stokLib = System.Reflection.Assembly.LoadFile(Application.StartupPath + "\\KarmaStokLib.dll");
            List<Type> _types = new List<Type>();
            _types.AddRange(myAssembly.GetTypes());
            _types.AddRange(stokLib.GetTypes());
            foreach (Type type in _types)
            {
                if (type.BaseType.FullName == "DexExpress.XtraEditors.XtraForm" || type.BaseType.FullName == "KarmaObjects.KarmaForm")
                {
                    if (type.Name == FormName)
                    {
                        var form = Activator.CreateInstance(type) as XtraForm;
                        xtraForm = form;
                        break;
                    }
                }
            }
            return xtraForm;
        }
        public static bool AppRunning { get; set; } = false;

        public static string KarmaBase64ToString(string base64string)
        {
            byte[] bdata = Convert.FromBase64String(base64string);
            string sonuc = Encoding.UTF8.GetString(bdata);
            return sonuc;
        }

        public static string KarmaStringToBase64(string currStr)
        {
            byte[] bdata = Encoding.UTF8.GetBytes(currStr);
            return Convert.ToBase64String(bdata);
        }

        public static void Mesaj(string Mesaj, int BekleSure = 0, string Baslik = "Karma Bildirim Sistemi")
        {
            FrmMesajAlt _Mesaj = new FrmMesajAlt(Mesaj, true, true, BekleSure, Baslik);
            if (!(MainForm is null))
            {
                _Mesaj.Size = new Size(MainForm.Width - 4, MainForm.Height);
                _Mesaj.WindowState = FormWindowState.Normal;
                _Mesaj.StartPosition = FormStartPosition.Manual;
                _Mesaj.Location = new Point(MainForm.Location.X + 2, MainForm.Location.Y);
            }
            else
            {
                _Mesaj.Height = 200;
                _Mesaj.StartPosition = FormStartPosition.CenterScreen;
            }
            _Mesaj.ShowDialog();
        }

        public static DialogResult Sor(string Mesaj,int bekleSure = 0, string Baslik = "Onayınız Gerekiyor",  bool DefaultDeger= false)
        {
            FrmMesajAlt _Soru = new FrmMesajAlt(Mesaj, false, DefaultDeger, bekleSure, Baslik);
            if (!(MainForm is null))
            {
                _Soru.Size = new Size(MainForm.Width - 4, MainForm.Height);
                _Soru.WindowState = FormWindowState.Normal;
                _Soru.StartPosition = FormStartPosition.Manual;
                _Soru.Location = new Point(MainForm.Location.X + 2, MainForm.Location.Y);
            }
            else
            {
                _Soru.Height = 200;
                _Soru.StartPosition = FormStartPosition.CenterScreen;
            };
            
            _Soru.ShowDialog();
            return _Soru.DialogResult;
        }

        public static string HataMesajiHazirla(string SQLText, string HataMesaji, Type GonderenNesne, string DataBase)
        {
            string Msj = "";
            Msj  = "Hata             :" + HataMesaji + Environment.NewLine;
            Msj += "SQL Text         :" + SQLText + Environment.NewLine;
            Msj += "Gönderen Nesne   :" + GonderenNesne.Name+ Environment.NewLine;
            Msj += "Çalışılan Şifket :" + DataBase + Environment.NewLine;
            Msj += "Hata Tarihi      :" + DateTime.Now.ToString("D");
            return Msj;
        }
        public static void PleaseWait(Thread currThread)
        {
            FrmBekle _WaitForm = new FrmBekle(currThread);
            _WaitForm.ShowDialog();
        }

        public static bool LisansVarmi
        {
            get
            {
                return true;
                //return File.Exists(Application.StartupPath + "//Karma.krl");
            }
        }
        public static string SecurityKey
        {
            get
            {
                return SecureKey;
            }
            set
            {
                SecureKey = value;
            }
        }
        public enum KarmaFieldNumericTypes
        {
            TamSayi,
            Miktar,
            Fiyat,
            Tutar,
            Genel
        }

        public static int GetOndalik(KarmaFieldNumericTypes _Type)
        {
            int i = 0;
            switch (_Type)
            {
                case KarmaFieldNumericTypes.Miktar:
                    i = MiktarDigit;
                    break;
                case KarmaFieldNumericTypes.Fiyat:
                    i= FiyatDigit;
                    break;
                case KarmaFieldNumericTypes.Tutar:
                    i = TutarDigit;
                    break;
                case KarmaFieldNumericTypes.TamSayi:
                    i= 0;
                    break;
                case KarmaFieldNumericTypes.Genel:
                    i= GenelDigit;
                    break;
                default:
                    i = GenelDigit;
                    break;
            }
            return i;
        }
        public static int MiktarDigit { get; set; } = 2;
        public static int FiyatDigit { get; set; } = 2;
        public static int GenelDigit { get; set; } = 2;
        public static int TutarDigit { get; set; } = 3;

        public static int ToInt(this object _obj)
        {
            if (_obj is DBNull) return -999;
            else
                return Convert.ToInt32(_obj);
        }

        public static int ToInt(this string _obj)
        {
            return Convert.ToInt32(_obj);
        }
        public static int ToInt(this double _obj)
        {
            return Convert.ToInt32(_obj);
        }

        public static decimal ToDecimal(this object _obj)
        {
            if (_obj is DBNull) return -999;
            else
                return Convert.ToDecimal(_obj);
        }

        public static decimal ToDecimal(this string _obj)
        {
            return Convert.ToDecimal(_obj);
        }
        public static decimal ToDecimal(this double _obj)
        {
            return Convert.ToDecimal(_obj);
        }

        public static bool ToBool(this object _obj)
        {
            try
            {
                return Convert.ToBoolean(_obj);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ToBool(this string _obj)
        {
            return Convert.ToBoolean(_obj);
        }
    }

}
