using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ETL.Models;

namespace ETL.Forms
{
    public partial class AddEditFilterForm : Telerik.WinControls.UI.RadForm
    {
        public AddEditFilterForm()
        {
            this.InitializeComponent();
        }

        public AddEditFilterForm(FieldFilter filter) : this()
        {
            this.FieldFilter = filter ?? new FieldFilter
            {
                Name = "New Filter",
                Type = FilterType.CannotBeNull,
                Action = FilterAction.Flag
            };

            this.ddlType.DataSource = Enum.GetValues(typeof(FilterType));
            this.ddlAction.DataSource = Enum.GetValues(typeof(FilterAction));

            this.txtName.Text = this.FieldFilter.Name;
            this.ddlType.SelectedValue = this.FieldFilter.Type;
            this.ddlAction.SelectedValue = this.FieldFilter.Action;
        }

        public FieldFilter FieldFilter { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.FieldFilter.Name = this.txtName.Text;
            this.FieldFilter.Type = (FilterType) this.ddlType.SelectedValue;
            this.FieldFilter.Action = (FilterAction) this.ddlAction.SelectedValue;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ddlType_SelectedValueChanged(object sender, EventArgs e)
        {
            var val = (FilterType) this.ddlType.SelectedValue;
            this.pnlRegEx.Visible = val == FilterType.CannotMatchRegex || val == FilterType.MustMatchRegex;
            this.pnlList.Visible = val == FilterType.CannotMatchList || val == FilterType.MustMatchList;
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                var regex = new Regex(this.txtPattern.Text);
                MessageBox.Show("RegEx is valid.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("RegEx is invalid.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}