using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXMLEdd
{
    [Serializable]
    public class CAuto
    {
        private double costo;
        private string modelo;
        public double Costo { set { costo = value; } get { return costo; } }
        public string Modelo { set { modelo = value; } get { return modelo; } }
        public CAuto()
        {
            costo = 10000;
            modelo = "Vocho";

        }
        public void MuestraInfo()
        {
            Console.WriteLine($"Tu automovil es {modelo}");
            Console.WriteLine($"El costo es {costo}");
            Console.WriteLine("----------------");
        }
    }
}
