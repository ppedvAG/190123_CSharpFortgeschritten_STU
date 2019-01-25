using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class Program
    {
        // Variante "alt"
        public delegate void MeinDelegat();

        static void Main(string[] args)
        {
            #region Delegat - Eigenbau
            //// MachWas();

            ////MeinDelegat del = new MeinDelegat(MachWas);
            ////del.Invoke();

            ////MeinDelegat del = MachWas;
            ////del += MachNochWas;
            ////del += MachNochEinBisserlMehr;
            ////del(); // .Invoke

            //// Null-Conditional Operator
            //MeinDelegat del = null;
            //del?.Invoke();

            //// Null-Coalescing
            //int? zahlDieNullSeinKönnte = 10;
            //int zahl1 = zahlDieNullSeinKönnte ?? 0;

            //// if(person != null && person.GanzerName != null && person.GanzerName.Vorname != null=
            //// if(person?.GanzerName?.Vorname != null); 
            #endregion

            #region Action<T>, Func<T>, EventArgs<T>
            //// Alles, was keine Rückgabe hat (void)
            //// Action<T>

            //Action a1 = MachWas;
            //a1 += MachNochWas;
            //a1?.Invoke();

            //Action<int> a2 = MachNochEinBisserlMehr;
            //a2(123);

            //// Alles mit Rückgabe
            //// Func<T>
            //Func<int, int, int> rechner = Add;
            //rechner += Sub; // nur das letzte wird ausgeführt
            //int erg = rechner(12, 5);

            //// WinForms, WPF, UWP, Xamarin 
            //EventHandler eh = Button1_Click;
            //EventHandler<MeineArgumente> eh3 = Button2_Click; 
            #endregion


            Button meinButton = new Button();
            meinButton.ClickEvent += MachWasBeiEinemClick;
            meinButton.ClickEvent += Logger;

            meinButton.Click();

            //meinButton.ClickEvent = null;       // absolut verboten !

            meinButton.Click();
            meinButton.Click();
            meinButton.ClickEvent -= Logger;

            meinButton.Click();
            meinButton.Click();
            meinButton.Click();

            //meinButton.ClickEvent?.Invoke(null,EventArgs.Empty); // Verboten


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static void Logger(object sender, EventArgs e)
        {
            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]: Button wurde geklickt ");
        }

        private static void MachWasBeiEinemClick(object sender, EventArgs e)
        {
            Console.Beep();
            Console.WriteLine("*click*");
        }

        private static void Button2_Click(object sender, MeineArgumente e)
        {
            throw new NotImplementedException();
        }

        private static void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void MachWas()
        {
            Console.WriteLine("Mach was ....");
        }
        private static void MachNochWas()
        {
            Console.WriteLine("Mach noch was ....");
        }
        private static void MachNochEinBisserlMehr(int zahl)
        {
            Console.WriteLine($"Ich mache noch was mit {zahl}");
        }

        public static int Add(int z1, int z2) => z1 + z2;
        public static int Sub(int z1, int z2) => z1 - z2;
    }

    class MeineArgumente : EventArgs // Sollte man immer machen für Polymorphie :)
    {

    }
}
