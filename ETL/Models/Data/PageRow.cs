using System;
using System.Linq;

namespace ETL.Models.Data
{
    internal sealed class PageRow
    {
        public PageRow(Page page, int index)
        {
            this.Page = page ?? throw new ArgumentNullException(nameof(page));
            this.Index = index;
            this.Cells = new PageCellCollection();
        }

        public object this[int index]
        {
            get
            {
                var column = this.Page.Columns[index].Name;
                return this[column];
            }
            set
            {
                var column = this.Page.Columns[index].Name;
                this[column] = value;
            }
        }

        public object this[string column]
        {
            get { return this.Cells.First(x => x.Column.Name == column).Value; }
            set { this.Cells.First(x => x.Column.Name == column).Value = value; }
        }
        

        public Page Page { get; }

        public int Index { get; internal set; }

        public PageCellCollection Cells { get; }

        public bool IsValid => this.Cells.All(
            x => x.IsValid);

        public bool IsRemoved => this.Cells.Any(
            x => !x.IsValid && x.Column.Validators.Any(
                y => y.Action == FilterAction.Remove));

        public string Error => this.Cells.Select(
            x => x.Error)
                .Aggregate((x, y) => x + y);



        public void Validate()
        {
            foreach (PageCell cell in this.Cells)
            {
                cell.Validate();
            }
        }
    }
}