using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_10";

            int numero;
            int i;
            int j;
            string impresion = "*";

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            Console.Clear();

            for (i = 0; i < numero; i++)
            {
                for (j = 0; j < numero - i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(impresion);
                impresion = impresion + "**";
            }

            Console.ReadLine();
        }
    }
}
