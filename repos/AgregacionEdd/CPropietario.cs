using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacionEdd
{
    class CPropietario
    {

        private string nombre;
        private CEdificio propiedad = null;

        public CPropietario(string pNombre)
        {
            nombre = pNombre;
        }
        public void MuestraPropiedad( )
        {

            if (propiedad != null )
            {
                Console.WriteLine($"{nombre} tiene: Edificio");
                propiedad.Muestra();

            }
            else
            {
                Console.WriteLine($"{nombre} aun no tiene propiedades");
            }
     

        }
        public void AdicionarPropiedad(CEdificio pEdificio)
        {
            if (pEdificio != null)
                propiedad = pEdificio;
        }
    }
    
}
