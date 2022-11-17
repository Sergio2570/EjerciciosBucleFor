using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n10.SumarDesdeAHastaB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
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
                            suma = suma + i;
                        }
                    }
                    else
                    {
                        for (int i = a; i >= b; i--)
                        {
                            Console.WriteLine(i);
                            suma = suma + i;
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
            Console.WriteLine($"La suma de los números da {suma}");
            Console.WriteLine("\nPulse una tecla para finalizar");
            Console.ReadKey();
        }
    }
}