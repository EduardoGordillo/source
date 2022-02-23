using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosGenericoEDd
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 4;

            Console.WriteLine($" x = {x}, y = {y} ");
            Intercambio<int>(ref x, ref y);
            Console.WriteLine($" x = {x}, y = {y}");

            double a = 24.6;
            double b = 36.5;
            Console.WriteLine($" a = {a}, b ={b}");
            Intercambio<double>(ref a, ref b);
            Console.WriteLine($" a = {a}, b ={b}");

            string o = "hola";
            string p = "a todos";

            Console.WriteLine($"o = {o}, p = {p}");
            Intercambio<string>(ref o, ref p) ;
            Console.WriteLine($"o = {o}, p = {p}");
        }

        static void Intercambio<T>(ref T a, ref T b) // metodo generico
            // cuando se manda a llamar al metodo 
            // todas <T> que se llamen un tipo al llamar la funcion
            // se convertiran en el tipo que se halla llamado
        {
            T temporal;
            temporal = a;
            a = b;
            b = temporal;
        }
    }
}
