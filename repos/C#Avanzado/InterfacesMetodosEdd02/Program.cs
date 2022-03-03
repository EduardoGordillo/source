using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesMetodosEdd02
{
    class Program
    {
        static void Main(string[] args)
        {
            CCuadrado cuadro = new CCuadrado(5);

            ((IPerimetro)cuadro).Calcular();

            ((IArea)cuadro).Calcular();

        }
    }
}
