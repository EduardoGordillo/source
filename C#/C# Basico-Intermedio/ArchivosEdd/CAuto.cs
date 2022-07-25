using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosEdd
{
    class CAuto
    {
        private double costo;
        private string modelo;

        public double Costo { get { return costo; } set { costo = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }

        public CAuto()
        {
            costo = 0;
            modelo = "";
        }

        public CAuto(double pCosto, string pModelo)
        {
            costo = pCosto;
            modelo = pModelo;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine($"------------\n" +
                $"Tu auto es {modelo}\n" +
                $"Costo: {costo}\n" +
                $"----------------");
        }
    }
}
