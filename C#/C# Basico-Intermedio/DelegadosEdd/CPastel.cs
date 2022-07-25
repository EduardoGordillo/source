using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEdd
{
    class CPastel
    {
        public static void MostrarPastel(string pAnuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pastel llevara el mensaje de {0}", pAnuncio);
        }
    }
}
