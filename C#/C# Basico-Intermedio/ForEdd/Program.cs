using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEdd
{
    class Program
    {
        static void Main(string[] args)
        {
           // for (inicializacion; expresion booleana; actualizacion de la variable);
           //{
           // enunciados }
            for(int i = 0; i<= 10; i++)
            {
                Mensaje("mi mensaje");
            }
            Console.ReadLine();
        }
        static string Mensaje(string mensaje)
        {
            Console.WriteLine($"esto es {mensaje}");
            return mensaje;
          
      
        }
        
    }
}
