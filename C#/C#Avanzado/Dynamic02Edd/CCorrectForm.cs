using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic02Edd
{
    class CCorrectForm
    {
        // atributo dinamico
        private dynamic atributo;
        // propiedad dynamic
        public dynamic Propiedad { get {return atributo; } set { atributo = value; } }

        public void Imprime()
        {
            Console.WriteLine(atributo);
        }
       public void Recibe(dynamic parametro)
        {
            Console.WriteLine("Recibi: {0}", parametro);
        }
        public dynamic Regresar(int a)

        {
            if (a < 0)
                return 5;
            else
                return "positivo";
        }
    }
}
