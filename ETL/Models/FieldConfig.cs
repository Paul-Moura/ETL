using System.Collections.Generic;

namespace ETL.Models
{
    public sealed class FieldConfig
    {
        public string SourceField { get; set; }
        
        public string Name { get; set; }

        public FieldType FieldType { get; set; }

        public int Size { get; set; }

        private string _formulaPattern;
        public string FormulaPattern
        {
            get => this._formulaPattern;
            set
            {
                this._formulaPattern = value ?? "";
                this.Formula = Formula.Parse(this._formulaPattern);
            }
        }

        public Formula Formula { get; private set; }

        public List<FieldFilter> Filters { get;  } = new List<FieldFilter>();
    }
}