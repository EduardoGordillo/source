using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Reflection03Edd
{
    class Program
    {
        static void Main(string[] args)
        {
            // cargamos el assembly en tiempo de ejecucion y lo usamos 
            // late binding con el assembly

            Assembly asm = null;
            try
            {
                // cargamos el assembly
                asm = Assembly.Load(" ");
                EncuentraTipos1(asm);
            }
            catch (FileNotFoundException ex)

            {
                Console.WriteLine(ex.Message);
                return;
            }

            if (asm != null) // codigo de seguridad
            {
                Type mates = asm.GetType("AritmeticaEdd.MisMates");
                try
                {
                    object obj = Activator.CreateInstance(mates, new object[] { 5, 6 });
                    Console.WriteLine("Tenemos a una instancia de {0}", obj);
                    // obtenemos el metodo
                    MethodInfo suma = mates.GetMethod("Suma");
                    MethodInfo resta = mates.GetMethod("Resta");

                    // obtenemos la propiedad

                    PropertyInfo resultado = mates.GetProperty("R");

                    // invovamos el metodo
                    suma.Invoke(obj, null);

                    // si suma tuviera parametros de entrada se invoca de la siguiente manera
                    //suma.Invoke(obj, new object[] { 1, 3 });

                    // invocamos la propiedad
                    object r = resultado.GetValue(obj);

                    Console.WriteLine("El valor es {0}", r);
                    resta.Invoke(obj, null);

                    r = resultado.GetValue(obj);

                    Console.WriteLine("El valor es {0}",r);
                }
                catch (FileNotFoundException ex)

                {
                    Console.WriteLine(ex.Message);
                    return ;
                }

            }



        }

        // sin uso de linq
        private static void EncuentraTipos(Assembly asm)
        {
            // mostramos los nomnbres en el assembly
            Console.WriteLine("los tipos encontrados son: {0}", asm.FullName);
            // obtenemos los tipos
            Type[] tipo = asm.GetTypes();
            // los desplegamos

            foreach (Type t in tipo)

            {
                Console.WriteLine(t);
            }

        } 
        // son linq
        private static void EncuentraTipos1(Assembly asm)
        {
            Console.WriteLine("Los tipos encontrados son: {0}", asm.FullName);
            var tipos = from t in asm.GetTypes() select t.Name;
            foreach (var t in tipos)
                Console.WriteLine(t);

        }
    }
}
