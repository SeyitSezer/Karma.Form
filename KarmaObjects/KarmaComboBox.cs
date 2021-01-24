using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KarmaLib.KarmaSQL;

namespace KarmaObjects
{
    public partial class KarmaComboBox : LookUpEdit
    {
        public KarmaComboBox()
        {
            Font = ObjectsDefaults.GenelYaziTipi();
        }
        public string KarmaFieldName { get; set; }
        public string KarmaLookUpTable { get; set; }
        public string KarmaLookupDisplayField { get; set; }
        public string KarmaLookupValueField { get; set; }
        public string KarmaLookupFilter { get; set; }
        public KarmaValueTypes KarmaValueType { get;set; }
        public KarmaFieldTypes KarmaFieldType { get; set; }

        protected override void OnCreateControl()
        {
            if (KarmaValueType == KarmaValueTypes.Lookup)
            {
                if(!string.IsNullOrEmpty(KarmaLookUpTable) && !string.IsNullOrEmpty(KarmaLookupDisplayField) && !string.IsNullOrEmpty(KarmaLookupValueField))
                {
                    Properties.DataSource = GetSQLData("SELECT " + KarmaLookupValueField + "," + KarmaLookupDisplayField + " FROM " + KarmaLookUpTable + " WHERE 1=1 AND" + KarmaLookupFilter);
                    Properties.DisplayMember = KarmaLookupDisplayField;
                    Properties.ValueMember = KarmaLookupValueField;
                }
            }
            base.OnCreateControl();
        }
        public decimal ToDecimal()
        {
            decimal _Sonuc = 0;
            if (KarmaFieldType == KarmaFieldTypes.Numeric)
            {
                _Sonuc = Convert.ToDecimal(EditValue);
            }
            return _Sonuc;
        }

        public override string ToString()
        {
            return EditValue.ToString();
        }

        public int ToInteger()
        {
            int _Sonuc = 0;

            if (KarmaFieldType == KarmaFieldTypes.Numeric)
                _Sonuc = Convert.ToInt32(EditValue);

            return _Sonuc;
        }

        public DateTime ToDateTime()
        {
            if (KarmaFieldType == KarmaFieldTypes.Date)
                return Convert.ToDateTime(EditValue);
            else
                return DateTime.MinValue;
        }
    }
    public enum KarmaValueTypes
    {
        ItemIndex,
        Text,
        Lookup
    }
}
