using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArchivosEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";
            Console.WriteLine("1) Crear archivo\n" +
                "2) Leer Archivo");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                string  modelo;
                double costo;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                CAuto auto = new CAuto(costo, modelo);

                //variables extra

                int numero = 5;
                bool acceso = false;
                byte conteo = 120;

                //creamos el stream
                FileStream fs = new FileStream("MiArchico.arc", FileMode.Create, FileAccess.Write, FileShare.None);

                //creamos el escritor

                BinaryWriter writer = new BinaryWriter(fs);

                // escribimos los atributos del objeto, no es una serializacio 

                writer.Write(auto.Modelo);
                writer.Write(auto.Costo);
                writer.Write(numero);
                writer.Write(acceso);
                writer.Write(conteo);

                // cerramos el stream
                fs.Close();

            }
            if (opcion ==2)

            {
                Console.WriteLine("---Leemos archivo---");

                //creamos el stream
                Stream fs = new FileStream("MiArchico.arc", FileMode.Open, FileAccess.Read, FileShare.None);
                // creamos el lectos

                BinaryReader lector = new BinaryReader(fs);

                // leemos en el mismo orden que se envio

                string modelo = "";
                double costo = 0;
                int numero = 0;
                bool acceso = true;
                byte conteo = 0;

                modelo = lector.ReadString();
                costo = lector.ReadDouble();
                CAuto miauto = new CAuto(costo, modelo);
                numero = lector.ReadInt32();
                acceso = lector.ReadBoolean();
                conteo = lector.ReadByte();
                fs.Close();
                miauto.MuestraInformacion();
                Console.WriteLine(numero);
                Console.WriteLine(acceso);
                Console.WriteLine(conteo);

            }
        }
    }
}
