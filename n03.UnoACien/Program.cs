using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n03.UnoACien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nPulse una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
