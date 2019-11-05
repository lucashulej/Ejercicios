using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Clase_20.Entidades
{
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Empleado))]
    public class Persona : IXML
    {
        public string nombre;
        public string apellido;
        public int edad;
        List<string> apodos;

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public List<string> Apodo
        {
            get
            {
                return this.apodos;
            }
        }

        public Persona()
        {
            this.apodos = new List<string>();
        }

        public Persona(string nombre, string apellido, int edad) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            return this.nombre + " " + this.apellido + " " + this.edad + "\n";
        }

        public bool Guardar(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));

                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    serializer.Serialize(streamWriter, path);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        public bool Leer(string path, out object objeto)
        {
            objeto = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));

                using (StreamReader streamReader = new StreamReader(path))
                {
                    objeto = (Persona)serializer.Deserialize(streamReader);
                    Console.WriteLine(objeto);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
    }
}
