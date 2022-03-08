using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // obtenemos la cantidad de bytes en el heap

            long bytesHeap = GC.GetTotalMemory(false);

            Console.WriteLine("El Heap usa {0} bytes", bytesHeap);

            // obtenemos la cantidad de generaciones basada en 0 por eso es +1
            int maximaGeneracion = GC.MaxGeneration + 1;
            Console.WriteLine($"Se tienen {maximaGeneracion} generaciones");

            // creamos una instacia
            CPrueba prueba1 = new CPrueba(1);

            bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine($"El Heap usa {bytesHeap} bytes");

            // obtener la generacion de una instancia en particular
            int generacionInstancia = GC.GetGeneration(prueba1);

            Console.WriteLine("La generacion de la instancia es {0}", generacionInstancia);


            // forzar la recoleccion de basura

            ///solo para hacerlo en situaciones especiales
            ///cuando la aplicacion entra a un bloque de codigoque no debe ser interrumpido por 
            ///la recoleccion
            ///la aplicacion creo una gran cantidad de instancias y se necesita
            ///liberar la mayor cantidad de memoria posible
            ///

           // GC.Collect();
            //GC.WaitForPendingFinalizers();

            // para recolectar una generacion en particular

            GC.Collect(0);// es el indice de generacion que nos interesa recolectar
            GC.WaitForPendingFinalizers();
        }
    }
}
