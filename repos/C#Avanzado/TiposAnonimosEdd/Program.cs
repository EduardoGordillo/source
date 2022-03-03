using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAnonimosEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            //  creamos tipos anonimos
            // crea un tipo temporal con atributos, propiedades, ToString

            // creamos el tipo anonimo

            var miCompu = new { Procesador = "i7", Memoria = 16, Graficos = "Intel" };
            // no puede contener ningun metodo y tampoco se puede modificar en ningun mommento

            // imprimos la variable

            Console.WriteLine(miCompu);

            // imprimimos un atributo

            Console.WriteLine($"La compu tiene {miCompu.Memoria}GB de memoria");

            // no se puede modificar el atributo, es de solo lectura
            //miCompu.Memoria = 16;
        }
    }
}
