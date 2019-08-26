using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            int numeroInt = 0;
            int resto;

            numeroInt = (int) numero;
            Console.WriteLine(numeroInt);

            while (numeroInt > 0)
            {
                resto = (numeroInt % 2);
                
                if(resto==0)
                {
                    binario = 0 + binario;
                }
                else
                {
                    binario = 1 + binario;
                }

                numeroInt = numeroInt / 2;
            } 
            return binario;
        }
        public static int BinarioDecimal(string numero)
        {
            int resultado = 0;
            int i = 0;
            int j = 0;
            string binario;
            for (i = numero.Length - 1; i > -1; i++)
            {
                //binario[j] = numero[i];
                j++;
            }
            return resultado;
        }
    }
}
