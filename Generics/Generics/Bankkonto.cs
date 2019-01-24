using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    abstract class Bankkonto
    {
        public string Inhaber { get; set; }
        protected decimal Kontostand { get; set; }

        public virtual void Einzahlen(decimal betrag) => Kontostand += betrag;
        public virtual void Abheben(decimal betrag) => Kontostand -= betrag;
    }

    class Jugendkonto : Bankkonto
    {
        public override void Abheben(decimal betrag)
        {
            if (Kontostand - betrag >= 0)
                base.Abheben(betrag);
            else
                ; // darf nicht abheben, da man sonst unter 0 kommt
        }
    }


}
