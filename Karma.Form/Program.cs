using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karma_Form
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if(args.Length >0 && string.IsNullOrEmpty(args[0]) && args[0] == "KarmaLauncher")
                Application.Run(new MainForm());
            //else
            //{
                //Process.Start("KarmaLauncher.exe");
                //Application.Exit();
            //}
        }
    }
}
