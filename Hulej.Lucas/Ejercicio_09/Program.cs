using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_09";
            int numero;
            int i;
            int j;
            Console.WriteLine("Ingrese un numero");
            numero=int.Parse(Console.ReadLine());
            Console.Clear();
            for (i = 0; i < numero; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("*");
                    continue;
                }
                else
                {
                    j = 0;
                    while (j < i+2)
                    {
                        Console.Write("*");
                        j++;
                    }
                    Console.WriteLine("");
                }
            }
            Console.ReadLine();
        }
    }
}
