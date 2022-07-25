using Mate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
           /* var p = new Usuario();

            var j = new Usuario("Edgar");
            var n = new Usuario("Eduardo", "Gordillo");
            Console.WriteLine(Utilidades.sumar(1, 3));

            //p.Nombre;
            p.EstadoCivil = "soltero";
            Console.WriteLine(p.EstadoCivil);

            p.nHijos = 4;

            Console.WriteLine("El numero de hijos es " + p.nHijos);*/
            var alumno1 = new Alumno( );
            alumno1.Nombre = "juan";
            alumno1.Apellido = "Goridllo";
            alumno1.Saludar();
            var instructor1 = new Instructor();
            instructor1.Nombre = "Carlos";
            instructor1.Apellido = "santamaria";

            instructor1.NParqueo = 12;
            instructor1.Saludar();
        }
    }
}
