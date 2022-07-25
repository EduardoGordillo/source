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
            CImaginario im1 = new CImaginario(1, 2);

            CImaginario im2 = new CImaginario(3,4);
            CImaginario imr;

            imr = im1 + im2;
            Console.WriteLine($"{im1} + {im2} = {imr} ");
            imr = im1 - im2;
            Console.WriteLine($"{im1} - {im2} = {imr} ");
            imr = im1 / im2;
            Console.WriteLine($"{im1} / {im2} = {imr} ");
            imr = im1 * im2;
            Console.WriteLine($"{im1} * {im2} = {imr} ");
            im1 += im2;
            Console.WriteLine(im1);
            im1 -= im2;
            Console.WriteLine(im1);

        }
    }
}
