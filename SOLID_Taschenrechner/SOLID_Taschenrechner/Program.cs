using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Taschenrechner
{
    class Program
    {
        // Bootstrapping -> Initialisieren der Logik
        static void Main(string[] args)
        {
            new KonsolenUI().Start();
        }
    }

    class Formel
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public char Operator { get; set; }
    }

    class StringSplitParser
    {
        public Formel Parse(string input)
        {
            string[] teile = input.Split(' ');
            int zahl1 = Convert.ToInt32(teile[0]);
            int zahl2 = Convert.ToInt32(teile[2]);

            return new Formel { Operand1 = zahl1, Operand2 = zahl2, Operator = teile[1][0] };
        }
    }

    class Rechner
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

    class KonsolenUI
    {
        public void Start()
        {
            // UI
            Console.WriteLine("Bitte geben Sie die Rechenformel ein:");
            string input = Console.ReadLine(); // "2 + 2"

            // Parser
            StringSplitParser parser = new StringSplitParser();
            Formel f = parser.Parse(input);

            // Rechner
            Rechner r = new Rechner();
            int ergebnis = r.Berechne(f);

            // UI
            // C# 6 String-Interpolation
            Console.WriteLine($"Das Ergebnis ist: {ergebnis}");
            Console.WriteLine("---ENDE--");
            Console.ReadKey();
        }
    }
}
