using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedEdd
{
    sealed class CEmpleado: CPersona

    {
        public CEmpleado(string pNombre, int pEdad , string pPuesto, int pSueldo)
            : base (pNombre, pEdad)
        {
            sueldo = pSueldo;
            puesto = pPuesto;

        }

        protected string puesto;
        protected int sueldo;
        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public int Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public void ponerDatos (string pNombre, int pEdad, string pPuesto, int pSueldo)
        {
            Nombre = pNombre;
            Edad = pEdad;
            puesto = pPuesto;
            sueldo = pSueldo;
            
        }
        public void MuestraEmpleado()
        {
            Muestra();
            Console.WriteLine($"{Puesto} que gana {Sueldo}");
        }

    }

}
