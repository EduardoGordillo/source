using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i > 10; i++)
           // {


               bool esCierto = true;
                while (esCierto)
                {
                    Console.WriteLine("Ciclo While");
                    esCierto = false;

             } 
            int i = 1;
            int suma = 0;
            while (i <= 10)
            {
                Console.WriteLine(suma);
                suma += i;
                i++;
                
            }
            string input = string.Empty;
            while(input != "salir")
            {
                Console.WriteLine("Ejecutando");
                input = Console.ReadLine();
            }
            
                // }
                Console.ReadLine();


           // }

        }
    }
}
