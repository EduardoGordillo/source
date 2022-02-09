using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CRefri mirefri = new CRefri(60, -27);
            Random rnd = new Random();

            // creamos el sink
            // sink1 tiene el codigo que se ejecutara cuando suceda el evento
            CRefriSink sinkn = new CRefriSink();
            CTienda sink2 = new CTienda();
            // adicionamos el sink al refri
            mirefri.AgregarSink(sinkn);
            mirefri.AgregarSink(sink2);
           // mirefri.EliminarSink(sinkn);
            while(mirefri.Kilos > 0 && sinkn.Paro == false)
            {
                // el refri trtabaja y le sacamos los kilos al azar
                mirefri.Trabajar(rnd.Next(1, 5));
            }
            
        }
    }
}
