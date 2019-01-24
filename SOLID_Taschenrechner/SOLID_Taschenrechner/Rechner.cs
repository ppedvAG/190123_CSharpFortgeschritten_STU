﻿using System;

namespace SOLID_Taschenrechner
{
    class Rechner : IRechner
    {
        public int Berechne(Formel formel)
        {
            if (formel.Operator == '+')
                return formel.Operand1 + formel.Operand2;
            else if (formel.Operator == '-')
                return formel.Operand1 + formel.Operand2;
            
            throw new NotSupportedException("Operator ist unbekannt");
        }
    }
}
