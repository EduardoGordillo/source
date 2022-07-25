using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoGenericoEdd
{
    class Program
    {
        public delegate void miDelegado<T>(T p);
        static void Main(string[] args)
        {
            // para el registro y usos del delegado como string
            miDelegado<string> delCadena = new miDelegado<string>(HandlerString);
            delCadena("Estoy dentro del handler string");
            // para el registro y usos del delgado como double
            miDelegado<double> delDouble = new miDelegado<double>(HandlerDouble);
            delDouble(55.68);
        }

        // handler para el caso string 
        static void HandlerString(string p)
        {
            Console.WriteLine($"Uso string como tipo y el valor es {p}");
        }
        static void HandlerDouble( double p)
        {
            Console.WriteLine($"Uso doble como tipo y el valor es {p}");
        }
    }
}
