using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoStaticEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0.0, s = 0.0;

            CCalculadora calcu = new CCalculadora(5, 6);
            calcu.suma();
            Console.WriteLine("la suma es  {0}",calcu.R);
            Console.ReadLine();
            calcu.resta();
            Console.WriteLine(calcu.R);
            Console.ReadLine();
            // metodos estaticos
             r = CCalculadoraS.suma(1,3);
            Console.WriteLine(r);
            Console.ReadLine();

             s = Math.Abs(-5);
            Console.WriteLine(s);
            Console.ReadLine();
             
        }
    }
}
