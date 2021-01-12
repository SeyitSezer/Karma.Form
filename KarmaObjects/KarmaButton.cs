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
    }
}
