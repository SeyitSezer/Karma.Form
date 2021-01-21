using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
        private string _GuideValue = "";
        private CalcEdit _Numeric;
        private TextEdit _String;
        private DateEdit _Date;
        private TimeEdit _Time;
        private ButtonEdit _Guide;
        private bool _ShowPassword = false;
        KarmaFieldTypes _FieldType;
        KarmaFieldNumericTypes _NumericType;
        public KarmaTextBox()
        {
            InitializeComponent();
            SetFieldType(KarmaFieldTypes.String);
        }

        public BorderStyles BorderStyle { get; set; } = BorderStyles.UltraFlat;
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
            Controls[0].BackColor = base.BackColor;
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
                        _String.BackColor = BackColor;
                        _String.Dock = DockStyle.Fill;
                    }
                    break;
                case KarmaFieldTypes.Date:
                    {
                        _Date = new DateEdit();
                        Controls.Clear();
                        Controls.Add(_Date);
                        _Date.StyleController = KarmaStyle();
                        _Date.BorderStyle = BorderStyle;
                        _Date.BackColor = BackColor;
                        _Date.Dock = DockStyle.Fill;
                    }
                    break;
                case KarmaFieldTypes.Time:
                    {
                        _Time = new TimeEdit();
                        Controls.Clear();
                        Controls.Add(_Time);
                        _Time.BorderStyle = BorderStyle;
                        _Time.StyleController = KarmaStyle();
                        _Time.BackColor = BackColor;
                        _Time.Dock = DockStyle.Fill;
                    }
                    break;
                case KarmaFieldTypes.Numeric:
                    {
                        _Numeric = new CalcEdit();
                        Controls.Clear();
                        Controls.Add(_Numeric);
                        _Numeric.BorderStyle = BorderStyle;
                        _Numeric.BackColor = BackColor;
                        _Numeric.StyleController = KarmaStyle();
                        _Numeric.Dock = DockStyle.Fill;
                        SetNumericType();
                    }
                    break;
                case KarmaFieldTypes.Guide:
                    {
                        _Guide = new ButtonEdit();
                        Controls.Clear();
                        _Guide.ButtonClick += _Guide_ButtonClick; ;
                        Controls.Add(_Guide);
                        _Guide.BorderStyle = BorderStyle;
                        _Guide.BackColor = BackColor;
                        _Guide.StyleController = KarmaStyle();
                        _Guide.Dock = DockStyle.Fill;
                    }
                    break;
                default:
                    break;
            }

        }

        private void _Guide_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
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
                return Convert.ToDateTime(_Time.Text);
            else
                return DateTime.MinValue;
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
