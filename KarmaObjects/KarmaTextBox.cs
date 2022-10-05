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
    public partial class KarmaTextBox : Control, KarmaObject
    {
        SerializableAppearanceObject serializableAppearanceObject1 = new SerializableAppearanceObject();
        SerializableAppearanceObject serializableAppearanceObject2 = new SerializableAppearanceObject();
        SerializableAppearanceObject serializableAppearanceObject3 = new SerializableAppearanceObject();
        SerializableAppearanceObject serializableAppearanceObject4 = new SerializableAppearanceObject();
        EditorButtonImageOptions editorButtonImageOptions1 = new EditorButtonImageOptions();
        ComponentResourceManager resources = new ComponentResourceManager(typeof(KarmaForm));
        private CalcEdit _Numeric;
        private TextEdit _String;
        private DateEdit _Date;
        private TimeEdit _Time;
        private ButtonEdit _Guide;
        private bool _ShowPassword = false;
        KarmaFieldTypes _FieldType;
        KarmaFieldNumericTypes _NumericType;
        public bool KarmaLastEdit { get; set; } = false;
        public KarmaButton _Btn;
        public KarmaTextBox()
        {
            InitializeComponent();
            SetFieldType(KarmaFieldTypes.String);
        }
        public string KarmaFieldName { get; set; }
        public string KarmaGuideTableName { get; set; }
        public string KarmaGuideColumnName { get; set; }
        public string KarmaGuideFields { get; set; }
        public string KarmaGuideFilter { get; set; }
        public string KarmaGuideName { get; set; }
        public bool KarmaAddSirketWhere { get; set; } = false;
        public bool KarmaAddYilWhere { get; set; } = false;
        public BorderStyles BorderStyle { get; set; } = BorderStyles.UltraFlat;

        public void xOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if(KarmaLastEdit && !(_Btn is null))
                {
                    _Btn.Post();
                }
            }
        }
        public KarmaTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public KarmaFieldNumericTypes KarmaNumericType
        {
            get
            {
                return _NumericType;
            }
            set
            {
                _NumericType = value;
                SetNumericType();
            }
        }

        private void SetNumericType()
        {
            if (_FieldType == KarmaFieldTypes.Numeric)
            {
                _Numeric.Properties.EditFormat.FormatType = FormatType.Numeric;
                _Numeric.Properties.Mask.EditMask = "N" + GetOndalik(KarmaNumericType).ToString();
                _Numeric.Properties.Mask.UseMaskAsDisplayFormat = true;
                _Numeric.Properties.DisplayFormat.FormatType = FormatType.Custom;
                _Numeric.Properties.DisplayFormat.FormatString = "N" + GetOndalik(KarmaNumericType).ToString();
            }
        }
        public bool KarmaPasswordTextBox
        {
            get { return _ShowPassword; }
            set
            {
                _ShowPassword = value;
                if (KarmaFieldType == KarmaFieldTypes.String)
                {
                    _String.Properties.UseSystemPasswordChar = value;
                }
                else
                {
                    _ShowPassword = false;
                }
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            Controls[0].Focus();
            base.OnGotFocus(e);
        }

        public KarmaFieldTypes KarmaFieldType
        {
            get { return _FieldType; }
            set { SetFieldType(value); }
        }

        public override string Text
        {
            get
            {
                string _Sonuc = "";
                switch (KarmaFieldType)
                {
                    case KarmaFieldTypes.String:
                        _Sonuc = _String.Text;
                        break;
                    case KarmaFieldTypes.Date:
                        _Sonuc = _Date.Text;
                        break;
                    case KarmaFieldTypes.Time:
                        _Sonuc = _Time.Text;
                        break;
                    case KarmaFieldTypes.Numeric:
                        _Sonuc = _Numeric.Text;
                        break;
                    case KarmaFieldTypes.Guide:
                        _Sonuc = _Guide.Text;
                        break;
                    default:
                        _Sonuc = Controls[0].Text;
                        break;
                }
                return _Sonuc;
            }
            set
            {
                DateTime _d;
                decimal _x;
                string _Sonuc = value;
                switch (KarmaFieldType)
                {
                    case KarmaFieldTypes.String:
                        _String.Text = _Sonuc;
                        break;
                    case KarmaFieldTypes.Date:
                        _Date.DateTime = DateTime.TryParse(_Sonuc, out _d) ? _d : DateTime.Now;
                        break;
                    case KarmaFieldTypes.Time:
                        _Time.Time = DateTime.TryParse(_Sonuc, out _d) ? _d : DateTime.Now;
                        break;
                    case KarmaFieldTypes.Numeric:
                        _Numeric.Value = decimal.TryParse(_Sonuc, out _x) ? _x : 0;
                        break;
                    case KarmaFieldTypes.Guide:
                        _Guide.Text = _Sonuc;
                        break;
                    default:
                        _Sonuc = "";
                        break;
                }
            }
        }
        public bool IsNull 
        { 
            get 
            { 
                return string.IsNullOrEmpty(Text); 
            } 
        }
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
            }
        }

        public bool ReadOnly { get; set; }

        protected override void OnCreateControl()
        {
            //Controls[0].BackColor = base.BackColor;
            base.OnCreateControl();
        }
        private void SetFieldType(KarmaFieldTypes _Type)
        {
            _FieldType = _Type;
            switch (_Type)
            {
                case KarmaFieldTypes.String:
                    {
                        _String = new TextEdit();
                        Controls.Clear();
                        Controls.Add(_String);
                        _String.BorderStyle = BorderStyle;
                        _String.StyleController = KarmaStyle();
                        _String.Dock = DockStyle.Fill;
                        _String.EnterMoveNextControl = true;
                        _String.KeyDown += xOnKeyDown;
                    }
                    break;
                case KarmaFieldTypes.Date:
                    {
                        _Date = new DateEdit();
                        Controls.Clear();
                        Controls.Add(_Date);
                        _Date.StyleController = KarmaStyle();
                        _Date.BorderStyle = BorderStyle;
                        _Date.Dock = DockStyle.Fill;
                        _Date.EnterMoveNextControl = true;
                        _Date.KeyDown += xOnKeyDown;
                    }
                    break;
                case KarmaFieldTypes.Time:
                    {
                        _Time = new TimeEdit();
                        Controls.Clear();
                        Controls.Add(_Time);
                        _Time.BorderStyle = BorderStyle;
                        _Time.StyleController = KarmaStyle();
                        _Time.Dock = DockStyle.Fill;
                        _Time.EnterMoveNextControl = true;
                        _Time.KeyDown += xOnKeyDown;
                    }
                    break;
                case KarmaFieldTypes.Numeric:
                    {
                        _Numeric = new CalcEdit();
                        Controls.Clear();
                        Controls.Add(_Numeric);
                        _Numeric.BorderStyle = BorderStyle;
                        _Numeric.StyleController = KarmaStyle();
                        _Numeric.Dock = DockStyle.Fill;
                        SetNumericType();
                        _Numeric.EnterMoveNextControl= true;
                        _Numeric.KeyDown += xOnKeyDown;
                    }
                    break;
                case KarmaFieldTypes.Guide:
                    {
                        _Guide = new ButtonEdit();
                        Controls.Clear();
                        _Guide.Properties.Buttons.Clear();
                        editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
                        _Guide.Properties.Buttons.AddRange(new EditorButton[] {
            new EditorButton(ButtonPredefines.Search, "", 22, true, true, false, editorButtonImageOptions1, new KeyShortcut((Keys.Control | Keys.F)), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
                        _Guide.ButtonClick += _Guide_ButtonClick; ;
                        _Guide.KeyDown += _Guide_KeyDown; ;
                        Controls.Add(_Guide);
                        _Guide.BorderStyle = BorderStyle;
                        _Guide.StyleController = KarmaStyle();
                        _Guide.Dock = DockStyle.Fill;
                        _Guide.EnterMoveNextControl= true;
                        _Guide.KeyDown += xOnKeyDown;
                    }
                    break;
                default:
                    break;
            }

        }

      

        private void _Guide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                e.Handled = true;
                if (KarmaFieldType == KarmaFieldTypes.Guide)
                {
                    _Guide_ButtonClick(this, null);
                }
            }
        }

        private void _Guide_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            KarmaRehber rehber = new KarmaRehber(KarmaGuideTableName, KarmaGuideFields, KarmaGuideColumnName, KarmaGuideFilter, KarmaGuideName, KarmaAddSirketWhere, KarmaAddYilWhere);
            rehber.ShowDialog();
            Text = rehber.Sonuc;
            if (!(KarmaOnGuideClick is null))
                KarmaOnGuideClick(sender, e);
        }

        public event OnGuideClick KarmaOnGuideClick;
        public delegate void OnGuideClick(object Sender, EventArgs e);

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = Controls[0].Height;
        }

        public decimal ToDecimal()
        {
            decimal _Sonuc = 0;
            if (KarmaFieldType == KarmaFieldTypes.Numeric)
            {
                _Sonuc = _Numeric.Value;
            }
            return _Sonuc;
        }

        public override string ToString()
        {
            string _Sonuc = "";
            switch (KarmaFieldType)
            {
                case KarmaFieldTypes.String:
                    _Sonuc = _String.Text;
                    break;
                case KarmaFieldTypes.Date:
                    _Sonuc = _Date.Text;
                    break;
                case KarmaFieldTypes.Time:
                    _Sonuc = _Time.Text;
                    break;
                case KarmaFieldTypes.Numeric:
                    _Sonuc = _Numeric.Text;
                    break;
                case KarmaFieldTypes.Guide:
                    _Sonuc = _Guide.Text;
                    break;
                default:
                    _Sonuc = "";
                    break;
            }
            return _Sonuc;
        }

        public int ToInteger()
        {
            int _Sonuc = 0;

            if (KarmaFieldType == KarmaFieldTypes.Numeric)
                _Sonuc = Convert.ToInt32(_Numeric.Value);

            return _Sonuc;
        }

        public DateTime ToDateTime()
        {
            if (KarmaFieldType == KarmaFieldTypes.Date)
                return Convert.ToDateTime(_Date.Text);
            else
                return DateTime.MinValue;
        }
        public DateTime ToTime()
        {
            if (KarmaFieldType == KarmaFieldTypes.Time)
                return Convert.ToDateTime(_Time.Text);
            else
                return DateTime.MinValue;
        }

        public object GetFieldData
        {
            get
            {
                object deger;
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
                        deger =  ToString();
                        break;
                    default:
                        deger = "";
                        break;
                }
                return deger;
            }
        }
        public string GetSQLText
        {
            get
            {
                string deger;
                switch (KarmaFieldType)
                {
                    case KarmaFieldTypes.String:
                        deger = "'" +ToString().Replace("'","''") + "'";
                        break;
                    case KarmaFieldTypes.Date:
                        deger = "'" + ToDateTime().ToString("yyyy-MM-dd") + "'";
                        break;
                    case KarmaFieldTypes.Time:
                        deger = ToTime().ToString("hh-mm-ss");
                        break;
                    case KarmaFieldTypes.Numeric:
                        deger = ToDecimal().ToString().Replace(",",".");
                        break;
                    case KarmaFieldTypes.Guide:
                        deger = "'" + ToString().Replace("'", "''") + "'";
                        break;
                    default:
                        deger = "null";
                        break;
                }
                return deger;
            }
        }

        public bool KarmaIsRequired { get; set; }

        protected override void OnLeave(EventArgs e)
        {
            if (Parent is KarmaPanel && (Parent as KarmaPanel).KarmaMasterTextBox == this)
            {
                (Parent as KarmaPanel).KarmaLoadFromTable();
            }
            base.OnLeave(e);
        }

        public void KarmaSetValue(object value)
        {
            Text = value.ToString();
        }
    }

    public enum KarmaFieldTypes
    {
        String,
        Date,
        Time,
        Numeric,
        Guide
    }

}
