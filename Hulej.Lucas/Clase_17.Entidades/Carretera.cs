using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public class Carretera : Vehiculo
    {
        public Carretera(double precio) : base(precio)
        {

        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio " + this._precio);
        }
    }
}
