using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic02Edd
{
    class Program
    {
        static void Main(string[] args)
        {
            // forma de invocara miembros cuando se usa dynamic
            // notar que intelisense no actua, cuidado con eso
            // creamo una cadena dynamic
            dynamic txt = "hola";
            // obtener propiedad del tipo
            int n = txt.Length;
            // podemos invocar un metodo
            
            Console.WriteLine($"{n}, {txt.ToUpper()}");

            // con dynamic no se verifica el error de sintaxis en el momento de compilacion
            // el error no desaparecera cuando se ejecute
            // n = texto.length;

            // podemos invocar metodos que no existen sin error de compilacion
            // texto.Nono();

            // forma correcta de usar dynamic es con try y catch

            dynamic txt2 = "Edd";

            try
            {
                n = txt2.Length;
                txt2=txt2.ToUpper();
                Console.WriteLine("{0},{1}", n, txt2);

                CCorrectForm objeto = new CCorrectForm();
                objeto.Propiedad = 5;
                objeto.Imprime();
                objeto.Propiedad = "Mas saludos";
                objeto.Imprime();
                objeto.Recibe(57.6);
                objeto.Recibe("Otro Test");
                dynamic regreso = objeto.Regresar(-1);
                Console.WriteLine(regreso);


            }
            catch(Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
