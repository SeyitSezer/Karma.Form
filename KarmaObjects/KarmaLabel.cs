using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KarmaLib.KarmaLib;

namespace KarmaObjects
{
    public class KarmaLabel : Label
    {
        private KarmaObject _Control;
        public KarmaObject KarmaFocusControl 
        { 
            get 
            { 
                return _Control; 
            } 
            set
            {
                _Control = value;
                //if (!AppRunning && !(_Control is null))
                //{
                //    ((Control)_Control).Top = Top - 2;
                //    ((Control)_Control).Left = Left + Width + 10;
                //}
            }
        }
        public bool ReadOnly { get; set; }

        public KarmaLabel()
        {
            Font = ObjectsDefaults.GenelYaziTipi();
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }
    }
}
