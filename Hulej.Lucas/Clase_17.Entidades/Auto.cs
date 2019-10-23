﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public abstract class Auto : Vehiculo
    {
        protected string _patente;

        public Auto(string patente, double precio) : base(precio)
        {
            this._patente = patente;
        }

        public abstract void MostrarPatente();
    }
}
