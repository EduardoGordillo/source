using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class CAve : CAnimal
    {
        public override void Moverse()
        {
            Console.WriteLine($"EL ave {nombre} vuela");
        }
    }
}
