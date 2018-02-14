using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ETL.Forms;
using ETL.Models;

namespace ETL.Controllers
{
    public sealed class MapFieldsController : IDisposable
    {
        public MapFieldsController(EtlController controller)
        {
            this._form = new MapFieldsForm();

            //foreach (var page in controller.Pages)
            //{
            //    page.Fields = new List<FieldConfig>();
            //    foreach (var sourceField in page.Source.Fields)
            //    {
            //        page.Fields.Add(new FieldConfig(sourceField, sourceField, FieldType.Text));
            //    }
            //}

            //this._form.Init(controller.Pages, controller.TargetSchema);
        }

        private readonly MapFieldsForm _form;

        public DialogResult ShowDialog()
        {
            return this._form.ShowDialog();
        }

        public void Dispose()
        {
            this._form?.Dispose();
        }
    }
}