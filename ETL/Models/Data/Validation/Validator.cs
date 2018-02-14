using System;

namespace ETL.Models.Data.Validation
{
    public abstract class Validator
    {
        protected Validator(string name, ValidatorType type, FilterAction action)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Type = type;
            this.Action = action;
        }

        public string Name { get; }

        public ValidatorType Type { get; }

        public FilterAction Action { get; }

        public abstract bool Validate(object value);
    }
}