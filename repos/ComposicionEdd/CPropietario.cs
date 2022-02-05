using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionEdd
{
    class CPropietario
    {

        private string nombre;
        private CEdificio propiedad = null;

        public CPropietario(string pNombre)
        {
            nombre = pNombre;
           
            propiedad = new CEdificio("Cholula 3 #3", 4, 2);
            
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
       
    }
    
}
