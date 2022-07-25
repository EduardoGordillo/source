using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            bool MayorEdad = false;
            int costoEntrada = 0;
            if (MayorEdad == true)
            {
                costoEntrada = 20;
                Console.WriteLine($"El costo de tu entrada es {costoEntrada}");
            }
            else
            {
                costoEntrada = 80;
                Console.WriteLine($"El costo de tu entrada es {costoEntrada}");
            }

            
            
            int x = 6;
            if (x < 5 || x == 5)
            {
                Console.WriteLine($"si es igual {x}");
            }
            else
                Console.WriteLine("no se cumple");
           

            bool mayorEdad = false;
            mayorEdad = !mayorEdad;
            Console.WriteLine(mayorEdad);
            Console.ReadLine();

            bool esIgual1 = 42 == 42;
            Console.WriteLine(esIgual1);
            bool esIgual2 = 42 != 423;
            Console.WriteLine(esIgual2);

            int num1 = 100;
            int num2 = 100;
            bool esIgual3 = num1 == num2;
            Console.WriteLine(esIgual3);
            Console.ReadLine();

        }
    }
}
