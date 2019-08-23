using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio-14";

            double ladoCuadrado = 0;
            double baseTriangulo = 0;
            double alturaTriangulo = 0;
            double diametroCiruculo = 0;

            double areaCuadrado = 0;
            double areaTriangulo = 0;
            double areaCiruculo = 0;

            Console.WriteLine("Ingrese el lado del cuadrado");
            ladoCuadrado=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la base del triangulo");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo");
            alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el diametro del circulo");
            diametroCiruculo = Convert.ToDouble(Console.ReadLine());

            areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoCuadrado);
            areaTriangulo = CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);
            areaCiruculo = CalculoDeArea.CalcularCiruculo(diametroCiruculo);

            Console.WriteLine("El area del cuadrado es {0}",areaCuadrado);
            Console.WriteLine("El area del triangulo es {0}",areaTriangulo);
            Console.WriteLine("El area del circulo es {0}",areaCiruculo);

            Console.ReadLine();

        }
    }
}
