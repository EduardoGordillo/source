using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableEdd
{
    class CAuto:IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }

        public void CalcularTenencia(double pImpuesto)
        {
            tenencia = 5000.0 + costo * pImpuesto;
        }
        public void MuestraInformacion()
        {
            Console.WriteLine($"Tu auto {modelo}");
            Console.WriteLine($"Costo ${costo} con una tenencia ${tenencia}");
            Console.WriteLine($"Total = ${costo + tenencia}");
            Console.WriteLine("------------------------------");

        }
    }
}
