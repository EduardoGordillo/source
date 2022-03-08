using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// usamos el namespace
using System.Configuration;

namespace SystemConfigurationEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Editamos App.config y lo leemos a travez de la aplicacion
            // creamos el objeto lector
            AppSettingsReader lector = new AppSettingsReader();

            // leemos los datos con el type cast correcto

            // (string)lector el typecast es para asignar el valor dentro del string que se asigno
            // .GetValue(Key del valor, tipo de valor que esta leyendo)

            object nombre = lector.GetValue("Nombre", typeof(string));

            string Nombre = Convert.ToString(nombre);
                

            object edad = lector.GetValue("Edad", typeof(int));

            Console.WriteLine($"{Nombre} tiene {edad} años");
        }
    }
}
