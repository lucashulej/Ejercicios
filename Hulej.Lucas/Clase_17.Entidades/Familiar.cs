using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public class Familiar : Auto
    {
        protected int _cantidadAsientos;

        public Familiar(double precio, string patente, int cantidadAsientos) : base(patente, precio)
        {
            this._cantidadAsientos = cantidadAsientos;
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("Patente: " + this._patente);
            Console.WriteLine("Asientos: " + this._cantidadAsientos);
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio);
        }
    }
}
