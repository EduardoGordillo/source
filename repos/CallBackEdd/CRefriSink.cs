using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackEdd
{
    class CRefriSink : IEventoRefri

    {

        private bool paro = false;
        public bool Paro { get { return paro; } }
        public void EDescongelado(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---> El refri se descongela");
            if (pGrados > 0)
                paro = true;

        }

        //esta es la clase sink
        // Aqui colocamos los handlers de los eventos definidos en la interface

        public void EReservaBaja(int pKilos)
        {
            //agregamos que pasara cuando el evento pase en cada metodo
            Console.ForegroundColor = ConsoleColor.Yellow; // esto hace que el mesaje enviado desde este metodo tenga color amarillo de fondo
            Console.WriteLine($"---> Reservas bajas de alimentos");
            Console.WriteLine($"---> Quedan {pKilos} kilos");
           
        }

    }
}
