using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n08.CalcularDivisores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Dame un número para mostrar sus divisores");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (0 < num)
                {
                    for (int i = 1; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El número no puede ser cero o negativo");
                }
                
            }
            else
            {
                Console.WriteLine("Dato inválido");
            }
            Console.WriteLine("\nPulse una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
