using System;

namespace PracticaLambdaEdd
{
    delegate int Operacion(int x, int y);
    class Program
    {
        static void Main()
        {
            Operacion op = (a, b) => a * b;
            var res = op(2, 2);
            Console.WriteLine($"Total =  {res}");

            Operacion potencia = (a, b) =>
            {
                Console.WriteLine($"{a} elevado a la {b} potencia");
                return (int)Math.Pow(a, b);
            };
            int x = 5;
            int z = 3;
            int p = potencia(x, z);
            Console.WriteLine($"Total es : {p}");
            Func < int, int, int> pot = (x, y) => (int)Math.Pow(x, y);
            Console.WriteLine($"Total {pot(2, 3)}");

            Func<string, string, bool> igual = (a, b) => a.Equals(b);
            string cadA = "Noemi";
            string cadB = "Noemi";
            Console.WriteLine($"son iguales? {igual(cadA, cadB)}");
        }
    }
}
