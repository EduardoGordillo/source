using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionGenericaEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            COperacion<int> miOperacion = new COperacion<int>();
            COperacion<string> op = new COperacion<string>();

            Console.WriteLine(miOperacion.multi(14,18));
            
            Console.WriteLine(op.div("hola ", "todos"));

        }
    }
}
