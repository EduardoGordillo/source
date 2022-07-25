using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoExtension
{
    // las clases donde se guardan las extensiones debe ser estatica
     static class CExtensiones
    {
        // el metodo que estiende debe ser estatico
        // el primer parametro lleva this y representa el tipo que estamos extendiendo

        public static string EsPar (this int i)
        {
            if (i % 2 == 0)
            {
                // Console.WriteLine("Es par");
                return string.Format("Es par");
            }
            else
            {
                return string.Format("Es impar"); ;
            }
        }

        // extiende double

        public static double Dobletea(this double o)
        {
            return o * 2.0;
        }

        public static void Sonido( this ISaludador s)

        {
            Console.Beep();
        }
    }
}
