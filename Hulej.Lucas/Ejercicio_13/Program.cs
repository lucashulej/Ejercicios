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
            string binario = "";

            string binario2 = "";
            double resultado = 0;

            Console.WriteLine("Ingrese un numero decimal");
            numero = double.Parse(Console.ReadLine());
            binario = Conversor.DecimalBinario(numero);

            Console.WriteLine("Ingrese un numero binario");
            binario2 = Console.ReadLine();
            resultado = Conversor.BinarioDecimal(binario2);
            Console.WriteLine(binario);

            Console.ReadLine();
        }
    }
}
