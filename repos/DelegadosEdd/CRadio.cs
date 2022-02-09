using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEdd
{
    class CRadio
    {
        public static void MetodoRadio(string pMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("estamos en la clase radio");
            Console.WriteLine($"Este es el mensaje {pMensaje}");
        }
    }
}
