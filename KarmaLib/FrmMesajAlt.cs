using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KarmaLib
{
    public partial class FrmMesajAlt : DevExpress.XtraEditors.XtraForm
    {
        bool varsayilan, mesajmi;
        public FrmMesajAlt(string Mesaj, bool MesajMi = true, bool Varsayilan = false, string Baslik = "Karma Bildirim Sistemi")
        {
            InitializeComponent();
                BtnOk.Visible = MesajMi;
            BtnNo.Visible = !MesajMi;
            BtnYes.Visible = !MesajMi;
            BtnCancel.Visible = !MesajMi;
            mesajmi = MesajMi;
            varsayilan = Varsayilan;
            TxtMesaj.Text = Mesaj;
            lblBaslik.Text = Baslik;
            //panel3.BackColor = Color.FromArgb(60, Color.Yellow);
            //panel4.BackColor = Color.FromArgb(60, Color.Yellow);
        }

        private void FrmMesajAlt_Shown(object sender, EventArgs e)
        {
            if (!mesajmi)
            {
                if (varsayilan) BtnYes.Focus();
                else BtnNo.Focus();
            }
        }


        private void ButtonsClick(object sender, EventArgs e)
        {
            DialogResult = (sender as Button).DialogResult;
            Close();
        }
    }
}