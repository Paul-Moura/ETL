using System.Collections.Generic;
using ETL.Models;
using Telerik.WinControls.UI;

namespace ETL.Forms
{
    public partial class MapFieldsForm : RadForm
    {
        public MapFieldsForm()
        {
            this.InitializeComponent();
        }

        public void Init(IEnumerable<PageConfig> pages, IEnumerable<SchemaInfo> schemas)
        {
            this.mapFieldsControl.Init(pages, schemas);
        }
    }
}
