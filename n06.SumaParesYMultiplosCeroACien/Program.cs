using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n06.SumaParesYMultiplosCeroACien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, pares = 0, multiplosTres = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i%2 == 0)
                {
                    pares = pares + i;
                }
                if (i%3 == 0)
                {
                    multiplosTres = multiplosTres + i;
                }
                suma = suma + i;
            }
            Console.WriteLine($"La suma de todos los números es: {suma}, la de los pares es: {pares} y la de los múltiplos de 3 es: {multiplosTres}");
            Console.WriteLine("\nPulse una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
