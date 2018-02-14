using System;
using System.Collections.Generic;
using ETL.Models.Data.Validation;

namespace ETL.Models.Data
{
    internal sealed class PageColumn
    {
        public PageColumn(string name)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Type = DataType.String;
            this.Validators = new List<Validator>();
        }

        public string Name { get; }

        public DataType Type { get; set; }

        public List<Validator> Validators { get; }
    }
}