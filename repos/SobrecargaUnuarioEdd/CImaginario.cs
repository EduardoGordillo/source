using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaUnuarioEdd
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

        public double Entero { get { return entero; } set { entero = value; } }
        public double Imaginario { get { return imaginario; } set { imaginario = value; } }

        public override string ToString()
        {
           if (imaginario < 0 )
            {
                return string.Format($"{entero} i{imaginario}");
            }
            else
            {
                return string.Format($"{entero} + i{imaginario}");
            }

          
        }
        public static CImaginario operator ++(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.Entero + 1, i1.Imaginario + 1);
            return temp;
        }
        public static CImaginario operator --(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.Entero -1, i1.Imaginario -1);
            return temp;

        }

        public override bool Equals(object obj)
        {
            if (obj is CImaginario)
            {
                CImaginario temp = (CImaginario)obj;
                // comparamos por igualdad
                if (imaginario == temp.Imaginario && entero == temp.Entero)
                    return true;
            }
            return false;
        }

        public static bool operator == (CImaginario i1, CImaginario i2)
        {
            return i1.Equals(i2);
        }
        public static bool operator !=(CImaginario i1, CImaginario i2)
        {
            return !(i1.Equals(i2));
        }
    }
}
