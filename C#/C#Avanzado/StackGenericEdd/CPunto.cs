using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGenericEdd
{
    class CPunto : IComparable
    {
        private int x;
        private int y;
        private int suma;
        public CPunto(int pX, int pY)
        {
            x = pX;
            y = pY;
            Suma();
        }

        public int CompareTo(object obj)
        {
            CPunto temp = (CPunto)obj;
            if (suma > temp.suma)
                return 1;
            if (suma < temp.suma)
                return -1;

            return 0;
        }

        public override string ToString()
        {
            return string.Format($"X = {x}, Y = {y}");
        }

        public void Suma()
        {
            suma = x + y;
        }

    }
}
