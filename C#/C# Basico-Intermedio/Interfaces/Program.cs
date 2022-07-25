using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double vala = 0.0;
            double valb = 0.0;
            string valora = "";
            string valorb = "";
            string valor = "";
            IOperacion operacion = new CResta();

            
            
            while (opcion != 5)
            {

                Console.WriteLine("Elige una opcion\n" +
                    "1.-Suma\n" +
                    "2.-Resta\n" +
                    "3.-Multiplicacion\n" +
                    "4.-Division");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                Console.WriteLine("Dame el valor a");
                valora = Console.ReadLine();
                vala = Convert.ToDouble(valora);
                Console.WriteLine("Dame el valor b");
                valorb = Console.ReadLine();
                valb = Convert.ToDouble(valorb);


                if (opcion == 1)
                    operacion = new CSuma();

                if (opcion == 2)
                    operacion = new CResta();

                if (opcion == 3)
                    operacion = new CMulti();

                if (opcion == 4)
                    operacion = new CDivi();

            

            ///Aqui el programa trabaja en terminos 
            ///del concepto operacion, en lugar de cosas concretas 
            ///ya sea suma resta o multiplicacion
           

                operacion.calcular(vala, valb);
                operacion.mostrar();

            }


        }
    }
}
