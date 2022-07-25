using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosMulEdd
{
    class CTienda
    {
        public static void MandaViveres(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("---> Vamos ma mnadar sus viveres, estoy en la tienda");
            Console.WriteLine($"-----> Seran tantos {pKilos} kilos");
        }
    }
}
