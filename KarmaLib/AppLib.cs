using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static KarmaLib.KarmaLib;

namespace KarmaLib
{
    public static class AppLib
    {
        public static void VersionControl()
        {

        }

        public static string FileVersion()
        {
            string _Versions = "";
            XmlSerializer xsSubmit = new XmlSerializer(typeof(VersionInfos));
            var subReq = new VersionInfos();

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, subReq);
                    _Versions = sww.ToString();
                }
            }
            return _Versions;
        }
    }

    public class VersionInfos
    {
        public string KarmaFormExe = FileVersionInfo.GetVersionInfo(Application.StartupPath + "\\Karma_Form.exe").FileVersion;
        public string KarmaObjectsDll = FileVersionInfo.GetVersionInfo(Application.StartupPath + "\\KarmaObjects.dll").FileVersion;
        public string KarmaLibDll = FileVersionInfo.GetVersionInfo(Application.StartupPath + "\\KarmaLib.dll").FileVersion;
        public string KarmaLauncher = FileVersionInfo.GetVersionInfo(Application.StartupPath + "\\KarmaLauncher.exe").FileVersion;
    }
}
