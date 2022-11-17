using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n1.Hola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int count = 0; count < 5; count++)
            {
                Console.WriteLine("Hola");
            }
            Console.WriteLine("\nPulse una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
