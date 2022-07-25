using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposPlug_on;

namespace PluginSumatoria
{
   // hacemos la referencia a plugin
   // colocamos el atributo
   [CInfoPlugIn(Creador ="Edd", Informacion ="Regresa double, 1er operando valor, 2ndo poner 0")]
   // creamos la clase que implementa la interfaz
   public class CSumatoria: IPlugInMates
    {
        public double Calcular(double pA, double pB)
        {
            int n = 0;
            double sumatoria = 0;
            for (n = 1; n < pA; n++)
                sumatoria += n;
            return sumatoria;
        }
    }
}
