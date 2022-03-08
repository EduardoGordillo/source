using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// despues de colocar la referencia ponemos el namespace
using AritmeticaEdd;

namespace NamespaceBaseEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            // para el uso de bibliotecas debemos hacer la referencia 
            // despues se debe hacer uso del namespace 
            // cada que hagamos un cambio en la biblioteca debemos volver a compilar
            MisMates mates = new MisMates(5, 6);


            Console.WriteLine(mates.Suma());

            Console.ReadKey();
            
        }
    }
}
