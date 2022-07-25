using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionEdd_
{
    class CAula
    { 
    
        private string nombreAula;
        private int cantidadAlumnos;
        public CAula(string pNombreAula, int pCantidadAlum)
        {
            nombreAula = pNombreAula;
            cantidadAlumnos = pCantidadAlum;
        }
        public override string ToString()
        {
         string mensaje = string.Format($"El aula {nombreAula}, tiene {cantidadAlumnos} alumnos");
            return mensaje;
        }

    }
}
