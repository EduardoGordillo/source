using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TiposPlug_on;
using System.Threading.Tasks;

namespace PluginSuma
{
    // no olvidar hacer la referancia a tipospluin
    // colocammos el atributo
    [CInfoPlugIn(Creador ="Edd", Informacion ="Regresa double, dos operando a sumar")]

    // creamos la clase que implemente la interface

    public class CSuma : IPlugInMates
    {
        public double Calcular(double pA, double pB)
        {
            double r = pA + pB;
            return r;
        }
    }
}
