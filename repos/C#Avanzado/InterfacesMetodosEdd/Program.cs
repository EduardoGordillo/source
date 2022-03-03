using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesMetodosEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            // arreglo de interfaces

            //    IElectronico[] teles = { new CTelevisor("Sharp"), new CTelevisor("Sony"), new CRadio("Rode") };
               IElectronico aparatoCreado = null;

            //    foreach (IElectronico aparato in teles)
            //        Console.WriteLine(aparato);

            //    Console.WriteLine("-------------");
            //    for(int n = 0; n<teles.Length; n++)
            //    {
            //        Console.WriteLine(teles[n]);
            //    }
            //}

            // usar interfaces de metodos

            //CTelevisor miTV = new CTelevisor("Sony TV");
            //CRadio miRadio = new CRadio("RCA Radio");

            //Muestra(miTV);
            //Muestra(miRadio);

            // Metodo que regresa un objeto que implementa la interface
            aparatoCreado = CrearAparato();
           
            Console.WriteLine(aparatoCreado);
            Muestra(aparatoCreado);


          

        }
        // este metodo puede recibir cualquier objeto que implemenete IElectronico
        static void Muestra(IElectronico aparato)
        {
           
            if (aparato is CTelevisor)
                Console.WriteLine(aparato);
            if (aparato is CRadio)
                Console.WriteLine(aparato);
            aparato.Encender(true);
        }

        static IElectronico CrearAparato()
        {
            IElectronico aparato = null;
            string dato = string.Empty;
            int opcion = 0;
            Console.WriteLine("Que deseas crear?\n" +
                "1) Televisor\n" +
                "2) Radio\n");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            if (opcion == 1 )
            {
                Console.WriteLine("Ingresa marca del Televisor");
                dato = Console.ReadLine();
                aparato = new CTelevisor(dato);
            }
            if (opcion == 2)
            {
                Console.WriteLine("Ingresa la marca del Radio");
                dato = Console.ReadLine();
                aparato = new CRadio(dato);
            }

            return aparato;


        }

    }
}