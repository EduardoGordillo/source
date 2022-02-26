using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacemos lo mismo que en el ejemplo anterior pro con la expresion lambda
            // solo se puede usar dode se haga yso de un metodo anonimo o un delegado
            // fuertenmente tipificado

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> numPares = numeros.FindAll(i => (i %2) == 0);

            // mostramos los numeros
            foreach (int n in numPares)
                Console.WriteLine(n);

            List<int> newPares = numeros.FindAll((i) =>
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Un par");
                    return true;
                }
                else
                {
                    Console.WriteLine("Un impar");
                    return false;
                }
            });

            foreach (int n in newPares)
                Console.WriteLine(n);
            
        }
    }
}
