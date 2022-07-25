using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_01
{
    class Program
    {
        static void Main(string[] args)

        {
            CEmpleado empleado = new CEmpleado();
            empleado.Set_sueldo(5600.025);
            empleado.Muestra();
            Console.ReadLine();
            empleado.CalculaImpuesto();
            
            empleado.MuestraImpuesto();
         
            Console.ReadLine();

        }
    }
}
