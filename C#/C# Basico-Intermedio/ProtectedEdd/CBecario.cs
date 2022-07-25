using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedEdd
{
    class CBecario : CPersona

    {
        public CBecario(string pNombre, int pEdad, double pTiempo)
            : base(pNombre, pEdad )
        {
            Nombre = pNombre;
            Edad = pEdad;
            
            tiempo = pTiempo;

        }
        protected double tiempo;

        public double Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }

        public void MuestraBecario()
        {
            Muestra();
            Console.WriteLine($"Becario Cumplio {tiempo} horas en la semana");
        }


    }
}
