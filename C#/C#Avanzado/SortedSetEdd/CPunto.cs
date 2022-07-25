using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetEdd
{
    class CPunto : IComparable<CPunto>
    {
        private int x;
        private int y;
        private int suma;
        public CPunto(int pX, int pY)
        {
            x = pX;
            y = pY;
            
        }



        public override string ToString()
        {
            return string.Format($"X = {x}, Y = {y}");
        }

        public void Suma()
        {
            suma = x + y;
        }

        public int CompareTo(CPunto b)// yo objeto dentro de la clase me estoy comparando con un objeto b de entrada

        {
            double maga = Math.Sqrt(x * x + y * y); // magnitud del vector 
            double magb = Math.Sqrt(b.x * b.x + b.y * b.y);

            if (maga > magb)
                return 1;
            if (maga < magb)
                return -1;
            
            else 
            return 0;

        }
    }
}
