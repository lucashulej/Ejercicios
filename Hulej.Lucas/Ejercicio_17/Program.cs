using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_17";

            string impresionAzul;
            string impresionRojo;
            ConsoleColor actual = Console.ForegroundColor;

            Boligrafo azul = new Boligrafo(ConsoleColor.Blue, 30);
            Boligrafo rojo = new Boligrafo(ConsoleColor.Red, 50);

            if(azul.Pintar(10,out impresionAzul)==true)
            {
                Console.ForegroundColor = azul.GetColor();
                Console.WriteLine(impresionAzul);
                Console.ForegroundColor = actual;
            }

            if (rojo.Pintar(51, out impresionRojo) == true)
            {
                Console.ForegroundColor = rojo.GetColor();
                Console.WriteLine(impresionRojo);
                Console.ForegroundColor = actual;
            }

            Console.ReadLine();
        }
    }
}
