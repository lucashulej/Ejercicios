using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio-01";
            int numero;
            int i;
            int minimo = 0;
            int maximo = 0;
            int acumulador = 0;
            double promedio = 0;

            for(i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                acumulador = acumulador + numero;
                if (i==0)
                {
                    minimo = numero;
                    maximo = numero;
                    continue;
                }
                if(minimo<numero)
                {
                    minimo = numero;
                }
                if(maximo>numero)
                {
                    maximo = numero;
                }
            }
            promedio = (double)acumulador / 5;
            Console.WriteLine("Minimo = {0}",minimo);
            Console.WriteLine("Maximo = {0}", maximo);
            Console.WriteLine("Promedio = {0}", promedio);
            Console.ReadLine();
        }
    }
}
