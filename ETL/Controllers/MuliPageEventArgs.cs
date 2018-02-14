using System.Collections.Generic;

namespace ETL.Controllers
{
    public sealed class MuliPageEventArgs
    {
        public List<string> Pages { get; set; }

        public bool Cancel { get; set; }

        public MuliPageEventArgs(List<string> pages)
        {
            this.Pages = pages;
        }
    }
}