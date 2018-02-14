using System;
using System.Data;
using System.Windows.Forms;
using ETL.Models;
using Telerik.WinControls.UI;

namespace ETL.Forms
{
    public partial class FormulaEditorForm : RadForm
    {
        public FormulaEditorForm(string formula, string sourceField, PageInfo info)
        {
            this.InitializeComponent();

            this.txtFormula.Text = formula;
            this.lblFieldName.Text = sourceField;
            //this.ddlRow.DataSource = info.DataTable;
            //this.ddlRow.DisplayMember = sourceField;

            foreach (string field in info.SourceFields)
            {
                var menuItem = new RadMenuItem(field);
                menuItem.Click += (sender, args) =>
                {
                    this.FormatFormulaField(field);
                };
                this.menuSourceFields.Items.Add(menuItem);
            }

            this.DialogResult = DialogResult.Cancel;
        }

        public string Formula { get; private set; }



        private void FormatFormulaMacro(string macro)
        {
            var txt = this.txtFormula.SelectedText;

            if (string.IsNullOrWhiteSpace(txt)) return;

            var index = this.txtFormula.Text.IndexOf(txt, StringComparison.Ordinal);

            var start = this.txtFormula.Text.Substring(0, index);

            var end = this.txtFormula.Text.Substring(index + txt.Length);

            var newTxt = $@"{start}${macro}({txt}){end}";

            this.txtFormula.Text = newTxt;

            this.txtFormula.CaretIndex = newTxt.Length - end.Length;
        }

        private void FormatFormulaField(string field)
        {
            var pos = this.txtFormula.CaretIndex;

            var start = this.txtFormula.Text.Substring(0, pos);

            var end = this.txtFormula.Text.Substring(pos);

            var newTxt = $@"{start}$[{field}]{end}";

            this.txtFormula.Text = newTxt;

            this.txtFormula.CaretIndex = newTxt.Length - end.Length;
        }



        private void btnSource_Click(object sender, EventArgs e)
        {
            this.FormatFormulaField("source");
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            this.FormatFormulaMacro("upper");
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            this.FormatFormulaMacro("lower");
        }

        private void btnProper_Click(object sender, EventArgs e)
        {
            this.FormatFormulaMacro("proper");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Formula = this.txtFormula.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var formula = ETL.Formula.Parse(this.txtFormula.Text);
            var row = (DataRowView) this.ddlRow.SelectedItem.DataBoundItem;
            var result = formula.Format(row.Row, this.lblFieldName.Text);
            this.txtTestResult.Text = result.ToString();
        }
    }
}