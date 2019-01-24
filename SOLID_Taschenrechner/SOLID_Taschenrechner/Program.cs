using SOLID_Taschenrechner.FreeFeatures;
using SOLID_Taschenrechner.Logic;
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
            var parser = new RegexParser();
            var rechner = new ModularerRechner(new Addition(),new Subtraktion());
            new KonsolenUI(parser,rechner).Start();
        }
    }
}
