using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoInterfaceEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CTelevisor miTele = new CTelevisor("Sony");
            CPelota miPel = new CPelota("Mediana");
            IElectronico objeto = null;

            //// metodo 1, por exepcion
            //try
            //{
            //    Console.WriteLine("Probamos la tele");
            //    objeto = (IElectronico)miTele;
            //    objeto.Encender(true);
            //}
            //catch (InvalidCastException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //// probamos la pelota
            //try
            //{
            //    Console.WriteLine("Probamos la pelota");
            //    objeto = (IElectronico)miPel;
            //    objeto.Encender(false);

            //}
            //catch (InvalidCastException e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //// Metodo 2, por as(puede ser tratado como )
            //Console.WriteLine("Probamos la tele");
            //objeto = miTele as IElectronico;
            //if (objeto != null)
            //    objeto.Encender(true);
            //else
            //    Console.WriteLine("No es un electronico");

            //Console.WriteLine("Probamos la pelota");
            //objeto = miPel as IElectronico;
            //if (objeto != null)
            //    objeto.Encender(true);
            //else
            //    Console.WriteLine("No es un electronico");

            // metodo 3, por is (es p es compatible con)

            Console.WriteLine("Probamos la tele");

            if (miTele is IElectronico)
                miTele.Encender(true);
            else
                Console.WriteLine("No es un electronico");

            Console.WriteLine("Probamos la pelota");
            if (miPel is IElectronico)

            {
                Console.WriteLine("Wow es una pelota electronica");

            }
            else
            {
                Console.WriteLine("No es un electronico");
            }
            


        }
    }
}
