using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDemo
{
    class Program
        
    {
        static string nombre = "eddd";
        static void Main(string[] args)
        {
            /*int cociente = 0;
            int residuo = 0;
            (cociente, residuo) = Dividir(37, 6);
            Console.WriteLine(cociente);
            Console.WriteLine(residuo);

            (int cociente, int residuo) data = Dividir(44, 22);
            Console.WriteLine(data.cociente);
            Console.WriteLine(data.residuo);

            Console.WriteLine(nombre);
            Saludar();
            nombre = "ivan";
            Saludar();
            float mult = Multiplicar(2.0f, 3.0f);
            Console.WriteLine(mult);*/

            CalcularAreaCuadrado2(20, "juan", 50m, true);
            int resultado = CalcularAreaCuadrado2(20, "juan", 50m, true);
            double calcular = CalcularCuenta(Propina: 5700, totalCuenta: 200, comensales: 5, IVA: 20);

            Console.WriteLine(calcular);
            EscribirTexto("Jorge");
            Console.ReadLine();
            LimpiarConsole();

        }

        private static void LimpiarConsole()
        {
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }

        private static int CalcularAreaCuadrado2(int v1, string v2, decimal v3, bool v4)
        {
            throw new NotImplementedException();
        }

        static void EscribirTexto(string texto)
        {
            Console.WriteLine(texto);
            Limpiar();
            Limpiar();
            void Limpiar()
            {
                Console.ReadLine();
                Console.Clear();
                Console.Beep();

            }

        }
        static double CalcularCuenta (double totalCuenta, double Propina, int comensales, 
            double estacionamiento = 0, double IVA = 15)
        {
             
            return (totalCuenta + Propina + estacionamiento +IVA  ) / comensales; 
        }

        //static double CalcularCuenta (double totalCuenta, double Propina, int comensales, double estacionamiento)
        //{
          //  return (totalCuenta + Propina + estacionamiento) / comensales;
        //}
        static void Saludar() => Console.WriteLine(nombre);
        static (int, int) Dividir(int x, int y)
        {
            int cociente = x / y;
            int residuo = x % y;
            return (cociente, residuo);
        }
        static (int, string) RegresarDatos()
        {
            return (8,"edd");
        }
        static int Multiplicar(int x, int y) => x * y;
        static float Multiplicar(float x, float z)
        {
            return x * z;
        }


    }
}
