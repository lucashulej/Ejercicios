using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_20.Entidades;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Clase_20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();

            Persona persona1 = new Persona("lukitas", "hulej", 20);
            persona1.Apodo.Add("apodo1");
            Persona persona2 = new Persona("adriansiyo", "brizuela", 28);
            persona2.Apodo.Add("apodo2");

            Empleado empleado1 = new Empleado("juan", "perez", 23, 1,500);
            Empleado empleado2 = new Empleado("pedro", "hernandez", 2,33, 560);

            Alumno alumno1 = new Alumno("mario", "alberto", 55, 9);
            Alumno alumno2 = new Alumno("wario", "berto", 55, 8);

            lista.Add(persona1);
            lista.Add(persona2);
            lista.Add(empleado1);
            lista.Add(empleado2);
            lista.Add(alumno1);
            lista.Add(alumno2);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));

                using (StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Persona.xml"))
                {
                    serializer.Serialize(streamWriter, lista);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));

                using (StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"Persona.xml"))
                {
                    List<Persona> auxList = (List<Persona>)serializer.Deserialize(streamReader);
                    foreach(Persona item in auxList)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
