using System;
using System.Collections.Generic;
using System.Linq;

namespace ETL
{
    public class FormulaConcat : Formula
    {
        public FormulaConcat(params Formula[] formulas)
        {
            this._formulas = formulas?.Where(x => x != null).ToList() ?? throw new ArgumentNullException(nameof(formulas));
        }

        private readonly List<Formula> _formulas;
        
        public override string Format()
        {
            switch (this._formulas.Count)
            {
                case 0:
                    return "";

                case 1:
                    return this._formulas[0].Format();

                default:
                    return this._formulas.Select(x => x.Format()).Aggregate((s1, s2) => $"{s1}+{s2}");
            }
        }
    }
}