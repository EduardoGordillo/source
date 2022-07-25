using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamanos al metodo creando una instancia
            CCalculadora calcu = new CCalculadora();
            // agregamos valor a variable con sentido de pertenencia
            
          
            calcu.Sumar(23,24);
           
            calcu.Division(4, 4);
          
            Console.ReadLine();
        }
    }
}
