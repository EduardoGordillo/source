using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionEdd_
{
    class Program
    {
        static void Main(string[] args)
        {
            CEscuela miescuela = new CEscuela("Edd");
            miescuela.ColocaAula();
            Console.WriteLine(miescuela);
            Console.ReadLine();


        }
    }
}
