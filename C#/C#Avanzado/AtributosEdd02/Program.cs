using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace AtributosEdd02
{
    class Program
    {
        static void Main(string[] args)
        {
            // usaremos la reflexion con late binding 
            // no olvidar hacer la copia de la libreria

            try
            {
                Assembly asm = Assembly.Load("AritmeticaAtriburtosEdd");

                // obtenemos el tipo de atributo
                Type datoAt = asm.GetType("AritmeticaAtriburtosEdd.DatosAttribute");
                // obtenemos la propiedades
                PropertyInfo dataProp = datoAt.GetProperty("Dato");

                // hacemos una lista de tipos en el assembly
                Type[] tipos = asm.GetTypes();
                // para cada tipo de assembly obtenemos el atributo

                foreach(Type t in tipos)
                {
                    object[] objetos = t.GetCustomAttributes(datoAt, false);
                    
                    foreach(object obj in objetos)
                    {
                        Console.WriteLine($"{t.Name},  {dataProp.GetValue(obj, null)}");
                    }    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
