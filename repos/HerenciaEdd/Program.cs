using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmEdad = "";
            string tmSalario = "";
            CEmpleado Juan = new CEmpleado();
           // Juan.ponerDatos("Juan", 28, "Developer", 14000);
            //Juan.Nombre = "Eduardo";
            Juan.Nombre = Console.ReadLine();
            tmEdad = Console.ReadLine();
            Juan.Edad = Convert.ToInt32(tmEdad);
            Juan.Puesto = Console.ReadLine();
            tmSalario = Console.ReadLine();
            Juan.Salario = Convert.ToInt32(tmSalario);

           
            Juan.EmpleadoMuestra();
            Console.ReadLine();
        }

    }
}
