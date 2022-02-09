using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CRectangulo[] res = new CRectangulo[5];
            res[0] = new CRectangulo(2,3);
            res[1] = new CRectangulo(4,5);
            res[2] = new CRectangulo(8,6);
            res[3] = new CRectangulo(8,9);
            res[4] = new CRectangulo(7,6);

            foreach (CRectangulo r in res)
                Console.WriteLine(r);
            Console.WriteLine("----------");

            // array sort es una implementacion de la interfaz de Icomparable 
            Array.Sort(res);

            foreach (CRectangulo r in res)
                Console.WriteLine(r);

            Console.ReadLine();
        }
    }
}
