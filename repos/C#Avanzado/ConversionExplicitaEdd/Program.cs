using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicitaEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // conversion de custom de tipo 
            CComplejo comp1 = new CComplejo(2,3);

            // ya con la implementacion de explicit operator
            CReal real1 = (CReal)comp1;

            Console.WriteLine(comp1);

            Console.WriteLine(real1);
        }
    }
}
