using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //do 
            // enunciados 
            // While(expresion booleana );
            do
            {
                Console.WriteLine("Hola mundo");
            }


            while (8 > 10);
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
            
            
            Console.ReadLine();
        }
    }
}
