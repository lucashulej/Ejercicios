using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio-11";
            int i;
            int numero;
            bool retorno = false;
            int acumulador = 0;
            int minimo = 0;
            int maximo = 0;
            float promedio = 0;
            for (i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100");
                numero = int.Parse(Console.ReadLine());
                retorno = Validacion.Validar(numero,-100,100);

                if (retorno==false)
                {
                    Console.WriteLine("El numero ingresado no es valido");
                    break;
                }

                if (i == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }

                if (maximo < numero)
                {
                    maximo = numero;
                }

                if (minimo > numero)
                {
                    minimo = numero;
                }

                acumulador = acumulador + numero;
            }
            if(retorno==true)
            {
                promedio = (float) acumulador / 5;
                Console.WriteLine("El valor minimo es {0}", minimo);
                Console.WriteLine("El valor maximo es {0}", maximo);
                Console.WriteLine("El valor promedio es {0}", promedio);
            }
            Console.ReadLine();

        }
    }
}
