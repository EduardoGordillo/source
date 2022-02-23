using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarNulleableEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            ///declaracions implicita de variables
            ///solo se permiten en variables locales
            ///no se puede usar atributos
            ///no se pueden usar como tipos de retorno
            ///se debe colocar un valor en el momento de declaracion y no se puede ser null
            ///no confundir con var o variant de otros lenguajes, es fuertemente tipificado
            ///se usan en linq donde un query puede dar un resultado dinamicamente creado

            var a = 5;
            var b = "hola a todos";
            var c = 15.36;
            var d = false;
            var f = c;
            //var e = null; no puede ser null una variable implicita
            

            Console.WriteLine($"{a}, {b}, {c}, {d}");

            Console.WriteLine($"a es {a.GetType().Name}");
            Console.WriteLine($"b es {b.GetType().Name}");
            Console.WriteLine($"c es {c.GetType().Name}");
            Console.WriteLine($"d es {d.GetType().Name}");
            Console.WriteLine($"f es {f} tipo {f.GetType().Name}");

            Console.WriteLine("-------------");

            // tipos nulleables 
            /// los tipos valor no pueden tener null
            /// int valor = null; no se puede
            /// los tipos nulleables pueden representar los mismos valores mas el valor null
            /// son utilles en bases de datos, podemos encontrar columnas no definidas
            /// para definirlo usamos el signo ?
            /// pero es realmente crear una instancia de system.nulleable<t>

            int? dato = null;
            Console.WriteLine($"Dato : {dato}");
            dato = 5;
            Console.WriteLine($"Dato : {dato}");

            // el string no es nulleable ya que es un tipo referencia
            // string? n = null; no se puede hacer
            string nombre = null; // asi se hace

            // podemos saber si tiene un valor o no 
           // dato = null;

            if (dato.HasValue)// la propiedad hasvalue regresa valor booleano si existe true si no false
            {
                Console.WriteLine("tiene valor {0}", dato.Value);
            }
            else { Console.WriteLine("no tiene valor"); }

            // el operador ?? nos permite asignar un valor en caso que tenga un null

            double? numero = asignador() ?? 5.55;
            Console.WriteLine(numero);


        }
        public static double? asignador()
        {
            return 4.55;
            //return null;
        }
    }
}
