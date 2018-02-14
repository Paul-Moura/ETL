using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ETL.Controllers.Export;
using ETL.Controllers.Import;
using ETL.Models;
using ETL.Models.Data;
using ETL.Models.Data.Validation;

namespace ETL.Controllers
{
    public sealed class EtlController
    {
        private Page[] _pages;

        public ICollection<ImportController> Importers { get; } = new List<ImportController>();
        public ICollection<ExportController> Exporters { get; } = new List<ExportController>();
        public List<PageConfig> Pages { get; set; }

        private readonly Dictionary<string, Source[]> _sourceDict = new Dictionary<string, Source[]>();
        
        public Result ImportData(IEnumerable<ImporterInfo> importConfig)
        {
            this._sourceDict.Clear();

            foreach (var info in importConfig)
            {
                var importer = this.Importers.FirstOrDefault(x => x.Type == info.Type);
                
                if (importer == null)
                    throw new Exception(); //TODO: make this a custom exception

                var source = importer.ImportData(info.Source);

                this._sourceDict.Add(info.Name, source);
            }

            return new Result(9999, 9999); //TODO: correct counts being returned
        }
        
        private Source GetPageSource(PageConfig pageConfig)
        {
            return this._sourceDict[pageConfig.ImporterName]
                .FirstOrDefault(x => x.Data.TableName == pageConfig.ImportTableName);
        }

        public Result Process()
        {
            DataSet masterSet = new DataSet();

            foreach (var source in this._sourceDict.Values.SelectMany(x => x).ToList())
            {
                var tbl = source.Data.Copy();
                masterSet.Tables.Add(tbl);
            }

            List<Page> pages = new List<Page>();

            foreach (var pageConfig in this.Pages.Where(x => x.Fields?.Any() ?? false))
            {
                var colNames = pageConfig.Fields.Select(x => x.Name);
                var page = new Page(pageConfig.Name, colNames);
                var source = this.GetPageSource(pageConfig);

                //TODO: handle (source == null)

                var tbl = source.Data.Copy();
                tbl.TableName += $"_{pageConfig.Name}";
                masterSet.Tables.Add(tbl);

                //TODO: add relationships to DataSet

                foreach (FieldConfig field in pageConfig.Fields)
                {
                    var col = new DataColumn(field.Name)
                    {
                        Expression = field.Formula.Format()
                    };
                    tbl.Columns.Add(col);

                    var column = page.Columns[field.Name];

                    switch (field.FieldType)
                    {
                        case FieldType.Text:
                            column.Type = DataType.String;
                            break;

                        case FieldType.WholeNumber:
                            column.Type = DataType.Int;
                            break;

                        case FieldType.Decimal:
                            column.Type = DataType.Double;
                            break;

                        case FieldType.DateTime:
                            column.Type = DataType.DateTime;
                            break;

                        case FieldType.TrueFalse:
                            column.Type = DataType.Bool;
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    
                    foreach (var filter in field.Filters)
                    {
                        Validator validator = null;

                        switch (filter.Type)
                        {
                            case FilterType.CannotBeNull:
                                break;
                            case FilterType.CannotMatchList:
                                break;
                            case FilterType.CannotMatchRegex:
                                validator = new RegexValidator(filter.Name, ValidatorType.Match, filter.Action, filter.RegExPattern);
                                break;
                            case FilterType.MustBeNull:
                                break;
                            case FilterType.MustMatchList:
                                break;
                            case FilterType.MustMatchRegex:
                                validator = new RegexValidator(filter.Name, ValidatorType.NotMatch, filter.Action, filter.RegExPattern);
                                break;
                            case FilterType.StandardizeInput:
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }

                        column.Validators.Add(validator);
                    }
                }

                //var columns = pageConfig.Fields.Select(x => x.Name).ToArray();

                //var newTbl = new DataView(tbl).ToTable(false, columns);

                //TODO: copy the data from the newTbl into the Page

                pages.Add(page);
            }

            this._pages = pages.ToArray();

            return new Result(this._pages.Length, 0);
        }

        public Result ExportData()
        {
            //TODO: export each page

            throw new NotImplementedException();
        }
    }
}