using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionComposicionEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1) Crear y serializar auto\n" +
                "2) Leer auto");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                string modelo = "";
                double costo = 0;
                int cilindros = 0;
                int hp = 0;
                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                Console.WriteLine("Dame los cilindros");
                valor = Console.ReadLine();
                cilindros = Convert.ToInt32(valor);

                Console.WriteLine("Dame los Hp");
                valor = Console.ReadLine();
                hp = Convert.ToInt32(valor);

                CAuto miAuto = new CAuto();
                CMotor miMoto = new CMotor();
                miAuto.Modelo = modelo;
                miAuto.Costo = costo;
                miMoto.Cilindros = cilindros;
                miMoto.Hp = hp;
               

                Console.WriteLine("Auto a serializar ");
                miAuto.MuestraAuto();

                Console.WriteLine("---Serializamos---");
                // seleccionamos el formateador

                BinaryFormatter formateador = new BinaryFormatter();
                // creamos el stream

                Stream miStream = new FileStream("Cautos.aut", FileMode.Create, FileAccess.Write, FileShare.None);
                // serializamos
                miAuto.Motor = miMoto;
                formateador.Serialize(miStream, miAuto);
                // cerramos el stream
                miStream.Close();

            }
            if (opcion == 2)
            {
                // deserializar el objeto 
                Console.WriteLine("---Deserializamos");
                // seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                // creamos el stream

                Stream miStream = new FileStream("Cautos.aut", FileMode.Open, FileAccess.Read, FileShare.None);
                // deserializamos con el formateador
                CAuto auto = (CAuto)formateador.Deserialize(miStream);
                miStream.Close();

                Console.WriteLine("El auto es ");
                auto.MuestraAuto();

            }
        }
    }
}
