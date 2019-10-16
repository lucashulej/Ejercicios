using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16.Entidades
{
    public class DepositoDeAutos
    {
        private int _capcidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capcidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = true;
            if(d._lista.Count < d._capcidadMaxima)
            {
                if(d.GetIndice(a) == -1)
                {
                    d._lista.Add(a);
                    retorno = true;
                }
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            if(d.GetIndice(a) >= 0)
            {
                d._lista.Remove(a);
                retorno = true;
            }
            return retorno;
        }

        public bool Agregar(Auto a)
        {
            bool retorno = false;
            if(this + a)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool Remover(Auto a)
        {
            bool retorno = false;
            if (this - a)
            {
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Auto a)
        {
            return this._lista.IndexOf(a);
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Capacidad Maxima: " + this._capcidadMaxima);
            retorno.AppendLine("Listado de Autos:");
            foreach (Auto item in this._lista)
            {
                retorno.AppendLine(item.ToString());
            }
            return retorno.ToString();
        }
    }
}
