using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEdd
{
    class CProductoDetenido:CProductoImportado
    {
        private double multa;
        public CProductoDetenido (string pDescripcion, double pPrecioCompra, double pImpuesto, double pMulta)
            : base(pDescripcion, pPrecioCompra,pImpuesto)
        {
            multa = pMulta;
        }
        public override void CalcularPrecio()
        {
            Console.WriteLine("calcular precio con multa");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30 + multa; 
        }
    }
}
