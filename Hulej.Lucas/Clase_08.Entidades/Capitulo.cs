using System;

namespace Clase_08.Entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;

        static private Random generadorDeNumeros;
        static private Random generadorDePaginas;

        static Capitulo()
        {
            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
        }

        private Capitulo(int num, string tit, int pag)
        {
            this.numero = num;
            this.titulo = tit;
            this.paginas = pag;
        }
        
        public int Numero
        {
            get { return this.numero; }
        }

        public string Titulo
        {
            get { return this.titulo; }
        }

        public int Paginas
        {
            get { return this.paginas; }
        }

        public static implicit operator Capitulo(string s)
        {
            Capitulo capitulo = new Capitulo(Capitulo.generadorDeNumeros.Next(1, 65), s, Capitulo.generadorDePaginas.Next(15, 233));
            return capitulo;
        }

        public static bool operator ==(Capitulo a,Capitulo b)
        {
            if (a.numero == b.numero && a.titulo == b.titulo)
                return true;
            else
                return false;
        }

        public static bool operator !=(Capitulo a, Capitulo b)
        {
            return !(a==b);
        }

    }
}
