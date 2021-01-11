using System;
using System.Drawing;
using DevExpress.XtraEditors;
using System.IO;

namespace KarmaObjects
{
    public partial class KarmaForm : XtraForm
    {
        public KarmaForm()
        {
            InitializeComponent();
        }

        public static Image Base64ToImage(string base64Image)
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64Image)))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
    }
}