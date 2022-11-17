using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n07.TablasMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Dame un número para mostrar su tabla de multiplicar");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{num} x {i} = {num*i}");
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
