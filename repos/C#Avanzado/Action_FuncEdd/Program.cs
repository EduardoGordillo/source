using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_FuncEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // action nos permite crear un delegado en el momemnto, para un maximo de 16 parametros
            // pero el tipo de retorno debe ser void
            int n = 5;
            string m = "Hola a todos";
            // action toma el lugar de un delegado
            Action<int, string> delAction = new Action<int, string>(RepiteMensaje);
            // con el mismo llamammos al metodo repite mensaje
            delAction(n,m);

            // func funciona similar a Action, pero permite tipo de retorno

            int y = 5;
            int x = 6;

            Func<int, int, int> delFunc = new Func<int, int, int>(Suma); // siempre iran los tipos
            // de entrada primero <tipo1,tipo2,tipo<16, tiposalida>
            Console.WriteLine(delFunc(8,6));

            Func<int, bool> delPrueba = new Func<int, bool>(Prueba);
            Random rnd = new Random();

            bool v = delPrueba(rnd.Next(1,8));
            Console.WriteLine(v);
            if (v == true)
                Console.WriteLine("Numero Exitoso");
            if (v == false)
                Console.WriteLine("Numero cualquier");

            



        }

        public static void RepiteMensaje(int n, string m)
        {
            int z;
            for (z = 0; z < n; z++)
                Console.WriteLine(m);
        }
        public static int Suma(int n, int m)
        {
           
            return n + m;
        }
        public static bool Prueba(int n)
        {
            if (n > 5)
                return false;
            if (n < 4)
                return true;
            return false;
        }

    }
}
