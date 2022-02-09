using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace IEnumEdd
{
    class CContenedora : IEnumerable
    {
        private int[] valores = new int[10];
        public CContenedora()
        {
            for (int n = 0; n < 10; n++)
                valores[n] = n + n;
        }
        //implementamos el get enumerator necesario para IEnumwrable
        IEnumerator IEnumerable.GetEnumerator()
        {
            //instanciamos el enumarator y lo regresamos 
            return new ContenedorEnum(valores);
        }


    }
    class ContenedorEnum: IEnumerator
    {
        public int[] arreglo;
        private int posicion = -1;
        public ContenedorEnum(int [] pArreglo)
        {
            arreglo = pArreglo;
        }
        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
                return true;
            else
                return false;

        }
        public void Reset()
        {
            posicion = -1;
        }
        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }

    }
}
