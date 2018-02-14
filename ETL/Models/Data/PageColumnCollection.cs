using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ETL.Models.Data
{
    internal sealed class PageColumnCollection : IEnumerable<PageColumn>
    {
        public PageColumnCollection(IEnumerable<string> columns)
        {
            var names = columns?.ToArray() ?? throw new ArgumentNullException(nameof(columns));
            this._columns = new PageColumn[names.Length];

            for (var i = 0; i < names.Length; i++)
            {
                var name = names[i];
                this._columns[i] = new PageColumn(name);
            }
        }

        public PageColumn this[int index] => this._columns[index];
        public PageColumn this[string column] => this._columns.First(x => x.Name == column);

        private readonly PageColumn[] _columns;

        public int Count => this._columns.Length;



        //public PageColumn Add(string name, DataType type)
        //{
        //    var col = new PageColumn(this._page, name, type);
        //    foreach (var row in this._page.Rows)
        //    {
        //        var cell = new PageCell(col, row);
        //        col.Cells.Add(cell);
        //    }
        //    this._columns.Add(col);
        //    return col;
        //}

        //public bool Remove(string columnName)
        //{
        //    var col = this[columnName];
        //    return this._columns.Remove(col);
        //}

        //public void RemoveAt(int index)
        //{
        //    this._columns.RemoveAt(index);
        //}

        public IEnumerator<PageColumn> GetEnumerator()
        {
            return this._columns.ToList().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}