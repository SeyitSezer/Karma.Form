using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarmaObjects
{
    public partial class KarmaButton : SimpleButton
    {
        public ContextMenuStrip ButtonMenu = new ContextMenuStrip();
        public ToolStripMenuItem MnuKaydet;
        public ToolStripMenuItem MnuSil;
        public ToolStripMenuItem MnuYeniKayit;
        private Point MouseDownLocation;
        public KarmaButton()
        {
            InitializeComponent();
        }

        public KarmaButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public bool TasinabilirMi { get; set; } = false;

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left)
            {
                MouseDownLocation = mevent.Location;
            }
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            if (TasinabilirMi && mevent.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Left = mevent.X + Left - MouseDownLocation.X;
                Top = mevent.Y + Top - MouseDownLocation.Y;
            }
            base.OnMouseMove(mevent);
        }
        public KarmaButtonTypes KarmaButtonType { get; set; }

        protected override void OnCreateControl()
        {
            BackColor = Color.FromArgb(45, 45, 45);
            ForeColor = Color.White;
            if (KarmaButtonType == KarmaButtonTypes.Topluİşlem)
            {
                MnuKaydet = new ToolStripMenuItem();
                MnuSil = new ToolStripMenuItem();
                MnuYeniKayit = new ToolStripMenuItem();
                // MnuKaydet
                // 
                MnuKaydet.Text = "Kaydı Sakla";
                MnuKaydet.Name = "MnuKaydet";
                MnuKaydet.BackColor = Color.FromArgb(45, 45, 45);
                MnuKaydet.ForeColor = this.ForeColor;
                // 
                // MnuSil
                // 
                MnuSil.Text = "Kaydı Sil";
                MnuSil.Name = "MnuSil";
                MnuSil.BackColor = Color.FromArgb(45, 45, 45);
                MnuSil.ForeColor = this.ForeColor;
                // 
                // MnuYeniKayit
                // 
                MnuYeniKayit.Text = "Yeni Kayıt";
                MnuYeniKayit.Name = "MnuYeniKayit";
                MnuYeniKayit.BackColor = Color.FromArgb(45, 45, 45);
                MnuYeniKayit.ForeColor = this.ForeColor;
                ButtonMenu.BackColor = Color.FromArgb(45, 45, 45);
                ButtonMenu.ForeColor = this.ForeColor;
                ButtonMenu.ShowImageMargin = false;
                ButtonMenu.Items.AddRange(new ToolStripMenuItem[] { MnuKaydet, MnuSil, MnuYeniKayit });
                ButtonMenu.Name = "ButtonMenu";
                Text = "Kayıt :";
                ContextMenuStrip = ButtonMenu;
            }
            base.OnCreateControl();
        }
        protected override void OnClick(EventArgs e)
        {
            if (KarmaButtonType == KarmaButtonTypes.Topluİşlem) ButtonMenu.Show(this, new Point(Width, 0));
            base.OnClick(e);
        }
    }
    public enum KarmaButtonTypes
    {
        Özel,
        Kayıt,
        Sil,
        Yeni,
        Topluİşlem,
        DosyaAç,
        KlasörAç,
        DosyaKaydet
    }
}
