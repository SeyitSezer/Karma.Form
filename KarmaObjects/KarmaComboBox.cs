using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KarmaLib.KarmaSQL;
using static KarmaLib.KarmaLib;

namespace KarmaObjects
{
    public partial class KarmaComboBox : LookUpEdit, KarmaObject
    {
        public KarmaComboBox()
        {
            Font = ObjectsDefaults.GenelYaziTipi();
            Properties.NullValuePrompt = "Seçiniz";
            Properties.NullText = "Seçiniz";
            EnterMoveNextControl = true;
        }
        KarmaComboBox altobj, ustobj;
        public string GetSQLText
        {
            get
            {
                if (GetFieldData is null)
                    return "''";
                else
                    return "'" + GetFieldData.ToString() + "'";
            }
        }
        public void RefreshDataSource()
        {
            string ekFiltre = "";
            if (!(KarmaMasterObject is null))
            {
                if (!KarmaMasterObject.IsNull)
                    ekFiltre = " AND " + KarmaMasterFieldName + " = " + KarmaMasterObject.GetSQLText;
            }
            if (!string.IsNullOrEmpty(KarmaLookUpTable) && !string.IsNullOrEmpty(KarmaLookupDisplayField) && !string.IsNullOrEmpty(KarmaLookupValueField))
            {
                Properties.DataSource = GetSQLData("SELECT " + KarmaLookupValueField + "," + KarmaLookupDisplayField + " FROM " + KarmaLookUpTable + " WHERE 1=1 " + KarmaLookupFilter + ekFiltre, KarmaAddSirketWhere, KarmaAddYilWhere);
                Properties.DisplayMember = KarmaLookupDisplayField;
                Properties.ValueMember = KarmaLookupValueField;
            }
        }
        public bool IsNull { get => GetFieldData is null || string.IsNullOrEmpty(GetFieldData.ToString()); }
        public string KarmaFieldName { get; set; }
        public string KarmaLookUpTable { get; set; }
        public string KarmaLookupDisplayField { get; set; }
        public string KarmaLookupValueField { get; set; }
        public string KarmaLookupFilter { get; set; }
        public bool KarmaAddSirketWhere { get; set; } = false;
        public bool KarmaAddYilWhere { get; set; } = false;
        public KarmaValueTypes KarmaValueType { get; set; }
        public KarmaFieldTypes KarmaFieldType { get; set; }
        public KarmaComboBox KarmaMasterObject { get => ustobj; set { ustobj = value; if (!(ustobj is null)) ustobj.altobj = this; } }
        public string KarmaMasterFieldName { get; set; }

        protected override void OnEditValueChanged()
        {
            if (AppRunning && !(altobj is null))
            {
                altobj.Enabled = !IsNull;
                if (altobj.KarmaValueType == KarmaValueTypes.Lookup)
                    altobj.RefreshDataSource();
            }
            base.OnEditValueChanged();
        }
        protected override void OnCreateControl()
        {
            if (AppRunning && KarmaValueType == KarmaValueTypes.Lookup)
            {
                RefreshDataSource();
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
            if (EditValue is null)
                return "";
            else
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
        public DateTime ToTime()
        {
            if (KarmaFieldType == KarmaFieldTypes.Time)
                return Convert.ToDateTime(EditValue);
            else
                return DateTime.MinValue;
        }

        public void KarmaSetValue(object value)
        {
            EditValue = value;
        }

        public object GetFieldData
        {
            get
            {
                object deger;
                switch (KarmaValueType)
                {
                    case KarmaValueTypes.ItemIndex:
                        deger = ItemIndex;
                        break;
                    case KarmaValueTypes.Text:
                        deger = Text;
                        break;
                    case KarmaValueTypes.Lookup:
                        switch (KarmaFieldType)
                        {
                            case KarmaFieldTypes.String:
                                deger = ToString();
                                break;
                            case KarmaFieldTypes.Date:
                                deger = ToDateTime();
                                break;
                            case KarmaFieldTypes.Time:
                                deger = ToTime();
                                break;
                            case KarmaFieldTypes.Numeric:
                                deger = ToDecimal();
                                break;
                            case KarmaFieldTypes.Guide:
                                deger = EditValue;
                                break;
                            default:
                                deger = EditValue;
                                break;
                        }
                        break;
                    default:
                        deger = EditValue;
                        break;
                }
                return deger;
            }
        }

        bool KarmaObject.KarmaIsRequired { get;set; }
    }
    public enum KarmaValueTypes
    {
        ItemIndex,
        Text,
        Lookup
    }
}
