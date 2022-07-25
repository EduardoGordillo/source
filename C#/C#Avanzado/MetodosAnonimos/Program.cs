using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            // metodo aninomo no tiene nombre
            int x = 20;
            CPunto miPunto = new CPunto(5,6);
            // creamos el metodo anonimo para el mensaje

            miPunto.mensaje += delegate ()  // += va a asignar el metodo al delegado
            {
                Console.WriteLine("Estoy desde el metodo anonimo {0}", x);

            };
            Console.WriteLine(miPunto.ToString());

            // invocamos el metodo anonimo
            //miPunto.mensaje();

            // adicionamos otro
            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Este es otro metodo anonimo");
            };
            miPunto.mensaje();
        }
    }
}
