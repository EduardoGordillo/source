using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionImplicitaEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            CComplejo comp1 = new CComplejo(1,6);

            CReal r1 = new CReal(9);
            CComplejo im2 = r1;

            Console.WriteLine(im2);

            Console.WriteLine(r1);
        }
    }
}
