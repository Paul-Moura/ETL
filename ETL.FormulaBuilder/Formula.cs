using System;
using System.Collections.Generic;

namespace ETL
{
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
        
        public abstract string Format();
    }
}
