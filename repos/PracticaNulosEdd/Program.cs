using System;

namespace PracticaNulosEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = 5;
            int? y = null;
            if (x.Equals(y))
                Console.WriteLine($"son iguales");
            else
                Console.WriteLine($"no son iguales");

            Console.WriteLine(y.GetValueOrDefault());
            // operador ??

            int? g = null;
            int h = g ?? 1;
            Console.WriteLine(h.ToString("null"));
            Console.WriteLine(g.GetValueOrDefault());

           /* bool mayor = x > y;
            Console.WriteLine($"x es mayor que y {mayor}");*/


            /*if(x.HasValue)
            
                Console.WriteLine($"n = {x}");
                else
                    Console.WriteLine($"x es nulo");*/

            
        }
    }
}
