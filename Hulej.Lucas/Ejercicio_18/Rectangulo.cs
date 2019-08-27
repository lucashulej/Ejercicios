using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        {
            int i = 0;
            if(i == 0)
            {
                
            }
            return area;
        }

        public float Perimetro()
        {
            return perimetro;
        }

        public Rectangulo(Punto punto1, Punto punto3)
        {
            this.vertice1 = punto1;
            this.vertice2 = punto1;
            this.vertice3 = punto3;
            this.vertice4 = punto3;
        }


    }
}
