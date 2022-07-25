using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack miStack = new Stack();
            // la coleccion stack es LIFO(Last In First Out)

            // agregamos elementos
            miStack.Push("Manzana");
            miStack.Push("Mandarina");
            miStack.Push("Mango");
            miStack.Push("Pera");

            MuestraStack(miStack);

            // el metodo pop regresa el primer elemento en salir
            object var; 
            Console.WriteLine(miStack.Pop());
            MuestraStack(miStack);

            // cuenta elementos
            var = miStack.Count;
            Console.WriteLine(var);
            // péek tambien regresa el primer elemento
            var = miStack.Peek();
            Console.WriteLine(var);



        }
        public static void MuestraStack( Stack pStack)
        {
            foreach (object fruta in pStack )
            {
                Console.WriteLine(fruta);
            }
            Console.WriteLine("-----------------");
        }
    }
}
