using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_13";
            double numero = 0;
            string resultado = "";

            string binario = "";
            int Ndeciemal = 0;

            Console.WriteLine("Ingrese un numero decimal");
            numero = double.Parse(Console.ReadLine());
            resultado = Conversor.DecimalBinario(numero);
            Console.WriteLine("El numero {0} en binario es {1}",numero,resultado);

            Console.WriteLine("Ingrese un numero binario");
            binario = Console.ReadLine();
            Ndeciemal = Conversor.BinarioDecimal(binario);
            Console.WriteLine("El numero {0} en decimal es {1}", binario, Ndeciemal);

            Console.ReadLine();
        }
    }
}
