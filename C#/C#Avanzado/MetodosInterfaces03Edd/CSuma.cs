using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosInterfaces03Edd
{
    class CSuma: ICalcular
    {
        private int a;
        private int b;
        private int r;

        public int Calculo(int pa, int pb)
        {
            a = pa;
            b = pb;
            r = a + b;
            return r;

        }

        public void Mostrar()
        {
            Console.WriteLine($"{a} + {b} = {r}");
        }
    }
}
