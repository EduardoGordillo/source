using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntadores
{
    class Program
    {
        static void Main(string[] args)
        {

            // apuntadores 
            // es necesario poner el proyecto en unsafe

            unsafe
            {

               
                int valor = 5;

                // creo apuntador

                int* p;// el * es a donde apunta osease el apuntador

                // hago que apunte a la direccion valor
                p = &valor; // & es direccion de 

                Console.WriteLine(*p);// esto es, imprime a donde apunta p

                // cambiamos el valor
                *p = 67;

                Console.WriteLine(*p);

                Console.WriteLine(valor);
            }

            // fuera de unsafe
            Console.WriteLine("Aqui haremos un swap");
            int a = 3;
            int b = 5;
            Console.WriteLine($"a = {a}, b = {b}");

            unsafe { swap(&a, &b); }

            Console.WriteLine($"a = {a}, b = {b}");



        }
        unsafe public static void swap(int* n, int* m)
        {
            int temp = *m;
            *m = *n;
            *n = temp;
        }
    }

}
