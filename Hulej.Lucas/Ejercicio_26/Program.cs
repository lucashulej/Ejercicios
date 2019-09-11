using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_26";

            int[] lista = new int[20];
            int[] listaPositivos = new int[20];
            int[] listaNegativos = new int[20];
            int j = 0;

            Random random = new Random();

            for (int i = 0; i < lista.Length; i++)
            {
                do
                {
                    lista[i] = random.Next(-50, 50);
                } while (lista[i] == 0);
            }

            Console.WriteLine("Lista como fue cargada:");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            //LISTA POSITIVOS

            Console.WriteLine("Lista de positivos decreciente:");
            foreach (int i in lista)
            {
                if (i > 0)
                {
                    listaPositivos[j] = i;
                    j++;
                }
            }

            Comparison<int> comparador1 = new Comparison<int>((num1, num2) => num2.CompareTo(num1));
            Array.Sort(listaPositivos, comparador1);

            foreach (int i in listaPositivos)
            {
                if (i == 0)
                    continue;
                Console.WriteLine(i);
            }


            //LISTA NEGATIVOS
            Console.WriteLine("Lista de negativos creciente:");

            foreach (int i in lista)
            {
                if (i < 0)
                {
                    listaNegativos[j] = i;
                    j++;
                }
            }

            Comparison<int> comparador2 = new Comparison<int>((num1, num2) => num1.CompareTo(num2));
            Array.Sort(listaNegativos, comparador2);

            foreach (int i in listaNegativos)
            {
                if (i == 0)
                    continue;
                Console.WriteLine(i);

            }

            Console.ReadLine();
        }
    }
}
