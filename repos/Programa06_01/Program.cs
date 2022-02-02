using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado Juan = new CEmpleado();
            Juan.Set_sueldo(7800);
            Juan.CalculaImpuesto();
            Juan.Muestra();
            Juan.MuestraLog();
            Console.WriteLine($"el sueldo de Juan es {Juan.get_sueldo(12345)}");
            Console.WriteLine("----------------");
            Console.ReadLine();

            CEmpleado Jose = new CEmpleado();
         
            Jose.Set_sueldo(10000);
            
            Console.WriteLine($"el sueldo de jose es {Jose.get_sueldo(12345)}");
            
            Jose.Muestra();
            
            Jose.MuestraLog();
            Console.ReadLine();

            CEmpleado Ivan = new CEmpleado();
            Ivan.Set_sueldo(12500);
            
            Ivan.Muestra();
            Console.ReadLine();
        }
    }
}
