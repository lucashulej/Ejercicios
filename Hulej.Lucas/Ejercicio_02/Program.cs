using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";
            int numero;
            Console.WriteLine("Ingrese un numero");
            numero =int.Parse(Console.ReadLine());
            if(numero > 0)
            {
                Console.WriteLine("El cuadrado de {0} = {1}",numero, Math.Pow(numero, 2));
                Console.WriteLine("El cubo de {0} = {1}", numero, Math.Pow(numero, 3));
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
            Console.ReadLine();
        }
    }
}
