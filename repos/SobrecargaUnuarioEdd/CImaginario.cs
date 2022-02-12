using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaUnuarioEdd
{
    class CImaginario : IComparable
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
        public double magnitud ()
        {
            double m = 0;
            m = Math.Sqrt((entero * entero) * (imaginario * imaginario));
            return m;
        }

        public int CompareTo(object obj)
        {
            if (obj is CImaginario)
            {
                CImaginario temp = (CImaginario)obj;
                if (magnitud() > temp.magnitud())
                    return 1;
                if (magnitud() < temp.magnitud())
                    return -1;

            }
            return 0;
        }

        public override int GetHashCode()
        {
            int hashCode = 1801871858;
            hashCode = hashCode * -1521134295 + entero.GetHashCode();
            hashCode = hashCode * -1521134295 + imaginario.GetHashCode();
            hashCode = hashCode * -1521134295 + Entero.GetHashCode();
            hashCode = hashCode * -1521134295 + Imaginario.GetHashCode();
            return hashCode;
        }

        public static bool operator <(CImaginario i1, CImaginario i2)
        {
            if (i1.CompareTo(i2) < 0)
                return true;
            else
                return false;

        }
        public static bool operator  >(CImaginario i1, CImaginario i2)
        {
            if (i1.CompareTo(i2) > 0)
                return true;
            else
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
