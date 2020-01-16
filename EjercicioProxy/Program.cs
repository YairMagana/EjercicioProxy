using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Llave llave1 = new Llave("abc");
            Llave llave2 = new Llave("def");
            Llave llave3 = new Llave("ghi");

            Automovil automovil = new Automovil("ghi");
            ProxyAutomovil proxyAutomovil = new ProxyAutomovil(automovil);

            Console.WriteLine($"\nSe usará la llave \"{llave1.codigo}\"");
            proxyAutomovil.ColocarLlave(llave1);
            proxyAutomovil.EncenderAutomovil();
            Console.WriteLine($"\nSe usará la llave \"{llave2.codigo}\"");
            proxyAutomovil.ColocarLlave(llave2);
            proxyAutomovil.EncenderAutomovil();
            Console.WriteLine($"\nSe usará la llave \"{llave3.codigo}\"");
            proxyAutomovil.ColocarLlave(llave3);
            proxyAutomovil.EncenderAutomovil();

            Console.ReadKey();

        }
    }
}
