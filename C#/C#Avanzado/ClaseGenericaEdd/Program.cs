using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGenericaEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList puntos = new ArrayList() { 
                new CPunto<int>(1,3),
                new CPunto<int>(45,3),
                new CPunto<int>(5,3),
            };

            foreach (CPunto<int> elemento in puntos)
                Console.WriteLine(elemento);
            CPunto<double> punto = new CPunto<double>(1.6, 1.8);

            Console.WriteLine(puntos[1]);
            punto.EncuentraTipo();

            punto.Reset();

            Console.WriteLine(punto);

            punto.EncuentraTipo();
            CPunto<string> palabra = new CPunto<string>("hola", "estas");

            Console.WriteLine(palabra);
            palabra.Reset();
            Console.WriteLine(palabra);
            palabra.EncuentraTipo();


            
        }
    }
}
