using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio-04";
            int i;
            int contador = 0;
            int numero = 1;
            int acumulador = 0;
            while (contador != 4)
            {
                for (i = 1; i < numero-1; i++)
                {
                    if (numero % i == 0)
                    {
                        acumulador = acumulador + i;
                    }
                }
                if(acumulador==numero)
                {
                    Console.WriteLine(numero);
                    contador++;
                }
                acumulador = 0;
                numero++;
            }
            Console.ReadLine();
            
        }
    }
}
