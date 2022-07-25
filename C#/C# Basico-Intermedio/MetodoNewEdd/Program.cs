using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoNewEdd

{
    class Program
    {
        static void Main(string[] args)
        {
            // funcion virtual y override con sealed
            ///creamos producto
            CProducto uno = new CProducto("Avalancha", 2300.05);
            uno.CalcularPrecio();
            uno.MuestraVenta();

            //creamos producto importado
            CProductoImportado dos = new CProductoImportado("peluche", 2300.05, .33);
            dos.CalcularPrecio();
            dos.MuestraVenta();

           
        }
    }
}
