using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionEdd
{
    [Serializable]
    class CAuto
    {
        private double costo;
        private string modelo;
        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;

        }
        public void MuestraInfo()
        {
            Console.WriteLine($"Tu automovil es {modelo}");
            Console.WriteLine($"El costo es {costo}");
            Console.WriteLine("----------------");
        }
    }
}
