using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionEdd_
{
    class CEscuela
    {
        private string nombre;
        private CAula[] aulas = new CAula[2];
        public CEscuela(string pNombre)
        {
            nombre = pNombre;
        }
        public void ColocaAula()
        {
            int n = 0;
            string dato = "";
            string nombre = "";
            int cantidad = 0;
            for (n = 0; n < aulas.Length; n++)
            {
                Console.WriteLine("dame el nombre del aula");
                nombre = Console.ReadLine();
                Console.WriteLine("dame la cantidad de alumno");
                dato = Console.ReadLine();
                cantidad = Convert.ToInt32(dato);
                aulas[n] = new CAula(nombre, cantidad);
            }


        }
        public override string ToString()
        {
            string mensaje = "";
            int n = 0;
            mensaje = string.Format($"Bienvenidos a la escuela {nombre}, la cual consta de :\r\n");
            for (n = 0; n < aulas.Length; n++)
            {
                mensaje += aulas[n].ToString() + "\r\n";
                
                     
            }
            return mensaje;
        }
    }
}
