using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaConstructorEdd
{
    class CPersona
    {
        private string nombre;
        private int edad;

        public CPersona()
        {
            string tempEdad = "";
            Console.WriteLine("Estamos en el constructor");
            Console.WriteLine("Dame el nombre");

            nombre =  Console.ReadLine();
            Console.WriteLine("Dame la edad");
            tempEdad = Console.ReadLine();
            edad = Convert.ToInt32(tempEdad);
            Muestra();
         
            
        }
        public CPersona( string Nombre, int Edad)
        {
            Console.WriteLine("Estamos en la sobrecarga");
            nombre = Nombre;
            edad = Edad;
            Muestra();
        }
        public string Nombre
        {
            set {
                
                nombre = value; }
        }
        public int Edad
        {
            set {
                
                edad = value; }
        }
        private void Muestra()
        {
            Console.WriteLine($"Nombre: {nombre} \nEdad = {edad}");
            Console.ReadLine();
        }
        ~CPersona()
        {
            Console.WriteLine("adios desde {0}", nombre);
            Console.ReadLine();
            nombre = "";
            edad = 0;
        }
            
    }
}
