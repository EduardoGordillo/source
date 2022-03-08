using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NamespaceEdd.LasClases;
//using LasClases;
//using OtrasClases;

// creamos un alias a las clases que nos den conflicto 
using principal = LasClases.Clase1;
using secundario = OtrasClases.Clase1;

/// <summary>
///  Agregamos estos namespacepara poder usar los tipos definidos ahi
///  
/// using lasclases
/// using otrasclases
/// </summary>

namespace NamespaceEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            /// uso de namespace
            /// la clase solo se puede instanciar si suamos el namespace
            /// si tenemos los dos using el compilador no sabe cual usar
            //Clase1 ob1 = new Clase1();

            //solo si usamos el nomnre totalmente calificado
            // comentar el namespace
            // solo si estan en el mismo proyecto
            // LasClases.Clase2 ob2 = new LasClases.Clase2();

            // adicionamos el otro namespace 
            // hay conflicto si en los dos namespace se tienen clases con el mismo nombre
            //Clase1 ob3 = new Clase1();

            // se puede resolver con el nombre totalmente calficado

            //LasClases.Clase1 ob3 = new LasClases.Clase1();
            //OtrasClases.Clase1 ob4 = new OtrasClases.Clase1();

            // se puede crear un alias en el namespace

            principal ob5 = new principal();
            secundario ob6 = new secundario();

            LasClases.Clase1 obj = new LasClases.Clase1();

        }
    }
}
