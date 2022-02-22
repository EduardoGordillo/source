using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListGenericEdd
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
            // para implementar compare to para acomodar elemento que no se pueden ocupar con sort 
            // hacer una nueva instancia que va ser designada como el objeto que traera la funcion
            // entonces la funcion suma tienen el estado que se designa en el momento que se llama
            // y el objeto temp contiene el array que se ha creado en el main
            // compara la suma del estado inicial contra la suma del siguiente estado
            // si suma es mayor que la suma del objeto temp regresa uno
            // si la suma es menor regresa -1 

            // si el estado es igual regresa 0
            // esto implementa que el codigo de compare tome las desiciones de quien es mayor a quien y te devuelve el conjunto acomodado de menor a mayor
            CPunto temp = (CPunto)obj;
            if (suma < temp.suma)
                return 1;
            // si es mas pequeño regresa -1
            if (suma > temp.suma)
                return -1;

            return 0;

        }

        public override string ToString()
        {
            return string.Format($"X ={x}, Y = {y}");
        }

        private  void Suma()
        {
            suma = x + y;
        }


    }
}
