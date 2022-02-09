using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableEdd 
{
    class CRectangulo : IComparable
    {
        private double alto;
        private double ancho;
        private double area;

        public CRectangulo(double pAlto, double pAncho)
        {
            alto = pAlto;
            ancho = pAncho;
            CalculaArea();

        }

        public int CompareTo(object obj)
        {
            // hacemos el type cast con el obejto el cual se va a comprara
            CRectangulo temp = (CRectangulo)obj;
            // si somo mas grandes regresamos 1
            if (area > temp.area)
                return 1;
            // si es mas pequeño regresa -1
            if (area < temp.area)
                return -1;

            return 0;
        }

        private void CalculaArea()
        {
            area = ancho * alto;
        }
        public override string ToString()
        {
            return string.Format($"ancho{ancho} * alto{alto} = area  {area}");
        }
    }
}
