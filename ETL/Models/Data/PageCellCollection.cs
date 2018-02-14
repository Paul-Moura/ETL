using System.Collections;
using System.Collections.Generic;

namespace ETL.Models.Data
{
    internal sealed class PageCellCollection : IEnumerable<PageCell>
    {
        public PageCellCollection()
        {
            this._cells = new List<PageCell>();
        }

        public PageCell this[int index] => this._cells[index];
        
        private readonly List<PageCell> _cells;

        public void Add(PageCell item)
        {
            this._cells.Add(item);
        }

        public bool Remove(PageCell item)
        {
            return this._cells.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this._cells.RemoveAt(index);
        }

        public IEnumerator<PageCell> GetEnumerator()
        {
            return this._cells.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}