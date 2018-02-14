using System.Collections.Generic;
using ETL.Controllers;
using ETL.Models;
using ETL.Models.Data;

namespace ETL.SQL
{
    public sealed class SqlExportController : Controllers.Export.ExportController
    {
        private string _connectionString;

        public SqlExportController() : base(ControllerType.SQL)
        {
        }
        
        //private void btnSelectFields_Click(object sender, EventArgs e)
        //{
        //    var frm = new SourceFieldsForm(this._selectedController.Pages);
        //    var result = frm.ShowDialog();

        //    if (result != DialogResult.OK) return;

        //    this.btnConfigureFields.Enabled = true;
        //}

        //{
        //    _descs = new[]
        //    {
        //        new EntityDesc(COUNTRY)
        //        {
        //            Properties =
        //            {
        //                new EntityKeyPropDesc("Id", typeof(int)),
        //                new EntityGenericPropDesc("Code", typeof(string)),
        //                new EntityGenericPropDesc("Name", typeof(string)),
        //                new EntityNavCollectionDesc("States", STATE, "Countries")
        //                //new EntityNavCollectionDesc("States", STATE, "Country")
        //            }
        //        },
        //        new EntityDesc(STATE)
        //        {
        //            Properties =
        //            {
        //                new EntityKeyPropDesc("Id", typeof(int)),
        //                new EntityGenericPropDesc("Abrv", typeof(string)),
        //                new EntityGenericPropDesc("Name", typeof(string)),
        //                new EntityNavCollectionDesc("Countries", COUNTRY, "States")
        //                //new EntityNavDesc("Country", COUNTRY, typeof(int), "States")
        //            }
        //        }
        //    };

        //    EntityDbContext.Init(_descs);

        //    using (var context = new EntityDbContext("DefaultConnection"))
        //    {
        //        DbSet countries = context[COUNTRY];
        //        DbSet states = context[STATE];


        //        for (int i = 0; i < 5; i++)
        //        {
        //            dynamic country = countries.Create();

        //            var properties = TypeDescriptor.GetProperties(country.GetType(), new Attribute[] { new BrowsableAttribute(true) });

        //            country.Code = $"Code {i}";
        //            country.Name = $"Name {i}";

        //            for (int j = 0; j < 10; j++)
        //            {
        //                dynamic state = states.Create();
        //                state.Name = $"Name {i * 100 + j}";
        //                state.Abrv = $"Abrv {i * 100 + j}";
        //                state.Countries.Add(country);
        //                _states.Add(state);
        //            }

        //            _countries.Add(country);
        //        }
        //    }


        //    btnLoadData.BackColor = Color.Aquamarine;
        //    button2.Enabled = true;

        //    if (!_dllLoaded)
        //    {
        //        button2.BackColor = Color.Aquamarine;
        //        button3.Enabled = true;
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (EntityDbContext.ValidateDescriptions(_descs))
        //    {
        //        button2.BackColor = Color.Aquamarine;
        //        button3.Enabled = true;
        //    }
        //    else
        //    {
        //        button2.BackColor = Color.Red;
        //    }
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //EntityDbContext.Init(this._descs);
        //    button3.BackColor = Color.Aquamarine;
        //    button4.Enabled = true;
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    using (var context = new EntityDbContext("DefaultConnection"))
        //    {
        //        //DbSet countries = context[COUNTRY];
        //        foreach (var country in _countries)
        //        {
        //            context.Entry(country).State = EntityState.Added;
        //            //countries.Add(country);
        //        }

        //        //DbSet states = context[STATE];
        //        foreach (var state in _states)
        //        {
        //            context.Entry(state).State = EntityState.Added;
        //            //states.Add(state);
        //        }

        //        context.SaveChanges();
        //    }
        //    button4.BackColor = Color.Aquamarine;
        //}

        internal override Result ExportData(IEnumerable<Page> pages, string target)
        {
            throw new System.NotImplementedException();
        }

        internal override IEnumerable<SchemaInfo> GetSchemas(string target)
        {
            throw new System.NotImplementedException();
        }
    }
}