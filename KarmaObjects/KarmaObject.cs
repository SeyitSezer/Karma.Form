using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmaObjects
{
    public interface KarmaObject
    {
        bool ReadOnly { get; set; }
        string KarmaFieldName { get; set; }
        string GetSQLText { get; }
        object GetFieldData { get; }
        bool IsNull { get; }
        void KarmaSetValue(object value);
        bool KarmaIsRequired { get; set; }
    }
}
