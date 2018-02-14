using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ETL.Forms
{
    public partial class SourcePreviewForm : RadForm
    {
        public SourcePreviewForm()
        {
            this.InitializeComponent();
        }

        public void LoadData(IEnumerable<DataTable> tables)
        {
            foreach (var table in tables)
            {
                var grd = new RadGridView
                {
                    DataSource = table,
                    AllowAutoSizeColumns = true,
                    ReadOnly = true
                };
                grd.BestFitColumns(BestFitColumnMode.AllCells);

                var pg = new RadPageViewPage(table.TableName);
                pg.Controls.Add(grd);
                grd.Dock = DockStyle.Fill;

                this.pageView.Pages.Add(pg);
            }
        }
    }
}
