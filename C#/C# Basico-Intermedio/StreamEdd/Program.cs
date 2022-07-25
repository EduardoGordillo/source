using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola");
            long cantidad = 0;
            long n = 0;
            int valor = 0;
            FileStream fs = new FileStream("Datos.txt", FileMode.Open, FileAccess.Read, FileShare.None);

            cantidad = fs.Length;
            Console.WriteLine("El archivo mide {0}", cantidad);

            // leemos byte por byte

            for (n= 0; n<cantidad; n++)
            {
                fs.Seek(n, SeekOrigin.Begin);
                valor = fs.ReadByte();
                Console.Write("{0}", (char)valor);

            }

            Console.WriteLine("\n------------------------");



            // leer el archivo en otro sentido

            for (n = 1; n <= cantidad; n++)
            {
               
                fs.Seek(-n, SeekOrigin.End);
                valor = fs.ReadByte();
                Console.Write("{0}", (char)valor);
                
            }

            Console.WriteLine("\n------------------------");

            // colocar la posicion
             fs.Seek(0, SeekOrigin.Begin);
            
            while((valor = fs.ReadByte()) > 0)
            {
                Console.Write("{0}", (char)valor);

                
            }
            Console.WriteLine("\n------------------------");
            
            fs.Close();
        }
    }
}
