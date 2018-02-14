using System.ComponentModel;
using ETL.Converters;

namespace ETL.Models
{
    [TypeConverter(typeof(EnumToDescriptionConverter))]
    public enum FieldType
    {
        Text,
        [Description("Whole Number")]
        WholeNumber,
        Decimal,
        [Description("Date/Time")]
        DateTime,
        [Description("True/False")]
        TrueFalse,
        Navigation,
    }
}
