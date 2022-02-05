using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableEdd
{
    class Program
    {
        //public interface IEnumerable
        //{
        //    IEnumerator GetEnumerator();// metodo que nos permite obtener el iterador de la estructura trabajada
        //}
        //public interface IEnumerator
        //{
        //    bool MoveNext();// moverte al siguente valor del arreglo
        //    object Current();// darte el valor que estas trabajando en ese momento
        //    void Reset();// vuelve a empezar 
        //}
    
        static void Main(string[] args)
        {
            ///foreach es un iterador (no ciclo) que recorre todos los elementos de una estructura de datos.

            CTiendaAuto tienda = new CTiendaAuto();
            foreach(CAuto miAuto in tienda)
            {
                miAuto.CalcularTenencia(.05);
                miAuto.MuestraInformacion();
            }
            Console.ReadLine();

        }
    }

        
    
}
