using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue miQ = new Queue(); // FIFO

            // Adicionamos objetos
            miQ.Enqueue("Manzana");
            miQ.Enqueue("Fresa");
            miQ.Enqueue("Pera");

            //iteramos
            foreach(string fruta in miQ)
            {
                Console.WriteLine("->-{0}", fruta);
            }
            Console.WriteLine("------------------");

            // eliminamos el primer elmento de la cola
            Console.WriteLine("Dequeue {0}", miQ.Dequeue());
            Console.WriteLine("Dequeue {0}", miQ.Dequeue());
            foreach(object fruta in miQ)
            {
                Console.WriteLine(fruta);
            }

            miQ.Enqueue("Ciruela");
            miQ.Enqueue("Mango");
            miQ.Enqueue("Limon");

            // peek trae el primero elemento que entro
            Console.WriteLine("Peek {0}", miQ.Peek());
            foreach (object fruta in miQ)
            {
                Console.WriteLine(fruta);
            }

            //conteo de elementos 
            Console.WriteLine("Son: {0}", miQ.Count);

            // ver si un elemento existe en el queue
            Console.WriteLine(miQ.Contains("limon")); // regresa un valor booleano 
        }
    }
}
