using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_08.Entidades
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> listCapitulos;

        public Capitulo this[int index]
        {
            get
            {
                if (index >= 0 && index < listCapitulos.Count)
                    return this.listCapitulos[index];   
               else
                    return null;
            }
            set
            {
                if(index >= 0 && index <listCapitulos.Count)
                {
                    this.listCapitulos[index] = value;
                }
                else if(index == listCapitulos.Count)
                {
                    this.listCapitulos.Add(value);
                }          
            }
        }

        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }

        public int CantidadPaginas
        {
            get
            {
                int total = 0;
                foreach ( Capitulo capitulo in listCapitulos)
                {
                    total = total + capitulo.Paginas;
                }
                return total;
            }
        }

        public int CantidadCapitulos
        {
            get
            {
                int total = 0;
                foreach (Capitulo capitulo in listCapitulos)
                {
                    total++;
                }
                return total;
            }
        }


        public Libro(string tit, string aut)
        {
            this.titulo = tit;
            this.autor = aut;
            this.listCapitulos = new List<Capitulo>();
        }

        


    }
}
