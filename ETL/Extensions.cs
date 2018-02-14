using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace ETL
{
    public static class Extensions
    {
        public static bool Contains(char inChar, char[] findInChars)
        {
            foreach (int findInChar in findInChars)
            {
                if (findInChar == (int) inChar)
                    return true;
            }
            return false;
        }

        public static bool Contains(string text, int index, char[] findInChars)
        {
            char ch = text[index];
            foreach (int findInChar in findInChars)
            {
                if (findInChar == (int) ch)
                    return true;
            }
            return false;
        }

        public static bool Contains(string text, int index, string findInText)
        {
            return findInText.IndexOf(text[index]) >= 0;
        }
        
        public static string Indent(this string text, int totalWidth = 1)
        {
            return text.Indent(totalWidth, '\t'.ToString());
        }

        public static string Indent(this string text, int totalWidth, string paddingChar)
        {
            if (text == null)
                return (string) null;
            if (totalWidth == 0)
                return text;
            if (totalWidth < 0)
                return text.Unindent(totalWidth, paddingChar);
            string empty = string.Empty;
            for (int index = 0; index < totalWidth; ++index)
                empty += paddingChar;
            string pattern = string.Format(".*[{0}]*", (object) Environment.NewLine);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Match match in Regex.Matches(text, pattern))
            {
                if (match.ToString() == Environment.NewLine || string.IsNullOrEmpty(match.ToString().Trim()))
                    stringBuilder.AppendFormat("{0}", (object) match.ToString());
                else
                    stringBuilder.AppendFormat("{0}{1}", (object) empty, (object) match.ToString());
            }
            return stringBuilder.ToString();
        }

        public static string Unindent(this string text)
        {
            return text.Unindent(1, '\t'.ToString());
        }

        public static string Unindent(this string text, int totalWidth)
        {
            return text.Unindent(totalWidth, '\t'.ToString());
        }

        public static string Unindent(this string text, int totalWidth, string paddingChar)
        {
            if (text == null)
                return (string) null;
            if (totalWidth == 0)
                return text;
            if (totalWidth < 0)
                return text.Indent(Math.Abs(totalWidth), paddingChar);
            string pattern1 = string.Format(".*[{0}]*", (object) Environment.NewLine);
            string pattern2 = string.Format("{1}(?<text>.*[{0}]|.*)", (object) Environment.NewLine,
                (object) paddingChar);
            StringBuilder stringBuilder = new StringBuilder();
            for (int index = -1 * Math.Abs(totalWidth); index < 0; ++index)
            {
                stringBuilder = new StringBuilder();
                foreach (Match match1 in Regex.Matches(text, pattern1))
                {
                    if (match1.ToString() == Environment.NewLine || string.IsNullOrEmpty(match1.ToString().Trim()))
                    {
                        stringBuilder.AppendFormat("{0}", (object) match1.ToString());
                    }
                    else
                    {
                        Match match2 = Regex.Match(match1.ToString(), pattern2);
                        if (!match2.Success)
                            return text;
                        stringBuilder.AppendFormat("{0}", (object) match2.Groups["text"].ToString());
                    }
                }
                text = stringBuilder.ToString();
            }
            return stringBuilder.ToString();
        }

        public static bool ContainsMultiLines(this string inString)
        {
            if (inString.IsNullOrEmpty())
                return false;
            return inString.IndexOf(Environment.NewLine) != inString.LastIndexOf(Environment.NewLine);
        }

        public static string First(this string source, int len)
        {
            if (len >= source.Length)
                return source;
            return source.Substring(0, len);
        }

        public static string Last(this string source, int len)
        {
            if (len >= source.Length)
                return source;
            string str = source;
            int startIndex = str.Length - len;
            return str.Substring(startIndex);
        }
        
        public static void Raise(this EventHandler eventHandler, object sender, EventArgs e)
        {
            EventHandler eventHandler1 = eventHandler;
            if (eventHandler1 == null)
                return;
            eventHandler1(sender, e);
        }

        public static void Raise<T>(this EventHandler<T> eventHandler, object sender, T e) where T : EventArgs
        {
            EventHandler<T> eventHandler1 = eventHandler;
            if (eventHandler1 == null)
                return;
            eventHandler1(sender, e);
        }

        public static string FormatString(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
        
        public static bool IsEmpty(this string text)
        {
            if (text != null)
                return text.Length == 0;
            return false;
        }

        public static bool IsNull(this string text)
        {
            return text == null;
        }

        public static bool IsNullOrEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }

        public static bool IsNullOrWhiteSpace(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        public static Type GetEnumerableType(this Type type)
        {
            foreach (Type type1 in type.GetInterfaces())
            {
                if (type1.IsGenericType && type1.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                    return type1.GetGenericArguments()[0];
            }
            return (Type) null;
        }

        public static bool IsGenericList(this Type type)
        {
            return ((IEnumerable<Type>) type.GetInterfaces()).Any<Type>((Func<Type, bool>) (t =>
            {
                if (t.IsGenericType)
                    return t.GetGenericTypeDefinition() == typeof(IList<>);
                return false;
            }));
        }

        public static bool IsNullableType(this Type type)
        {
            if (type != (Type) null && type.IsGenericType)
                return type.GetGenericTypeDefinition() == typeof(Nullable<>).GetGenericTypeDefinition();
            return false;
        }

        public static Type GetUnderlyingType(this Type type)
        {
            if (type.IsNullableType())
                return Nullable.GetUnderlyingType(type);
            return type;
        }

        public static object Default(this Type type)
        {
            if (type.IsValueType)
                return Activator.CreateInstance(type);
            return (object) null;
        }
        
        public static Attribute GetCustomAttribute(this Type type, Type attributeType, bool inherit)
        {
            object[] customAttributes = type.GetCustomAttributes(attributeType, inherit);
            if (customAttributes != null && customAttributes.Length != 0)
                return customAttributes[0] as Attribute;
            return (Attribute) null;
        }

        public static T GetCustomAttribute<T>(this Type type) where T : Attribute
        {
            Type attributeType = typeof(T);
            if (type == (Type) null)
                return default(T);
            if (type.GetCustomAttributes().Any<Attribute>((Func<Attribute, bool>) (a => a.GetType() == attributeType)))
                return type.GetCustomAttributes()
                    .Where<Attribute>((Func<Attribute, bool>) (x => x.GetType() == attributeType))
                    .FirstOrDefault<Attribute>() as T;
            foreach (Type type1 in type.GetInterfaces())
            {
                Attribute[] customAttributes = type1.GetCustomAttributes(attributeType);
                if (customAttributes != null && customAttributes.Length != 0)
                    return (T) customAttributes[0];
            }
            return default(T);
        }

        public static Attribute[] GetCustomAttributes(this Type type, Type attributeType)
        {
            if (type == (Type) null)
                return new Attribute[0];
            if (type.GetCustomAttributes().Any<Attribute>((Func<Attribute, bool>) (a => a.GetType() == attributeType)))
                return type.GetCustomAttributes()
                    .Where<Attribute>((Func<Attribute, bool>) (x => x.GetType() == attributeType))
                    .ToArray<Attribute>();
            foreach (Type type1 in type.GetInterfaces())
            {
                Attribute[] customAttributes = type1.GetCustomAttributes(attributeType);
                if (customAttributes != null && customAttributes.Length != 0)
                    return customAttributes;
            }
            return new Attribute[0];
        }
        
        public static bool IsSubclassOfRawGeneric(this Type generic, Type toCheck)
        {
            for (; toCheck != (Type) null && toCheck != typeof(object); toCheck = toCheck.BaseType)
            {
                Type type = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == type)
                    return true;
            }
            return false;
        }

        public static string ToProper(this string str)
        {
            var a = str.Substring(0, 1);
            var b = str.Substring(1);
            return a.ToUpper() + b.ToLower();
        }
    }
}