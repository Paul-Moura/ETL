using System;
using System.Windows.Forms;

namespace ETL.Forms
{
    public partial class MainForm : Form
    {
        public event EventHandler<ResultEventArgs> LoadData;
        public event EventHandler PreviewSourceData;
        public event EventHandler<CancelEventArgs> ConfigureFields;
        public event EventHandler<CancelEventArgs> MapFields;
        public event EventHandler<ResultEventArgs> Process;
        public event EventHandler<ResultEventArgs> ExportData;

        public MainForm()
        {
            this.InitializeComponent();
        }
        


        private void btnLoadData_Click(object sender, EventArgs e)
        {
            new ImportersExportersForm().ShowDialog();

            var args = new ResultEventArgs();
            this.LoadData?.Invoke(this, args);

            if (args.Result?.Success != true) return;

            this.lblSource.Text = $"[{args.Result.TotalRows}] rows";
            this.lblSource.Visible = true;

            this.btnConfigureFields.Enabled = true;
            this.btnMapFields.Enabled = true;
        }

        private void lblSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.PreviewSourceData?.Invoke(this, EventArgs.Empty);
        }

        private void btnConfigureFields_Click(object sender, EventArgs e)
        {
            var args = new CancelEventArgs();
            this.ConfigureFields?.Invoke(this, args);

            this.btnProcess.Enabled = !args.Cancel;
        }

        private void btnMapFields_Click(object sender, EventArgs e)
        {
            var args = new CancelEventArgs();
            this.MapFields?.Invoke(this, args);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var args = new ResultEventArgs();
            this.Process?.Invoke(this, args);

            if (args.Result?.Success != true) return;

            this.lblProcess.Text = $"[{args.Result.TotalRows}] rows";
            this.lblProcess.Visible = true;

            this.btnReview.Enabled = true;
            this.btnExport.Enabled = true;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var args = new ResultEventArgs();
            this.ExportData?.Invoke(this, args);

            if (args.Result?.Success != true) return;
        }
    }
}