using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung
{
    [Serializable]
    public class SuperPerson
    {
        [JsonProperty("Vorname")]
        public string Vorname { get; set; }
        [JsonProperty("Kontostand")]
        public decimal Kontostand { get; set; }
        public bool Geschlecht { get; set; }
    }
}
