using System;
using System.IO;
using System.Windows.Forms;
using ETL.Controllers;
using Telerik.WinControls.UI;

namespace ETL.Forms
{
    public partial class ImportersExportersForm : RadForm
    {
        public ImportersExportersForm()
        {
            this.InitializeComponent();

            this.DialogResult = DialogResult.Cancel;

            var col = (GridViewComboBoxColumn) this.grdImporters.Columns["colType"];
            col.DataSource = Enum.GetValues(typeof(ControllerType));
            
            this.grdImporters.CurrentCellChanged += this.GrdImporters_OnCurrentCellChanged;
            this.grdImporters.CellValueChanged += this.GrdImporters_OnCellValueChanged;
        }

        private void GrdImporters_OnCurrentCellChanged(object sender, CurrentCellChangedEventArgs e)
        {
            if (e.NewCell.ColumnInfo.Name != "colType")
            {
                var cell = e.NewCell.RowInfo.Cells["colType"];

                if (cell.Value != null) return;

                this.grdImporters.ClearSelection();
                cell.IsSelected = true;
                cell.BeginEdit();
            }
        }
        
        private void GrdImporters_OnCellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name != "colType") return;

            ControllerType type;
            if (!Enum.TryParse(e.Value.ToString(), out type)) return;

            string source = "";
            string name = "";

            switch (type)
            {
                case ControllerType.EXCEL:
                    OpenFileDialog dialog = new OpenFileDialog { Filter = "Excel Files|*.xls;*.xlsx;*.xlsm" };
                    if (dialog.ShowDialog() != DialogResult.OK) return;
                    source = dialog.FileName;
                    name = Path.GetFileNameWithoutExtension(dialog.FileName);
                    break;
                case ControllerType.SQL:
                    break;
                case ControllerType.XML:
                    break;
                case ControllerType.TXT:
                    break;
                case ControllerType.JSON:
                    break;
                case ControllerType.WEB:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            e.Row.Cells["colName"].Value = name;
            e.Row.Cells["colSource"].Value = source;
        }

        private void grdExporters_CurrentCellChanged(object sender, CurrentCellChangedEventArgs e)
        {
            if (e.NewCell.ColumnInfo.Name != "colType")
            {
                var cell = e.NewCell.RowInfo.Cells["colType"];

                if (cell.Value != null) return;

                this.grdImporters.ClearSelection();
                cell.IsSelected = true;
                cell.BeginEdit();
            }
        }

        private void grdExporters_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name != "colType") return;

            ControllerType type;
            if (!Enum.TryParse(e.Value.ToString(), out type)) return;

            string source = "";
            string name = "";

            switch (type)
            {
                case ControllerType.EXCEL:
                    SaveFileDialog dialog = new SaveFileDialog { Filter = "Excel Files|*.xls;*.xlsx;" };
                    if (dialog.ShowDialog() != DialogResult.OK) return;
                    source = dialog.FileName;
                    name = Path.GetFileNameWithoutExtension(dialog.FileName);
                    break;
                case ControllerType.SQL:
                    break;
                case ControllerType.XML:
                    break;
                case ControllerType.TXT:
                    break;
                case ControllerType.JSON:
                    break;
                case ControllerType.WEB:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            e.Row.Cells["colName"].Value = name;
            e.Row.Cells["colTarget"].Value = source;
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
    }
}
