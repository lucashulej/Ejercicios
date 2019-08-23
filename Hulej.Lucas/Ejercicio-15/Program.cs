using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio-15";

            double numeroA = 0;
            double numeroB = 0;
            char operador;
            double resultado = 0;

            Console.WriteLine("Ingrese el primer numero");
            numeroA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numeroB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el operador");
            operador = Convert.ToChar(Console.ReadKey().KeyChar);

            resultado = Calculadora.Calcular(numeroA, numeroB, operador);

            Console.WriteLine("El resultador de es {0}", resultado);

            Console.ReadLine();
        }
    }
}
