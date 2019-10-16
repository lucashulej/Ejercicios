using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16.Entidades
{
    public class DepositoDeCocinas
    {
        private int _capcidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capcidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = true;
            if (d._lista.Count < d._capcidadMaxima)
            {
                if (d.GetIndice(c) == -1)
                {
                    d._lista.Add(c);
                    retorno = true;
                }
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            if (d.GetIndice(c) >= 0)
            {
                d._lista.Remove(c);
                retorno = true;
            }
            return retorno;
        }

        public bool Agregar(Cocina c)
        {
            bool retorno = false;
            if (this + c)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool Remover(Cocina c)
        {
            bool retorno = false;
            if (this - c)
            {
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Cocina c)
        {
            return this._lista.IndexOf(c);
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Capacidad Maxima: " + this._capcidadMaxima);
            retorno.AppendLine("Listado de Cocinas:");
            foreach (Cocina item in this._lista)
            {
                retorno.AppendLine(item.ToString());
            }
            return retorno.ToString();
        }
    }
}
