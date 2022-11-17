using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n02.SumaPorTeclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, num;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Dame números para sumar ({i}/5)");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    suma = suma + num;
                }
                else
                {
                    Console.WriteLine("Dato inválido");
                }
            }
            Console.WriteLine($"El total es {suma}");
            Console.WriteLine("\nPulse una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
