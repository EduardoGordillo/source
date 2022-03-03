using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionImplicitaEdd
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
            return string.Format("R = {0}", r);
        }

        public static implicit operator CComplejo(CReal pR)
        {
            CComplejo temporal = new CComplejo((int)pR.r, 0);
            return temporal;
        }
    }
}
