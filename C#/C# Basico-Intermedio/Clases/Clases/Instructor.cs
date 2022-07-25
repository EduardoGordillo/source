using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Instructor : Usuario
    {
        int nParqueo;

        public int NParqueo { get => nParqueo; set => nParqueo = value; }

        public override void Saludar()
        {
            Console.WriteLine("saludo desde instructor");
        }
    }
}
