using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionEdd
{
    class CEdificio
    {
        private string direccion;
        private int cantDepto;
        private int deptoRenta;

        public CEdificio(string pDireccion, int pCantDepto, int pDeptoRenta)
        {
            Console.Beep();
            direccion = pDireccion;
            cantDepto = pCantDepto;
            deptoRenta = pDeptoRenta;
            
        }

        public void Muestra (  )
        {

       
            Console.WriteLine($"Edificio en {direccion} con {cantDepto} departamentos y {deptoRenta} en renta");
        }
        


    }
}
