using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDisposable
{
    class Program
    {
        static void Main(string[] args)
        {

            /// si deseamos que los recursos no administrados sean liberados 
            /// tan pronto como sea posible en lugar de que lo haga el recolector de basura
            /// podemos implementar la interfaz IDisposable
            /// en este cao se toma cuando el usuario deja de usar el objeto 
            /// el usuario invoca Dispose(), se libra lo no administrado, pero el objeto sigue existiendo
            /// 
            /// forma basica
            CPrueba p = new CPrueba(9);
            int a;
            //Console.WriteLine(p);
            //p.Dispose();


            // manera segura de hacerlo
            //if (p is IDisposable)
            //    p.Dispose();

            // manera de garantizar que Dispose es invocado

            //try
            //{
            //    Console.WriteLine(p);

            //}
            //finally
            //{
            //    p.Dispose();
            //}

            // con esta tecnica dispose es invocado automaticamente 
            // se puede listar varios objetos en el using
            // using invoca automaticamente el dispose
            using (CPrueba prueba = new CPrueba(5))
            {
                Console.WriteLine(prueba);
            }
           

        }
    }
}
