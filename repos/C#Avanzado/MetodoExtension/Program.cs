using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoExtension
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 53;
            string par = numero.EsPar(); // uso de extension
            Console.WriteLine($"El numero {numero} es {par}");

            double valor = 55.18;

           Console.WriteLine( valor.Dobletea());// uso de extension

            CMiInt entero = new CMiInt(7);

            Console.WriteLine(entero);
            entero.Sonido();

        }
    }
}
