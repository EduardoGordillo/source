using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaBinariaEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 0);
            CImaginario im2 = new CImaginario(2,0);
            CImaginario imr;

            imr = im1 + im2;
            Console.WriteLine($"{im1} + {im2} = {imr} ");
        }
    }
}
