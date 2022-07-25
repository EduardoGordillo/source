using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerEdd
{
    class CTiendaAuto
    {
        private CAuto[] disponibles;

        public CTiendaAuto()
        {
            disponibles = new CAuto[4];
            disponibles[0] = new CAuto("Figo", 170000);
            disponibles[1] = new CAuto("Spark", 250000);
            disponibles[2] = new CAuto("Swift", 380000);
            disponibles[3] = new CAuto("Cogo", 150000);

        }
        // este es un indexer
        public CAuto this[int indice]
        {
            // para obtener informacion desde el exterior
            get { return disponibles[indice]; }
            // para ingresar informacion desde el exterior
            set { 
                if (indice < 5 )
                disponibles[indice] = value; }
        }
    }
}
