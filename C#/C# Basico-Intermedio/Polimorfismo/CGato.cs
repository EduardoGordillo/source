using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class CGato
      
    {
        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public void Moverse()
        {
            Console.WriteLine($"El gato {nombre} camina ");
        }

    }
}
