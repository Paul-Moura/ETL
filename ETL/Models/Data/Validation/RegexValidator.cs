using System;
using System.Text.RegularExpressions;

namespace ETL.Models.Data.Validation
{
    public sealed class RegexValidator : Validator
    {
        public RegexValidator(string name, ValidatorType type, FilterAction action, string pattern) : base(name, type, action)
        {
            this._regex = new Regex(pattern);
        }

        private readonly Regex _regex;

        public override bool Validate(object value)
        {
            switch (this.Type)
            {
                case ValidatorType.Match:
                    return this._regex.IsMatch(value.ToString());

                case ValidatorType.NotMatch:
                    return !this._regex.IsMatch(value.ToString());

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}