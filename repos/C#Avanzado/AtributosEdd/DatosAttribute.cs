using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributosEdd
{
    // la clase debe ser publica y sellada 
    // este atributo guarda el dato en el assembly
    public sealed class DatosAttribute : System.Attribute
    {
        string dato = "";
        public string Dato { get { return dato; } set { dato = value; } }

        public DatosAttribute()
        {
           
        }
        public DatosAttribute(string pDato)
        {
            dato = pDato;
        }

        //public enum AttributeTargets
        //{
        //    All, Assembly, Class, Constructor,
        //    Delegate, Enum, Event, Field, GenericParameter,
        //    Interface, Method, Module, Parameter,
        //    Property, ReturnValue, Struct
        //}
        //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    }
}
