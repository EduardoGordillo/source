using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CBecario b = new CBecario("Eduardo", 19, 48.5);

            b.MuestraBecario();
          
            Console.ReadLine();
            
        }
    }
}
