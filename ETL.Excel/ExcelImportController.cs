using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using ETL.Controllers;
using ETL.Controllers.Import;
using ETL.Models;

namespace ETL.Excel
{
    public class ExcelImportController : ImportController
    {
        private const string CONN_STR = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0;'";

        public ExcelImportController() : base(ControllerType.EXCEL) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <exception cref="FileNotFoundException"></exception>
        internal override Source[] ImportData(string source)
        {
            if (!File.Exists(source)) throw new FileNotFoundException("File not found.", source);

            List<Source> sources = new List<Source>();

            using (OleDbConnection conn = new OleDbConnection())
            {
                conn.ConnectionString = string.Format(CONN_STR, source);

                try
                {
                    conn.Open();

                    var dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    if (dt == null) throw new Exception($"No sheets found in file '{source}'.");

                    List<string> sheetNames = new List<string>();

                    // Add the sheet name to the string array.
                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        var sheetName = row["TABLE_NAME"].ToString();

                        if (sheetName.EndsWith("$") || sheetName.EndsWith("$'"))
                            sheetNames.Add(sheetName);
                    }

                    if (sheetNames.Count == 0) throw new Exception($"No sheets found in file '{source}'.");

                    if (sheetNames.Count > 1)
                    {
                        var args = new MuliPageEventArgs(sheetNames);
                        this.OnMultiplePages(args);

                        if (args.Cancel) return null;

                        sheetNames = new List<string>(args.Pages);
                    }

                    using (OleDbCommand cmd = new OleDbCommand
                    {
                        Connection = conn
                    })
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter())
                        {
                            foreach (var sheet in sheetNames)
                            {
                                cmd.CommandText = $"Select * from [{sheet}]";

                                dt = new DataTable();

                                da.SelectCommand = cmd;
                                da.Fill(dt);

                                dt.TableName = sheet;

                                sources.Add(new Source(dt));
                            }
                        }
                    }
                }
                finally
                {
                    conn.Close();
                }
            }

            return sources.ToArray();
        }

        //internal override IEnumerable<SchemaInfo> GetSchemas(string source)
        //{
        //    if (!File.Exists(source)) throw new FileNotFoundException("File not found.", source);

        //    List<SchemaInfo> tables = new List<SchemaInfo>();

        //    using (OleDbConnection conn = new OleDbConnection())
        //    {
        //        conn.ConnectionString = string.Format(CONN_STR, source);

        //        try
        //        {
        //            conn.Open();

        //            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

        //            if (dt == null) throw new Exception($"No sheets found in file '{source}'.");

        //            List<string> sheetNames = new List<string>();

        //            // Add the sheet name to the string array.
        //            for (var i = 0; i < dt.Rows.Count; i++)
        //            {
        //                DataRow row = dt.Rows[i];
        //                var sheetName = row["TABLE_NAME"].ToString();

        //                if (sheetName.EndsWith("$") || sheetName.EndsWith("$'"))
        //                    sheetNames.Add(sheetName);
        //            }

        //            if (sheetNames.Count == 0) throw new Exception($"No sheets found in file '{source}'.");

        //            if (sheetNames.Count > 1)
        //            {
        //                var args = new MuliPageEventArgs(sheetNames);
        //                this.OnMultiplePages(args);

        //                if (args.Cancel) return null;

        //                sheetNames = new List<string>(args.Pages);
        //            }

        //            foreach (var sheet in sheetNames)
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
        
        //private void GetDataType(int dataType, int colSize, int precision, int scale)
        //{
        //    switch (dataType)
        //    {
        //        case 2:
        //            // int
        //            break;

        //        case 3:
        //            switch (colSize)
        //            {
        //                case -2:
        //                    // AutoNumber
        //                    break;
        //                default:
        //                    // long
        //                    break;
        //            }
        //            break;

        //        case 4:
        //            // single
        //            break;

        //        case 5:
        //            // double
        //            break;

        //        case 6:
        //            // money / currency
        //            break;

        //        case 7:
        //            // DateTime
        //            break;

        //        case 11:
        //            // bool
        //            break;

        //        case 17:
        //            // byte
        //            break;

        //        case 72:
        //            // memo
        //            break;

        //        case 128:
        //        case 130:
        //            switch (colSize)
        //            {
        //                case 0:
        //                case -1:
        //                    // memo
        //                    break;
        //                default:
        //                    // string / varchar(colSize)
        //                    break;
        //            }
        //            break;

        //        case 131:
        //            // decimal(precicion, scale)
        //            break;

        //        default:
        //            switch (colSize)
        //            {
        //                case -1:
        //                    // memo
        //                    break;
        //                default:
        //                    // string / varchar(colSize)
        //                    break;
        //            }
        //            break;
        //    }
        //}
    }
}