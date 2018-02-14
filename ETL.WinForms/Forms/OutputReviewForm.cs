using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ETL.Models.Data;
using Telerik.WinControls.UI;

namespace ETL.Forms
{
    public partial class OutputReviewForm : RadForm
    {
        private readonly BindingSource _pageSource;
        private readonly BindingSource _rowsSource;

        public OutputReviewForm()
        {
            this.InitializeComponent();

            this._pageSource = new BindingSource
            {
                DataSource = new List<Page>()
            };

            this._rowsSource = new BindingSource
            {
                DataSource = new List<PageRow>()
            };

            this.ddlPages.DataSource = this._pageSource;
            this.grdFinalOutput.DataSource = this._rowsSource;
        }

        internal void Init(IEnumerable<Page> pages)
        {
            var pgList = pages.ToList();
            this._pageSource.DataSource = pgList;
            this.ddlPages.SelectedIndex = 0;
        }

        private void ddlPages_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var val = this.ddlPages.SelectedValue as Page;
            if (val == null)
            {
                this._rowsSource.DataSource = new List<PageRow>();
                //this.
            }
            else
            {
                
            }
        }
    }
}
