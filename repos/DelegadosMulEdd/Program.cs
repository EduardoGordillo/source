using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosMulEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CRefri miRefri = new CRefri(70,-20);
            Random rnd = new Random();

            //variables para el multicasting, necesitamos la instancia para adicionar o eliminar
            DReservasBajas kilos1 = new DReservasBajas(InformeKilos);
            DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);
            DDescongelado des1 = new DDescongelado(InformeGrados);

            miRefri.AdicionaMetodoReservas(kilos1);
            miRefri.AdicionaMetodoReservas(kilos2);
            miRefri.AdicionaMetodoDescongelado(des1);

            while (miRefri.Kilos > 0)
            {
                miRefri.Trabajar(rnd.Next(1,5));
            }

            miRefri.EliminaMetodoRerservas(kilos2);



            //////// Rellenamos el refri
            miRefri.Kilos = 50;
            miRefri.Grados = -15;

            while(miRefri.Kilos > 0)
            {
                miRefri.Trabajar(rnd.Next(1,5));
            }


        }
        public static void InformeKilos(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---->Reservas bajas de alimentos, estoy a nivel de main");
            Console.WriteLine($"Quedan {pKilos} kilos");
        }
        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----> se descongela el refri, estoy a nivel de main");
            Console.WriteLine($"Esta a {pGrados} grados");
        }
    }
}
