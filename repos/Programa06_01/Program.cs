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
            Console.WriteLine("----------------");

            CEmpleado Jose = new CEmpleado();
            Jose.Set_sueldo(50550);
            Jose.Set_sueldo(505000);
            Jose.Set_sueldo(10000);
            Jose.Get_impuestoo(12345);
            Console.WriteLine($"el sueldo de jose es {Jose.get_sueldo(12345)}");
            
            Jose.Muestra();
            Jose.MuestraLog();
            Console.ReadLine();

        }
    }
}
