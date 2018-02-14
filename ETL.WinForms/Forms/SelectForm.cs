using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ETL.Forms
{
    public partial class SelectForm : Form
    {
        public string[] SelectedItems { get; private set; }

        public bool AllowMultiple
        {
            get => this.lstItems.SelectionMode == SelectionMode.MultiExtended;
            set => this.lstItems.SelectionMode = value
                ? SelectionMode.MultiExtended
                : SelectionMode.One;
        }

        public SelectForm(string title, string message, IEnumerable<string> items)
        {
            this.InitializeComponent();
            this.Text = title;
            this.label1.Text = message;
            this.lstItems.Items.AddRange(items.ToArray());
        }

        private void lstSheets_SelectedValueChanged(object sender, System.EventArgs e)
        {
            this.btnOk.Enabled = this.lstItems.SelectedIndices.Count > 0;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.SelectedItems = this.lstItems.SelectedItems.Cast<string>().ToArray();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}