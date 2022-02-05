using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEdd
{
    class CProductoDetenido:CProducto
    {
        private double multa;
        private double impuesto;
        public CProductoDetenido (string pDescripcion, double pPrecioCompra, double pImpuesto, double pMulta)
            : base(pDescripcion, pPrecioCompra)
        {
            impuesto = pImpuesto;
            multa = pMulta;
        }
        public override void CalcularPrecio()
        {
            Console.WriteLine("calcular precio con multa");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30 + multa; 
        }
        public override void MuestraVenta()
        {
            Console.WriteLine($"El producto en aduana {descripcion}, tendra un costo de ${precioVenta}");
        }
    }
}
