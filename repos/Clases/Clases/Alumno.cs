using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Alumno : Usuario
    {
        public override void Saludar()
        {
            Console.WriteLine("hola desde alumno");
        }
    }
}
