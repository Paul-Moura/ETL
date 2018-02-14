using System;
using ETL.Models.Data;
using System.Collections.Generic;
using ETL.Models;

namespace ETL.Controllers.Export
{
    public abstract class ExportController
    {
        public event EventHandler<MuliPageEventArgs> MultiplePages;

        protected ExportController(ControllerType type)
        {
            this.Type = type;
        }

        internal ControllerType Type { get; }

        internal abstract Result ExportData(IEnumerable<Page> pages, string target);

        internal abstract IEnumerable<Source> GetSchemas(string target);

        protected virtual void OnMultiplePages(MuliPageEventArgs e)
        {
            this.MultiplePages?.Invoke(this, e);
        }
    }
}