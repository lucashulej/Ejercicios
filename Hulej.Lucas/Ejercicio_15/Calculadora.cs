using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular (double numeroA,double numeroB,char operador)
        {
            double resultado = 0;
            bool divisionValida = false;
            switch(operador)
            {
                case '+':
                    resultado = numeroA + numeroB;
                    break;
                case '-':
                    resultado = numeroA - numeroB;
                    break;
                case '*':
                    resultado = numeroA * numeroB;
                    break;
                case '/':
                    divisionValida = Calculadora.Validar(numeroB);
                    if(divisionValida==false)
                    {
                        Console.WriteLine("El divisor no puede ser 0");
                        break;
                    }
                    resultado = numeroA / numeroB;
                    break;
                default:
                    Console.WriteLine("El operador ingresado no es valido");
                    break;
            }
                   
            return resultado;
        }

        private static bool Validar(double numero)
        {
            bool retorno = false;
            if(numero!=0)
            {
                retorno = true;
            }
            return retorno;
        }

        
    }
}
