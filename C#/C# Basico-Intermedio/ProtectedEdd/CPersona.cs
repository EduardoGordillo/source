using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedEdd
{
    class CPersona
    {
        public CPersona(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;

        }
        protected string nombre;
        protected int edad;

        public string Nombre
            
        {  get {return nombre;}
            set { nombre = value; }

        }
        public int Edad
        {
            get { return edad; }

            set {
                
                if (edad <= 18)
                {
                    edad = -1;
                    Console.WriteLine("Edad no apta");
                }
                else
                {
                    edad = value;
                   
                }
            } 

        }
        public void Muestra()
        {
            
            Console.WriteLine($"{Nombre} tiene {edad} años");
        }
    }

}
