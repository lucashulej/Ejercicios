using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Clase_20.Entidades
{
    public class Auto : IXML
    {
        public string marca;
        public double precio;

        public Auto()
        {

        }

        public Auto(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public override string ToString()
        {
            return  "MARCA: "+ this.marca + " PRECIO" + this.precio + "\n";
        }

        public bool Guardar(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Auto));

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
                XmlSerializer serializer = new XmlSerializer(typeof(Auto));

                using (StreamReader streamReader = new StreamReader(path))
                {
                    objeto = (Auto)serializer.Deserialize(streamReader);
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
