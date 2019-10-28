using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public class Carreta : Vehiculo, IARBA
    {
        public Carreta(double precio) : base(precio)
        {

        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio Carreta: " + this._precio);
        }

        double IARBA.CobrarImpuesto()
        {
            return this._precio * 0.18;
        }
    }
}
