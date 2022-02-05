using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEdd

{
    class Program
    {
        static void Main(string[] args)
        {
            // funciones de clases y metodos abstractos
            ///creamos producto
          
            //creamos producto importado
            CProductoImportado dos = new CProductoImportado("peluche", 2300.05, .33);
            dos.CalcularPrecio();
            dos.MuestraVenta();

            //creamos producto importado con multa
            CProductoDetenido tres = new CProductoDetenido("Patineta", 2300.05, .33, 109);
            tres.CalcularPrecio();
            tres.MuestraVenta();
        }
    }
}
