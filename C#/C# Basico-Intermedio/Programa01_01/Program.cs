using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_01
{
    class Program
    {
        static void Main(string[] args)

        {
            //llamanos al metodo creando una instancia
            CCalculadora calcu = new CCalculadora();
            // agregamos valor a variable con sentido de pertenencia
            calcu.x = 3;
            calcu.y = 3;
            //llamamos a los metodos de CCalculadora con la instancia
            calcu.Sumar();
            calcu.Division();

            Console.ReadLine();

        }
        
    }
}
