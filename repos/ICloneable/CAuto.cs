using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneabl
{
    class CAuto : IAutomovil, ICloneable
    {
        double costo;
        double tenencia;
        string modelo;

        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }
        public double Costo { get { return costo; } set { costo = value; } }
        public double Tenencia { get { return tenencia; } set { tenencia = value; } }

        public void CalcularTenencia(double pImpuesto)
        {
            tenencia = 5000.0 + costo * pImpuesto;
        }

        public object Clone()
        {
            CAuto temp = new CAuto(modelo, costo);
            temp.Tenencia = tenencia;
            return temp;

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
