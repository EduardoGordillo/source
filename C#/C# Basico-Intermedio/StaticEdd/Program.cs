using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CCompu C1 = new CCompu();
       
            C1.muestraDolares();
            Console.WriteLine("----------------");
            
            CCompu C2 = new CCompu("i7", 14, 780);
            Console.WriteLine("-----------------");
            CCompu C3 = new CCompu("i5", 8, 730);
            Console.WriteLine("----------------");
            C1.TipoCambio = 18;
            C1.Muestra();
            C1.muestraDolares();
            Console.WriteLine("----------------");
            C2.Muestra();
            C2.muestraDolares();
            Console.WriteLine("----------------");
            C3.Muestra();
            C3.muestraDolares();


            Console.ReadLine();
        }
    }
}
