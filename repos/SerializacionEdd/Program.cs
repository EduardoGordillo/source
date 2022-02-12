﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializacionEdd
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

                CAuto Auto = new CAuto(modelo, costo);

                Console.WriteLine("Auto a seralizar");
                Auto.MuestraInfo();

                //empezamos la serializacion
                Console.WriteLine("Empieza serializacion");

                // seleccionar el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                // se crea el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

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
                BinaryFormatter formateador = new BinaryFormatter();
                //creamos el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);
                // deserializamos 
                CAuto auto = (CAuto)formateador.Deserialize(miStream);
                // cerramos el stream
                miStream.Close();
                // imprimimos el objeto
                Console.WriteLine("El auto es");
                auto.MuestraInfo();

            }
            //else
            //{
            //    Console.WriteLine("Eleccion incorrecta");
            //}
        }
    }
}
