using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEdd
{
    class CPersona
    {
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
                    edad = value;
                else 
                {
                    edad = -1;
                    Console.WriteLine($"Edad no permitida {edad}");

                }
            }


        }


        #region metodos

        public void Muestra()
        {
            Console.WriteLine($"{nombre} tiene {edad} años");
        }


        #endregion
    }
}
