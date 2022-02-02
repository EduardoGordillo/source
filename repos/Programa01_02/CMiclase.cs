using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_01
{
    class CMiclase
    {
        // esto datos se pueden ver en cualquier lugar de la clase
        //pero no fuera de ella, por eso el ambito objeto
        // no usar la misma variable en ambito local como en ambito objeto

        private int b = 10;
        public void Muestra()
        {
            //creamos una variable local a muestra
            //ambito local
            int m = 5;
            int b = 6;
            //podemos usar la variable local
            Console.WriteLine($"m es = {m}");
            // tratamos de mostrar la variable en main
            // no se puede
            //Console.WriteLine($"a es = {a}");
            // tratamos de mostrar el dato de la clase
            Console.WriteLine($"ambito local b = {b}");
            // para utulizar la variable de ambito objeto que es igual en ambito objeto que ambito local
            Console.WriteLine("ambito objeto b={0}", this.b);
        }
        public void Multiplicador()
        {
            // se puede usar b ya que esta en ambito local de la clase y no solo del metodo
            b = b * 5;
            Console.WriteLine($"b = {b}");
        }
    }
}
