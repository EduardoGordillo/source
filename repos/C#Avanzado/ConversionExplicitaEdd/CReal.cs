using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicitaEdd
{
    class CReal
    {
        private double r;
        public double R { get { return r; } set { r = value; } }


        public CReal()
        {

        }

        public CReal(double pR)
        {
            r = pR;
        }

        public override string ToString()
        {
            return string.Format("R = {0}", r) ;
        }

    }
}
