using System.Linq;
using System.Text.RegularExpressions;

namespace ETL
{
    public static class FieldNameHelper
    {
        public static string Parse(string fieldName)
        {
            var field = fieldName.Replace(" ", "_").Replace("-", "_");
            field = RegexExpressions.FieldNameParse.Matches(field).Cast<Match>().Aggregate("", (x, y) => x + y.Value, x => x);

            if (!RegexExpressions.FieldName.IsMatch(field))
                field = "_" + field;

            return field;
        }
    }
}
