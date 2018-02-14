using System;
using System.ComponentModel;

namespace ETL.Converters
{
    public class EnumToDescriptionConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(Enum);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        //public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        //{
        //    return base.ConvertFrom(context, culture, value);
        //}

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            object value, Type destinationType)
        {
            if (destinationType != typeof(string))
            {
                throw new ArgumentException("Can only convert to string.", nameof(destinationType));
            }

            var memberInfo = value.GetType().BaseType;
            if (memberInfo != null && memberInfo != typeof(Enum))
            {
                throw new ArgumentException("Can only convert an instance of enum.", nameof(value));
            }

            string name = value.ToString();
            object[] attrs = value.GetType().GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attrs.Length > 0 ? ((DescriptionAttribute) attrs[0]).Description : name;
        }
    }
}