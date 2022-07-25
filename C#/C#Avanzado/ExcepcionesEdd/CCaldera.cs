using System;
using System.Collections; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesEdd
{
    class CCaldera
    {
        private int tempMax = 120;
        private int tempAtcual = 0;
        private string marca = "";
        private bool funciona = true;

        public int Temperatura { get { return tempAtcual; } set { tempAtcual = value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public bool Funciona { get { return funciona; } }

        public CCaldera(string pMarca, int PTemp)
        {
            tempAtcual = PTemp;
            marca = pMarca;

        }

        // hacemos trabajar sin usar execpciones


        //public void Trabajar (int pAumento)
        //{
        //    if (funciona == false)
        //        Console.WriteLine("Caldera {0} descompuesta", marca);
        //    else
        //    {
        //        tempAtcual += pAumento;
        //        Console.WriteLine("La temperatura actual es {0}", tempAtcual);
        //        {

        //            if (tempAtcual > tempMax)
        //            {
        //                Console.WriteLine("{0} supero la temperatura , tiene{1}", marca, tempAtcual);
        //                tempAtcual = tempMax;
        //                funciona = false;
        //            }
        //        }
        //    }
        //}
        //public void Trabajar(int pAumento)
        //{
        //    if (funciona == false)
        //        Console.WriteLine("Caldera {0} descompuesta", marca);

        //    else
        //    {
        //        tempAtcual += pAumento;
        //        Console.WriteLine($"La temperatura actual es de {tempAtcual}");
        //        if (tempAtcual > tempMax)
        //        {
        //            Console.WriteLine($"{marca} supero la temperatura, tiene {tempAtcual}");
        //            tempAtcual = tempMax;
        //            funciona = false;
        //            // lanzamos la excepcion

        //            throw new Exception(string.Format($"La caldera {marca} se sobrecalienta"));
        //        }
        //    }
        //}
        public void Trabajar(int pAumento)
        {
            if (funciona == false)
                Console.WriteLine("Caldera {0} descompuesta", marca);

            else
            {
                tempAtcual += pAumento;
                Console.WriteLine("La temperatura actual es de {0}", tempAtcual);
                if (tempAtcual > tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempAtcual);
                    tempAtcual = tempMax;
                    funciona = false;
                    // lanzamos la excepcion
                    // y tenemos una variable para capturar la exception
                    Exception ex = new Exception(string.Format("La caldera {0} se sobrecalienta", marca));
                    ex.HelpLink = "http://www.edd0613.com";
                    // adicionamos datos propios a la excepcion
                    ex.Data.Add("Momento: ", string.Format("Ocurrio en {0}", DateTime.Now));
                    ex.Data.Add("Temperatura actual: ", string.Format($"{tempAtcual}° C"));
                    ex.Data.Add("Incremento dado: ", string.Format($"{pAumento}° C")); 
                    throw ex;

                }
            }
        }

    }
}
