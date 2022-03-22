using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AppDomainEdd02
{
    class Program
    {
        static void Main(string[] args)
        {

            // cuando el ejecutable inicia el CLR lo coloca en el appdomain
            // de default del proceso que lo alberga
            // podemos tener acceso a ese appdomain de default

            AppDomain AD = AppDomain.CurrentDomain;
            // imprimimos la informacion que nos proporciona 

            Console.WriteLine($"Nombre del dominio: {AD.FriendlyName}");
            Console.WriteLine($"ID del dominio del proceso: {AD.Id}");
            Console.WriteLine($"Directorio base del dominio: {AD.BaseDirectory}");

            // verificamos si es el del default
            if (AD.IsDefaultAppDomain() == true)
                Console.WriteLine("Es el de default");
            else
                Console.WriteLine("No es el de default");

            Console.WriteLine("-----------");

            // para encontrar los assemblies en el appdomain

            Assembly[] assemblies = AD.GetAssemblies();

            foreach (Assembly asm in assemblies)
                Console.WriteLine($"Nombre: {asm.GetName().Name}, Version: {asm.GetName().Version}");
        }
    }
}
