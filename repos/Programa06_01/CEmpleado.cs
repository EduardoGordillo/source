using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_01
{
    class CEmpleado
    {
        private double sueldo;
        private double impuesto;
        private string log;
        public double Get_impuestoo(int pPassword)
        {

            if (pPassword != 12345)
            {
                LogError("Password ilegal");
                return 0.0;

            }
            else

                return impuesto;
        }
        public void Muestra()
        {
            Console.WriteLine("Sueldo = {0} Impuesto = {1}", sueldo, impuesto);;
        }
       
        public void Set_sueldo( double psueldo)
        {
            if (psueldo < 5000 || psueldo > 15000)
            {
                LogError("Sueldo ilegal" + psueldo.ToString());
               
            }
            else
                sueldo = psueldo;
        }
        public double get_sueldo( int pPassword)
        {
            if (pPassword != 12345)
            {
                LogError("Password ilegal");
                return 0.0;

            }
            else
                return sueldo;
        }
      
        public void CalculaImpuesto()
        {
            impuesto = sueldo * .016;
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
