using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList miSLista = new SortedList();

            // adicionamos
            miSLista.Add(788, "Hola");
            miSLista.Add(777, "como");
            miSLista.Add(555, "estan");
            miSLista.Add(987, "todos");
            MuestraSList(miSLista);

            // contar elementos

            Console.WriteLine(miSLista.Count);

            // para ver si hay contenido en una llave especifica
            Console.WriteLine(miSLista.Contains(788));

            Console.WriteLine(miSLista.ContainsKey(587));

            Console.WriteLine(miSLista.ContainsValue("Hola"));
            Console.WriteLine("---------------");

            // Obtenemos elmento por indice 
            Console.WriteLine(miSLista.GetKey(2));
            Console.WriteLine(miSLista.GetByIndex(2)) ;


        }
        public static void MuestraSList(SortedList sLista)
        {


            foreach (DictionaryEntry elemeto in sLista)

            {
                Console.WriteLine($"{elemeto.Key} , {elemeto.Value}");
            }
            Console.WriteLine("--------------------");
        }

    }
}
