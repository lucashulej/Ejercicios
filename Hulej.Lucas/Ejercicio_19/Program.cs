using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_19";

            Sumador suma1 = new Sumador();
            Sumador suma2 = new Sumador(2);
            int a = 0;
            int b = 0;
            long resultado1 = 0;
            string resultado2 = "";

            resultado1 = suma1.Sumar(5, 5);
            resultado2 = suma2.Sumar("funciona ","bien");
            a = (int)suma1;
            b = (int)suma2;

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(suma1 | suma2);
            Console.WriteLine(suma1 + suma2);

            Console.ReadLine();
        }
    }
}
