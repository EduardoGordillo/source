using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionImplicitaEdd
{
    class CComplejo
    {
        //a+bi


        private int a;
        private int b;

        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }

        public CComplejo()
        {

        }
        public CComplejo(int pA, int pB)
        {
            a = pA;
            b = pB;

        }
        public override string ToString()
        {
            return string.Format($" {a} + {b}");
    }
    }
}
