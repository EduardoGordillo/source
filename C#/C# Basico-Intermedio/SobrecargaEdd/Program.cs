using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CCalculadora Suma = new CCalculadora();
           
            Console.WriteLine(Suma.Suma(1.03,2.4,4.3));
            Console.WriteLine(Suma.Suma(1,2));
            Console.ReadLine();

        }
    }
}
