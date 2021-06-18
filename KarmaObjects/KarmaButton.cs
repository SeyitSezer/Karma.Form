﻿using DevExpress.XtraBars;
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
        KarmaTextBox masterTextBox;
        public ContextMenuStrip ButtonMenu = new ContextMenuStrip();
        public ToolStripMenuItem MnuKaydet;
        public ToolStripMenuItem MnuSil;
        public ToolStripMenuItem MnuYeniKayit;
        public KarmaPanel KarmaMasterPanel { get; set; }
        public KarmaTextBox KarmaMasterTextBox { get
            {
                return masterTextBox;
            }
            set
            {
                masterTextBox = value; 
                if (!(value is null))
                {
                    Location = new Point(value.Left + value.Width + 2, value.Top);
                }

            }
                }
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
                MnuKaydet.Click += MnuKaydet_Click;
                // 
                // MnuSil
                // 
                MnuSil.Text = "Kaydı Sil";
                MnuSil.Name = "MnuSil";
                MnuSil.BackColor = Color.FromArgb(45, 45, 45);
                MnuSil.ForeColor = this.ForeColor;
                MnuSil.Click += MnuSil_Click; ;
                // 
                // MnuYeniKayit
                // 
                MnuYeniKayit.Text = "Yeni Kayıt";
                MnuYeniKayit.Name = "MnuYeniKayit";
                MnuYeniKayit.BackColor = Color.FromArgb(45, 45, 45);
                MnuYeniKayit.ForeColor = this.ForeColor;
                MnuYeniKayit.Click += MnuYeniKayit_Click;

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

        private void MnuYeniKayit_Click(object sender, EventArgs e)
        {
            if (!(KarmaMasterPanel is null))
            {
                KarmaMasterPanel.KarmaOnNew();
            }
            if (!(KarmaOnNewRecord is null))
            {
                KarmaOnNewRecord(sender, e);
            }
        }

        private void MnuKaydet_Click(object sender, EventArgs e)
        {
            if(!(KarmaMasterPanel is null))
            {
                KarmaMasterPanel.KarmaOnPost();
            }
            if (!(KarmaOnPost is null))
            {
                KarmaOnPost(sender, e);
            }
        }

        private void MnuSil_Click(object sender, EventArgs e)
        {
            if (!(KarmaMasterPanel is null))
            {
                KarmaMasterPanel.KarmaOnDelete();
            }
            if (!(KarmaOnDelete is null))
            {
                KarmaOnDelete(sender, e);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (KarmaButtonType == KarmaButtonTypes.Topluİşlem) ButtonMenu.Show(this, new Point(Width, 0));
            base.OnClick(e);
        }
        public event KarmaPost KarmaOnPost;
        public delegate void KarmaPost(object Sender, EventArgs e);
        public event KarmaDelete KarmaOnDelete;
        public delegate void KarmaDelete(object Sender, EventArgs e);
        public event KarmaNewRecord KarmaOnNewRecord;
        public delegate void KarmaNewRecord(object Sender, EventArgs e);
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
