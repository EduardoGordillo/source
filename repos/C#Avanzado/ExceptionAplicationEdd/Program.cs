using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAplicationEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            /// excepciones de aplicaciones
            /// Necesitamos cuatro entidades
            /// una clase representa los detalles de la excepcion
            /// mi miembro que lanza una instancia de la excepcion 
            /// un bloque de codigo qu einvoca el codigo que puede generar la excepcion
            /// un bloque que cachar la excepcion o procesar la excepcion si es que ocurre
            /// 
            CCaldera miCaldera = new CCaldera("Cald-os",5 );

            // v1
            Random rnd = new Random();
            //while(miCaldera.Funciona)
            //{
            //    try
            //    {
            //        miCaldera.Trabajar(rnd.Next(-5,10));
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("El mensaje : {0}", e.Message);
            //    }

            //    // codigo para atrapar nuestra excepcion
            //    //catch(CalderaExcepcion e)
            //    //{
            //    //    Console.ForegroundColor = ConsoleColor.DarkBlue;
            //    //    Console.WriteLine(e.Message);
            //    //    Console.WriteLine(e.Causa);
            //    //    Console.WriteLine(e.Momento);

            //    //}
            //    //catch(ArgumentOutOfRangeException e)
            //    //{
            //    //    Console.WriteLine(e.Message);
            //    //}

            while (miCaldera.Funciona)
            {
                try
                {
                    miCaldera.Trabajar(rnd.Next(-5, 5)); ;

                }
                catch (CalderaExcepcion e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(e.Message);

                }
                // de esta forma excepcion solo capturara las excepciones que no esten arriba
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Mantenimiento");
                }
            }
        }
    }
}
