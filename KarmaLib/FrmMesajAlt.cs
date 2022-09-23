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
        int Sayac = 0;
        bool varsayilan, mesajmi;
        public FrmMesajAlt(string Mesaj, bool MesajMi = true, bool Varsayilan = false, int beklemeSure = 0, string Baslik = "Karma Bildirim Sistemi")
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
            Sayac = beklemeSure;
            if(Sayac > 0)
            {
                BtnYes.Enabled = BtnOk.Enabled = BtnNo.Enabled = false;
                lblBekle.Text = $"Lütfen {Sayac} saniye bekleyiniz...";
                TmrBtnEnabled.Enabled = true;
            }
            else
            {
                lblBekle.Text = "";
            }
            
        }

        private void FrmMesajAlt_Shown(object sender, EventArgs e)
        {
            if (!mesajmi)
            {
                if (varsayilan) BtnYes.Focus();
                else BtnNo.Focus();
            }
        }

        private void TmrBtnEnabled_Tick(object sender, EventArgs e)
        {
            if(Sayac != 1)
            {
                Sayac--;
                lblBekle.Text = $"Lütfen {Sayac} saniye bekleyiniz...";
            }
            else
            {
                lblBekle.Text = "";
                BtnYes.Enabled = true;
                BtnOk.Enabled = true;
                //BtnCancel.Enabled = true;
                BtnNo.Enabled = true;
            }

        }

        private void ButtonsClick(object sender, EventArgs e)
        {
            DialogResult = (sender as Button).DialogResult;
            Close();
        }
    }
}