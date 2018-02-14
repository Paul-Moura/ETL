using System;
using System.Collections;
using System.Collections.Generic;

namespace ETL.Models.Data
{
    internal sealed class PageRowCollection : IEnumerable<PageRow>
    {
        public PageRowCollection(Page page)
        {
            this._page = page ?? throw new ArgumentNullException(nameof(page));
            this._rows = new List<PageRow>();
        }

        public PageRow this[int index] => this._rows[index];

        private readonly Page _page;
        private readonly List<PageRow> _rows;

        public int Count => this._rows.Count;



        public PageRow Add(params object[] values)
        {
            var row = new PageRow(this._page, this._rows.Count);

            for (int i = 0; i < values.Length; i++)
            {
                var column = this._page.Columns[i];

                var cell = new PageCell(column, row)
                {
                    Value = values[i]
                };

                row.Cells.Add(cell);
            }

            this._rows.Add(row);
            return row;
        }

        public bool Remove(PageRow row)
        {
            var result = this._rows.Remove(row);

            if (!result) return false;
            
            for (int i = row.Index; i < this._rows.Count; i++)
            {
                this._rows[i].Index--;
            }

            return true;
        }

        public void RemoveAt(int index)
        {
            this._rows.RemoveAt(index);
            
            for (int i = index; i < this._rows.Count; i++)
            {
                this._rows[i].Index--;
            }
        }

        public IEnumerator<PageRow> GetEnumerator()
        {
            return this._rows.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}