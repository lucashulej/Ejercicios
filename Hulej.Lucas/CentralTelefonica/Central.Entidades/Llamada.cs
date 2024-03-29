﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central.Entidades
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrginen;

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrginen;
            }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrginen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder palabra = new StringBuilder();
            palabra.Append("Origen: " + this._nroOrginen);
            palabra.Append(" ");
            palabra.Append("Destino: " + this._nroDestino);
            palabra.Append(" ");
            palabra.Append("Duracion: " + this._duracion);
            return palabra.ToString();
        }

        public static bool operator ==(Llamada uno, Llamada dos)
        {
            bool retorno = false;
            if (object.Equals(uno, null) == false && object.Equals(dos, null) == false)
            {
                if (Local.Equals(uno, dos) || Provincial.Equals(uno, dos))
                {
                    if (uno._nroOrginen == dos._nroOrginen && uno._nroDestino == dos._nroDestino)
                        retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Llamada uno,Llamada dos)
        {
            return !(uno==dos);
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return string.Compare(uno.Duracion.ToString(), dos.Duracion.ToString());
        }
    }
}
