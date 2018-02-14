using System.ComponentModel;
using ETL.Converters;

namespace ETL.Models
{
    [TypeConverter(typeof(EnumToDescriptionConverter))]
    public enum FilterType
    {
        [Description("Cannot Be Null")]
        CannotBeNull,
        [Description("Cannot Match List")]
        CannotMatchList,
        [Description("Cannot Match Regex")]
        CannotMatchRegex,
        [Description("Must Be Null")]
        MustBeNull,
        [Description("Must Match List")]
        MustMatchList,
        [Description("Must Match Regex")]
        MustMatchRegex,
        [Description("Standardize Input")]
        StandardizeInput,
    }
}