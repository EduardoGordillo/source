using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosRefriEdd
{
    class CRefri
    {
        // aqui van los delegados
        public delegate void DReservasBajas(int pKilos);
        public delegate void DDescongelado(int pGrados);

        private int kilosAlimentos = 0;
        private int grados = 0;
        // aqui estan las variables para invocar los delegados
        private DReservasBajas delReservas;
        private DDescongelado delDescongelado;
        public CRefri(int pKilos, int pGrados)
        {
            kilosAlimentos = pKilos;
            grados = pGrados;
        }

        public void AdicionaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas = pMetodo;

        }
        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado = pMetodo;

        }
        public int Kilos { get { return kilosAlimentos; } }
        public int Grados { get{ return grados; } }

        public void Trabajar(int pConsumo)
        {
            kilosAlimentos -= pConsumo;

            grados += 1;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{kilosAlimentos} kilos, {grados} grados");

            if (kilosAlimentos < 10)
            {
                delReservas(kilosAlimentos);
            }
            if (grados > 0)
            {
                delDescongelado(grados); 
            }
        }
    }
}
