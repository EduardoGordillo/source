using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosRefriEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos refri

            CRefri mirefri = new CRefri(70,-20);
            Random rnd = new Random();
            //adicionamos los handlers 
            mirefri.AdicionaMetodoReservas(new CRefri.DReservasBajas(InformeKilos));
            mirefri.AdicionaMetodoDescongelado(new CRefri.DDescongelado(InformeGrados));

            while(mirefri.Kilos > 0)
            {
                mirefri.Trabajar(rnd.Next(1, 5));
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
