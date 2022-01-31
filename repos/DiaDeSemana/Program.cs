using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDeSemana
{
    class Program
    { 
        public enum DiasSemana
            {
            Lunes = 1,
            martes = 2,
            Miercoles = 3,
            Jueves = 4,
            Viernes = 5,
            Sabado = 6,
            Domingo = 7



        }
        static void Main(string[] args)
        {
           int  Dias = 10;
            if (Dias == 1)
            {
                Console.WriteLine("lunes");
            }
            else if (Dias == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (Dias == 3)
            {
                Console.WriteLine("Miercoles");

            }
            else if (Dias == 4)
            {
                Console.WriteLine("Miercoles");
            }
            else
            {
                Console.WriteLine("Numero invalido");
            }
            Console.ReadLine();
        }
    }
}
