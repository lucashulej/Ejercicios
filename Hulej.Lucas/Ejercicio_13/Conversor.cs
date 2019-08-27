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
            int i = 0;
            int j = 0;
            string binario = "";
            int Ndecimal = 0;
            int multiplicador = 1;
            for (i = numero.Length - 1; i > -1; i--)
            {
                binario = numero[j] + binario;
                j++;
            }
            for (i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    Ndecimal = Ndecimal + multiplicador;
                }
                multiplicador = Convert.ToInt32(Math.Pow(2, i + 1));
            }

            return Ndecimal;
        }
    }
}
