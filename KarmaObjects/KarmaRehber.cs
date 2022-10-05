using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KarmaLib.KarmaSQL;

namespace KarmaObjects
{
    public partial class KarmaRehber : KarmaForm
    {
        string DonecekAlan="";
        public string Sonuc;
        public KarmaRehber(string TableName, string Alanlar, string xDonecekAlan, string SabitFiltre = "", string Baslik = "Rehber", bool AddSirket = true, bool AddYil = true)
        {
            InitializeComponent();
            DonecekAlan = xDonecekAlan;
            Text = Baslik;
            string SQLText = "SELECT " + Alanlar + " FROM " + TableName + " WITH(NOLOCK) WHERE 1=1 " + SabitFiltre;
            GrdRehber.DataSource = GetSQLData(SQLText, AddSirket, AddYil);
        }

        private void KarmaRehber_Load(object sender, EventArgs e)
        {
            var a = (GrdRehber.Views[0] as GridView);
            a.OptionsFind.AlwaysVisible = true;
            a.OptionsFind.ShowFindButton = false;
            a.OptionsFind.FindNullPrompt = "Aramak İstediğiniz Tümceyi Buraya Yazın...";
            a.OptionsView.ShowGroupPanel = false;
            a.OptionsBehavior.Editable = false;
            a.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            a.ShowFindPanel();
        }

        private void GrdRehber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Sonuc = !(GrdRehber.GetValueByColumnName(DonecekAlan) is null) ? GrdRehber.GetValueByColumnName(DonecekAlan).ToString() : "";
            }
            catch (Exception)
            {
                Sonuc = "";
            }
            finally
            {
                Close();
            }
            Close();
        }
    }
}
