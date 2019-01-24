using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Typeninformation auslesen mit .GetType()
            //int i = 42;
            //Type t = i.GetType();

            //Console.WriteLine(t);

            //var datum = Activator.CreateInstance(t);
            //Console.WriteLine(datum);
            //Console.WriteLine(datum.GetType()); 
            #endregion

            #region Assembly laden
            //string fullPath = Path.Combine(Environment.CurrentDirectory, @"Libs\LadeMichZurLaufzeit.dll");
            //Assembly lib = Assembly.LoadFile(fullPath);

            //// Typeninformation holen
            //Type t = lib.GetType("LadeMichZurLaufzeit.Taschenrechner");
            //Console.WriteLine(t);

            //var instanz = Activator.CreateInstance(t);

            //// Methodeninformation holen

            //// Typeninformation einer Instanz:
            //// instanz.GetType();
            //// Typeninformation einer Klasse/Struct/etc:
            //// typeOf(Int32)

            //MethodInfo minfo = t.GetRuntimeMethod("Add", new Type[] { typeof(double), typeof(double) });
            //var ergebnis = minfo.Invoke(instanz, new object[] { 12.5, 99.3 });

            //Console.WriteLine(ergebnis);
            //Console.WriteLine(ergebnis.GetType()); 
            #endregion

            #region Flag - Enum
            //Wochentage heute = Wochentage.Donnerstag;
            //Wochentage TageAnDenenDerWeckerLäutet = 
            //    Wochentage.Montag
            //    | Wochentage.Dienstag;

            //Console.WriteLine(heute);
            //Console.WriteLine(TageAnDenenDerWeckerLäutet);

            //// if(TageAnDenenDerWeckerLäutet.HasFlag(Wochentage.Montag)) 
            #endregion

            #region Attribut auslesen
            //Person p = new Person();

            //MemberInfo info = typeof(Person);
            //var allAttributes = info.GetCustomAttributes();

            //Type t = typeof(Person);
            //var propertyInfos = t.GetProperties();

            //var vornameInfo = propertyInfos[0];
            //var attribute = vornameInfo.GetCustomAttributes(); 
            #endregion

            Person p = new Person { Vorname = "Tom", Nachname = "Ate", Alter = 10, Kontostand = 100m };

            Console.WriteLine(ValidatePerson(p));

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static bool ValidatePerson(Person p)
        {
            foreach (PropertyInfo property in p.GetType().GetProperties())
            { // "Für jedes Property in Person"
                foreach (Attribute a in property.GetCustomAttributes())
                { // "Für jedes Attribut in Property XYZ"
                    if (a is ValidierungAttribute va)
                    {
                        // Logik
                        if (property.Name == nameof(Person.Nachname))
                        {
                            if (p.Nachname.Length > va.MaxLength)
                                return false;
                        }
                    }
                }
            }
            return true;
        }
    }

    [Flags]
    public enum Wochentage
    {
        Montag = 1,
        Dienstag = 2,
        Mittwoch = 4,
        Donnerstag = 8,
        Freitag = 16,
        Samstag = 32,
        Sonntag = 64
    }

    [Obsolete("Bitte verwende stattdessen Mitarbeiter")] //,true)] // <-- Für Fehler statt Warnung
    class Person
    {
        [Custom(Text = "Michis Text")]
        [Validierung(MaxLength = 255)]
        public string Vorname { get; set; }
        [Validierung(MaxLength = 200)]
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }
    }
}
