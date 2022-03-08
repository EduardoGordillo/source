using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionEdd
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.BackgroundColor = ConsoleColor.Blue;
            // obtenemos informacion sobre un tipo 
            try
            {
                // obtenemos el tipo
                //Type t = Type.GetType("System.Collections.ArrayList");
                Type t = Type.GetType("System.Console");

                // metodos que buscan la informacion sobre el tipo
                CaracteristicasTipo(t);
                EncuentraCampos(t);
                EncuentraPropiedades(t);
                EncuentraMetodos(t);
                EncuentraInterfaces(t);
                
            }
            catch
            {
                Console.WriteLine("Verificar el tipo");
            }
        }

        public static void CaracteristicasTipo(Type t)
        {
            // imprimimos las caractetisticas principales del tipo
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Las caracteristicas que tiene son: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Clase base : {0}", t.BaseType);
            Console.WriteLine("Es una clase : {0}", t.IsClass);
            Console.WriteLine("Abstracta : {0}", t.IsAbstract);
            Console.WriteLine("Sellada : {0}", t.IsSealed);
            Console.WriteLine("Generica : {0}", t.IsGenericTypeDefinition);
        }
        public static void EncuentraCampos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los campos encontrados son: ");
            Console.ResetColor();
            // encontramos los campos en ese tipo
            var nombres = from f in t.GetFields() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }

        }
        public static void EncuentraPropiedades(Type t)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Las Propiedades son: "  );
            Console.ResetColor();
            var propiedades = from p in t.GetProperties() select p.Name;
            foreach (var propiedad in propiedades)
                Console.WriteLine($"{propiedad}");
        }
        public static void EncuentraMetodos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Los metodos son: ");
            Console.ResetColor();
            var metodos = from m in t.GetMethods() select m.Name;
            foreach (var metodo in metodos)
                Console.WriteLine($"{metodo}");
        }
        public static void EncuentraInterfaces(Type t)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Las interfaces son: ");
            Console.ResetColor();
            var interfaces = from i in t.GetInterfaces() select i;
            foreach (var interfaz in interfaces)
            {
                Console.WriteLine($"{interfaz}");
            }
        }
    }
}
