using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string no = "";
            no = Console.ReadLine();
            n = Convert.ToInt32(no);

            CTiendaAuto mil = new CTiendaAuto();

            //obtenemos un auto
            CAuto miAuto = mil[n];
            miAuto.MuestraInformacion();

            // colocar un auto nuevo
            CAuto otroAuto = new CAuto("Vocho", 85000);
            mil[n] = otroAuto;
            //CAuto mi = mil[0];
            //mi.MuestraInformacion();

            for (n= 0; n< 4; n++)
            {
                mil[n].MuestraInformacion();
            }
           


        }
    }
}
