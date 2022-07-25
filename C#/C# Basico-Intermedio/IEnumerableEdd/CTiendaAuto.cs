using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableEdd
{
    class CTiendaAuto
    {
        private CAuto[] disponible;
        public CTiendaAuto()
        {
            disponible = new CAuto[4];
            disponible[0] = new CAuto("Figo", 240000);
            disponible[1] = new CAuto("Astra", 300000);
            disponible[2] = new CAuto("Sonic", 250000);
            disponible[3] = new CAuto("Swift", 340000);

        }
        public IEnumerator GetEnumerator()
        {
            //Regresamos la estructura que nos interesa que el foreach recorra
            // esta debe implementar IEnumerator
            return disponible.GetEnumerator();
        }

    }
}
