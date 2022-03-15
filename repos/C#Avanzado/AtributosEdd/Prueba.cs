using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributosEdd
{
    [Obsolete("Usa la nueva version de prueba 2")]
    class Prueba
    {
       
        public Prueba()
        {
            Console.WriteLine("Version 1");
        }
    }

    [Datos("Clase por Edd")]
    class Prueba2
    {
        public Prueba2()
        {
            Console.WriteLine("Version 2");
        }
    }
}
