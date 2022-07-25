using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reflection02Edd
{
    class Program
    {
        static void Main(string[] args)
        {


            Assembly asm = null;
            try
            {
                // cargamos el assembly
                asm = Assembly.Load("AritmeticaEdd");
                EncuentraTipos(asm);
               
            }
            catch
            {
                Console.WriteLine("Assembly no encontrado");
            }
        }
        private static void EncuentraTipos(Assembly asm)
        {
            // Mostramos el nombre del assembly
            Console.WriteLine($"Los tipos enocontrados en {asm.FullName} son: ");
            var tipos = from t in asm.GetTypes() select t.Name;
            foreach (var tipo in tipos)
            {
                Console.WriteLine($"{tipo}");
            }
        }
    }
}
