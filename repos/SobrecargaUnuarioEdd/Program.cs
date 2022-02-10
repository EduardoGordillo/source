using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaUnuarioEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(2, 3);
            im1++;
            Console.WriteLine(im1);
            im1--;
            Console.WriteLine(im1);
            bool i2;
            i2 =  im1 == im2;
            Console.WriteLine(i2);
        }
    }
}
