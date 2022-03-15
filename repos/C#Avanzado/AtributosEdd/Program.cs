using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// en este nivel se colocan los atributos que se colocaran en todos los elementos

[assembly: CLSCompliant(true)]

namespace AtributosEdd
{
    class Program
    {
        static void Main(string[] args)
        {

            /// atributos
            /// los hemos utilizado para decorar a las clases
            /// adicionan informacion al metadata del assembly
            /// se pueden usar con clases, interfaces, estructuras, propiedades, metodos
            /// son clases que descienden de System.Attribute
            /// [CLSCompilant], [Obsolete], [Serializable] [NonSerializable]
            /// El compilador esta preparado para encontrar los atributos y actuar con lo que se le deba
            /// tienen un nombre corto y un nombre largo [serializableAtrtibute]
            /// pueden o no recibir parametros dependiendo de sus constructores

            Prueba miPrueba = new Prueba();

            Prueba2 miPrueba2 = new Prueba2();
        }
    }
}
