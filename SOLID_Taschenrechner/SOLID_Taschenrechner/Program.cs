using SOLID_Taschenrechner.Domain;
using SOLID_Taschenrechner.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

            string pay2winDirectory = Path.Combine(Environment.CurrentDirectory, "Pay2Win");
            if(Directory.Exists(pay2winDirectory))
            {
                foreach (string file in Directory.GetFiles(pay2winDirectory))
                {
                    if (Path.GetExtension(file) == ".dll" ||
                        Path.GetExtension(file) == ".exe")
                        Assembly.LoadFrom(file);
                }
            }

            var alleDatentypenDieIRechenoperationImplementieren =
                AppDomain.CurrentDomain.GetAssemblies()
                                       .SelectMany(assembly => assembly.GetTypes())
                                       .Where(type => typeof(IRechenoperation).IsAssignableFrom(type) &&
                                                      type.IsInterface == false &&
                                                      type.IsAbstract == false)
                                       .ToArray();

            IRechenoperation[] alleOperationen = alleDatentypenDieIRechenoperationImplementieren
                                                 .Select(x => (IRechenoperation)Activator.CreateInstance(x))
                                                 .ToArray();

            var rechner = new ModularerRechner(alleOperationen);
            // var rechner = new ModularerRechner(new Addition(),new Subtraktion());
            new KonsolenUI(parser,rechner).Start();
        }
    }
}
