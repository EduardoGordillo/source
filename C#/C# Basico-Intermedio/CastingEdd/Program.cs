using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingEdd

{
    class Program
    {
        static void Main(string[] args)
        {
            /// casting 
            /// podemos hacer casting de una clase en la cadena de herencia
            /// podemos traeer metodos desde lo mas general a lo especifico pero no al reves
            ///creamos producto
            CProducto p1 = new CProductoImportado("tele", 2500, .15);

            p1.CalcularPrecio();
            Console.WriteLine(p1);
            /// no se puede llamar directamete a un elemento de CProductoimportado por que es mas especifico a lo general
            /// p1.Mensaje();
            /// uso de type cast
            ((CProductoImportado)p1).Mensaje();
            //Cproducto es un object
            Console.WriteLine("---------");
            object p2 = new CProducto("radio", 300);
            ((CProducto)p2).CalcularPrecio();
            Console.WriteLine(((CProducto)p2));

            // no se puede intanciar una clase generica a mas particular
            //CProducto p3 = new object();
            //CProductoImportado x = new CProducto("radio", 300);

            Console.WriteLine("------Detecta----");
            CProducto p4 = new CProducto("balon", 250.50);

            Detecta(p1);
            Detecta((CProducto)p2);
            Detecta(p4);

            //casting numerico

            int a = 57;
            float b = 5.67f;
            double c = 123.456;
            byte x = 5;
            // de un tipo menor a uno mayor no hace falta explicitamente el casting 
            a = x;
            Console.WriteLine(a);
            double y = b;
            Console.WriteLine(y);
            // de un tipo mayor a  menor se necesita hacer de forma explicita
            b = (float)c;
            Console.WriteLine(b);




        }

        public static void Detecta(CProducto pProducto)
        {
            if (pProducto is CProducto)
            {
                Console.WriteLine("== es producto");
                pProducto.CalcularPrecio();
                Console.WriteLine(pProducto);
            }
            if (pProducto is CProductoImportado)
            {
                Console.WriteLine("== Es un producto importado");
                pProducto.CalcularPrecio();
                ((CProductoImportado)pProducto).Mensaje();
                Console.WriteLine(pProducto);
            }
        }

    }
}
