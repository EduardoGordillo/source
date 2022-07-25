using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombradosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            // invovacion de metodo o funcion de tres parametros posicionales
            mostrarDatos(5, 6, 7);

            // invocacion de parametros nombrado y posicional
            // no se puede nombrar el primero y despues querer usar los posicionales
            mostrarDatos(5, pc: 2, pb: 3);

            // datos opcionales
        }

        public static void mostrarDatos(int pa, int pb, int pc)

        {
            Console.WriteLine($"El valor A : {pa}\n" +
                $"El valor B : {pb}\n" +
                $"El valor C : {pc}\n" +
                $"-----------------------");
        }

        public static void mostrarOpcionles(int pA = 1, int pB = 2, int pC = 3)
        {
            Console.WriteLine($"El valor A : {pA}\n" +
                $"El valor B : {pB}\n" +
                $"El valor C : {pC}\n" +
                $"-----------------------");
        }
    }
}
