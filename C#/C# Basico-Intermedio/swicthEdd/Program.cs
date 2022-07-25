using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swicthEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia = Console.ReadLine();
            switch( dia )
            {
                case "a":
                    Console.WriteLine("lunes");
                    break;

                case "b":
                    Console.WriteLine("Martes");
                    break;

                case "c":
                    Console.WriteLine("miercoles");
                    break;

                case "d":
                    Console.WriteLine("Jueves");
                    break;
                default: Console.WriteLine("valor incorrecto");
                    break;
            }
            Console.ReadLine();
            
        }
    }
}
