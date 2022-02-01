using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_01
{
    class CCalculadora

    {
       
        private int r;
        public void Sumar( int x, int y)
        {
           r = x + y ;
            Console.WriteLine($"{x} + {y} =");
            Muestra();
        }
        public void Division (int x, int y)
        {
            r = x / y;
            Console.WriteLine($"{x} / {y} =");
            Muestra();
        }
        private void Muestra()
        {
            Console.WriteLine($" {r} " );
        }
    }
}
