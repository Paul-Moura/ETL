using System;

namespace ETL.Models.Data
{
    internal sealed class PageCell
    {
        private object _value;

        public PageCell(PageColumn column, PageRow row)
        {
            this.Column = column ?? throw new ArgumentNullException(nameof(column));
            this.Row = row ?? throw new ArgumentNullException(nameof(row));
            this.Error = "";
        }

        public PageColumn Column { get; }

        public PageRow Row { get; }

        public object Value
        {
            get => this._value;
            set
            {
                this._value = value;
                this.Validate();
            }
        }

        public string Error { get; private set; }

        public bool IsValid => this.Error == "";

        public void Validate()
        {
            this.Error = "";
            foreach (var validator in this.Column.Validators)
            {
                if (!validator.Validate(this.Value))
                {
                    this.Error += $"[{this.Column}] failed {validator.Name}; ";
                }
            }
            this.Error = this.Error.TrimEnd();
        }
    }
}