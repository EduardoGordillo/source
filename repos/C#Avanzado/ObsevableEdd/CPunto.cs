using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsevableEdd
{
    class CPunto
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


    }
}
