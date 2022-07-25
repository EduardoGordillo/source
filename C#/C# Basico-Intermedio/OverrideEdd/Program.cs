using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEdd
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

            //creamos producto importado con multa
            CProductoDetenido tres = new CProductoDetenido("Patineta", 1300, .30, 109);
            tres.CalcularPrecio();
            tres.MuestraVenta();
        }
    }
}
