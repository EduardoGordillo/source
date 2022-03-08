using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeEdd
{
    class CPrueba
    {
        private int a;
        public CPrueba(int pA)

        {
            a = pA;

        }

        public override string ToString()
        {
            return string.Format($"El valor es {a}");
        }

        // Tipos finalizables
        ///Object tiene un metodo virtual finalize
        ///cuando se hace el override de finalize tenemos un lugar donde llevar a cabo
        ///la limpieza para la clase
        ///no se puede invocar directamente, porque es un metodo protegido
        ///lo incova el recolector de basura antes de eliminar el objeto de la memoria
        ///no se puede hacer override de tipos estructura
        ///practicamente nunca haremos esto a salgo que tengamos recursos no administrados
        ///que necesiten ser eliminador manualmente: PInvoke, COM, memoria no administrada
        ///

        /// no hacemos uso de override
        /// se utiliza el destrcutor para esto
        ~CPrueba()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Aqui liberamos recursos no administrados");
            Console.Beep(600, 54);

        }
    }
}
