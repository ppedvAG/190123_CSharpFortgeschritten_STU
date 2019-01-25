using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialisierung
{
    [Serializable] // nur für Binary
    [XmlRoot("EineTollePerson")]
    public class Person
    {
        [XmlElement("DerWichtigsteAllerNamen")]
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; } // 255, ushort -> 65k
        public decimal Kontostand { get; set; }

        public SuperPerson Vorgesetzer { get; set; }
    }
}
