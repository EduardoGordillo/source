using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGenericaEdd
{
    class CPunto<T> // cuando se asigna la <T> es una clase generica 
    {
        private T x;
        private T y;

        public CPunto(T pX, T pY)
        {
            x = pX;
            y = pY;
        }

        public override string ToString()
        {
            return string.Format($"X = {x}, Y = {y}");
        }

        public void Reset()
        {
            /// colocamos el valor de default para el tipo t
            /// numerico 0
            /// referencial null

            x = default(T);
            y = default(T);
        }
        public void EncuentraTipo()
        {
            if (typeof(T) == typeof(int))
                Console.WriteLine("Trabaja como entero");
            if (typeof(T) == typeof(double))
                Console.WriteLine("Soy un double");
            else
                Console.WriteLine("otro tipo");
        }
    }
}
