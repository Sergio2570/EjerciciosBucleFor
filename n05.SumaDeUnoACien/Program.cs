using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n05.SumaDeUnoACien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine($"La suma da: {sum}");
            Console.WriteLine("\nPulse una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
