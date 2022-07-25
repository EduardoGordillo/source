using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEdd
{
    class CCompu

    {
        private static double tipoCambio = 21;
        private string procesador = "";
        private int memoria;
        private double costo;
        public CCompu()
        {
            procesador = "i3";
            memoria = 2;
            costo = 350;
            Muestra();
           

        }
        public CCompu(string pProcesador, int mMemoria, double pCosto)
        {
            procesador = pProcesador;
            memoria = mMemoria;
            costo = pCosto;
            Muestra();
            muestraDolares();
           
        }
        public void Muestra ()
        {
            Console.WriteLine($"Procesador = {procesador}\nMemoria = {memoria} \nCosto en dolares = {costo} \nValor de cambio ={tipoCambio}  " );
        }

      /*  public string Procesador
        {
            set { procesador = value; }
        }
        public int Memoria
        {
            set { memoria = value; }
        }
        public double Costo
        {
            get
            {
                return costo;
            }
            set
            {
                costo =  value;
            }

        }*/
        public double TipoCambio
        {
         

            set { tipoCambio = value; }
        }
        public void muestraDolares()
        {
            double  precio = costo * tipoCambio;
            Console.WriteLine($"Precio en pesos {precio}"); 
        }
        

    }
}
