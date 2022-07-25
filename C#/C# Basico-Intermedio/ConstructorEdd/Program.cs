using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona p1 = new CPersona();
            
            p1.Muestra();
            CPersona p2 = new CPersona();
            
            p2.Muestra();

            Console.ReadLine();
        }
    }
}
