using System;
using System.Text.RegularExpressions;

namespace SOLID_Taschenrechner
{
    class RegexParser : IParser
    {
        public Formel Parse(string input)
        {
            Regex r = new Regex(@"\b(\d+)\s*(\D)\s*(\d+)\b");
            var result = r.Match(input);

            if (result.Success)
            {
                Formel f = new Formel();
                f.Operand1 = Convert.ToInt32(result.Groups[1].Value); // 2
                f.Operator = result.Groups[2].Value[0];               // +
                f.Operand2 = Convert.ToInt32(result.Groups[3].Value); // 2
                return f;
            }
            else
                throw new FormatException("Ihre Eingabe ist keine gültige Formel");
        }
    }
}
