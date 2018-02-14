using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ETL.Controllers;
using ETL.Controllers.Import;
using ETL.Models;

namespace ETL.Forms
{
    public partial class ConfigureFieldsForm : Form
    {
        public ConfigureFieldsForm()
        {
            this.InitializeComponent();
        }

        public ConfigureFieldsForm(IEnumerable<PageConfig> pages) : this()
        {
            this._pages = pages.Select(x => new PageInfo(x)).ToList();
            
            this.ddlPage.DataSource = new BindingSource
            {
                DataSource = new BindingList<PageInfo>(this._pages)
            };
            this.ddlPage.DisplayMember = nameof(PageInfo.SourceName);
            this.ddlPage.SelectedIndex = 0;

            this._pageSource.DataSource = this._pages[0];

            this.txtPageName.DataBindings.Add(
                nameof(this.txtPageName.Text),
                this._pageSource,
                nameof(PageInfo.OutputName));
        }


        private readonly BindingSource _pageSource = new BindingSource();
        private readonly List<PageInfo> _pages;
        public IEnumerable<PageInfo> Pages => this._pages;


        
        private void ddlPage_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedPage = this.ddlPage.SelectedItem as PageInfo;

            this.manageFieldsControl.SetPage(selectedPage);

            this._pageSource.DataSource = selectedPage;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPageName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;

            var i = this.txtPageName.SelectionStart;
            var j = this.txtPageName.SelectionLength;

            var txt = this.txtPageName.Text;
            var newText = txt.Substring(0, i) + e.KeyChar + txt.Substring(i + j);
            e.Handled = !RegexExpressions.FieldName.IsMatch(newText);
        }
    }
}