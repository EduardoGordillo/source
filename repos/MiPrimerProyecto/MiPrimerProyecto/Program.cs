using System;

namespace MiPrimerProyecto
{
    public enum Meses
    {
        Enero = 1,
        Febrero,
        Marzo,
        Abril,
        Mayo,
        Junio,
        Julio,
        Agosto,
        Septiembre,
        Octubre,
        Noviembre,
        Diciembre
    };
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*Console.WriteLine("Probando mi primer proyecto");
            Console.WriteLine("Mes Actual" + Meses.Enero);
            Console.ReadKey();
            #region anonimos
            var locacion = new { Pais = "Austria", Ciudad = "Graz" };
            Console.WriteLine("locacion - Pais: {0}, Ciudad: {1}", locacion.Pais, locacion.Ciudad);
            var locacionB = new { Pais = "Mexico", Ciudad = "CDMX" };
            var cliente = new
            {
                Nombre = "Leo",
                Apellido = "Gord",
                Locacion = locacionB
            };
            Console.WriteLine("Cliente - Nombre: {0}, Apellido: {1}, locacion: {2} ", cliente.Nombre, cliente.Apellido, cliente.Locacion);

             var clientes = new[]
             {
                    new {Nombre = "Eduardo", Apellido = "Gordillo", Locacion = locacion},
                    new {Nombre = "Mateo", Apellido = "Toribio", Locacion = locacionB},
                    cliente
             };

            foreach (var cl in clientes)
            {
                Console.WriteLine("cliente - Nombre {0}, Apellido {1}, Pais {2}", cl.Nombre, cl.Apellido, cl.Locacion.Pais); 
            };
            #endregion


            int a = 3;
            int b = 8;
            int c = 6;

            bool d = a > b;
            bool e = b < c;
            bool f = (c + 3) > a;

            bool op1 = d && e;
            bool op2 = f && e;
            bool op3 = (d || f) && (!e || f);
            Console.WriteLine("Op1: " + op1);
            Console.WriteLine("Op2: " + op2);
            Console.WriteLine("Op3: " + op3);
            
            int a, b, c;
            a = b = c = 1;
            a += b += c += 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a + b + c);
            
            int a = 5;
            int b = 2;
            int c = 7;
            int opcion;

            opcion = c % b;
            opcion = opcion + a;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Opción 1");
                    break;
                case 2:
                    Console.WriteLine("Opción 2");
                    break;
                case 3:
                    Console.WriteLine("Opción 3");
                    break;
                default:
                    Console.WriteLine("Ninguna opción");
                    break;
            */
            int mult = 0;

            Console.WriteLine("Escriba un numero:");
            int num = Int32.Parse(Console.ReadLine());

        }
    }


    }
}
