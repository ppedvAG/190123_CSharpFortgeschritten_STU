using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie die Rechenformel ein:");

            string formel = Console.ReadLine(); // "2 + 2"

            string[] teile = formel.Split(' ');
            int zahl1 = Convert.ToInt32(teile[0]);
            int zahl2 = Convert.ToInt32(teile[2]);

            int ergebnis = 0;
            if (teile[1] == "+")
                ergebnis = zahl1 + zahl2;
            else if (teile[1] == "-")
                ergebnis = zahl1 - zahl2;
                ; //....

            // C# 6 String-Interpolation
            Console.WriteLine($"Das Ergebnis ist: {ergebnis}");

            Console.WriteLine("---ENDE--");
            Console.ReadKey();
        }
    }
}
