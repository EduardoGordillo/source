using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            CCaldera miCaldera = new CCaldera("Cald-o", 20);

            /// sin excepciones
            //for (int i = 0; i < 10; i++)
            //    miCaldera.Trabajar(20);

            try
            {
                for(int i = 0; i < 10; i++ )
                {
                    miCaldera.Trabajar(20);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Sucedio la excepcion");
                Console.WriteLine("En este metodo : {0}", e.TargetSite);
                Console.WriteLine("Con este mensaje de error: {0}", e.Message);
                Console.WriteLine("Fuente : {0}", e.Source);//Hasta aqui llega* Primer metodo Trabajar
                Console.WriteLine("Clase donde ocurrio : {0}", e.TargetSite.DeclaringType);

                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Help Link : {0}",e.HelpLink);//* Segundo metodo Trabajar

                Console.WriteLine("Mostramos los datos propios");

                // verificamos que existan datos
                if (e.Data.Count != 0)
                {
                    foreach (DictionaryEntry dato in e.Data)
                        Console.WriteLine("->{0} -> {1}", dato.Key, dato.Value);
                    
                }


                
            }
        }
    }
}
