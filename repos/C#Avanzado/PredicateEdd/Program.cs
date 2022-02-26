using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            /// ejemplo con delegados
            /// system.predicate<t> es un delegado generico que representa un metodo que 
            /// va a definir un criterio y dice si el objeto cumple o no con ese criterio
            /// public List<T> FindAll(Predicate<T> match) recorre los elementos de la lista
            /// los pasa como parametro al delegado, si este regresa true los pone en la lista de retorno

            List<int> numero = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // iniciamos el delegado
           Predicate<int> delagdo = new Predicate<int>(Pares);

            List<int> numPares = numero.FindAll(delagdo);

            foreach (int num in numPares)
                Console.WriteLine(num);
            Console.WriteLine("--------------");

            numero.RemoveAll(delagdo);
            foreach (int n in numero)
                Console.WriteLine(n);
        }

        public static bool Pares(int x)
        {
            if (x % 2 == 0)
                return true;
            if (x % 2 != 0)
                return false;
            return false;

        }
        static bool Rango(int n)
        {
            if (n >= 3 && n <= 7)
                return true;
            else
                return false;
        }
    }
}
