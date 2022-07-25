using System;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Colecciones adentro de System.Collection
            ///provee estructura de datos que entre ellas estan
            ///ArrayList
            ///BitArray
            ///HashTable(k,v)
            ///Queue
            ///SortedList(k,v) k, []
            ///Satck

            ArrayList palabras = new ArrayList();
            int n = 0;
            int r = 0;

            // podemos adicionar por rango
            palabras.AddRange(new string[] {"hola", "como", "estan?" });// se pasa una coleccion como parametro

            Console.WriteLine("Este es el numero de contenidos que se encuentran en el ArrayList {0}", palabras.Count);

            // recorremos con un ciclo for
            for (n = 0; n < palabras.Count; n++)
                Console.Write(" {0}", palabras[n]);
            Console.WriteLine();
            Console.WriteLine("-----------");

            // otra forma de agregar elementos
            palabras.Add("Bien y tu?");

            // recorremos con foreach
            foreach (string palabra in palabras) // foreach es un iterador
            {
                Console.Write($" {palabra} ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------");

            // un  ArrayList tambien puede trabajar con valores

            ArrayList valores = new ArrayList();

            valores.Add(4);
            valores.Add(5);
            valores.Add(8);

            // recorremos con un cliclo foreach
             foreach (int a in valores)
            {
                Console.WriteLine($"{a}");
            }
            Console.WriteLine("-----------");
             for(n= 0; n < valores.Count; n++)
            {
               // r = (int)valores[n]; // se hace el typecast ya que los valores que guarda el arraylist los guarda como objetos
                Console.WriteLine($"{valores[n]}");
            }
            Console.WriteLine("-----------");

            // para ver si un elemento existe dentro del Arraylist
            Console.WriteLine(valores.Contains(5)); // contains busca en el arrayList y devuelve un valor booleano 
            Console.WriteLine(valores.Contains(9));
            Console.WriteLine("---------");

            // insertamos en un indice en particular(indice donde insertar elemento, el elemento a insertar)
            valores.Insert(2,55);

            for (n=0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("---------------");

            //remover elemento

            valores.Remove(55);// utilizamos remove (el elemento que deseeamos eliminar en el arraylist, debes de conocerlo ya)
            for (n=0; n< valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("-----------------");

            // removemos de una posicion en especifico
            valores.RemoveAt(1);// remove at(se indica el numero de indice que deseas remover)

            for (n= 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }    
        }
    }
}
