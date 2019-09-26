using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Central.Entidades;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita telefonica = new Centralita("Empresa de Lucas");

            Local local1 = new Local("1", 30, "1", 2.65f);
            Local local2 = new Local("2", 45, "2", 1.99f);
            Provincial provincial1 = new Provincial("1", Franja.Franja_1, 21f, "1");
            Provincial provincial2 = new Provincial(Franja.Franja_3,provincial1);

            telefonica = telefonica + local1;
            telefonica = telefonica + local2;
            telefonica = telefonica + provincial1;
            telefonica = telefonica + provincial2;

            Console.WriteLine(telefonica.ToString());

            telefonica.OrdenarLlamadas();

            Console.WriteLine();

            Console.WriteLine(telefonica.ToString());

            Console.ReadLine();
        }
    }
}
