using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ETL.Models;
using Telerik.WinControls.UI;

namespace ETL.Forms
{
    public partial class FieldInfoControl : UserControl
    {
        public FieldInfoControl()
        {
            this.InitializeComponent();

            this._sourceFields.DataSource = new List<string>();

            this._fieldInfo.DataSource = new FieldInfo();

            this._filters.DataSource = new List<FieldFilter>();

            this.ddlSource.DataSource = this._sourceFields;

            this.ddlOutputDataType.DataSource = Enum.GetValues(typeof(FieldType));

            var colType = (GridViewComboBoxColumn)this.grdFilters.Columns["colType"];
            colType.DataSource = Enum.GetValues(typeof(FilterType));
            var colAction = (GridViewComboBoxColumn)this.grdFilters.Columns["colAction"];
            colAction.DataSource = Enum.GetValues(typeof(FilterAction));
            this.grdFilters.DataSource = this._filters;

            this.ddlSource.DataBindings.Add(
                nameof(this.ddlSource.SelectedItem),
                this._fieldInfo,
                nameof(FieldInfo.SourceName));

            this.txtOutputFieldName.DataBindings.Add(
                nameof(this.txtOutputFieldName.Text),
                this._fieldInfo,
                nameof(FieldInfo.Name));

            this.ddlOutputDataType.DataBindings.Add(
                nameof(this.ddlOutputDataType.SelectedItem),
                this._fieldInfo,
                nameof(FieldInfo.FieldType));

            this.txtOutputDataSize.DataBindings.Add(
                nameof(this.txtOutputDataSize.Text),
                this._fieldInfo,
                nameof(FieldInfo.Size));

            this.txtFormula.DataBindings.Add(
                nameof(this.txtFormula.Text),
                this._fieldInfo,
                nameof(FieldInfo.Formula));
        }

        private PageInfo _pageInfo;
        private readonly BindingSource _sourceFields = new BindingSource();
        private readonly BindingSource _fieldInfo = new BindingSource();
        private readonly BindingSource _filters = new BindingSource();

        public bool ShowFieldProperties
        {
            get => this.grpProperties.Visible;
            set => this.grpProperties.Visible = value;
        }



        public void SetSourceFields(IEnumerable<string> sourceFields)
        {
            this._sourceFields.DataSource = sourceFields?.ToList() ?? new List<string>();
        }

        public void SetPage(PageInfo page)
        {
            this._pageInfo = page;
        }

        public void SetInfo(FieldInfo info)
        {
            this._fieldInfo.DataSource = info ?? new FieldInfo();
            if (info == null)
            {
                this._filters.DataSource = new List<FieldFilter>();
                this.ddlSource.SelectedIndex = -1;
                this.Enabled = false;
            }
            else
            {
                this._filters.DataSource = info.Filters;
                this.Enabled = true;
            }
        }
        


        private void FieldInfoControl_Load(object sender, EventArgs e)
        {
        }

        private void txtOutputFieldName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;

            var i = this.txtOutputFieldName.SelectionStart;
            var j = this.txtOutputFieldName.SelectionLength;

            var txt = this.txtOutputFieldName.Text;
            var newText = txt.Substring(0, i) + e.KeyChar + txt.Substring(i + j);
            e.Handled = !RegexExpressions.FieldName.IsMatch(newText);
        }

        private void lnkFormulaBuilder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formula = this.txtFormula.Text;
            var field = this.ddlSource.Text;
            var frm = new FormulaEditorForm(formula, field, this._pageInfo);
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.txtFormula.Text = frm.Formula;
            }
        }

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            var frm = new AddEditFilterForm(null);
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this._filters.Add(frm.FieldFilter);
                this.grdFilters.BestFitColumns(BestFitColumnMode.AllCells);
            }
        }
    }
}