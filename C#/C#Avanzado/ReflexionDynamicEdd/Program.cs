using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ReflexionDynamicEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // hay un runtime complementario conocido como DLR (Dynamic Lengauge Runtime)
            // permite descubir los tiops dn tiempo de ejecucion sin chequeos por parte del compilador
            // permite tener codigo muy flexible, tambien se puede trabajar con diferentes
            // plataformas  y lenguajes de programacion 
            // permite adicionar o remover tipos de la memoria en tiempo de ejecucion
            // haemos uso de dynamic para simplificar la reflexion en el late binding
            Assembly asm;
            try
            {
                // cargamos el assembly
                asm = Assembly.Load("AritmeticaEdd");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            if (asm != null)
            {
                Type mates = asm.GetType("AritmeticaEdd.MisMates");
                try
                {
                    //object obj = Activator.CreateInstance(mates, new object[] { 7 ,5});
                    //Console.WriteLine("Tenemos una instancia de {0}", obj);
                    //// obtenemos el metodo
                    //MethodInfo suma = mates.GetMethod("Suma");
 
                    //// obtenemos la propiedad
                    //PropertyInfo resultado = mates.GetProperty("R");
                    //double r = 0;

                    //// invocamos el metodo
                    //suma.Invoke(obj, null);
                    // invocamos la propiedad
                    //object r = resultado.GetValue(obj);

                    //Console.WriteLine("El valor es {0}", r);
                    //resta.Invoke(obj, null);

                    //r = resultado.GetValue(obj);

                    //Console.WriteLine("El valor es {0}", r);

                    dynamic obj = Activator.CreateInstance(mates, new object[] { 8,6});

                    // hay que notar la simplificacion de la sintaxis 
                    // a comparacion sin dynamic
                    //solo invocamos el metodo
                    obj.Multi();

                    // trbajamos con la propiedad
                    double r = obj.R;
                    Console.WriteLine(r);

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
