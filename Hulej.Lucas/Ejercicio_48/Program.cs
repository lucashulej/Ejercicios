using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Recibo, Factura> contabilidad = new Contabilidad<Recibo, Factura>();

            Recibo r1 = new Recibo(11);
            Recibo r2 = new Recibo();
            Factura f1 = new Factura(23);
            Factura f2 = new Factura(50);

            contabilidad = (contabilidad + f1);
            contabilidad = (contabilidad + f2);
            contabilidad = (contabilidad + r1);
            contabilidad = (contabilidad + r2);

            Console.WriteLine(contabilidad.ToString());

            Console.ReadLine();
        }
    }
}
