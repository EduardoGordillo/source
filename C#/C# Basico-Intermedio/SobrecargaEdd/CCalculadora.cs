using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaEdd
{
    //clasde difinida por el trabajo
    class CCalculadora
    {
        // Declaramos los metodos
        public int Suma(int a, int b)
        {
            int r = 0;
            r = a + b;
            return r;

                
        }
        public double Suma(double a, double b, double c)
        {
            double r = 0;
            r = a + b + c ;
            return r;
        }

    }
}
