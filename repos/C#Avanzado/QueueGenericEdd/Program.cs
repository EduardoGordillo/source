using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGenericEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CPunto entrada;
            Queue<CPunto> puntos = new Queue<CPunto>(); //FIFO
            puntos.Enqueue(new CPunto(1,3));
            puntos.Enqueue(new CPunto(6, 4));
            puntos.Enqueue(new CPunto(8, 5));
            puntos.Enqueue(new CPunto(6, 8));
            puntos.Enqueue(new CPunto(18, 23));

            foreach (CPunto punto in puntos)
            {
                Console.WriteLine(punto);
            }

            Console.WriteLine("----------------");

            // hacemos un peek

            Console.WriteLine(puntos.Peek());
            Console.WriteLine("--------------");

            // hacemos un dequeue
            entrada = puntos.Dequeue(); // toma el primer objeto que sale y lo saca
            Console.WriteLine(entrada);
            Console.WriteLine("-------");

            foreach (CPunto punto in puntos)
            {
                Console.WriteLine(punto);
            }

        }
    }
}
