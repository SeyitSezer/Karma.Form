using DevExpress.CodeParser;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using KarmaObjects.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KarmaLib.KarmaLib;
using static KarmaObjects.ObjectsDefaults;

namespace KarmaObjects
{
    public partial class KarmaCheck : ToggleSwitch, KarmaObject
    {
        public KarmaCheck()
        {
            Font = GenelYaziTipi();
            Properties.OnText = "Evet";
            Properties.OffText = "Hayır";
            EnterMoveNextControl = true;
        }
        public bool ToBool()
        {
            return IsOn ? KarmaCheckedValue.ToBool() : KarmaUnCheckedValue.ToBool();
        }

        public override string ToString()
        {
            //base.ToString();
            return IsOn ? KarmaCheckedValue : KarmaUnCheckedValue;
        }

        public int ToInt()
        {
            return IsOn ? KarmaCheckedValue.ToInt() : KarmaUnCheckedValue.ToInt();
        }
        public decimal ToDecimal()
        {
            return IsOn ? KarmaCheckedValue.ToDecimal() : KarmaUnCheckedValue.ToDecimal();
        }

        public void KarmaSetValue(object value)
        {
            if (value is bool)
                IsOn = (value.ToBool());
            else
            {
                IsOn = KarmaCheckedValue == value.ToString();
            }
        }

        public string KarmaFieldName { get; set; }

        public string GetSQLText { get => "'" + GetFieldData + "'"; }

        public object GetFieldData { get => EditValue; }

        public bool IsNull { get => EditValue is null; }
        public string KarmaCheckedText { get => Properties.OnText; set => Properties.OnText = value; }
        public string KarmaUnCheckedText { get => Properties.OffText; set => Properties.OffText = value; }
        public string KarmaCheckedValue { get => Properties.ValueOn.ToString(); set => Properties.ValueOn = value; }
        public string KarmaUnCheckedValue { get => Properties.ValueOff.ToString(); set => Properties.ValueOff = value; }
        
    }
}
