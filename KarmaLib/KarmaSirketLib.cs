using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmaLib
{
    public class Sirket
    {
        public int ID { get; set; }
        public string SirketKodu { get; set; }
        public string Unvan { get; set; }
        public string KisaUnvan { get; set; }
        public string Adres { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string FaksNo { get; set; }
        public string Telefon { get; set; }
        public string WebSitesi { get; set; }
        public string EMail { get; set; }
    }   
    public class CalismaYili
    {
        public string SirketKodu { get; set; }
        public int Yil { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

    }
    public static class KarmaSirketLib
    {
        public static Sirket CurrentSirket { get; set; }
        public static CalismaYili CurrentCalismaYil { get; set; }
    }
}
