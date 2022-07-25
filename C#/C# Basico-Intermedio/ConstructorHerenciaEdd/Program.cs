using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorHerenciaEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado E1 = new CEmpleado("Eduardo", 27, "Developer", 14000);
            E1.MuestraEmpleado();
            Console.ReadLine();
        }
    }
}
