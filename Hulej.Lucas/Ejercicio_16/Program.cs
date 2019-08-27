using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_16";

            Alumno alumnoA = new Alumno("Lucas", "Hulej", 42028318);
            alumnoA.Estudiar(7, 10);
            alumnoA.CalcularFinal();
            Alumno alumnoB = new Alumno("Camila", "Aimchil", 41613242);
            alumnoB.Estudiar(3, 5);
            alumnoB.CalcularFinal();

            Console.WriteLine(alumnoA.Mostrar());
            Console.WriteLine(alumnoB.Mostrar());

            Console.ReadLine();
        }
    }
}
