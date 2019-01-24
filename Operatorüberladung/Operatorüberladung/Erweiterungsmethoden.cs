using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorüberladung
{
    static class Erweiterungsmethoden
    {
        public static int Verdoppeln(this int input) // this -> Erweiterungsmethode
        {
            return input * 2;
        }
    }
}
