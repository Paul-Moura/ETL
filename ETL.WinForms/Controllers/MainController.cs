using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ETL.Controllers.Export;
using ETL.Controllers.Import;
using ETL.Forms;
using ETL.Models;

namespace ETL.Controllers
{
    public class MainController : IDisposable
    {
        public MainController()
        {
            DateTime.Now.ToString("");


            this._controller = new EtlController();

            this._form = new MainForm();
            this.WireEvents();

            List<ImportController> importers = new List<ImportController>();
            List<ExportController> exporters = new List<ExportController>();

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fls = di.GetFiles("*ETL*.dll");

            foreach (FileInfo fi in fls)
            {
                var assembly = Assembly.LoadFile(fi.FullName);
                IEnumerable<Type> types;

                try
                {
                    types = assembly.DefinedTypes;
                }
                catch (ReflectionTypeLoadException ex)
                {
                    types = ex.Types.Where(x => x != null);
                }

                foreach (var definedType in types.Where(x => !x.IsAbstract))
                {
                    if (typeof(ImportController).IsAssignableFrom(definedType))
                    {
                        importers.Add((ImportController)Activator.CreateInstance(definedType));
                    }
                    else if (typeof(ExportController).IsAssignableFrom(definedType))
                    {
                        exporters.Add((ExportController)Activator.CreateInstance(definedType));
                    }
                }
            }

            if (!importers.Any())
                throw new ArgumentException("At least one importer is required.");

            if (!exporters.Any())
                throw new ArgumentException("At least one exporter is required.");

            foreach (var importer in importers)
            {
                this._importers.Add(importer.Type, importer);
            }

            if (this._importers.Count == 1)
                this._selectedImporter = importers[0];

            foreach (var exporter in exporters)
            {
                this._exporters.Add(exporter.Type, exporter);
            }

            if (this._exporters.Count == 1)
                this._selectedExporter = exporters[0];
        }

        private MainForm _form;
        private readonly EtlController _controller;
        private readonly Dictionary<ControllerType, ImportController> _importers = new Dictionary<ControllerType, ImportController>();
        private readonly Dictionary<ControllerType, ExportController> _exporters = new Dictionary<ControllerType, ExportController>();
        private ImportController _selectedImporter;
        private ExportController _selectedExporter;
        private string _source;
        private string _target;


        private void WireEvents()
        {
            this._form.LoadData += this.Form_OnLoadData;
            this._form.PreviewSourceData += this.Form_OnPreviewSourceData;
            this._form.ConfigureFields += this.Form_OnConfigureFields;
            this._form.MapFields += this.Form_OnMapFields;
            this._form.Process += this.Form_OnProcess;
            this._form.ExportData += this.Form_OnExportData;
        }

        private void UnWireEvents()
        {
            this._form.LoadData -= this.Form_OnLoadData;
            this._form.PreviewSourceData -= this.Form_OnPreviewSourceData;
            this._form.ConfigureFields -= this.Form_OnConfigureFields;
            this._form.MapFields -= this.Form_OnMapFields;
            this._form.Process -= this.Form_OnProcess;
            this._form.ExportData -= this.Form_OnExportData;
        }
        
        public DialogResult ShowDialog()
        {
            return this._form.ShowDialog();
        }

        public void Dispose()
        {
            this.UnWireEvents();
            this._form?.Dispose();
        }



        private void Form_OnLoadData(object sender, ResultEventArgs e)
        {
            this._form = new MainForm();

            if (this._importers.Count > 1)
            {
                var ttl = "Data Source";
                var msg = "Select the source from which to copy data.";
                var frm = new SelectForm(ttl, msg, this._importers.Keys.Select(x => x.ToString()));

                if (frm.ShowDialog() != DialogResult.OK) return;

                ControllerType type;
                if (Enum.TryParse(frm.SelectedItems[0], out type))
                {
                    this._selectedImporter = this._importers[type];
                }
            }

            if (this._selectedImporter == null) return;

            try
            {
                switch (this._selectedImporter.Type)
                {
                    case ControllerType.EXCEL:
                        this._selectedImporter.MultiplePages += this.OnMultipleExcelPages;
                        OpenFileDialog dialog = new OpenFileDialog { Filter = "Excel Files|*.xls;*.xlsx;*.xlsm" };
                        if (dialog.ShowDialog() != DialogResult.OK) return;
                        this._source = dialog.FileName;
                        break;
                    //case ControllerType.JSON:
                    //    break;
                    //case ControllerType.SQL:
                    //    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                //e.Result = this._controller.ImportData(this._selectedImporter, this._source);
            }
            finally
            {
                switch (this._selectedImporter.Type)
                {
                    case ControllerType.EXCEL:
                        this._selectedImporter.MultiplePages -= this.OnMultipleExcelPages;
                        break;
                    //case ControllerType.JSON:
                    //    break;
                    //case ControllerType.SQL:
                    //    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void Form_OnPreviewSourceData(object sender, EventArgs e)
        {
            //var frm = new SourcePreviewForm();
            //frm.LoadData(this._controller.SourceData);
            //frm.ShowDialog();
        }

        private void Form_OnConfigureFields(object sender, CancelEventArgs e)
        {
            if (this._controller.Pages == null || 
                MessageBox.Show("Reset Configuration?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this._controller.Pages = new List<PageConfig>();
                
                //foreach (SchemaInfo schema in this._controller.SourceSchema)
                //{
                //    this._controller.Pages.Add(new PageConfig(schema.Name, schema.Fields.ToArray()));
                //}
            }

            var frm = new ConfigureFieldsForm(this._controller.Pages);
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (var pg in frm.Pages)
                {
                    //var page = this._controller.Pages.First(x => x.Source.Name == pg.SourceName);
                    //page.Name = pg.OutputName.Trim();
                    //page.Fields = pg.Fields.Select(x => (FieldConfig)x).ToList();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form_OnMapFields(object sender, CancelEventArgs e)
        {
            if (this._selectedExporter == null ||
                (this._exporters.Count > 1 && 
                MessageBox.Show("Reset Exporter?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                var ttl = "Exporters";
                var msg = "Select the target to map to.";
                var frm = new SelectForm(ttl, msg, this._exporters.Keys.Select(x => x.ToString()));
                var result = frm.ShowDialog();

                if (result != DialogResult.OK) return;

                ControllerType type;
                if (Enum.TryParse(frm.SelectedItems[0], out type))
                {
                    this._selectedExporter = this._exporters[type];
                }

                this._target = null;
            }
            
            if (this._selectedExporter == null) return;

            if (string.IsNullOrWhiteSpace(this._target) ||
                MessageBox.Show("Reset Export Target?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    switch (this._selectedExporter.Type)
                    {
                        case ControllerType.EXCEL:
                            this._selectedExporter.MultiplePages += this.OnMultipleExcelPages;
                            OpenFileDialog dialog = new OpenFileDialog { Filter = "Excel Files|*.xls;*.xlsx;*.xlsm" };
                            if (dialog.ShowDialog() != DialogResult.OK) return;
                            this._target = dialog.FileName;
                            break;
                        //case ControllerType.JSON:
                        //    break;
                        //case ControllerType.SQL:
                        //    break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                finally
                {
                    switch (this._selectedImporter.Type)
                    {
                        case ControllerType.EXCEL:
                            this._selectedImporter.MultiplePages -= this.OnMultipleExcelPages;
                            break;
                        //case ControllerType.JSON:
                        //    break;
                        //case ControllerType.SQL:
                        //    break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                //this._controller.LoadTargetSchema(this._selectedExporter, this._target);

                this._controller.Pages = null;
            }
            
            if (this._controller.Pages == null || 
                MessageBox.Show("Reset Configuration?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this._controller.Pages = new List<PageConfig>();

                //foreach (SchemaInfo schema in this._controller.TargetSchema)
                //{
                //    this._controller.Pages.Add(new PageConfig(schema.Name, schema.Fields.ToArray()));
                //}
            }

            using (var controller = new MapFieldsController(this._controller))
            {
                controller.ShowDialog();
            }
        }

        private void Form_OnProcess(object sender, ResultEventArgs e)
        {
            e.Result = this._controller.Process();
        }

        private void Form_OnExportData(object sender, ResultEventArgs e)
        {
            if (this._exporters.Count > 1)
            {
                var ttl = "Exporters";
                var msg = "Select the target to export data to.";
                var frm = new SelectForm(ttl, msg, this._exporters.Keys.Select(x => x.ToString()));
                var result = frm.ShowDialog();

                if (result != DialogResult.OK) return;

                ControllerType type;
                if (Enum.TryParse(frm.SelectedItems[0], out type))
                {
                    this._selectedExporter = this._exporters[type];
                }
            }

            if (this._selectedExporter == null) return;

            string target;
            switch (this._selectedExporter.Type)
            {
                case ControllerType.EXCEL:
                    SaveFileDialog dialog = new SaveFileDialog { Filter = "Excel Files|*.xlsx" };
                    if (dialog.ShowDialog() != DialogResult.OK) return;
                    target = dialog.FileName;
                    break;
                //case ControllerType.JSON:
                //    break;
                //case ControllerType.SQL:
                //    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            //e.Result = this._controller.ExportData(this._selectedExporter, target);
        }

        private void OnMultipleExcelPages(object sender, MuliPageEventArgs e)
        {
            var title = "Select Excel Sheets";
            var message = "The selected file contains multiple sheets. Please specify which sheet(s) to use!";
            var frm = new SelectForm(title, message, e.Pages);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                e.Pages = frm.SelectedItems.ToList();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}