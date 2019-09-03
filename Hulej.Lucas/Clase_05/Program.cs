using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_05.Entidades;

namespace Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase_05";

            Tinta tinta1 = new Tinta();
            Tinta tinta2 = new Tinta(ConsoleColor.Red);
            Tinta tinta3 = new Tinta(ConsoleColor.Red,ETipoTinta.China);

            Console.WriteLine(Tinta.Mostrar(tinta1));
            Console.WriteLine(Tinta.Mostrar(tinta2));
            Console.WriteLine(Tinta.Mostrar(tinta3));

            Console.WriteLine((string)tinta1);

            Pluma pluma1 = new Pluma("Castel",tinta3,4);
            string plumaString;
            plumaString = pluma1;
            Console.WriteLine("\n" + plumaString);

            Console.ReadLine();
        }
    }
}
