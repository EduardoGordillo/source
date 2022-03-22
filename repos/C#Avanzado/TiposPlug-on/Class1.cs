using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPlug_on
{
   
        // en esta interface definimos los metodos que debe de implementar el plug-in

        public interface IPlugInMates
        {
            double Calcular(double pA, double pB);
        }

        // indicamos que el atributo se usara solo con clases
        [AttributeUsage(AttributeTargets.Class)]
        // creamos un atributo para proveer informacion del plug in
        public sealed class CInfoPlugIn: System.Attribute
        {
            private string creador;
            private string informacion;
            public string Creador { get { return creador; }set { creador = value; } }
            public string Informacion { get { return informacion; } set { informacion = value; } }
        }
    
}
