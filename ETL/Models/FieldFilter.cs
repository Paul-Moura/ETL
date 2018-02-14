using System.Collections.Generic;

namespace ETL.Models
{
    public sealed class FieldFilter
    {
        public string Name { get; set; }

        public FilterType Type { get; set; }

        public FilterAction Action { get; set; }

        public string RegExPattern { get; set; }

        public List<string> List { get; } = new List<string>();
    }
}