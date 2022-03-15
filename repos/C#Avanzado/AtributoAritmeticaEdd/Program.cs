using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AritmeticaAtributosEdd;
using System.Threading.Tasks;

namespace AtributoAritmeticaEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            // usaremos reflexion con earli binding
            // no olvidar adicionar la referencia 

            // obtenemos el tipo de la clase
            Type t = typeof(CPrueba2);

            // obtenemos la lista de atributos

            object[] atributos = t.GetCustomAttributes(true);


            // mostramos los atributos

            foreach (DatosAttribute r in atributos)
                Console.WriteLine($"{r.Dato}");
        }
    }
}
