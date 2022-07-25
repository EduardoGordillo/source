using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edd
{
    class Class1
    {
         public static void BorrarConsola()
        {
            Console.ReadLine();
            Console.Clear();
            Console.Beep();

        }
        public static void Saludar(string nombre)
        {
            
            Console.WriteLine("hola" + " " + nombre );
        }
        public static int Sumar(int x, int y)
        {
            return x + y;
        }
        public static void saludar() => Console.WriteLine("hola");
        public int Resta(int num1, int num2) => num1 - num2;


    }
}
