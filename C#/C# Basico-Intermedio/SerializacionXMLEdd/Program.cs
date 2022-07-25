using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXMLEdd
{
    class Program
    {
        static void Main(string[] args)
            {
                int opcion = 0;
                string valor = "";

                Console.WriteLine("1) Crear serializacion \n" +
                    "2) Leer auto");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion == 1)
                {
                    string modelo = "";
                    double costo = 0;

                    Console.WriteLine("Dame el modelo");
                    modelo = Console.ReadLine();

                    Console.WriteLine("Dame el costo");
                    valor = Console.ReadLine();
                    costo = Convert.ToDouble(valor);

                    CAuto Auto = new CAuto();
                    Auto.Costo = costo;
                    Auto.Modelo = modelo;
                

                    Console.WriteLine("Auto a seralizar");
                    Auto.MuestraInfo();

                    //empezamos la serializacion
                    Console.WriteLine("Empieza serializacion");

                    // seleccionar el formateador
                    XmlSerializer formateador = new XmlSerializer(typeof(CAuto));

                    // se crea el stream
                    Stream miStream = new FileStream("XmlAutos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                    //serializamos 
                    formateador.Serialize(miStream, Auto);

                    // cerramos el stream
                    miStream.Close();


                }
                if (opcion == 2)
                {

                    // Deserializamos el objeto
                    Console.WriteLine("---- Deserializacion ----");
                    // seleccionamos el formateador
                    XmlSerializer formateador = new XmlSerializer(typeof(CAuto));
                    //creamos el stream
                    Stream miStream = new FileStream("XmlAutos.aut", FileMode.Open, FileAccess.Read, FileShare.None);
                    // deserializamos 
                    CAuto auto = (CAuto)formateador.Deserialize(miStream);
                    // cerramos el stream
                    miStream.Close();
                    // imprimimos el objeto
                    Console.WriteLine("El auto es");
                    auto.MuestraInfo();

                }
            }
    }
}
