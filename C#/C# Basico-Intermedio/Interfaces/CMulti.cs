using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class CMulti : IOperacion
    {
        private double r = 0;
        //Metodos a implementar
        public void calcular(double a, double b)
        {
            r = a * b;

        }
        public void mostrar()
        {
            Console.WriteLine($"El resultado de la multiplicacion es = {r}");
        }
    }
}
    

