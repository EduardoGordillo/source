using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListGenericEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int r;
            ArrayList valores = new ArrayList();// el arraylist guarda el valor de tipo objeto
            valores.AddRange(new int[] {
                1,2,3,5});

            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            List<int> valor = new List<int>();// list es un tipo de coleccione generica
                                              // la cual ocupa <T> que sea el tipo de dato que se va a utilizar 



            valor.AddRange(new int[] { 1, 2, 3, 4, 5 });

            for (n = 0; n < valor.Count; n++)
            {
                Console.WriteLine(valor[n]);

            }

            // detecta si un valor existe
            Console.WriteLine(valor.Contains<int>(7));
            Console.WriteLine(valor.Contains<int>(2));
            Console.WriteLine(valor.Contains<int>(5));

            Console.WriteLine("-----------------");
            // podemos obtener el indice de un elemento
            Console.WriteLine(valor.IndexOf(5));
            Console.WriteLine(valor.LastIndexOf(2));
            Console.WriteLine("----------------");

            // para insertar en un indice en particular
            valor.Insert(2, 5);

            for (n = 0; n < valor.Count; n++)
            {
                Console.WriteLine(valor[n]);
            }
            Console.WriteLine("------------------");
            // para remover elemento de un indice

            valor.RemoveAt(0);
            foreach (int numero in valor)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("------------------");

            // remove elemina determinado elemento
            valor.Remove(5);


            foreach (int numero in valor)
                Console.WriteLine(numero);
            Console.WriteLine("--------------------");

            // reverse coloca la lista en sentido contrario

            valor.Reverse();

            foreach (int numero in valor)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("-------------------");

            // ordenamos la lista por valores
            valor.Sort();

            foreach (int numero in valor)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("----------------");

            // creamos una lista para nuestra clase

            List<CPunto> listaPuntos = new List<CPunto> { new CPunto(7, 8) };

            listaPuntos.Add(new CPunto(1, 2));
            listaPuntos.Add(new CPunto(5, 3));
            listaPuntos.Add(new CPunto(8, 6));
            listaPuntos.Add(new CPunto(7, 9));

            foreach (CPunto punto in listaPuntos)
            {
                Console.WriteLine(punto);
            }
            Console.WriteLine("--------------");

            // insertamos un punto 

            listaPuntos.Insert(4, new CPunto(6,9)) ;
            foreach (CPunto numero in listaPuntos)
                Console.WriteLine(numero);

            Console.WriteLine("----------------");

            // para copiar arreglo
            CPunto[] nuevoPunto = listaPuntos.ToArray();

            for ( n= 0; n<nuevoPunto.Length; n++ )
            {
                Console.WriteLine(nuevoPunto[n]);
            }

            Console.WriteLine("-----------------");

            // para ocupar sort debemos implementar IComparable
            listaPuntos.Sort();
            foreach(CPunto elemento in listaPuntos)
            {
                Console.WriteLine(elemento);
            }


        }
    }
}
