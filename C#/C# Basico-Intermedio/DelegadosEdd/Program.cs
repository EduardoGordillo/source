using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEdd
{
    class Program
    {
        public delegate void MiDelegado(string m);
        static void Main(string[] args)
        {
            // creamos un objeto del delegado y lo referenciamos a un metodo
            MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);
            delegado("hola a todos");
            // hacemos que el delegado apunte a otro metodo
            delegado = new MiDelegado(CPastel.MostrarPastel);

            delegado("Feliz cumpleaños");
        }
    }
}
