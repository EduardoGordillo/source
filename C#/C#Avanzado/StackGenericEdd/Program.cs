using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGenericEdd
{
    class Program
    {
        static void Main(string[] args)

        {
            CPunto punt;
            Stack<CPunto> puntos = new Stack<CPunto>();  // LIFO

            puntos.Push(new CPunto(2,3));
            puntos.Push(new CPunto(5, 6));
            puntos.Push(new CPunto(7, 8));
            puntos.Push(new CPunto(9, 5));
            puntos.Push(new CPunto(9, 1));
            puntos.Push(new CPunto(5, 5));

            foreach (CPunto punto in puntos)
            {
                Console.WriteLine($"->{punto}");
            }
            Console.WriteLine("------------");

            // hacemos un peek

            Console.WriteLine(puntos.Peek());

            // hacemo un pop
            punt = puntos.Pop();
            Console.WriteLine(punt);
            Console.WriteLine("---------------");

            foreach(CPunto punto in puntos)
            {
                Console.WriteLine(punto);
            }
            Console.WriteLine("--------------");
        }
    }
}
