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
using System.Threading;

namespace KarmaLib
{
    public partial class FrmBekle : DevExpress.XtraEditors.XtraForm
    {
        Thread MainThread;
        public FrmBekle(Thread customThread)
        {
            InitializeComponent();
            MainThread = customThread;
            MainThread.Start();
            MainThread.IsBackground = true;
            TmrGenel.Start();
        }

        private void TmrGenel_Tick(object sender, EventArgs e)
        {
            if (!MainThread.IsAlive)
            {
                Close();
            }
        }

        private void FrmBekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainThread.IsAlive)
            {
                KarmaLib.Mesaj("Devam Eden İşlem Varken Ekran Kapatılamaz!");
                e.Cancel = true;
            }
        }
    }
}