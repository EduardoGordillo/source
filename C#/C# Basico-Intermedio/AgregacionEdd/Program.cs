using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacionEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de agregacion
            //creamos al propietario
            CPropietario Edd = new CPropietario("Eduardo");
            //creamos la propiedad
            CEdificio edif1 = new CEdificio("Av. 3 # 3, Lomas", 10, 3);
          
            // vemos info del propietario
            CEdificio edif2 = new CEdificio("Lago xaltocan 19-202", 4,3);
           
          //  Edd.MuestraPropiedad();
           
            Edd.AdicionarPropiedad(edif1);

            Edd.MuestraPropiedad();


            ///// eliminanos a edd
            // Edd = null;
            //GC.Collect();

            //Edd.MuestraPropiedad();
            //edif1.Muestra();

            Edd.AdicionarPropiedad(edif2);
            Edd.MuestraPropiedad();
        }
    }
}
