using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_01
{
    class CCalculadora

    {
        public int x;
        public int y;
        private int r;
        public void Sumar()
        {
           r = x + y ;
        }
        public void Division()
        {
            r = x / y;
        }
        public void Muestra()
        {
            Console.WriteLine($"x = {x} \n y = {y} \n r = {r} " );
        }
    }
}
