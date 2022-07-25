using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesMetodosEdd
{
    class CTelevisor : IElectronico
    {
        string marca;

        public CTelevisor(string pMarca)
        {
            marca = pMarca;
        }

        public override string ToString()
        {
            return string.Format($"Televisor es {marca}");
        }
        public void Encender(bool pInterruptor)
        {
            if (pInterruptor)
            {
                Console.WriteLine("Encendido");

            }
            else
                Console.WriteLine("Apagado");
        }
         
    }
}
