using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAnonimos
{
    class CPunto
    {
        public delegate void DelMensaje();
        public DelMensaje mensaje;
        private int x;
        private int y;

        public CPunto(int pX, int pY)
        {
            x = pX;
            y = pY;
        }

        public override string ToString()
        {
            return string.Format($" X = {x}, Y = {y}"); 
        }
    }
}
