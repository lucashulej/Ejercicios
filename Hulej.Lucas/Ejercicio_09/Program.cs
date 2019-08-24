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
            string impresion = "*";
            Console.WriteLine("Ingrese un numero");
            numero=int.Parse(Console.ReadLine());
            Console.Clear();
            for (i = 0; i < numero; i++)
            {
                Console.Write(impresion);
                impresion = impresion + "**";
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
