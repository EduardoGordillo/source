using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorAsignacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable = 50;
            Console.WriteLine(++variable);
            variable = 10;
            Console.WriteLine(variable);
            variable *= 40;
            Console.WriteLine(variable);
            string texto = "Edd soy un programador";
            Console.WriteLine(texto);
            texto += "de c#";
            Console.WriteLine(texto);
            string texto2 = "y .NET";
            texto += texto2;
            Console.WriteLine(texto);

            Console.ReadLine();

        }
    }
}
