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
            var parser = new StringSplitParser();
            var rechner = new Rechner();
            new KonsolenUI(parser,rechner).Start();
        }
    }
}
