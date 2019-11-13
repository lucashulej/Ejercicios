using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_24.Entidades;

namespace Clase_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("lucas", "hulej", 1234);
            empleado1.limiteSueldo += new LimiteSueldoDelDelegado(LimiteSueldoDelDelegado);
            empleado1.Sueldo = 33000;
            Console.WriteLine(empleado1.ToString());
            Console.ReadLine();

            void LimiteSueldoDelDelegado(double sueldo, Empleado empleado)
            {
                //Console.WriteLine(empleado.ToString());
                //Console.WriteLine(sueldo);
                Console.WriteLine("QUE WEA");
            }
        } 
    }
}
