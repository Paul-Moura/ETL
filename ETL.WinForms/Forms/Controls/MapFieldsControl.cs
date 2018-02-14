using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ETL.Models;
using Telerik.WinControls.UI.Data;

namespace ETL.Forms
{
    public partial class MapFieldsControl : UserControl
    {
        private readonly BindingSource _sourceSource;
        private readonly BindingSource _targetSource;
        private readonly BindingSource _sourceFieldsSource;
        private readonly BindingSource _targetFieldsSource;
        private bool _isUpdating;
        private List<SchemaInfo> _schemaSources;
        private PageInfo _selectedPageInfo;
        private SchemaInfo _selectedSchemaSource;

        public MapFieldsControl()
        {
            this.InitializeComponent();

            this._targetSource = new BindingSource
            {
                DataSource = new List<PageInfo>()
            };

            this._targetFieldsSource = new BindingSource
            {
                DataSource = new List<FieldInfo>()
            };

            this._sourceSource = new BindingSource
            {
                DataSource = new List<SchemaInfo>()
            };

            this._sourceFieldsSource = new BindingSource
            {
                DataSource = new List<string>()
            };

            this.ddlOutputPages.DataSource = this._targetSource;
            this.ddlOutputPages.DisplayMember = nameof(PageInfo.SourceName);

            this.lstOutputFields.DataSource = this._targetFieldsSource;
            this.lstOutputFields.DisplayMember = nameof(FieldInfo.SourceName);

            this.ddlSourcePages.DataSource = this._sourceSource;
            this.ddlSourcePages.DisplayMember = nameof(SchemaInfo.Name);

            this.lstSourceFields.DataSource = this._sourceFieldsSource;
        }
        
        public void Init(IEnumerable<PageConfig> pages, IEnumerable<SchemaInfo> schemas)
        {
            try
            {
                this._isUpdating = true;

                this._targetSource.DataSource = pages.Select(x => new PageInfo(x)).ToList();
                this._sourceSource.DataSource = this._schemaSources = schemas.ToList();
                this.ddlOutputPages.SelectedIndex = -1;
                this.ddlSourcePages.SelectedIndex = -1;
            }
            finally
            {
                this._isUpdating = false;
            }

            this.ddlOutputPages.SelectedIndex = 0;
        }
        
        private void ddlSourcePages_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            if (this._isUpdating) return;

            try
            {
                this._isUpdating = true;

                this._selectedPageInfo = (PageInfo) this.ddlSourcePages.SelectedValue;

                this.ddlOutputPages.SelectedValue =
                    this._schemaSources.FirstOrDefault(x => x.Name == this._selectedPageInfo.OutputName);

                this._sourceFieldsSource.DataSource = this._selectedPageInfo.Fields;
            }
            finally
            {
                this._isUpdating = false;
            }
        }

        private void ddlOutputPages_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            if (this._isUpdating) return;

            try
            {
                this._isUpdating = true;

                this._selectedSchemaSource = (SchemaInfo) this.ddlOutputPages.SelectedValue;

                this._selectedPageInfo.OutputName = this._selectedSchemaSource.Name;
            }
            finally
            {
                this._isUpdating = false;
            }
        }

        private void lstSourceFields_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this._isUpdating) return;

            try
            {
                this._isUpdating = true;


            }
            finally
            {
                this._isUpdating = false;
            }
        }

        private void lstOutputFields_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this._isUpdating) return;

            try
            {
                this._isUpdating = true;


            }
            finally
            {
                this._isUpdating = false;
            }
        }
    }
}
