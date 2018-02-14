using System;
using System.Globalization;

namespace ETL
{
    public class FormulaConstant : Formula
    {
        public FormulaConstant(string value)
        {
            this._value = $"'{value ?? ""}'";
        }

        public FormulaConstant(DateTime value)
        {
            this._value = $"#{value}#";
        }

        public FormulaConstant(short value)
        {
            this._value = value.ToString();
        }

        public FormulaConstant(int value)
        {
            this._value = value.ToString();
        }

        public FormulaConstant(float value)
        {
            this._value = value.ToString(CultureInfo.InvariantCulture);
        }

        public FormulaConstant(double value)
        {
            this._value = value.ToString(CultureInfo.InvariantCulture);
        }

        public FormulaConstant(Enum value)
        {
            this._value = Convert.ToInt32(value).ToString();
        }

        private readonly string _value;
        
        public override string Format()
        {
            return this._value;
        }
    }
}