using System;

namespace ETL
{
    public class FormulaParameter : Formula
    {
        public FormulaParameter(string field)
        {
            if (field == null)
                throw new ArgumentNullException(nameof(field));

            this._field = $"`{field}`";
        }

        private readonly string _field;
        
        public override string Format()
        {
            return this._field;
        }
    }
}