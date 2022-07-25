using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_01
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
            // intento entrar al dato privado
            //  no se puede
            //Console.WriteLine(calcu.r);
            //llamamos a los metodos de CCalculadora con la instancia
            calcu.Sumar();
            calcu.Muestra();
            calcu.Division();
            calcu.Muestra();

            Console.ReadLine();
        }
    }
}
