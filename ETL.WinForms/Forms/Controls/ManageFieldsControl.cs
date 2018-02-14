using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ETL.Models;

namespace ETL.Forms
{
    public partial class ManageFieldsControl : UserControl
    {
        public ManageFieldsControl()
        {
            this.InitializeComponent();

            this._sourceFields.DataSource = new List<FieldInfo>();
            this._outputFields.DataSource = new List<FieldInfo>();

            this.lstSource.DataSource = this._sourceFields;
            this.lstSource.DisplayMember = nameof(FieldInfo.SourceName);

            this.lstOutput.DataSource = this._outputFields;
            this.lstOutput.DisplayMember = nameof(FieldInfo.Name);
        }

        private bool _isUpdating;
        private readonly BindingSource _sourceFields = new BindingSource();
        private readonly BindingSource _outputFields = new BindingSource();
        private PageInfo _page;
        private FieldInfo _selectedInfo;



        private void UpdateEnables()
        {
            this.btnAddSource.Enabled = this.lstSource.SelectedItems.Count > 0;
            this.btnRemoveTargetAll.Enabled = this.lstSource.Items.Count > 0;
            this.btnRemoveTarget.Enabled = this.lstOutput.SelectedItems.Count > 0;
            this.btnRemoveTargetAll.Enabled = this.lstOutput.Items.Count > 0;
            this.btnTargetUp.Enabled =
                this.btnTargetDown.Enabled =
                    this.lstOutput.Items.Count > this.lstOutput.SelectedItems.Count;
        }
        
        public void SetPage(PageInfo page)
        {
            try
            {
                this._isUpdating = true;

                this._page = page;

                if (page != null)
                {
                    this._sourceFields.DataSource = page.SourceFields.ToList();
                    this._outputFields.DataSource = page.Fields.ToList();
                    this.fieldInfoControl.SetSourceFields(this._page.SourceFields);
                    this.fieldInfoControl.SetInfo(this._page.Fields.FirstOrDefault());
                }
                else
                {
                    this._sourceFields.DataSource = null;
                    this._outputFields.DataSource = null;
                    this.fieldInfoControl.SetSourceFields(null);
                    this.fieldInfoControl.SetInfo(null);
                }

                this.lstSource.SelectedIndex = -1;
                this.lstOutput.SelectedIndex = -1;

                this.btnAddSource.Enabled = 
                    this.btnRemoveTarget.Enabled =
                        this.btnRemoveTargetAll.Enabled =
                            this.btnTargetUp.Enabled =
                                this.btnTargetDown.Enabled =
                                    false;

                this.fieldInfoControl.SetPage(page);
            }
            finally
            {
                this._isUpdating = false;
            }
        }

        private void AddTargets(IEnumerable<string> sourceFields)
        {
            try
            {
                this._isUpdating = true;

                foreach (var item in sourceFields)
                {
                    var outputField = this._page.Add(item);
                    this._outputFields.Add(outputField);
                }

                this.UpdateEnables();

                this.fieldInfoControl.SetInfo(this.lstOutput.SelectedItem as FieldInfo);
            }
            finally
            {
                this._isUpdating = false;
            }
        }

        private void RemoveTargets(IEnumerable<FieldInfo> outputFields)
        {
            try
            {
                this._isUpdating = true;

                foreach (FieldInfo info in outputFields)
                {
                    if (this._page.Remove(info.Name))
                        this._outputFields.Remove(info);
                }

                this.UpdateEnables();

                this.fieldInfoControl.SetInfo(this.lstOutput.SelectedItem as FieldInfo);
            }
            finally
            {
                this._isUpdating = false;
            }
        }



        private void ManageFieldsControl_Load(object sender, EventArgs e)
        {
        }

        private void lstSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._isUpdating) return;

            this.btnAddSource.Enabled = this.lstSource.SelectedItems.Count > 0;
        }

        private void lstOutput_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this._isUpdating) return;

            try
            {
                this._isUpdating = true;

                var count = this.lstOutput.SelectedItems.Count;

                this.UpdateEnables();

                if (count == 1)
                {
                    this._selectedInfo = this.lstOutput.SelectedItem as FieldInfo;
                    this.fieldInfoControl.SetInfo(this._selectedInfo);
                }
                else
                {
                    this.fieldInfoControl.SetInfo(null);
                }

            }
            finally
            {
                this._isUpdating = false;
            }
        }
        
        private void btnAddSource_Click(object sender, EventArgs e)
        {
            this.AddTargets(this.lstSource.SelectedItems.Cast<string>());
        }

        private void btnAddSourceAll_Click(object sender, EventArgs e)
        {
            this.AddTargets(this.lstSource.Items.Cast<string>());
        }

        private void btnNewTarget_Click(object sender, EventArgs e)
        {
            this.AddTargets(new []{""});
        }

        private void btnTargetUp_Click(object sender, EventArgs e)
        {
            try
            {
                this._isUpdating = true;

                var count = this.lstOutput.SelectedIndices.Count;

                List<int> indices = new List<int>();
                List<FieldInfo> items = new List<FieldInfo>();
                foreach (int index in this.lstOutput.SelectedIndices)
                {
                    indices.Add(index);
                    items.Add((FieldInfo)this.lstOutput.Items[index]);
                }

                bool first = this.lstOutput.SelectedIndices[0] == 0;
                int lastIndex = -1;
                for (int i = 0; i < count; i++)
                {
                    var index = indices[i];

                    if (!first || index != lastIndex + 1)
                    {
                        var item = items[i];

                        this._outputFields.Remove(item);
                        this._outputFields.Insert(index - 1, item);
                        //this.lstOutput.SelectedItems.Add(item);
                    }

                    lastIndex = index;
                }

                this.lstOutput.SelectedItems.Clear();
                foreach (var item in items)
                {
                    this.lstOutput.SelectedItems.Add(item);
                }
            }
            finally
            {
                this._isUpdating = false;
            }
        }

        private void btnTargetDown_Click(object sender, EventArgs e)
        {
            try
            {
                this._isUpdating = true;

                var count = this.lstOutput.SelectedIndices.Count;

                List<int> indices = new List<int>();
                List<FieldInfo> items = new List<FieldInfo>();
                foreach (int index in this.lstOutput.SelectedIndices)
                {
                    indices.Add(index);
                    items.Add((FieldInfo)this.lstOutput.Items[index]);
                }

                bool last = this.lstOutput.SelectedIndices[count - 1] == this.lstOutput.Items.Count - 1;
                int lastIndex = this.lstOutput.Items.Count;
                for (int i = count - 1; i >= 0; i--)
                {
                    var index = indices[i];

                    if (!last || index != lastIndex - 1)
                    {
                        var item = items[i];

                        this._outputFields.Remove(item);
                        this._outputFields.Insert(index + 1, item);
                        //this.lstOutput.SelectedItems.Add(item);
                    }

                    lastIndex = index;
                }

                this.lstOutput.SelectedItems.Clear();
                foreach (var item in items)
                {
                    this.lstOutput.SelectedItems.Add(item);
                }
            }
            finally
            {
                this._isUpdating = false;
            }
        }

        private void btnRemoveTarget_Click(object sender, EventArgs e)
        {
            this.RemoveTargets(this.lstOutput.SelectedItems.Cast<FieldInfo>().ToList());
        }

        private void btnRemoveTargetAll_Click(object sender, EventArgs e)
        {
            this.RemoveTargets(this.lstOutput.Items.Cast<FieldInfo>().ToList());
        }
    }
}
