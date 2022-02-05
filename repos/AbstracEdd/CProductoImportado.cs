using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEdd
{
    class CProductoImportado : CProducto
    {
        protected double impuesto;
        public CProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto)
            : base (pDescripcion,pPrecioCompra)
        {
            impuesto = pImpuesto;
                 
        }
        public  override void CalcularPrecio()
        {
            Console.WriteLine("Calcula precio de importado");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
        }

        public override void MuestraVenta()
        {
            Console.WriteLine($"El gran producto {descripcion} se vende en ${precioVenta}!!!");
        }
    }
}
