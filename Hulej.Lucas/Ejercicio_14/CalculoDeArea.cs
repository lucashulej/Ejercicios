using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            double area = 0;
            area = numero * numero;
            return area;
        }

        public static double CalcularTriangulo(double numeroA,double numeroB)
        {
            double area = 0;
            area = (numeroA * numeroB) / 2;
            return area;
        }

        public static double CalcularCiruculo(double numero)
        {
            double area = 0;
            area = Math.PI * Math.Pow((numero / 2), 2);
            return area;
        }
    }
}
