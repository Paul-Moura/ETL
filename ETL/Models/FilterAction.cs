using System.ComponentModel;
using ETL.Converters;

namespace ETL.Models
{
    [TypeConverter(typeof(EnumToDescriptionConverter))]
    public enum FilterAction
    {
        Flag,
        [Description("Hard Flag")]
        HardFlag,
        Remove,
    }
}