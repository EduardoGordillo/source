using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa07_01
{
    class CEmpleado
    {
        private double sueldo;
        private double impuesto;
        private string log;
        
     

        public void Muestra( )
        {
            CalculaImpuesto();
            Console.WriteLine("Sueldo = {0} Impuesto = {1}", sueldo, impuesto);;
        }
       
      public double Sueldo 
        {
            
            get
            {
                
                return sueldo;
            }
            set
            {
                if (sueldo < 5000)
                { sueldo = value; }


                else
                {
                    LogError("sueldo ilegal");
                    MuestraLog();
                }

            }
        }
        public double Impuesto
        {
            get
            {
                return impuesto;
            }
          
        }

        private void CalculaImpuesto()
        {
            impuesto = sueldo * .16;
        }
        private void LogError (string pError)
        {
            log += pError + "\r\n";
        }
        public void MuestraLog()
        {
            Console.WriteLine(log);
        }
        
    }
}
