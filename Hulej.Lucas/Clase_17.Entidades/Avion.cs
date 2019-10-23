using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public class Avion : Vehiculo, IAFIP
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double vMax) : base(precio)
        {
            this._velocidadMaxima = vMax;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio);
            Console.WriteLine("Velocidad Maxima: " + this._velocidadMaxima);
        }

        public double CalcularImpuesto()
        {
            return this._precio * 0.33;
        }
    }
}
