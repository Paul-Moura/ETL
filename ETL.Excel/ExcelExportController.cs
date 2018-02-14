using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System;
using System.Data;
using System.Linq;
using ETL.Controllers;
using ETL.Controllers.Export;
using ETL.Controllers.Import;
using ETL.Models;
using ETL.Models.Data;

namespace ETL.Excel
{
    public class ExcelExportController : ExportController
    {
        private const string NUMBER = "NUMBER";
        private const string DATETIME = "DATETIME";
        private const string TEXT = "Text"; // also works with "STRING".
        private const string CONN_STR = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES;'";

        public ExcelExportController() : base(ControllerType.EXCEL)
        {
        }
        
        internal override Result ExportData(IEnumerable<Page> tables, string file)
        {
            var result = ExportToExcelOleDb(tables.ToList(), CONN_STR, file);

            return result ? new Result(0, 0) : new Result();
        }

        internal override IEnumerable<Source> GetSchemas(string target)
        {
            throw new NotImplementedException();
        }

        //internal override IEnumerable<SchemaInfo> GetSchemas(string target)
        //{
        //    if (!File.Exists(target)) throw new FileNotFoundException("File not found.", target);

        //    List<SchemaInfo> tables = new List<SchemaInfo>();

        //    using (OleDbConnection conn = new OleDbConnection())
        //    {
        //        conn.ConnectionString = String.Format(CONN_STR, target); // this.GetConnection(file);

        //        try
        //        {
        //            conn.Open();

        //            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

        //            if (dt == null) throw new Exception($"No sheets found in file '{target}'.");

        //            List<string> sheetNames = new List<string>();

        //            // Add the sheet name to the string array.
        //            for (var i = 0; i < dt.Rows.Count; i++)
        //            {
        //                DataRow row = dt.Rows[i];
        //                var sheetName = row["TABLE_NAME"].ToString();

        //                if (sheetName.EndsWith("$") || sheetName.EndsWith("$'"))
        //                    sheetNames.Add(sheetName);
        //            }

        //            if (sheetNames.Count == 0) throw new Exception($"No sheets found in file '{target}'.");

        //            if (sheetNames.Count > 1)
        //            {
        //                var args = new MuliPageEventArgs(sheetNames);
        //                this.OnMultiplePages(args);

        //                if (args.Cancel) return null;

        //                sheetNames = new List<string>(args.Pages);
        //            }

        //            foreach (string sheet in sheetNames)
        //            {
        //                List<string> fields = new List<string>();
        //                var tableColumns = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, sheet, null });
        //                foreach (DataRow row in tableColumns.Rows)
        //                {
        //                    fields.Add(row["COLUMN_NAME"].ToString());
        //                    //int dataType = (int)row["DATA_TYPE"];
        //                    //var position = row["ORDINAL_POSITION"];
        //                    //var precision = row["NUMERIC_PRECISION"];
        //                    //var scale = row["NUMERIC_SCALE"];
        //                    //var flags = row["COLUMN_FLAGS"];
        //                    //int colWidth;
        //                    //switch ((int)flags)
        //                    //{
        //                    //    case 122:
        //                    //        colWidth = -1;
        //                    //        break;
        //                    //    case 90:
        //                    //        colWidth = -2;
        //                    //        break;
        //                    //    default:
        //                    //        colWidth = -3;
        //                    //        break;
        //                    //}

        //                    //this.GetDataType(dataType, colWidth, precision, scale);
        //                }

        //                tables.Add(new SchemaInfo(sheet, fields));
        //            }
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
        //    }

        //    return tables.ToArray();
        //}

        /// <summary>
        /// Routine to export a given DataSet to Excel. For each DataTable contained 
        /// in the DataSet the overloaded routine will create a new Excel sheet based 
        /// upon the currently selected DataTable. The proceedure loops through all 
        /// DataRows in the selected DataTable and pushes each one to the specified 
        /// Excel file using ADO.NET and the Access Database Engine (Excel is not a 
        /// prerequisit).
        /// </summary>
        /// <param name="tables">The <see cref="DataTable"/> list to be written to Excel.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="fileName">The Excel file name to export to.</param>
        /// <param name="deleteExistFile">Delete existing file?</param>
        private static bool ExportToExcelOleDb(List<Page> tables, string connectionString,
            string fileName, bool deleteExistFile)
        {
            // Support for existing file overwrite.
            if (deleteExistFile && File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            return ExportToExcelOleDb(tables, connectionString, fileName);
        }

        /// <summary>
        /// Overloaded version of the above.
        /// </summary>
        /// <param name="tables">The <see cref="DataTable"/> list to be written to Excel.</param>
        /// <param name="connectionString">The SqlConnection string.</param>
        /// <param name="fileName">The Excel file name to export to.</param>
        private static bool ExportToExcelOleDb(List<Page> tables, string connectionString, string fileName)
        {
            try
            {
                // Check for null set.
                if (tables != null && tables.Any())
                {
                    using (OleDbConnection connection = new OleDbConnection(String.Format(connectionString, fileName)))
                    {
                        // Initialise SqlCommand and open.
                        connection.Open();

                        // Loop through DataTables.
                        foreach (Page dt in tables)
                        {
                            // Build the Excel create table command.
                            string strCreateTableStruct = BuildCreateTableCommand(dt);

                            if (String.IsNullOrEmpty(strCreateTableStruct)) return false;

                            var command = new OleDbCommand(strCreateTableStruct, connection);

                            command.ExecuteNonQuery();

                            // Puch each row into Excel.
                            for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                            {
                                command = new OleDbCommand(BuildInsertCommand(dt, rowIndex), connection);

                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                return true;
            }
            catch //(Exception ex)
            {
                //Utils.ErrMsg(eX.Message);
                return false;
            }
        }
        
        /// <summary>
        /// Routine to build the CREATE TABLE command. The conversion of 
        /// .NET to Excel data types is also handled here (supposedly!). 
        /// Help: http://support.microsoft.com/kb/316934/en-us.
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns>The CREATE TABLE command string.</returns>
        private static string BuildCreateTableCommand(Page dataTable)
        {
            // Get the type look-up tables.
            StringBuilder sb = new StringBuilder();
            Dictionary<DataType, string> dataTypeList = BuildExcelDataTypes();

            // Check for null data set.
            if (dataTable.Columns.Count <= 0) return null;

            // Start the command build.
            sb.AppendFormat("CREATE TABLE {0} (", BuildExcelSheetName(dataTable));

            // Build column names and types.
            foreach (var col in dataTable.Columns)
            {
                string type = TEXT;

                if (dataTypeList.ContainsKey(col.Type))
                {
                    type = dataTypeList[col.Type];
                }

                sb.AppendFormat("[{0}] {1},", col.Name.Replace(' ', '_'), type);
            }

            sb = sb.Replace(',', ')', sb.ToString().LastIndexOf(','), 1);

            return sb.ToString();
        }

        /// <summary>
        /// Routine to construct the INSERT INTO command. This does not currently 
        /// work with the data type miss matches.
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        private static string BuildInsertCommand(Page dataTable, int rowIndex)
        {
            StringBuilder sb = new StringBuilder();

            // Remove whitespace.
            sb.AppendFormat("INSERT INTO [{0}$](", BuildExcelSheetName(dataTable));

            foreach (var col in dataTable.Columns)
            {
                sb.AppendFormat("[{0}],", col.Name.Replace(' ', '_'));
            }

            sb = sb.Replace(',', ')', sb.ToString().LastIndexOf(','), 1);

            // Write values.
            sb.Append("VALUES (");

            foreach (var col in dataTable.Columns)
            {
                //string type = col.DataType.ToString();

                string strToInsert = string.Empty;

                strToInsert = dataTable.Rows[rowIndex][col.Name].ToString().Replace("'", "''");

                sb.AppendFormat("'{0}',", strToInsert);
                
                //strToInsert = String.IsNullOrEmpty(strToInsert) ? "NULL" : strToInsert;
                //String.IsNullOrEmpty(strToInsert) ? "NULL" : strToInsert);
            }

            sb = sb.Replace(',', ')', sb.ToString().LastIndexOf(','), 1);

            return sb.ToString();
        }

        /// <summary>
        /// Build the Excel sheet name.
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        private static string BuildExcelSheetName(Page dataTable)
        {
            string retVal = dataTable.Name;

            //if (dataTable.ExtendedProperties.ContainsKey(TABLE_NAME_PROPERTY))
            //    retVal = dataTable.ExtendedProperties[TABLE_NAME_PROPERTY].ToString();

            //if (retVal.Contains(' '))
            //    retVal = $"'{retVal}'";

            return retVal;

            //return retVal.Replace(' ', '_');
        }

        /// <summary>
        /// Dictionary for conversion between .NET data types and Excel 
        /// data types. The conversion does not currently work, so I am 
        /// puching all data upto excel as Excel "TEXT" type.
        /// </summary>
        /// <returns></returns>
        private static Dictionary<DataType, string> BuildExcelDataTypes()
        {
            var dataTypeLookUp = new Dictionary<DataType, string>
            {
                {DataType.String, TEXT},
                {DataType.DateTime, DATETIME},
                {DataType.Bool, TEXT},
                {DataType.Short, NUMBER},
                {DataType.Int, NUMBER},
                {DataType.Long, NUMBER},
                {DataType.Decimal, NUMBER},
                {DataType.Double, NUMBER},
                {DataType.Float, NUMBER},
            };

            // I cannot get the Excel formatting correct here!?
            return dataTypeLookUp;
        }
    }
}
