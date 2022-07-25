using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // forma concreta sin polimorfismo

            int a ;
            string valor = "";
            Console.WriteLine("Elige una opcion\n" +
                "1.- Gato \n" +
                "2.- Reptil");
            valor = Console.ReadLine();
            a = Convert.ToInt32(valor);
            if (a == 1)
            {
                CGato migato = new CGato();
                Console.WriteLine("Ingresa nombre");
                migato.Nombre = Console.ReadLine();
                migato.Moverse();

            }
            if (a ==2)
            {
                CReptil mireptil = new CReptil();
                Console.WriteLine("Ingresa nombre");
                mireptil.Nombre = Console.ReadLine();
                mireptil.Moverse();
            }

            int opcion;
            string valor1;

            Console.WriteLine("Elige una opcion\n" +
               "1.- Ave \n" +
               "2.- Pez\n" +
               "3.- Perro");
            valor1 = Console.ReadLine();
            opcion = Convert.ToInt32(valor1);
            CAnimal mimascota = new CAnimal();

            if (opcion == 1)
            {
                mimascota = new CAve();
                mimascota.Nombre = "hey";
                mimascota.Moverse();
              

            }
            if (opcion == 2)
            {
                mimascota = new CPez();
                mimascota.Nombre = "Ship";
                mimascota.Moverse();

                

            }
            if (opcion == 3)
            {
                mimascota = new CPerro();
                mimascota.Nombre = "Solo";
                mimascota.Moverse();

            }
        }
    }
}
