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
        [Category("Veri Tabanı Bağlantı Ayarları"), Description("Server")]
        public string Server { get; set; }
        [Category("Veri Tabanı Bağlantı Ayarları"), Description("Varsayılan Veri Tabanı")]
        public string VeriTabani { get; set; }
        [Category("Veri Tabanı Bağlantı Ayarları"), Description("Kullanıcı Adı")]
        public string UserName { get; set; }
        [Category("Veri Tabanı Bağlantı Ayarları"), Description("Kullanıcı Şifresi")]
        public string Password { get; set; }
    }
}
