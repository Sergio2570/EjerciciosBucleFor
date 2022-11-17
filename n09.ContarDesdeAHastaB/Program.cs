using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n09.ContarDesdeAHastaB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame 2 números por teclado");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                if (int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.WriteLine();
                    if (a < b)
                    {
                        for (int i = a; i <= b; i++)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        for (int i = a; i >= b; i--)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Dato inválido");
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
