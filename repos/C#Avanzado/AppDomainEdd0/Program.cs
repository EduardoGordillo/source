using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace AppDomainEdd0
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain dAD = AppDomain.CurrentDomain;
            // colocamos el hanlder para la carga del assembly
           dAD.AssemblyLoad += handlerCarga;
            dAD.ProcessExit += handlerDescarga;
            

            ListaAssemblies(dAD);

            AppDomain nuevoAD = AppDomain.CreateDomain("NuestroAppDomain");

            // cargamos un assembly en ese AppDomaim

            try
            {
                nuevoAD.Load("AritmeticaEdd");
               

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            ListaAssemblies(nuevoAD);
            AppDomain.Unload(nuevoAD);
           


        }
        public static void ListaAssemblies(AppDomain pAD)
        {
            var assemblies = from asm in pAD.GetAssemblies()
                              orderby asm.GetName().Name
                              select asm;

            Console.WriteLine($"Assemblies encontrados: {pAD.FriendlyName}");
            foreach(var asm in assemblies)
            {
                Console.WriteLine($"Nombre: {asm.GetName()}, Version: {asm.GetName().Version}");
            }
        }
        // handler para detectar la carga de un assembly

        public static void handlerCarga(System.Object o, AssemblyLoadEventArgs s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Se cargo {0}", s.LoadedAssembly.GetName().Name);
            Console.ResetColor();
        }
        // handler para deterctar cuando sale del proceso al descargar appdomain

        public static void handlerDescarga(System.Object o, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   Se descargo AppDomain");
        }
    }
}
