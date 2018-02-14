using System;
using System.Collections.Generic;
using System.Data;

namespace ETL
{
    public class FormulaConstant : Formula
    {
        internal FormulaConstant(string value)
        {
            this._value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private readonly string _value;

        public override object Format(DataRow row, string sourceName)
        {
            return this._value;
        }
    }

    public class FormulaParameter : Formula
    {
        private const string SOURCE = "source";

        internal FormulaParameter(string field)
        {
            this._field = field ?? throw new ArgumentNullException(nameof(field));
        }

        private readonly string _field;

        public override object Format(DataRow row, string sourceName)
        {
            if (this._field.ToLower() == SOURCE)
                return row[sourceName];

            return row[this._field];
        }
    }

    public class FormulaConcat : Formula
    {
        internal FormulaConcat(IEnumerable<Formula> formulas)
        {
            this._formulas = formulas ?? throw new ArgumentNullException(nameof(formulas));
        }

        private readonly IEnumerable<Formula> _formulas;

        public override object Format(DataRow row, string sourceName)
        {
            string str = "";
            foreach (var formula in this._formulas)
            {
                str += formula.Format(row, sourceName);
            }
            return str;
        }
    }

    public enum MacroType
    {
        ToUpper,
        ToLower,
        ToProper,
    }

    public class FormulaMacro : Formula
    {
        internal FormulaMacro(MacroType type, Formula formula)
        {
            this._type = type;
            this._formula = formula ?? throw new ArgumentNullException(nameof(formula));
        }

        private readonly MacroType _type;
        private readonly Formula _formula;

        public override object Format(DataRow row, string sourceName)
        {
            var value = this._formula.Format(row, sourceName);

            switch (this._type)
            {
                case MacroType.ToUpper:
                    value.ToString().ToUpper();
                    break;
                case MacroType.ToLower:
                    value.ToString().ToLower();
                    break;
                case MacroType.ToProper:
                    value.ToString().ToProper();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return value;
        }
    }

    public abstract class Formula
    {
        private const string TO_UPPER = "upper";
        private const string TO_LOWER = "lower";
        private const string TO_PROPER = "proper";

        // $lower($[FirstName].$[LastName]@$[CompanyName]).com
        public static Formula Parse(string formula)
        {
            if (formula == null)
                throw new ArgumentNullException(nameof(formula));

            if (string.IsNullOrWhiteSpace(formula))
                return new FormulaConstant("");

            List<Formula> formulas = new List<Formula>();
            string val = "";
            string macroName = "";
            bool isFormula = false;
            int endBrace = 0;
            for (var i = 0; i < formula.Length; i++)
            {
                var c = formula[i];

                if (isFormula)
                {
                    if (c == ')')
                    {
                        endBrace--;
                        if (endBrace == 0)
                        {
                            MacroType type;
                            switch (macroName.ToLower())
                            {
                                case TO_UPPER:
                                    type = MacroType.ToUpper;
                                    break;

                                case TO_LOWER:
                                    type = MacroType.ToLower;
                                    break;

                                case TO_PROPER:
                                    type = MacroType.ToProper;
                                    break;

                                default:
                                    throw new ArgumentOutOfRangeException(nameof(macroName), "A macro with this name does not exist.");
                            }
                            formulas.Add(new FormulaMacro(type, Parse(val)));
                            macroName = "";
                            val = "";
                            isFormula = false;
                            continue;
                        }
                    }
                    else if (c == '(')
                    {
                        endBrace++;
                    }
                }
                else
                {
                    if (c == '$')
                    {
                        c = formula[++i];

                        if (c == '$')
                        {
                            val += c;
                            continue;
                        }

                        if (c == '[')
                        {
                            var index = formula.IndexOf("]", i);
                            if (index > i)
                            {
                                if (val != "")
                                {
                                    formulas.Add(new FormulaConstant(val));
                                    val = "";
                                }
                                val = formula.Substring(++i, index - i);
                                formulas.Add(new FormulaParameter(val));
                                val = "";
                                i = index;
                                continue;
                            }
                        }
                        else
                        {
                            var index = formula.IndexOf("(", i);
                            if (index > i)
                            {
                                if (val != "")
                                {
                                    formulas.Add(new FormulaConstant(val));
                                    val = "";
                                }

                                macroName = formula.Substring(i, index - i);
                                isFormula = true;
                                endBrace++;
                                i = index;
                                continue;
                            }
                        }
                    }
                }

                val += c;
            }

            if (val != "")
            {
                formulas.Add(new FormulaConstant(val));
                val = "";
            }

            if (formulas.Count > 1)
                return new FormulaConcat(formulas);

            return formulas[0];
        }

        public abstract object Format(DataRow row, string sourceName);

        public abstract string Format();
    }
}
