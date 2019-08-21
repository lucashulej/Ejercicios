using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio-12";
            int acumulador = 0;
            int numero = 0;
            char respuesta;
            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                acumulador = acumulador + numero;
                Console.WriteLine("¿Desea ingrear otro numero?");
                respuesta = Console.ReadKey().KeyChar;
                Console.WriteLine("");
            } while (ValidarRespuesta.ValidarS_N(respuesta) == true);
            Console.WriteLine("El total de la suma es {0}", acumulador);
            Console.ReadLine();
        }
    }
}
