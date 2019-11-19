using System;

namespace Clase_24.Entidades
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;
        public event LimiteSueldoDelDelegado limiteSueldo;,

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }

        public double Sueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                if (value > 18000)
                {
                    this.limiteSueldo(value, this);
                }
                else
                {
                    this.sueldo = value;
                }
            }
        }

        public Empleado(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public override string ToString()
        {
            return "Nombre " + this.nombre + "\nApellido " + this.apellido + "\nLegajo " + this.legajo + "\nSueldo " + this.sueldo;
        }
    }
}
