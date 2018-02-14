using System.Collections.Generic;
using System.Data;
using ETL.Controllers;
using ETL.Models;

namespace ETL.SQL
{
    public sealed class SqlImportController : Controllers.Import.ImportController
    {
        private string _connectionString;

        public SqlImportController() : base(ControllerType.SQL)
        {
        }

        internal override DataTable[] ImportData(string source)
        {
            throw new System.NotImplementedException();
        }

        internal override IEnumerable<SchemaInfo> GetSchemas(string source)
        {
            throw new System.NotImplementedException();
        }
    }
}