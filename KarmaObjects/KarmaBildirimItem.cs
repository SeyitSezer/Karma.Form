using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using KarmaObjects.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmaObjects
{
    public class KarmaBildirimItem : TileItem
    {

        TileItemElement tileItemElement1 = new TileItemElement();
        TileItemElement tileItemElement2 = new TileItemElement();
        TileItemElement tileItemElement4 = new TileItemElement();
        public int NotifyID { get; set; }
        public bool IsRead { get; set; } = false;

        public string EventForm
        {
            get
            {
                if (string.IsNullOrEmpty(Tag.ToString()))
                    return "";
                else
                    return ((string)Tag).Substring(0, Tag.ToString().IndexOf(";"));

            }
        }
        public string EventObject
        {
            get
            {
                if (string.IsNullOrEmpty(Tag.ToString()))
                    return "";
                else
                    return ((string)Tag).Substring(Tag.ToString().IndexOf(";")+1);

            }
        }
        public KarmaBildirimItem(int ID = 0, string EventString = "", string Baslik = "Başlık", string Mesaj = "Bildirim Mesajı", string BildirimZaman = "01.01.2020 20:00:00", TileItemClickEventHandler xClick = null)
        {
            AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            AppearanceItem.Normal.Options.UseBackColor = true;
            AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = Baslik;
            tileItemElement2.Text = Mesaj;
            tileItemElement2.TextAlignment = TileItemContentAlignment.MiddleLeft;
            tileItemElement4.Text = BildirimZaman;
            tileItemElement4.TextAlignment = TileItemContentAlignment.BottomLeft;
            Elements.Add(tileItemElement1);
            Elements.Add(tileItemElement2);
            Elements.Add(tileItemElement4);
            Id = ID;
            NotifyID = ID;
            ItemSize = TileItemSize.Wide;
            Name = "BildirimButton_" + ID.ToString();
            Tag = EventString;
            if (xClick != null)
                ItemClick += xClick;
        }
    }
}
