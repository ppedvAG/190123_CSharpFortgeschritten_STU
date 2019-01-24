using SOLID_Taschenrechner.Domain;
using System;

namespace SOLID_Taschenrechner
{
    class KonsolenUI
    {
        public KonsolenUI(IParser parser, IRechner rechner)
        {
            this.parser = parser ?? throw new ArgumentNullException(nameof(parser));
            this.rechner = rechner ?? throw new ArgumentNullException(nameof(rechner));
        }
        private readonly IParser parser;
        private readonly IRechner rechner;

        public void Start()
        {
            Console.WriteLine("Bitte geben Sie die Rechenformel ein:");
            string input = Console.ReadLine(); // "2 + 2"

            // Parser
            Formel f = parser.Parse(input);
            // Rechner
            int ergebnis = rechner.Berechne(f);

            // C# 6 String-Interpolation
            Console.WriteLine($"Das Ergebnis ist: {ergebnis}");
            Console.WriteLine("---ENDE--");

            Console.ReadKey();
        }
    }
}
