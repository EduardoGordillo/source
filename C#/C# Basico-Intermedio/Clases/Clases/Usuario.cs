using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    abstract class Usuario
    {
        string nombre;
        string apellido;
        int edad;
        string estadoCivil;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public string EstadoCivil
        {

            get { return "Mi estado civil es " + estadoCivil; }
            set { estadoCivil = value; }


        }
        public int nHijos
        {
            get; set;
        }

        public Usuario() 
        {

            Console.WriteLine("hola desde el constructor usuario");
            }
        public Usuario (string _nombre)
        {
            nombre = _nombre;
            Console.WriteLine("mi nombre es " + _nombre);

        }
        public Usuario(string _nombre, string _apellido)
        {
            nombre = _nombre;
            apellido = _apellido;
            Console.WriteLine("mi nombre es " + _nombre + " " + _apellido);
        }
            public abstract void Saludar();
        }

    }

