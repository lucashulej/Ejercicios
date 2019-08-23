using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_03";
            int numero;
            int i;
            int j;
            int contador = 0;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            if (numero < 2)
            {
                Console.WriteLine("El numero ingresado no es valido");
            }
            else
            {
                for (i = 2; i < numero; i++)
                {
                    for(j=1;j<=i+1;j++)
                    {
                        if(i%j==0)
                        {
                            contador++;
                        }
                    }
                    if (contador == 2)
                    {
                        Console.WriteLine(i);
                    }
                    contador = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
