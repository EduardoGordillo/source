using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticaEdd
{
    public class MisMates
    {
        private double a;
        private double b;
        private double r;

        public MisMates(double pA, double pB)
        {
            a = pA;
            b = pB;
            r = 0;
        }

        public double R { get { return r; } }

        public double Suma()
        {
            r = a + b;
            return r;
        }

        public double Resta()
        {
            r = a - b;
            return r;
        }

        public double Multi()
        {
            r = a * b;
            return r;

        }
        public double Div()
        {
            r = a / b;
            return r;
        }
    }
}
