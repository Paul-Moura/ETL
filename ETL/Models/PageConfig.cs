using System.Collections.Generic;

namespace ETL.Models
{
    public sealed class PageConfig
    {
        public PageConfig()
        {
            this.Fields = new List<FieldConfig>();
        }

        public string ImporterName { get; set; }

        public string ImportTableName { get; set; }

        public string ExporterName { get; set; }

        public string Name { get; set; }

        public ICollection<FieldConfig> Fields { get; }
    }
}