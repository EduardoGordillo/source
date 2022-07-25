using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorHerenciaEdd
{
    class  CPersona
    {
         public CPersona (string pNombre, int pEdad)
        {
            //Console.WriteLine("Constructor Persona");
            nombre = pNombre;
            edad = pEdad;

        }
        private string nombre;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public int Edad
        {
            get { return edad; }

            set 
            {
                if (edad > 18)
                {
                    edad = value;
                }
                else
                {
                    edad = -1;
                    Console.WriteLine("No apto");
                }
            }
      

        }
        public void Muestra()
        {
            Console.WriteLine($"El empleado {Nombre} tiene {Edad} años");
        }
    }
}
