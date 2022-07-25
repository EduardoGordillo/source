using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado Juan = new CEmpleado();

            Juan.Sueldo = 2500;
            Console.WriteLine($"El sueldo de juan es { Juan.Sueldo}");
         
            Juan.Muestra();
            Console.WriteLine($" El impuesto de juan es {Juan.Impuesto}");
            Console.ReadLine();
            CEmpleado Jose = new CEmpleado();
            Jose.Sueldo = 8500;
            
            Jose.Muestra();
            
            // Console.WriteLine(Juan.Sueldo);
            Console.WriteLine(Jose.Impuesto);
            Console.ReadLine();

        }
    }
}
