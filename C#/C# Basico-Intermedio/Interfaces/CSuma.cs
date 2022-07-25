using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class CSuma : IOperacion

    {

        private double r = 0;
        private ArrayList resultados = new ArrayList(); //declarar un array tipo objeto para guardar reultados
        

        //Metodos a implementar
        public void calcular (double a, double b)
        {
            r = a + b;

        }
        public void mostrar()
        {
            Console.WriteLine($"El resultado de la suma es = {r}");
            resultados.Add(r);// agregar resultados de r cada vez que mostremos el resultado y agregarlo a arraylist
        
        }

        //Metodos propios de la clase
        public void MuestraResultados()
        {
            foreach (double r in resultados)

            {
                
                Console.WriteLine(r);
                //foreach(double a in resultados)
                //{
                //    Console.WriteLine(a);
                //}
            }
            //mostrar todos los resultados que se hayan guardado en el arraylist

        }

    }
}
