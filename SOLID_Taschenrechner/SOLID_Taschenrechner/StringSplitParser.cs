using System;

namespace SOLID_Taschenrechner
{
    class StringSplitParser : IParser
    {
        public Formel Parse(string input)
        {
            string[] teile = input.Split(' ');
            int zahl1 = Convert.ToInt32(teile[0]);
            int zahl2 = Convert.ToInt32(teile[2]);

            return new Formel { Operand1 = zahl1, Operand2 = zahl2, Operator = teile[1][0] };
        }
    }
}
