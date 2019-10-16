using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16.Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }

        public double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool retorno = false;
            if (a._codigo == b._codigo && a._esIndustrial == b._esIndustrial && a._precio == b._precio)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return (this == (Cocina)obj);
        }

        public override string ToString()
        {
            return "Codigo: " + this._codigo + " - Precio: " + this._precio + " - Es industrial? " + this._esIndustrial;
        }
    }
}
