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

            Console.WriteLine("Ingrese un numero");
            numero = double.Parse(Console.ReadLine());

            binario = Conversor.DecimalBinario(numero);
            Console.WriteLine(binario);

            Console.ReadLine();
        }
    }
}
