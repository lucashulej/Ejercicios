using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public class Deportivo : Auto, IAFIP
    {
        protected int caballosFuerza;

        public Deportivo(double precio, string patente, int hp) : base(patente, precio)
        {
            this.caballosFuerza = hp;
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("Patente: " + this._patente);
            Console.WriteLine("Caballos de Fuerza: " + this.caballosFuerza);
        }

        public override void MostrarPrecio()
        {
            throw new NotImplementedException();
        }

        public double CalcularImpuesto()
        {
            return this._precio * 0.33;
        }


    }
}
