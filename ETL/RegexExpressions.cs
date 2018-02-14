using System.Text.RegularExpressions;

namespace ETL
{
    public static class RegexExpressions
    {
        public static Regex FieldNameParse => new Regex("[a-zA-Z0-9_]");

        public static Regex FieldName => new Regex("^[a-zA-Z_][a-zA-Z0-9_]*$");
    }
}