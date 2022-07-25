using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizableDisposable
{
    class Program
    {
        static void Main(string[] args)
        {

            CPrueba o1 = new CPrueba(4);
            CPrueba o2 = new CPrueba(5);

            Console.WriteLine(o1 + " \n" + o2);

            o1.Dispose();

            Console.WriteLine("-----------");

        }
    }
}
