using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";
            DateTime fecha;
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia;

            Console.WriteLine("Ingrese la fecha en formato dd/mm/aaaa");
            fecha = DateTime.Parse(Console.ReadLine());
            diferencia = fechaActual - fecha;
            Console.WriteLine("La diferencia es de {0} dia/s", Convert.ToInt32(diferencia.TotalDays));
            
            Console.ReadLine();
        }
    }
}
