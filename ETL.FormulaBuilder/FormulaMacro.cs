using System;

namespace ETL
{
    public class FormulaMacro : Formula
    {
        internal FormulaMacro(MacroType type, Formula formula)
        {
            this._type = type;
            this._formula = formula ?? throw new ArgumentNullException(nameof(formula));
        }

        private readonly MacroType _type;
        private readonly Formula _formula;

        //public override object Format(DataRow row, string sourceName)
        //{
        //    var value = this._formula.Format(row, sourceName);

        //    switch (this._type)
        //    {
        //        case MacroType.ToUpper:
        //            value.ToString().ToUpper();
        //            break;
        //        case MacroType.ToLower:
        //            value.ToString().ToLower();
        //            break;
        //        case MacroType.ToProper:
        //            value.ToString().ToProper();
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException();
        //    }

        //    return value;
        //}
        public override string Format()
        {
            throw new NotImplementedException();
        }
    }
}