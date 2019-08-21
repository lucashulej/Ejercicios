using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio-06";
            int numeroA;
            int numeroB;
            int i;
            Console.WriteLine("Ingrese el año base");
            numeroA=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año final");
            numeroB = int.Parse(Console.ReadLine());
            Console.Clear();
            for(i=numeroA;i<numeroB;i++)
            {
                if(i%4==0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
