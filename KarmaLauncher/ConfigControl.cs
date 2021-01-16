using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarmaLauncher
{
    public partial class ConfigControl
    {
        [CategoryAttribute("Veri Tabanı Bağlantı Ayarları"), DescriptionAttribute("Server")]
        public string Server { get; set; }
        [CategoryAttribute("Veri Tabanı Bağlantı Ayarları"), DescriptionAttribute("Varsayılan Veri Tabanı")]
        public string DefaultVeriTabani { get; set; }
        [CategoryAttribute("Veri Tabanı Bağlantı Ayarları"), DescriptionAttribute("Kullanıcı Adı")]
        public string UserName { get; set; }
        [CategoryAttribute("Veri Tabanı Bağlantı Ayarları"), DescriptionAttribute("Kullanıcı Şifresi")]
        public string Password { get; set; }
    }
}
