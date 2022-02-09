using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackEdd
{
    class CTienda : IEventoRefri
    {
        public void EDescongelado(int pgrados)
        {
            
        }

        public void EReservaBaja(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Green; // esto hace que el mesaje enviado desde este metodo tenga color amarillo de fondo
            Console.WriteLine($"---> Le enviaremos sus viveres");
            Console.WriteLine($"---> Seran {pKilos} kilos");

        }
    }
}
