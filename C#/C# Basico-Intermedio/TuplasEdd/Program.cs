using System;

namespace TuplasEdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var proveedor = ("Manuel", "Perez", 50);
            Console.WriteLine($"Proveedor:{ proveedor.Item1} {proveedor.Item2}");
            var proveedorB = (Nombre: "Edd", Apellido: "Gutierrez", Edad: 50);
            Console.WriteLine($"Proveedor B: {proveedorB.Nombre} {proveedorB.Apellido}");

            (string Nombre, string Apellido) MiTupla = (Nombre: "Ivan", Apellido: "Gordillo");
            Console.WriteLine($"MiTupla : {MiTupla.Nombre} {MiTupla.Apellido}");
            MiTupla.Nombre = "Fer";
            Console.WriteLine($"Mitupla {MiTupla.Nombre}");
        }
    }
}
