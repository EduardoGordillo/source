using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaBinariaEdd
{
    class CImaginario
    {

        private double entero;
        private double imaginario;
        public CImaginario(double pEntero, double pImaginario)

        {
            entero = pEntero;
            imaginario = pImaginario;
        }

        //propiedades
        public double Entero { get { return entero; } set { entero = value; } }
        public double Imaginario { get { return imaginario; } set { imaginario = value; } }

        public override string ToString()
        {
            if (imaginario < 0)
                return string.Format($"({entero} {imaginario}i)");
            else
            {
                return string.Format($"({entero} + {imaginario}i)");
            }
        }
        public static CImaginario operator +(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;
            re = i1.Entero + i2.Entero;
            ri = i1.Imaginario + i2.Imaginario;
            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }
    }
}
