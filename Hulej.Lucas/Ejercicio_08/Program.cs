using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_08";

            string nombre = "";
            int antiguedad = 0;
            double valorHora = 0;
            int horasTrabajadas = 0;
            double total = 0;
            double descuento = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese el nombre del empleado");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la antiguedad del empleado");
                antiguedad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor hora del empleado");
                valorHora = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese las horas trabajadas por mes del empleado");
                horasTrabajadas = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                total = (valorHora * horasTrabajadas) + (antiguedad * 150);
                descuento = (total * 0.13);

                Console.WriteLine("Nombre = {0}", nombre);
                Console.WriteLine("Antiguedad = {0}", antiguedad);
                Console.WriteLine("Valor Hora = {0}", valorHora);
                Console.WriteLine("El total bruto es de {0}", total);
                Console.WriteLine("El total de los descuentos es {0}", descuento);
                Console.WriteLine("El total neto a cobrar es de = {0}", total - descuento);

                Console.WriteLine("Desea ingresar otro empleado S | N");
                respuesta = Console.ReadKey().KeyChar;
                Console.Clear();
            }
            while (respuesta == 's' || respuesta == 'S');
            Console.ReadLine();
        }
    }
}
