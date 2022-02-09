using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackEdd
{
    class CRefri
    {
        private ArrayList listaSinks = new ArrayList();

        private int kilosAlimentos =0 ;
        private int grados = 0;

        public CRefri(int Pkilos, int pGrados)
        {
            kilosAlimentos = Pkilos;
            grados = pGrados;
        }
        //con este metodo adicionamos un sink 
        public void AgregarSink(IEventoRefri pSink)
        {
            if (pSink != null)
                listaSinks.Add(pSink);
        }
        // eliminamos un sinks
        public void EliminarSink(IEventoRefri pSink)
        {
            if (listaSinks.Contains(pSink))
                listaSinks.Remove(pSink);
        }
        public int Kilos { get { return kilosAlimentos; } }
        public int Grados { get { return grados; } }

        public void Trabajar(int pConsumo)
        {
            //actualizamos los kilos del refri
            kilosAlimentos -= pConsumo;
            //subimos la temperatura
            grados += 1;

           Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{kilosAlimentos} kilos, {grados} grados");

            // hay que verificar si se cumple la condicion para invocar los handler del evento
            if (kilosAlimentos < 10)
            {
                // invocamos a los handlers de cada sink
                foreach(IEventoRefri handler in listaSinks)
                {
                    handler.EReservaBaja(kilosAlimentos);
                  
                }
            }

            if (grados > 0)
            {
                foreach(IEventoRefri handler in listaSinks)
                {
                    handler.EDescongelado(grados);
                }
            }    
        }


      
    }
}
