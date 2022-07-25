using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Dynamic se puese usar como una forma de system.object
            ///en el sentido de que cualquier valor se puede asignar a dynamic
            ///la difrencia es que no es fuertemente tipificado
            ///se le puede asignar cualquier tipo al iniciio y posteriormente
            ///asignar otro

            dynamic a = 5;
            Console.WriteLine($"Dynamic: {a} tipo: {a.GetType()} ");

            a = "hola a todos";
            Console.WriteLine($"Tipo valor {a.GetType()}, valor {a}");

            // a diferencia de object es dynamyc se conoce el tipo hasta 
            // el tiempo de ejecucion
            // dynamic se puede usar como un tipo de retorno
            // no se puede usar expresiones lambda o metodos anonimos
            // puede ser util si nos comunicamos con bibliotecas COM


        }
    }
}
