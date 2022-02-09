using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerEdd
{
    class CAuto
    {
        double costo;
        double tenecia;
        string modelo;

        public CAuto(string pModelo, double pCosto)
        {
            modelo = pModelo;
            costo = pCosto;


        }

        public void MuestraInformacion()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"El auto {modelo}\n" +
                $"Costo ${costo}\n" +
                $"---------------------");
        }
    }
}
