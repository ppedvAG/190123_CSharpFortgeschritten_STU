using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorüberladung
{
    class Bruch
    {
        public Bruch(int zähler, int nenner)
        {
            Zähler = zähler;
            Nenner = nenner;
        }

        public int Zähler { get; set; }
        public int Nenner { get; set; }


        // Arithmetische Operatoren:
        // +,-,*,/,%
        // +=,-= .... (automatisch dabei)

        // Bit Operatoren:
        // &,|,^,<<,>>

        // Vergleichsoperatoren: (müssen paarweise implementiert werden)
        // ==, !=, <=, >=, <, >

        public static Bruch operator *(Bruch left, Bruch right)
        {
            return new Bruch(
                left.Zähler * right.Zähler,
                left.Nenner * right.Nenner);
        }
    }
}
