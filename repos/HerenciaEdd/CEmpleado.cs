using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEdd
{
    class CEmpleado : CPersona
    {
        private string puesto;
        private double salario;

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }

        }
        public double Salario
        {
            get { 
                return salario; 
            
                }
            set {
                if (salario >= 15000)

                    salario = value;
                else
                {
                    Console.WriteLine($"No corresponde");
                    salario = -1;
                   
                }
            }
        }

        #region Metodos

        public void ponerDatos( string pNombre , int pEdad, string pPuesto, double pSalario  )
        {
            Nombre = pNombre;
            Edad = pEdad;

            puesto = pPuesto;
            salario = pSalario;
        }
        public void EmpleadoMuestra()
        {
            Muestra();
            Console.WriteLine($"Puesto : {puesto}\n" +
                $"Salario : {Salario}"); 
        }
        #endregion
    }
}
