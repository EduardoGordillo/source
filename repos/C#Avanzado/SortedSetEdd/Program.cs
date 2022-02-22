using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<CPunto> puntos = new SortedSet<CPunto>();
            puntos.Add(new CPunto(28,3));
            puntos.Add(new CPunto(5, 8));
            puntos.Add(new CPunto(6, 39));
            puntos.Add(new CPunto(7, 10));
            puntos.Add(new CPunto(28, 2));
            
            foreach(CPunto punto in puntos)
            {
                Console.WriteLine(punto);
            }
        }
        
    }
}
