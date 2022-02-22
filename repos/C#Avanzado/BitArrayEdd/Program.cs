using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray miArreglo = new BitArray(new byte[] { 1, 2, 3, 4, 5 });

            // cantidad de elementos, 5 bytes * 8 = 40 bits
            // por cada posicion el arreglo guarda 8 bits

            Console.WriteLine(miArreglo.Count);
            muestraArreglo(miArreglo, "Mi Arreglo");

            // para obtener un bit en particular
            Console.WriteLine(miArreglo.Get(3)); // get regresa el valor booleano del bit donde es colocado (posicion)

            // ponemos un bit en particular
            miArreglo.Set(3, true);// puede agregar en una posicion especifica el valor boleano que es traducido como 0 y 1
            muestraArreglo(miArreglo, "miArreglo");
            Console.WriteLine(miArreglo.Get(3));
            Console.WriteLine("--------------");


            // para clonar el bit array
            BitArray arreglo2 = (BitArray)miArreglo.Clone();
            muestraArreglo(arreglo2);
            Console.WriteLine("--------");

            // se pueden hacer operaciones bit por bit dentro del arreglo
            // not invierte el arreglo, lo que era 1 ahora es 0 y lo que es 0 ahora es 1

            arreglo2.Not();
            muestraArreglo(arreglo2, "arreglo2");
            Console.WriteLine("--------");

            // creamos otro arreglo para compararlos
            BitArray arreglo3 = new BitArray(new byte[] { 5, 7, 8, 9, 10 });
            muestraArreglo(arreglo3, "arreglo3");
            Console.WriteLine("----------------");

            // hacemos or entre los arrelgos
            arreglo3.Or(miArreglo);
            muestraArreglo(miArreglo, "miArreglo");
            muestraArreglo(arreglo3, "arreglo3");
            Console.WriteLine("---------------");


            // hacemos lo mismo con AND

            arreglo3.And(miArreglo);
            muestraArreglo(miArreglo, "miArreglo");
            muestraArreglo(arreglo3, "arreglo3");
            Console.WriteLine("---------------");

            // la operacion XOR

            arreglo2.Xor(miArreglo);
            muestraArreglo(arreglo2, "arreglo2");
            Console.WriteLine("-------------");

        }
        public static void muestraArreglo(BitArray pArreglo, string pNombre= "")
        {
            int c = 0;
            Console.Write($"" +
                $"{pNombre}\t");
            foreach (bool b in pArreglo)
            {
                c++;
                if (b)
                    Console.Write("1");
                else
                    Console.Write("0");
                if (c % 8 == 0)
                    Console.Write(",");
            }
            Console.WriteLine();
        }
    }
}
