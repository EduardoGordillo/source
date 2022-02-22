using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable miTabla = new Hashtable();

            // adicionamos elementos

            miTabla.Add(123, "Hola");// el uso de add tiene como valores de entrada objetos,
                                     // eso significa que puede entrar cualquier valor como key y como valor
            miTabla.Add(234, "Saludos");
            miTabla.Add(45, "Adios");
            miTabla.Add(567, "C#");
            miTabla.Add("Programacion", "Programacion");

            ElementoTabla(miTabla);

            // no puede existir un elemento con la misma llave
            //miTabla.Add(123, "hey"); no se puede repetir la misma llave y si no el elemento se rompe

            // contar los elementos de la tabla hash
            Console.WriteLine(miTabla.Count);
            Console.WriteLine("-----------------");

            // como acceder a un termino en particular
            Console.WriteLine(miTabla["Programacion"]);
            Console.WriteLine(miTabla[12]); // esta key no existe recibe un vacio

            Console.WriteLine("--------------");

            // colocar elementos en una llave especifica
            miTabla[123] = "Hola a todos";
            miTabla[400] = "C# Avanzado";
            Console.WriteLine(miTabla[123]);
            ElementoTabla(miTabla);

            Console.WriteLine("-----------");

            // para obtener un elemento determinado, se inicia la llave en el Contains(llave)

            Console.WriteLine(miTabla.Contains(400));
            Console.WriteLine(miTabla.ContainsKey("Saludos"));

            Console.WriteLine("-----------");

            //eliminamos un elemento 
            miTabla.Remove(400);

            ElementoTabla(miTabla);
            KeyTable(miTabla);
            ValueTable(miTabla);

            


        }
        public static void ElementoTabla(Hashtable pHash)
        {

            foreach(DictionaryEntry elemento in pHash)
            {
                Console.WriteLine($"{elemento.Key}, {elemento.Value}");
            }
        }
        public static void KeyTable(Hashtable pHash)
        {
            foreach (object llave in pHash.Keys)
            {
                Console.WriteLine(llave);
            }
            Console.WriteLine("----------");
        }
        public static void ValueTable(Hashtable pHash)

        {
            foreach (object value in pHash.Values)
            {
                Console.WriteLine(value);
            }

        }

    }
}
