using System;
using ETL.Models;

namespace ETL.Controllers.Import
{
    public abstract class ImportController
    {
        public event EventHandler<MuliPageEventArgs> MultiplePages;

        protected ImportController(ControllerType type)
        {
            this.Type = type;
        }

        internal ControllerType Type { get; }

        internal abstract Source[] ImportData(string source);

        protected virtual void OnMultiplePages(MuliPageEventArgs e)
        {
            this.MultiplePages?.Invoke(this, e);
        }
    }
}