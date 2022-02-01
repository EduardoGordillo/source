using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_01
{
    class CEmpleado
    {
        private double sueldo;
        private double impuesto;
        
        public void Muestra()
        {
            Console.WriteLine($"Sueldo = {sueldo}");
        }
        public void MuestraImpuesto()
        {
            Console.WriteLine($"Impuesto = {impuesto}");
        } 
        public void Set_sueldo( double psueldo)
        {
            sueldo = psueldo;
        }
        public double get_sueldo()
        {
            return sueldo;
        }
        public double Get_impuestoo()
        {
           
            return impuesto;
        }
        public void CalculaImpuesto()
        {
            impuesto = sueldo * .016;
        }
        
    }
}
