using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesMetodosEdd
{
    class CRadio : IElectronico
    {
        string marca;
        public CRadio(string pMarca)
        {
            marca = pMarca;
        }

        public override string ToString()
        {
            return string.Format($"Radio es {marca}") ;
        }

        public void Encender(bool interruptor)
        {
            if (interruptor)
                Console.WriteLine("Encendido");
            else
                Console.WriteLine("Apagado");
        }
    }
}
