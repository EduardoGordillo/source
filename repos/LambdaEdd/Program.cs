using System;

namespace LambdaEdd
{
    class Program
    {
        static void Main(string[] args)
        {


            #region variables e iteraciones
            int a = 5;
            int x = 12;
            Func<int, int> suma = s => x + a;
            Console.WriteLine($"Suma = {suma(6)}");

            Func<int, int, int> potB = (x, y) => (int)Math.Pow(x, y);
            int baseP = 5;
            for (int i = 1; i <=3; i++)
            {
                int res = potB(baseP, i);
                Console.WriteLine($"{baseP} Elevado a la {i} potencia = {res}");
            }
            #endregion
            #region tuplas
            Func<(int, int), (int, int)> invertir = c => (c.Item1 * -1, c.Item2 * -1);
            var coordenadas = (-20, 50);
            Console.WriteLine($"Coordenadas invertidas {invertir (coordenadas)}");
            #endregion
            Func<int, int, int> multiplica = (n1, n2) => n1 * n2;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"5 x {i} = {multiplica(5, i)}");
            }
        }
    }
}
