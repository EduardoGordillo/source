using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneabl
{
    class Program
    {
        static void Main(string[] args)
        {
            CAuto auto1 = new CAuto("march", 170000);
            // hacemos la referencia de una variable referenciada
            // pero ninguna de estas formas se puede clonar un objeto

            CAuto auto2 = auto1;
            auto1.CalcularTenencia(.05);
            auto2.CalcularTenencia(.30);

            auto1.MuestraInformacion();
            auto2.MuestraInformacion();

            Console.WriteLine("-----------------");

            auto1.Costo = 60000;

            auto1.MuestraInformacion();
            auto2.MuestraInformacion();

            //creamos un nuevo objeto y lo clonamos con el metodo Clone


            CAuto auto3 = (CAuto)auto1.Clone();
            auto1.MuestraInformacion();
            auto3.MuestraInformacion();
            auto1.Costo = 250000;
            auto1.MuestraInformacion();
            auto3.CalcularTenencia(.05);
            auto3.MuestraInformacion();


            
        }
    }
}
