using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_17.Entidades;

namespace Clase_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Carreta carr1 = new Carreta(10000);
            Deportivo dep1 = new Deportivo(500000, "bbb", 500);
            Comercial com1 = new Comercial(240, 800, 300);
            Privado priv1 = new Privado(7000, 900, 10000);



            carr1.MostrarPecio();
            Console.WriteLine("Impuestos ARBA: " + Gestion.MostrarImpuestoProvincial((IARBA)carr1).ToString("C2"));
            Console.WriteLine();

            dep1.MostrarPecio();
            Console.WriteLine("Impuestos AFIP: " + Gestion.MostrarImpuestoNacional((IAFIP)dep1).ToString("C2"));
            Console.WriteLine("Impuestos ARBA: " + Gestion.MostrarImpuestoProvincial((IARBA)dep1).ToString("C2"));
            Console.WriteLine();

            com1.MostrarPecio();
            Console.WriteLine("Impuestos AFIP: " + Gestion.MostrarImpuestoNacional((IAFIP)com1).ToString("C2"));
            Console.WriteLine("Impuestos ARBA: " + Gestion.MostrarImpuestoProvincial((IARBA)com1).ToString("C2"));
            Console.WriteLine();

            priv1.MostrarPecio();
            Console.WriteLine("Impuestos AFIP:" + Gestion.MostrarImpuestoNacional((IAFIP)priv1).ToString("C2"));
            Console.WriteLine("Impuestos ARBA: " + Gestion.MostrarImpuestoProvincial((IARBA)priv1).ToString("C2"));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
