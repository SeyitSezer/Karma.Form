﻿using System;
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

        public static void Mesaj(string Mesaj, string Baslik = "Karma Bildirim Sistemi")
        {
            FrmMesajAlt _Mesaj = new FrmMesajAlt(Mesaj, true, true, Baslik)
            {
                Size = new Size(MainForm.Width - 4, MainForm.Height),
                WindowState = FormWindowState.Normal,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(MainForm.Location.X + 2, MainForm.Location.Y),
            };
            _Mesaj.ShowDialog();
        }

        public static DialogResult Sor(string Mesaj, string Baslik = "Onayınız Gerekiyor", bool DefaultDeger= false)
        {
            FrmMesajAlt _Soru = new FrmMesajAlt(Mesaj, false, DefaultDeger, Baslik)
            {
                Size = new Size(MainForm.Width - 4, MainForm.Height),
                WindowState = FormWindowState.Normal,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(MainForm.Location.X +2, MainForm.Location.Y),
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
    }

}
