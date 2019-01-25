using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialisierung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Binär    -> BinaryFormatter
            // XML      -> XmlSerializer
            // Json     -> NuGet: Newtonsoft.JSON

            Person p = new Person
            {
                Vorname = "Tom",
                Nachname = "Ate",
                Alter = 10,
                Kontostand = 100m,
                Vorgesetzer = new SuperPerson { Vorname = "Martha", Kontostand = 200m, Geschlecht = false }
            };
            // Binär: Attribut: [Serializable]

            // Serialisieren

            using (FileStream stream = new FileStream(@".\person.bin", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, p);
            } // using -> Ruft die Methode .Dispose() auf und schließt für uns den Stream

            // Deserialisieren
            using (FileStream stream = new FileStream(@".\person.bin", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Person deserialisiert = (Person)formatter.Deserialize(stream);
                Console.WriteLine(deserialisiert.Vorname);
                Console.WriteLine(deserialisiert.Nachname);
                Console.WriteLine(deserialisiert.Alter);
                Console.WriteLine(deserialisiert.Kontostand);
            }

            // XML:

            // Limitierungen:
            // Klasse muss Public sein !!!
            // Properties + Felder müssen auch public sein
            // Properties MÜSSEN get; + set;
            // Es MUSS ein parameterloser Konstruktor
            // "Vorteil": Es gibt kein Attribut, aber es gibt welche zum Steuern

            // Serialisieren

            using (FileStream stream = new FileStream(@".\person.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(stream, p);
            } // using -> Ruft die Methode .Dispose() auf und schließt für uns den Stream

            // Deserialisieren
            using (FileStream stream = new FileStream(@".\person.xml", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));

                Person deserialisiert = (Person)serializer.Deserialize(stream);
                Console.WriteLine(deserialisiert.Vorname);
                Console.WriteLine(deserialisiert.Nachname);
                Console.WriteLine(deserialisiert.Alter);
                Console.WriteLine(deserialisiert.Kontostand);
            }

            // JSON mit Newtonsoft.JSON

            string json = JsonConvert.SerializeObject(p);
            File.WriteAllText("person.json", json);

            string jsonFromFile = File.ReadAllText("person.json");
            SuperPerson pJson = JsonConvert.DeserializeObject<SuperPerson>(jsonFromFile);

            Console.WriteLine(pJson.Vorname);
            //Console.WriteLine(pJson.Nachname);
            //Console.WriteLine(pJson.Alter);
            Console.WriteLine(pJson.Kontostand);
            Console.WriteLine(pJson.Geschlecht);

            StreamReader sr = new StreamReader("person.xml");
            while(sr.Peek() != -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
