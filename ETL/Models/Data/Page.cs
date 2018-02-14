using System.Collections.Generic;
using System.Linq;

namespace ETL.Models.Data
{
    internal sealed class Page
    {
        public Page(string name, IEnumerable<string> columns)
        {
            this.Columns = new PageColumnCollection(columns);
            this.Rows = new PageRowCollection(this);
            this.Name = name;
        }

        public PageColumnCollection Columns { get; }
        public PageRowCollection Rows { get; }

        public IEnumerable<PageRow> Removed => this.Rows.Where(x => x.IsRemoved);

        //TODO: validate setter value before assigning. use FieldNameHelper
        public string Name { get; set; }

        public int RowCount => this.Rows.Count;

        public int ColumnCount => this.Columns.Count;

        public bool IsValid => this.Rows.All(x => x.IsValid);



        public void Validate()
        {
            foreach (var row in this.Rows)
            {
                row.Validate();
            }
        }
    }
}