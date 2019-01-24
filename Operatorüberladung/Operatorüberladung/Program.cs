using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace Operatorüberladung
{
    class Program
    {
        static void Main(string[] args)
        {
            Bruch b1 = new Bruch(1, 2);
            Bruch b2 = new Bruch(1, 4);

            Bruch summe = b1 * b2;

            Console.WriteLine($"{summe.Zähler}/{summe.Nenner}");

            // Erweiterungsmethode:

            int zahl = 42;

            int dasDoppelte = zahl.Verdoppeln();
            // int dasDoppelte = Erweiterungsmethoden.Verdoppeln(zahl);
            Console.WriteLine(dasDoppelte);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }


}
