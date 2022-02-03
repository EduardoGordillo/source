using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorHerenciaEdd
{
    class CEmpleado : CPersona 
    {
        private string puesto;
        private double salario;

        public CEmpleado(string pNombre, int pEdad, string pPuesto, double pSalario)
            : base (pNombre, pEdad)
        {
            //Console.WriteLine("constructo empleado");
            puesto = pPuesto;
            salario = pSalario;
        }
        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }

        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public void MuestraEmpleado()
        {
            Muestra();
            Console.WriteLine($"Que es {Puesto} y gana {salario}");
        }

    }
}
